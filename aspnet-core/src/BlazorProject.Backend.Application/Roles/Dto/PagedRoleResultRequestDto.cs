using Abp.Application.Services.Dto;

namespace BlazorProject.Backend.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

