using FluentValidation;

namespace Notes.Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(delCom => delCom.Id).NotEqual(Guid.Empty);
            RuleFor(delCom => delCom.UserId).NotEqual(Guid.Empty);
        }
    }
}
