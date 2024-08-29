using AutoMapper;
using ResumeManagementSystem.Core.Dtos.Company;
using ResumeManagementSystem.Core.Dtos.Job;
using ResumeManagementSystem.Core.Entities;

namespace ResumeManagementSystem.Core.AutoMapperConfig
{
    public class AutoMapperConfigProfile: Profile
    {
        public AutoMapperConfigProfile()
        {
            //Company
            CreateMap<CompanyCreateDto, Company>();
            CreateMap<Company, CompanyGetDto>();

            //Job
            CreateMap<JobCreateDto, Job>();
            CreateMap<Job, JobGetDto>()
                .ForMember(dest  => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name) )
                ;
        }
    }
}
