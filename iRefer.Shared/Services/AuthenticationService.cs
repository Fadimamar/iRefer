using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using iRefer.Shared.Models;

namespace iRefer.Shared.Services
{
    public class AuthenticationService
    {

        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/register", request);
            return response.Result;
        }

        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/login", request);
            return response.Result;
        }
        public async Task<UserManagerResponse> ForgotPasswordAsync(string email)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/ForgotPassword", email);
            return response.Result;
        }
        public async Task<UserManagerResponse> ResetPasswordAsync(ResetPasswordRequest model)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/RestPassword", model);
            return response.Result;
        }
    }
}
