using Northwİnd.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Services.Abstract
{
    public interface ICargoService
    {
        Task<List<Cargo>> GetCargos();
    }
}
