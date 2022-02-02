using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebItProject.Models.Entities;
using WebItProject.ViewModels;

namespace WebItProject.MapperProfiles
{
    public class SubscriptionProfiles: Profile
    {
        public SubscriptionProfiles()
        {
            CreateMap<SubscriptionType, SubscriptionTypeViewModel>().ReverseMap();
            CreateMap<Address, AddressViewModel>().ReverseMap();
        }       
    }
}
