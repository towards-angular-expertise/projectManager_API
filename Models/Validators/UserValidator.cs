using FluentValidation;

namespace Backend.Models.Validators
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator(){
            RuleFor(x=>x.id).NotEmpty();
            RuleFor(x=>x.name).NotEmpty();
            RuleFor(x=>x.lastname).NotEmpty();
            RuleFor(x=>x.email).NotEmpty();
            RuleFor(x=>x.username).NotEmpty();
            RuleFor(x=>x.password).NotEmpty();
            RuleFor(x=>x.rightids).NotEmpty();
        }
    }
}