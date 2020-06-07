using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Authorization;
using Radzen;
using Radzen.Blazor;
using iRefer.Shared.Services;
using iRefer.Shared.Models;

namespace iRefer.Client.Pages.SysAdmin
{
    public partial class AgenciesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }
        [Inject]
        protected AgencyService Agencyservice { get; set; }
        protected RadzenGrid<Agency> grid0;
        List<Agency> _agencies;
        protected List<Agency> Agencies
        {
            get
            {
                return _agencies;
            }
            set
            {
                if (!object.Equals(_agencies, value))
                {
                    _agencies = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }
     
       

        [CascadingParameter]
        private Task<AuthenticationState> authenticationState { get; set; }

       
        protected override async System.Threading.Tasks.Task OnInitializedAsync()

        {
            
          
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()

        {
                   await getAgenciesAsync();
        }

        async Task getAgenciesAsync()
        {
           
            var userState = authenticationState.Result;
            Agencyservice.AccessToken = userState.User.FindFirst("AccessToken").Value;
           
            var result = await Agencyservice.GetAllAgenciesAsync();

            if (result.IsSuccess)
            {
                Agencies = result.Records.ToList();
                NotificationService.Notify(NotificationSeverity.Success, result.Message);

            }
            else
            {
                NotificationService.Notify(NotificationSeverity.Error, result.Message);
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Agency args)
        {
          
           var dialogResult = await DialogService.OpenAsync<iRefer.Client.Pages.Admin.EditAgency>("Edit Agency", new Dictionary<string, object>() { { "Id", args.Id } });
                await InvokeAsync(() => { StateHasChanged(); });
           
        }
        
       
       
        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var ireferDeleteAgencyResult = await Agencyservice.DeleteAgencyAsync($"{data.Id}");
                if (ireferDeleteAgencyResult != null)
                {
                    grid0.Reload();
                }
            }
            catch (Exception ireferDeleteAgencyException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Agency");
            }
        }
    }
}
