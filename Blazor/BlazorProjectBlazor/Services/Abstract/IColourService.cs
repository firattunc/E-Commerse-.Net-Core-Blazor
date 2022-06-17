using BlazorProjectBlazor.Models;
using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectBlazor.Services.Abstract
{
    public interface IColourService
    {
        Task<List<ColourModel>> GetAll();
    }
}
