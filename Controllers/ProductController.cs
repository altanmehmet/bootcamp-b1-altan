using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using net_core_bootcamp_b1;

namespace net_core_bootcamp_b1_altan.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private static readonly IList<Product> data = new List<Product>();
        [HttpPost("Add")]
        public IActionResult Add([FromBody]Product model)
        {
            model.Id = Guid.NewGuid();
            model.CreatedAt = DateTime.UtcNow;

            data.Add(model);

            return Ok($"{ model.Name} eklendi."); 
        }
        [HttpPut("Update")]
        public IActionResult Update([FromBody]Product model)
        {
            if (model.Id == null)
                return BadRequest("Id alanı boş geçilemez.");
            var rec = data.Where(x => x.Id == model.Id).FirstOrDefault();
            if (rec == null)
                return BadRequest($"{model.Id }  adlı kayıt bulunamadı.");
            rec.Name = model.Name;
            rec.Desc = model.Desc;
            rec.Price = model.Price;
            return Ok($"{model.Id} kaydı güncellendi.");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete([BindRequired]Guid id)
            // bind?
        {
            var rec = data.Where(x => x.Id == id).FirstOrDefault();
            if (rec == null)
                return BadRequest($"{id} adlı kayıt bulunamadı.");
            data.Remove(rec);
            return Ok($"{id} adlı kayıt silindi.");
        }
        [HttpGet("Get")]
        public IActionResult Get(string name = null)
        {
            var selectedData = data;
            if (!string.IsNullOrWhiteSpace(name))
            {
                selectedData = data.Where(x => x.Name.Contains(name)).ToList();
                return Ok(selectedData);
            }
            else
            {
                return BadRequest(name + "adında bir kayıt bulunamadı.");
            }

        }
        }                

        
        
    }

    

