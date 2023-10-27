using Domain.Entidades;
using FluentValidation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("Please enter the name.")
                .NotNull().WithMessage("Please enter the name.");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Please enter the last name.")
                .NotNull().WithMessage("Please enter the last name.");

            RuleFor(c => c.Username)
                .NotEmpty().WithMessage("Please enter the username.")
                .NotNull().WithMessage("Please enter the username.");

            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Please enter the password.")
                .NotNull().WithMessage("Please enter the password.");
        }
    }
}
