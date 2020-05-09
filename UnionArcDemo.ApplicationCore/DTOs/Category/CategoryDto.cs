namespace UnionArcDemo.ApplicationCore.DTOs.Category
{
    public class CategoryDto
    {
        public CategoryDto()
        {
            
        }

        public CategoryDto(string categoryName, string description)
        {
            CategoryName = categoryName;
            Description = description;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}