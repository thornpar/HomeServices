using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using netcore.Models;
using HomeServices.ModelDtos;

namespace netcore.Repositories
{
    public class PelleEventRepository : IPelleEventRepository
    {
        public PelleEventRepository(PelleEventContext context)
        {
            Context = context;
        }
        private PelleEventContext Context { get; }
        public void Add(PelleEventDto pelleEvent)
        {
            var p = new PelleEvent
            {
                Status = pelleEvent.Status,
                Date = DateTime.Now
            };
            Context.PelleEvents.Add(p);
            Context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Context.PelleEvents.Remove(Context.PelleEvents.FirstOrDefault(e => e.Id == id));
            Context.SaveChanges();
        }

        public void Update(Guid id, PelleEvent delta)
        {
            delta.Id = id;
            var entity = Context.PelleEvents.FirstOrDefault(e => e.Id == id);
            entity.Status = delta.Status ?? entity.Status;
            Context.SaveChanges();
        }

        public IEnumerable<PelleEvent> People()
        {
            return Context.PelleEvents
                .AsEnumerable();
        }
    }
}
