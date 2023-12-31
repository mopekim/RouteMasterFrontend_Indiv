﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterBackend.Models
{
    public partial class ActivityProduct
    {
        public ActivityProduct()
        {
            CartActivitiesDetails = new HashSet<CartActivitiesDetail>();
            OrderActivitiesDetails = new HashSet<OrderActivitiesDetail>();
            TravelPlans = new HashSet<TravelPlan>();
        }

        public int Id { get; set; }
        public int ActivityId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual ICollection<CartActivitiesDetail> CartActivitiesDetails { get; set; }
        public virtual ICollection<OrderActivitiesDetail> OrderActivitiesDetails { get; set; }

        public virtual ICollection<TravelPlan> TravelPlans { get; set; }
    }
}