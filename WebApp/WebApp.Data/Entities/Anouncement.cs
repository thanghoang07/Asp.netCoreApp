using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebApp.Data.Enums;
using WebApp.Data.Interfaces;
using WebApp.Infrastructure.SharedKernel;

namespace WebApp.Data.Entities
{
    [Table("Announcements")]
    public class Announcement : DomainEntity<string>, ISwitchable, IDateTracking
    {
        public Announcement()
        {
            AnnouncementUsers = new List<AnnouncementUser>();
        }
        [Required]
        [StringLength(250)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Content { set; get; }

        [StringLength(450)]
        public string UserId { set; get; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        public Status Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateCreated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateModified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }
    }
}
