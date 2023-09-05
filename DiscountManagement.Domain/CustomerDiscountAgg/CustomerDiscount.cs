﻿using _0_Framework.Domain;
using System;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public class CustomerDiscount : EntityBase
    {
        public CustomerDiscount(long productId, int discountRate, 
            DateTime startDate, DateTime endDate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }

        public long ProductId { get;private set; }
        public int DiscountRate { get;private set; }
        public DateTime StartDate { get;private set; }
        public DateTime EndDate { get;private set; }
        public string Reason { get;private set; }


        public void Edit(long productId, int discountRate,
            DateTime startDate, DateTime endDate, string reason)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
    }
}
