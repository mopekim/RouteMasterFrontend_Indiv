﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterBackend.Models
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityImages = new HashSet<ActivityImage>();
            ActivityProducts = new HashSet<ActivityProduct>();
            OrderActivitiesDetails = new HashSet<OrderActivitiesDetail>();
            PackageTours = new HashSet<PackageTour>();
        }

        public int Id { get; set; }
        public int ActivityCategoryId { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public int AttractionId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }

        public virtual ActivityCategory ActivityCategory { get; set; }
        public virtual Attraction Attraction { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<ActivityImage> ActivityImages { get; set; }
        public virtual ICollection<ActivityProduct> ActivityProducts { get; set; }
        public virtual ICollection<OrderActivitiesDetail> OrderActivitiesDetails { get; set; }

        public virtual ICollection<PackageTour> PackageTours { get; set; }
    }
}