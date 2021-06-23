using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Validators
{
    public class EmployeeRoleValidator : AbstractValidator<Entities.EmployeeRole>
    {
        public EmployeeRoleValidator()
        {
            RuleSet("New", () =>
            {
                RuleFor(p => p.RoleName)
                .NotEmpty()
                .WithMessage("{PropertyName} can not be enpty");

            });
        }
    }
}
