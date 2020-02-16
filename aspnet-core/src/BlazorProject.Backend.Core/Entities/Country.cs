using Abp.Domain.Entities;

namespace BlazorProject.Backend.Entities
{
    public class Country:Entity<int>
    {
        public string Name { get; set; }
    }
}
