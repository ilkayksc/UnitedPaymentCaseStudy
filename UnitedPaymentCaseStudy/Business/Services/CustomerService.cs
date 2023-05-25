using AutoMapper;
using UnitedPaymentCaseStudy.Business.Dto;
using UnitedPaymentCaseStudy.Business.Interfaces;
using UnitedPaymentCaseStudy.Context;
using UnitedPaymentCaseStudy.Data.Entity;
using ISession = NHibernate.ISession;

namespace UnitedPaymentCaseStudy.Business
{
    public class CustomerService : BaseService<CustomerDto, Customer>, ICustomerService
    {

        protected readonly ISession session;
        protected readonly IMapper mapper;
        protected readonly IMapperSession<Customer> hibernateRepository;

        public CustomerService(ISession session, IMapper mapper) : base(session, mapper)
        {
            this.session = session;
            this.mapper = mapper;
            hibernateRepository = new MapperSession<Customer>(session);
        }
        //Macbook Kullandığım için Wcf servis ekleyemiyorum bu yüzden bu kısmı tamamlayamadım. 
        /*public async Task VerifyCustomer(Customer customer)
        {
            var isVerified = await this.VerifyIdentityNo(customer);
            if (isVerified)
            {
                customer.IdentityNoVerified = true;
                customer.Status = true;
                this.hibernateRepository.Save(customer);
            }
            else
            {
                //doğrulanamadığında yapılacak işlemler varsa yapılır.
            }
               this.hibernateRepository.Save(customer);
        }

        private async Task<bool> VerifyIdentityNo(Customer customer)
        {
            var client = new KPSApiClient(KPSApiClient.EndpointConfiguration.KPSPublicSoap);
            var result = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.IdentityNo),
                                                        customer.Name.ToUpper(),
                                                        customer.Surname.ToUpper(),
                                                        customer.BirthDate.Year
                                                        );
            return result.Body.TCKimlikNoDogrulaResult;
        }*/

    }
}

