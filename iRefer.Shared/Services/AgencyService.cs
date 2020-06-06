using AKSoftware.WebApi.Client;
using iRefer.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace iRefer.Shared.Services
{
    public class AgencyService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public AgencyService(string url)
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

        /// <summary>
        /// Retrieve all the Agencies from the API with pagination
        /// </summary>
        /// <param name="page">Number of the page</param>
        /// <returns></returns>
        public async Task<AgenciesCollectionPagingResponse> GetAllAgenciesByPageAsync(int page = 1)
        {
            var response = await client.GetProtectedAsync<AgenciesCollectionPagingResponse>($"{_baseUrl}/api/Agencies/Pages?page={page}");
            return response.Result; 
        }
        /// <summary>
        /// Retrieve all the Agencies from the API without pagination. SysAdmin Logged in user will retrieve all Agencies. Agency Admin will reterive only one Agency.
        /// </summary>
       
        /// <returns></returns>
        public async Task<IEnumerable<Agency>> GetAllAgenciesAsync()
        {
            var response = await client.GetAsync<IEnumerable<Agency>>($"{_baseUrl}/api/Agencies");
            return response.Result;
        }

        /// <summary>
        /// Return a Plan by ID
        /// </summary>
        /// <param name="id">ID of the plan to be retrieved</param>
        /// <returns></returns>
        public async Task<AgencySingleResponse> GetAgencyByIdAsync(string id)
        {
            var response = await client.GetProtectedAsync<AgencySingleResponse>($"{_baseUrl}/api/agencies/{id}");
            return response.Result;
        }

        /// <summary>
        /// Retrieve all the plans from the API with pagination
        /// </summary>
        /// <param name="page">Number of the page</param>
        /// <returns></returns>
        public async Task<AgenciesCollectionPagingResponse> SearchAgenciesByPageAsync(string query, int page = 1)
        {
            var response = await client.GetProtectedAsync<AgenciesCollectionPagingResponse>($"{_baseUrl}/api/Agencies/search?query={query}&page={page}");
            return response.Result;
        }

        /// <summary>
        /// Post a agency to the API
        /// </summary>
        /// <param name="model">object represnets the plan to be added</param>
        /// <returns></returns>
        public async Task<AgencySingleResponse> PostAgencyAsync(AgencyRequest model)
        {
            var formKeyValues = new List<FormKeyValue>()
            {
                new StringFormKeyValue("AgencyName", model.AgencyName),
                new StringFormKeyValue("Address1", model.Address1),
                new StringFormKeyValue("Address2", model.Address2),
                new StringFormKeyValue("City", model.City),
                new StringFormKeyValue("State", model.State),
                new StringFormKeyValue("ZipCode", model.ZipCode),
                new StringFormKeyValue("Website", model.Website),
                new StringFormKeyValue("PhoneNo", model.PhoneNo),
                

            };

            if (model.Logo != null)
                formKeyValues.Add(new FileFormKeyValue("Logo", model.Logo, model.FileName));

            var response = await client.SendFormProtectedAsync<AgencySingleResponse>($"{_baseUrl}/api/Agencies", ActionType.POST, formKeyValues.ToArray());

            return response.Result; 
        }

        /// <summary>
        /// Edit a plan to the API
        /// </summary>
        /// <param name="model">object represnets the plan to be added</param>
        /// <returns></returns>
        public async Task<AgencySingleResponse> EditAgencyAsync(AgencyRequest model)
        {
            var formKeyValues = new List<FormKeyValue>()
            {
                 new StringFormKeyValue("Id", model.Id),
                 new StringFormKeyValue("Address1", model.Address1),
                new StringFormKeyValue("Address2", model.Address2),
                new StringFormKeyValue("City", model.City),
                new StringFormKeyValue("State", model.State),
                new StringFormKeyValue("ZipCode", model.ZipCode),
                new StringFormKeyValue("Website", model.Website),
                new StringFormKeyValue("PhoneNo", model.PhoneNo),

            };


            if (model.Logo != null)
                formKeyValues.Add(new FileFormKeyValue("Logo", model.Logo, model.FileName));

            var response = await client.SendFormProtectedAsync<AgencySingleResponse>($"{_baseUrl}/api/Agencies", ActionType.PUT, formKeyValues.ToArray());

            return response.Result;
        }

        /// <summary>
        /// Delete plan from the account
        /// </summary>
        /// <param name="id">ID of the plan to be deleted</param>
        /// <returns></returns>
        public async Task<AgencySingleResponse> DeleteAgencyAsync(string id)
        {
            var response = await client.DeleteProtectedAsync<AgencySingleResponse>($"{_baseUrl}/api/Agencies/{id}");
            return response.Result; 
        }
        
    }
}
