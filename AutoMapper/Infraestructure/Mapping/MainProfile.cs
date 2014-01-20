using AutoMapper.Models;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper.Infraestructure.Mapping
{
    public class MainProfile:Profile
    {
        protected override void Configure()
        {
            CreateMap<double,string>().ConvertUsing(d => d.ToString("c"));

            CreateMap<Customer, CustomerViewModel>()
                .ForMember(c=> c.Name,opt=> opt.ResolveUsing<NameResolver>())
                .ForMember(c=> c.Status,opt=> opt.ResolveUsing<StatusResolver>())
                .ForMember(c=> c.ShippingAddress,opt=> opt.ResolveUsing<AddressResolver>())
                .ForMember(c => c.TotalAmountPaid, opt => opt.ResolveUsing<TotalAmountValueResolver>());
        }
    }

    public class AddressResolver : ValueResolver<Address, string> 
    {
        protected override string ResolveCore(Address source)
        {
            return String.Format("{0} {1} {2} {3} {4}", source.Line1, source.Line2, source.City, source.State,
                source.Zip);
        }
    }

    public class StatusResolver : ValueResolver<CustomerStatus, string>
    {
        protected override string ResolveCore(CustomerStatus source)
        {
            return source.DisplayName;
        }
    }


    public class NameResolver : ValueResolver<Name, string> 
    {
        protected override string ResolveCore(Name source)
        {
            return string.Format("{0} {1} {2}", source.First, source.Middle, source.Last);
        }
    }

    public class TotalAmountValueResolver : ValueResolver<Customer, string> 
    {
        protected override string ResolveCore(Customer source)
        {
            return source.GetTotalAmountPaid().ToString("c");
        }
    }
}