using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffDesk.BusinessLayer.Models;

namespace GriffDesk.ServiceLibrary.Data
{
    public class GriffDeskContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Contact> Contacts { get; set; } 
    }
}
