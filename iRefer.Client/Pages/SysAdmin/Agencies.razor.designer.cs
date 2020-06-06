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
        public int? PageNumber { get; set; }
        public string Query { get; set; }

        [CascadingParameter]
        private Task<AuthenticationState> authenticationState { get; set; }

        bool isBusy = false;
        int totalPages = 1;
        string selectedAgencyId = string.Empty;
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
            isBusy = true;
            AgenciesResponse result;
            var userState = authenticationState.Result;
            Agencyservice.AccessToken = userState.User.FindFirst("AccessToken").Value;
            //if (PageNumber == null)
                //PageNumber = 1;
            //if (string.IsNullOrWhiteSpace(Query))
               // result = await Agencyservice.GetAllAgenciesByPageAsync(PageNumber.Value);
            result = await Agencyservice.GetAllAgenciesAsync();
            //else
            //    result = await Agencyservice.SearchAgenciesByPageAsync(Query, PageNumber.Value);

            //if (result.Count % result.PageSize == 0)
            //    totalPages = result.Count / result.PageSize;
            //else
            //    totalPages = (result.Count / result.PageSize) + 1;
            Agencies = result.Records.ToList();

            isBusy = false;
        }
        protected async System.Threading.Tasks.Task Grid0RowSelect(Agency args)
        {
            //var dialogResult = await DialogService.OpenAsync<EditAgency>("Edit Agency", new Dictionary<string, object>() { { "Id", args.Id } });
            selectAgency(args.Id);
            await InvokeAsync(() => { StateHasChanged(); });
        }
        async Task moveToPageAsync(int pageNumber)
        {
            PageNumber = pageNumber;
            await getAgenciesAsync();
        }
        protected void selectAgency(string id)
        {
            selectedAgencyId = id;
        }
        //async Task deletePlanAsync()
        //{
        //    isBusy = true;

        //    var result = await Agencyservice.DeleteAgencyAsync(selectedAgencyId);
        //    if (result.IsSuccess)
        //    {
        //        var deletedAgency = Agencies.SingleOrDefault(p => p.Id == selectedAgencyId);
        //        Agencies.Remove(deletedAgency);
        //    }
        //    else
        //    {
        //        await getAgenciesAsync();
        //    }

        //    isBusy = false;
        //}
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
