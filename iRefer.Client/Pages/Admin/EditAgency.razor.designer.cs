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
using Microsoft.AspNetCore.Components.Authorization;

using Blazor.FileReader;
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
        protected IFileReaderService fileReaderSerivce { get; set; }

        protected  System.IO.Stream fileStream = null;
        protected  string imageContent = string.Empty;
        protected string fileName = string.Empty;


        public ElementReference inputReference;
        [Inject]
        protected AgencyService Agencyservice { get; set; }

        [Parameter]
        public dynamic Id { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> authenticationState { get; set; }
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
        protected async Task chooseFileAsync()
        {
            // Read the file
            var file = (await fileReaderSerivce.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

            // Read the info of the file
            var fileInfo = await file.ReadFileInfoAsync();

            // Validate the extension
            string extension = System.IO.Path.GetExtension(fileInfo.Name);
            var allowedExtensions = new string[] { ".jpg", ".png", ".bmp" };

            if (!allowedExtensions.Contains(extension))
            {
                NotificationService.Notify(NotificationSeverity.Error, "The chosen file is not a valid image file");
               
                return;
            }
            

            // Open the stream
            using (var memoryStream = await file.CreateMemoryStreamAsync())
            {
                // Copy the content to a new stream
                fileStream = new System.IO.MemoryStream(memoryStream.ToArray());
                fileName = fileInfo.Name;

                // Show the file in the UI
                imageContent = $"data:{fileInfo.Type};base64, {Convert.ToBase64String(memoryStream.ToArray())}";
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
            
            
        }

        protected async System.Threading.Tasks.Task Form0Submit(iRefer.Shared.Models.Agency args)
        {
            try
            {
                var userState = authenticationState.Result;
                Agencyservice.AccessToken = userState.User.FindFirst("AccessToken").Value;

                var agencyRequest = new AgencyRequest { Id = agency.Id, AgencyName = agency.AgencyName, Address1 = agency.Address1, Address2 = agency.Address2, Website = agency.Website, PhoneNo = agency.PhoneNo, State = agency.State, ZipCode = agency.ZipCode, Logo = fileStream,FileName = fileName};
                var ireferUpdateAgencyResult = await Agencyservice.EditAgencyAsync(agencyRequest);
                if (ireferUpdateAgencyResult.IsSuccess)
                {
                    DialogService.Close(agency);

                }
                else
                {
                    NotificationService.Notify(NotificationSeverity.Error, ireferUpdateAgencyResult.Message);
                }
            }
            catch (Exception ireferUpdateAgencyException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", ireferUpdateAgencyException.Message);
            }
        }

        protected  void  Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
