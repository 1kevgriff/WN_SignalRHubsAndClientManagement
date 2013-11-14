using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffDesk.BusinessLayer.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateEdited { get; set; }

        public List<Comment> Comments { get; set; }
        public Contact Contact { get; set; }
    }
}
