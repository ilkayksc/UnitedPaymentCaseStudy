using AutoMapper;
using UnitedPaymentCaseStudy.Data.Entity;
using UnitedPaymentCaseStudy.Business.Dto;

namespace UnitedPaymentCaseStudy.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
        }
    }
}

