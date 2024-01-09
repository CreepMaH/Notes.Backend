using FluentValidation;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidator : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(updCom => updCom.Id).NotEmpty();
            RuleFor(updCom => updCom.UserId).NotEqual(Guid.Empty);
            RuleFor(updCom => updCom.Title).NotEmpty().MaximumLength(250);
        }
    }
}
