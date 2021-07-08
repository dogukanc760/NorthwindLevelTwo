using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("Bu Alan Boş Geçilemez!!!");
            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.Email).NotEmpty().Must(StartWithA);
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.Adress).NotEmpty();
            RuleFor(s => s.Age).NotEmpty();
        }

        //private bool StartWithA(int arg)
        //{
        //    throw new NotImplementedException();
        //}

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
