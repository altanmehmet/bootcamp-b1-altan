using System;
using System.Collections.Generic;
using net_core_bootcamp_b1_altan.Dtos;
using net_core_bootcamp_b1_altan.Models;

namespace net_core_bootcamp_b1_altan.Services
{
    public interface IEventService
    {
        string Add(EventAddDto model);
    }

    public class EventService : IEventService
    {
        private static IList<Event> data = new List<Event>();

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
        public class 
    }
}