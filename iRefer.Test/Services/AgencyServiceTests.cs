using Microsoft.VisualStudio.TestTools.UnitTesting;
using iRefer.Shared.Services;
using AKSoftware.WebApi.Client;
using iRefer.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;

namespace iRefer.Tests
{
    [TestClass()]
    public class AgencyServiceTests
    {
        private readonly ServiceClient client = new ServiceClient();

        private readonly string _baseUrl = "https://localhost:44344";

        public AgencyServiceTests()
        {
            client.AccessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJFbWFpbCI6ImluZm9Ad2VzdGxpbmVzb2Z0LmNvbSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWVpZGVudGlmaWVyIjoiMjVkYzQzNjktNjlmYy00YWY0LWE5NmYtZGZmNDllMDYyNTNjIiwiRmlyc3ROYW1lIjoiRmFkaSIsIkxhc3ROYW1lIjoiTWFtYXIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJTeXNBZG1pbiIsImV4cCI6MTU5Mzk5MjAxMCwiaXNzIjoiaHR0cHM6Ly93ZXN0bGluZXNvZnQuY29tIiwiYXVkIjoiaHR0cDovL2xvY2FsaG9zdCJ9.vb1OPafreUCFvE1tz_6ZyHGqCR5MyhltN-Fb_Z2m-O4";
        }

        [TestMethod()]

        public void GetAllAgenciesAsyncTest()
        {
            Task.Run(async () =>
            {
                var response = await client.GetProtectedAsync<AgenciesResponse>($"{_baseUrl}/api/Agencies");

                Assert.IsTrue(response.Result.IsSuccess);

            }).GetAwaiter().GetResult();

        }

        [TestMethod()]
        public void GetAgencyByIdAsyncTest()
        {
            string id = "0248dc2d-7624-4e03-9f87-a5521466b9f1";
            Task.Run(async () =>
            {
                var response = await client.GetProtectedAsync<AgencySingleResponse>($"{_baseUrl}/api/agencies/{id}");

                Assert.IsTrue(response.Result.IsSuccess);

            }).GetAwaiter().GetResult();
        }
    }

}
