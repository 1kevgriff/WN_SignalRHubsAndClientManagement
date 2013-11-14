using System;
using System.ComponentModel.DataAnnotations;

namespace GriffDesk.BusinessLayer.Models
{
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}