using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using iRefer.Shared.Models;

namespace iRefer.Shared.Services
{
    class RewardService
    {
       

            private readonly string _baseUrl;

        private readonly ServiceClient client = new ServiceClient();

            public RewardService(string url)
            {
                _baseUrl = url;
            }

            public async Task<UserManagerResponse> GetActiveRewardAsync(string agencyId)
            {
                var response = await client.GetAsync<UserManagerResponse>($"{_baseUrl}/api/Rewards/ActiveReward/AgencyId={agencyId}");
                return response.Result;
            }

            public async Task<UserManagerResponse> GetAgencyRewards(string agencyId)
            {
                var response = await client.GetAsync<UserManagerResponse>($"{_baseUrl}/api/Rewards/AllRewards/AgencyId={agencyId}");
                return response.Result;
            }
            public async Task<UserManagerResponse> ConfigureCustomReward(CustomRewardRequest model)
            {
                var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Rewards/ConfigureCustom", model);
                return response.Result;
            }
        public async Task<UserManagerResponse> ConfigureCashReward(CashRewardRequest model)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Rewards/ConfigureCash", model);
            return response.Result;
        }
        public async Task<UserManagerResponse> ConfigurePointsReward(PointsRewardRequest model)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Rewards/ConfigurePoints", model);
            return response.Result;
        }
        public async Task<UserManagerResponse> ConfigureCouponReward(CouponRewardRequest model)
        {
            var response = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/Rewards/ConfigureCoupon", model);
            return response.Result;
        }
        
        
    }
}
