using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;


namespace DataBaseTutorial.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("can't be empty")
                .Must(ProductValidName).WithMessage("Contains invalid characters");

            RuleFor(p => p.ProductWeight)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull().WithMessage("Use only Numbers and dot");

            RuleFor(p => p.ProductId).NotEmpty();

            RuleFor(p => p.ProductBuyedDate)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("can't be empty")
                .Must(ProductAvaliableDate).WithMessage("Incorrect date");
        }

        bool ProductValidName(string name)
        {
            return name.All(Char.IsLetter);
        }
        bool ProductAvaliableDate(DateTime date)
        {
            if (date <= DateTime.Now && date.AddDays(365)> DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
