using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace iRefer.Shared.Models
{
    class RewardResponse: BaseAPIResponse
    {

        
        public string Description { get; set; }

        
        public DateTime? ExpirationDate { get; set; }
        
        public RewardTypes RewardType { get; set; }

        public int RewardReviewDays { get; set; }

        
        public string RewardMessage { get; set; }

        public float DiscountRate { get; set; }

        public bool NoExpiration { get; set; }
        public int? PointsAmount { get; set; }
        
        public decimal? EquivalentDollarAmount { get; set; }
        
        public decimal? CashAmount { get; set; }
        public Agency Agency { get; set; }
        public string AgencyId { get; set; }
    }
}
