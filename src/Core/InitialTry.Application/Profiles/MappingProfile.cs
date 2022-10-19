using AutoMapper;
using InitialTry.Application.Features.Categories.Commands.CreateCategory;
using InitialTry.Application.Features.Categories.Commands.StoredProcedure;
using InitialTry.Application.Features.Categories.Queries.GetCategoriesList;
using InitialTry.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using InitialTry.Application.Features.Events.Commands.CreateEvent;
using InitialTry.Application.Features.Events.Commands.Transaction;
using InitialTry.Application.Features.Events.Commands.UpdateEvent;
using InitialTry.Application.Features.Events.Queries.GetEventDetail;
using InitialTry.Application.Features.Events.Queries.GetEventsExport;
using InitialTry.Application.Features.Events.Queries.GetEventsList;
using InitialTry.Application.Features.Orders.GetOrdersForMonth;
using InitialTry.Domain.Entities;

namespace InitialTry.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
