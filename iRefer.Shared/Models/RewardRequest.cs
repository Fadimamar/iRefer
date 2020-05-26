using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iRefer.Shared.Models
{
    public enum RewardTypes { Cash=1, Coupon = 2, Custom = 3, Points = 4 }
    public class CashRewardRequest
    {
        [Required]

        public string Description { get; set; }


        public DateTime? ExpirationDate { get; set; }
        

        public int RewardReviewDays { get; set; }

        [Required]

        public string Message { get; set; }



        public bool NoExpiration { get; set; }




        public decimal? CashAmount { get; set; }

        public string AgencyId { get; set; }
    }
    public class CouponRewardRequest
    {
        [Required]

        public string Description { get; set; }


        public DateTime? ExpirationDate { get; set; }

        public int RewardReviewDays { get; set; }

        [Required]

        public string Message { get; set; }


        public bool NoExpiration { get; set; }
        public float DiscountRate { get; set; }

        public string AgencyId { get; set; }
    }
    public class PointsRewardRequest
    {
        [Required]

        public string Description { get; set; }


        public DateTime? ExpirationDate { get; set; }
        [Required]


        public int RewardReviewDays { get; set; }

        [Required]

        public string Message { get; set; }

        public float DiscountRate { get; set; }

        public bool NoExpiration { get; set; }
        public int? PointsAmount { get; set; }

        public decimal? EquivalentDollarAmount { get; set; }


        public string AgencyId { get; set; }
    }
    public class CustomRewardRequest
    {
        [Required]

        public string Description { get; set; }


        public DateTime? ExpirationDate { get; set; }


        public int RewardReviewDays { get; set; }

        [Required]

        public string Message { get; set; }



        public bool NoExpiration { get; set; }




        public string AgencyId { get; set; }
    }
}
