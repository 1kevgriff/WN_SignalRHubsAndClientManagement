using System;
using System.Collections.Generic;
using System.Data.Entity;
using GriffDesk.BusinessLayer.Models;

namespace GriffDesk.ServiceLibrary.Data
{
    public class GriffDeskDatabaseInitializer : DropCreateDatabaseIfModelChanges<GriffDeskContext>
    {
        protected override void Seed(GriffDeskContext context)
        {
            var contact = new Contact()
            {
                Id = Guid.NewGuid(),
                EmailAddress = "kevin@kevgriffin.com",
                FirstName = "Kevin",
                LastName = "Griffin"
            };

            context.Tickets.Add(new Ticket()
            {
                Id = Guid.NewGuid(),
                Contact = contact,
                Title = "Windows will not boot",
                DateOpened = DateTime.Now.AddMonths(3),
                DateEdited = DateTime.Now.AddMonths(2),
                Comments = new List<Comment>(),
                Description = "User"
            });

            context.Tickets.Add(new Ticket()
            {
                Id = Guid.NewGuid(),
                Contact = contact,
                Title = "IE6 cannot use web sockets",
                DateOpened = DateTime.Now.AddMonths(1),
                DateEdited = DateTime.Now.AddDays(14),
                Comments = new List<Comment>(),
                Description = "User"
            });

            context.SaveChanges();
        }
    }
}