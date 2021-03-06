using FluentValidation;
using MyWebAPICore.Dtos.Book;

namespace MyWebAPICore.Validators
{
    public class UpdateBookValidator : AbstractValidator<UpdateBookDto>
    {
        public UpdateBookValidator()
        {
            RuleFor(book => book.Title).NotEmpty().WithMessage("Book Title is required.");
            RuleFor(book => book.Pages).NotNull().GreaterThan(0).WithMessage("Number of pages must be indicated by value grater than 0.");
            RuleFor(book => book.Price).NotNull().GreaterThan(0).WithMessage("Price value must be greater than 0.");
        }
    }
}
