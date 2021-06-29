using FluentValidation;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("New", () =>
            {
                RuleFor(p => p.FirstName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be enpty");

                RuleFor(p => p.Surname)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be enpty");

                RuleFor(p => p.employeeRole)
                .SetValidator(new EmployeeValidator());
            });
        }
    }
}
