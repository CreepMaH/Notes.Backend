using FluentValidation;
using Notes.Application.Notes.Queries.GetNoteList;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator()
        {
            RuleFor(getQuery => getQuery.UserId).NotEqual(Guid.Empty);
        }
    }
}
