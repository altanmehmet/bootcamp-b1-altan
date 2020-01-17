using System;
using System.Collections.Generic;
using System.Linq;
using net_core_bootcamp_b1_altan.Dtos;
using net_core_bootcamp_b1_altan.Models;

namespace net_core_bootcamp_b1_altan.Services
{
    public interface IEventService
    {
        string Add(EventAddDto model);
        string Update(EventUpdateDto model);
        string Delete(Guid id);
        string Get(EventGetDto model);
    }

    public class EventService : IEventService
    {
        private static readonly IList<Event> data = new List<Event>();

        public string Add(EventAddDto model)
        {
            var entity = new Event
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow
            };
            
            entity.Name = model.Name;
            entity.StartDate = model.StartDate;
            entity.FinishDate = model.FinishDate;
            entity.Addres = model.Address;
            entity.IsFree = model.IsFree;
            entity.Price = model.Price;
            entity.Subject = model.Subject;
            entity.Desc = model.Desc;

            data.Add(entity);
            return "success";
        }
        public string Update(EventUpdateDto model)
        {
            var entity = data.Where(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefault();

            if (entity == null)
                return "Böyle bir kayıt bulunamadı.";

            entity.Name = model.Name;
            entity.StartDate = model.StartDate;
            entity.FinishDate = model.FinishDate;
            entity.Addres = model.Address;
            entity.IsFree = model.IsFree;
            entity.Price = model.Price;
            entity.Subject = model.Subject;
            entity.Desc = model.Desc;

            return ($"{model.Id} kaydı güncellendi.");
        }
        public string Delete(Guid id)
        {
            var entity = data.Where(x => x.Id == id).FirstOrDefault();
            if (entity == null)
                return ($"{entity.Name} ait kayıt bulunamadı.");
            entity.IsDeleted = true;

            return ($"{entity.Name} ait kayıt silindi.");
        }

        public string Get(EventGetDto model)
        {
            var result = data.Where(x => !x.IsDeleted && x.Name == model.Name  ).FirstOrDefault();


            
            
        }


















        }
    }
}