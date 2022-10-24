using EntityLayers.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class DoktorValidator : AbstractValidator<TBLDOKTOR>
    {
        public DoktorValidator()
        {
            RuleFor(x => x.DOKTORAD).NotEmpty().WithMessage(" Hasta Adı Boş Olamaz! Güncelleme Yapılamadı... ");
            RuleFor(x => x.DOKTORAD).MinimumLength(3).WithMessage(" Hasta Adı En az 3 Karakter Olmalı. Güncelleme Yapılamadı... ");
            RuleFor(x => x.DOKTORAD).MaximumLength(50).WithMessage(" Hasta Adı En fazla 50 Karakter Olmalı. Güncelleme Yapılamadı... ");
            RuleFor(x => x.DOKTORADRESBILGI).NotEmpty().WithMessage(" Hasta Bilgisi Boş Olamaz! Güncelleme Yapılamadı... ");
            RuleFor(x => x.DOKTORADRESBILGI).MaximumLength(1250).WithMessage(" Hasta Bilgisi En fazla 1250 Karakter Olmalı. Güncelleme Yapılamadı... ");

        }
    }
}
