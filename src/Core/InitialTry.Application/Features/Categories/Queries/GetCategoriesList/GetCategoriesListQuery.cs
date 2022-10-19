using InitialTry.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace InitialTry.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
