using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using netcore.Models;
using HomeServices.ModelDtos;

namespace netcore.Repositories
{
    public interface IPelleEventRepository
    {
        void Add(PelleEventDto person);
        void Delete(Guid id);
        void Update(Guid id, PelleEvent delta);
        IEnumerable<PelleEvent> People();

    }
}
