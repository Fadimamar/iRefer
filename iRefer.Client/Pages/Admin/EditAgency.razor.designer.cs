using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using iRefer.Shared.Models;
using iRefer.Shared.Services;

namespace iRefer.Client.Pages.Admin
{
    public partial class EditAgencyComponent : ComponentBase
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

        [Parameter]
        public dynamic Id { get; set; }

        iRefer.Shared.Models.Agency _agency;
        protected iRefer.Shared.Models.Agency agency
        {
            get
            {
                return _agency;
            }
            set
            {
                if (!object.Equals(_agency, value))
                {
                    _agency = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }

        protected async System.Threading.Tasks.Task Load()
        {
            var ireferGetAgencyByIdResult = await Agencyservice.GetAgencyByIdAsync($"{Id}");
            agency = ireferGetAgencyByIdResult.Record;
            //agency.Address1 = ireferGetAgencyByIdResult.Record.Address1;
            //agency.Address2= ireferGetAgencyByIdResult.Record.Address2;
            //agency.Website = ireferGetAgencyByIdResult.Record.Website;
            //agency.AgencyName = ireferGetAgencyByIdResult.Record.AgencyName;
            //agency.PhoneNo = ireferGetAgencyByIdResult.Record.PhoneNo;
            //agency.City = ireferGetAgencyByIdResult.Record.City;
            //agency.ZipCode = ireferGetAgencyByIdResult.Record.ZipCode;
            //agency.Id = ireferGetAgencyByIdResult.Record.Id;
            //agency.State= ireferGetAgencyByIdResult.Record.State;
            
        }

        protected async System.Threading.Tasks.Task Form0Submit(iRefer.Shared.Models.Agency args)
        {
            try
            {
                var agencyRequest = new AgencyRequest { Id = agency.Id, AgencyName = agency.AgencyName, Address1 = agency.Address1, Address2 = agency.Address2, Website = agency.Website, PhoneNo = agency.PhoneNo, State = agency.State, ZipCode = agency.ZipCode };
                var ireferUpdateAgencyResult = await Agencyservice.EditAgencyAsync(agencyRequest);
                DialogService.Close(agency);
            }
            catch (Exception ireferUpdateAgencyException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Agency");
            }
        }

        protected  void  Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
