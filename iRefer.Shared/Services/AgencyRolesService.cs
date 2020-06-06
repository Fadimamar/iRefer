using AKSoftware.WebApi.Client;
using iRefer.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iRefer.Shared.Services
{
    public class AgencyRolesService
    {

        private readonly string _baseUrl;

        private readonly ServiceClient client = new ServiceClient();

        public AgencyRolesService(string url)
        {
            _baseUrl = url;
        }

        public string AccessToken
        {
            get => client.AccessToken;
            set
            {
                client.AccessToken = value;
            }
        }

        public async Task<AgenciesCollectionPagingResponse> GetRolesByAgencyIdAsync(string agencyId)
        {
            var response = await client.GetProtectedAsync<AgenciesCollectionPagingResponse>($"{_baseUrl}/api/AgenciesRoles/agencyid={agencyId}");
            return response.Result;
        }
        public async Task<AgenciesCollectionPagingResponse> GetAllRoles()
        {
            var response = await client.GetProtectedAsync<AgenciesCollectionPagingResponse>($"{_baseUrl}/api/AgenciesRoles/");
            return response.Result;
        }
    public async Task<AgencyRoleSingleResponse> AddRoleByUserIDAsync(AgencyRoleByIDRequest model)
        {
            var response = await client.PostProtectedAsync<AgencyRoleSingleResponse>($"{_baseUrl}/api//api/AgenciesRoles/AddRoleByID", model);
            return response.Result; 
        }

        public async Task<AgencyRoleSingleResponse> AddRoleByUserEmailAsync(AgencyRoleByEmailRequest model)
        {
            var response = await client.PostProtectedAsync<AgencyRoleSingleResponse>($"{_baseUrl}/api/AgenciesRoles/AddRoleByEmail", model);
            return response.Result;
        }

        public async Task<AgencySingleResponse> GetAgencyByIdAsync(string id)
        {
            var response = await client.GetProtectedAsync<AgencySingleResponse>($"{_baseUrl}/api/agencies/{id}");
            return response.Result;
        }


        public async Task<AgencyRoleSingleResponse> DeletePlanAsync(string id)
        {
            var response = await client.DeleteProtectedAsync<AgencyRoleSingleResponse>($"{_baseUrl}/api/AgenciesRoles/{id}");
            return response.Result;
        }



    }
}
