using AutoMapper;
using System.Linq;
using WebApplicationTest.Entities;
using WebApplicationTest.Models;

namespace WebApplicationTest.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            
            CreateMap<Personne, PersonneModel>();
            CreateMap<PersonneModel, Personne>();

        }
    }
}
