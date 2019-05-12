using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareBackend.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string PickedLists { get; set; }
    }
}