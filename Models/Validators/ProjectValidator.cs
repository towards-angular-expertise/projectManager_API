using FluentValidation;

namespace Backend.Models.Validators
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.id).NotEmpty();
            RuleFor(x => x.name).NotEmpty();
            RuleFor(x => x.url).NotEmpty();
            RuleFor(x => x.userid).NotEmpty();
            

        }
    }
}