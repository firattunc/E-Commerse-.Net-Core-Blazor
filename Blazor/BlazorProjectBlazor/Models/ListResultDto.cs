using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class ListResultDto<T>
    {
        public IReadOnlyList<T> items { get; set; }
    }
}
