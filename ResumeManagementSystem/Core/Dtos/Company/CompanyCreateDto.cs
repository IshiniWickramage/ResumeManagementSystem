using ResumeManagementSystem.Core.Enums;

namespace ResumeManagementSystem.Core.Dtos.Company
{
    public class CompanyCreateDto
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }
    }
}
