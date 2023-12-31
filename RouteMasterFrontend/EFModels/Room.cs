﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class Room
    {
        public Room()
        {
            RoomImages = new HashSet<RoomImage>();
            RoomProducts = new HashSet<RoomProduct>();
            RoomServiceInfos = new HashSet<RoomServiceInfo>();
        }

        public int Id { get; set; }
        public int AccommodationId { get; set; }
        public int RoomTypeId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<RoomImage> RoomImages { get; set; }
        public virtual ICollection<RoomProduct> RoomProducts { get; set; }

        public virtual ICollection<RoomServiceInfo> RoomServiceInfos { get; set; }
    }
}