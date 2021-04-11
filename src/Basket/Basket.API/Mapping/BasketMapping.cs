using AutoMapper;
using Basket.API.Entities;
using EventBusRabbitMQ.Events;

namespace Basket.API.Mapping
{
    public class BasketMapping : Profile
    {
        //Both model can be convert to each others by using reverse map
        public BasketMapping()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
