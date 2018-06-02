﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebApp.Data.Enums;
using WebApp.Data.Interfaces;
using WebApp.Infrastructure.SharedKernel;

namespace WebApp.Data.Entities
{
    [Table("Advertistments")]
    public class Advertistment : DomainEntity<int>, ISwitchable, ISortable
    {
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        [StringLength(250)]
        public string Url { get; set; }
        [StringLength(250)]
        public string PositionId { get; set; }
        public Status Status { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        [ForeignKey("PositionId")]
        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}
