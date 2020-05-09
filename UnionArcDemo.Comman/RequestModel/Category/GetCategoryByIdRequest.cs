using FluentValidation;
using FluentValidation.Attributes;

namespace UnionArcDemo.Common.RequestModel.Category
{
    [Validator(typeof(GetCategoryByIdRequestValidator))]
    public class GetCategoryByIdRequest
    {
        public int CategoryId { get; set; }
    }

    public class GetCategoryByIdRequestValidator : AbstractValidator<GetCategoryByIdRequest>
    {
        public GetCategoryByIdRequestValidator()
        {
            RuleFor(x => x.CategoryId).NotEmpty().NotNull().WithMessage("CategoryId cannot be null");
        }
    }
}