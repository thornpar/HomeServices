using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcore.Models;
using netcore.Repositories;
using HomeServices.ModelDtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcore.Controllers
{
    [Route("api/[controller]")]
    public class PelleEventsController : Controller
    {
        private IPelleEventRepository PelleEventsRepository { get; set; }
        public PelleEventsController(IPelleEventRepository pelleEventsRepository)
        {
            PelleEventsRepository = pelleEventsRepository;
        }
        // GET: api/PelleEvents
        [HttpGet]
        public IEnumerable<PelleEvent> Get()
        {
            return PelleEventsRepository.People();
        }

        [HttpGet("latest")]
        public PelleEvent LatestEvents()
        {
            return PelleEventsRepository.People().OrderByDescending(e => e.Date).FirstOrDefault();
        }

        // GET api/PelleEvents/5
        [HttpGet("{id}")]
        public PelleEvent Get(Guid id)
        {
            return PelleEventsRepository.People().FirstOrDefault(e => e.Id == id);
        }

        // POST api/PelleEvents
        [HttpPost]
        public void Post([FromBody]PelleEventDto value)
        {
            PelleEventsRepository.Add(value);
        }

        // PUT api/PelleEvents/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]PelleEvent delta)
        {
            PelleEventsRepository.Update(id, delta);
        }

        // DELETE api/PelleEvents/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            PelleEventsRepository.Delete(id);
        }
    }
}
