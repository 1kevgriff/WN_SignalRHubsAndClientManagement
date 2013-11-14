using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GriffDesk.BusinessLayer.Models;
using GriffDesk.ServiceLibrary.Data;

namespace GriffDesk.ServiceLibrary.Repositories
{
    public class TicketRepository
    {
        public void Create(Ticket newTicket)
        {
            using (var context = new GriffDeskContext())
            {
                context.Tickets.Add(newTicket);
                context.SaveChanges();
            }
        }
        public IEnumerable<Ticket> Get()
        {
            using (var context = new GriffDeskContext())
            {
                return context.Tickets.AsEnumerable();
            }
        }
        public IEnumerable<Ticket> Get(Func<Ticket, bool> predicate)
        {
            using (var context = new GriffDeskContext())
            {
                return context.Tickets.Where(predicate).AsEnumerable();
            }
        }
    }
}
