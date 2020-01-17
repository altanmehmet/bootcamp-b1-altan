using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using net_core_bootcamp_b1_altan.Dtos;
using net_core_bootcamp_b1_altan.Services;

namespace net_core_bootcamp_b1_altan.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class EventController : ControllerBase
{
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }
    [HttpPost("Add")]
    public IActionResult Add([FromBody]EventAddDto model)
        {
            var result = _eventService.Add(model);

            return Ok(result);
        }
    [HttpPut("Update")]
    public IActionResult Update([FromBody]EventUpdateDto model)
        {
            var result = _eventService.Update(model);

            return Ok(result);
        }
        [HttpDelete("Delete")]
    public IActionResult Delete([BindRequired]Guid id)
        {
            var result = _eventService.Delete(id);

            return Ok(result);
        }
    public IActionResult Get()
        {
            var result = _eventService.Get();
            return Ok(result);
        }
}
}
