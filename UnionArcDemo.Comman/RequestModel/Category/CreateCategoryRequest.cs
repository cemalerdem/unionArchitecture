using FluentValidation;
using FluentValidation.Attributes;

namespace UnionArcDemo.Common.RequestModel.Category
{
    [Validator(typeof(CreateCategoryRequestValidator))]
    public class CreateCategoryRequest
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }

    public class CreateCategoryRequestValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CreateCategoryRequestValidator()
        {
            RuleFor(cat => cat.CategoryName).NotEmpty().NotNull().WithMessage("Category name can not be null or empty");
            RuleFor(cat => cat.Description).NotEmpty().NotNull().WithMessage("Description can not be null or empty");
            RuleFor(cat => cat.Picture).NotEmpty().NotNull().WithMessage("Picture can not be null or empty");
        }
    }
}