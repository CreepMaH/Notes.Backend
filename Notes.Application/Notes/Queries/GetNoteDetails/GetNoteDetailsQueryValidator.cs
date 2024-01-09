using FluentValidation;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
            RuleFor(getQuery => getQuery.Id).NotEqual(Guid.Empty);
            RuleFor(getQuery => getQuery.UserId).NotEqual(Guid.Empty);
        }
    }
}
