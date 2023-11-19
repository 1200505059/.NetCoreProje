 using EntityLayer.Concrate;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş geçilemez");
            RuleFor(x => x.Time).NotEmpty().WithMessage("Resim alanıProje süresi boş geçilemez");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje linki boş geçilemez");
            RuleFor(x => x.Status).NotEmpty().WithMessage("durum alanı boş geçilemez");
        
        }

    }
}
