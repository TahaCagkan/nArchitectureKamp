using Application.Services.Repositories;
using AutoMapper;

namespace Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQueryBase
    {
        IBrandRepository _brandRepository;
        IMapper _mapper;
    }
}