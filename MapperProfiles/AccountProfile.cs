using AutoMapper;
using WebItProject.Models.Identity;
using WebItProject.ViewModels;

namespace  WebItProject.MapperProfiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<ApplicationUser, UserProfileViewModel>().ReverseMap();
        }
    }
}