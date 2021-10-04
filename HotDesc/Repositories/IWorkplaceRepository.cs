using HotDesc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Repositories
{
    public interface IWorkplaceRepository
    {
        Task<List<Workplace>> GetAllData();
        Task<List<Workplace>> GetBookData();
        Task CreateWorkpalce(string id);
        Task DeleteWorkplace(int id);
        Task Edit(int id, string description, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook);
        Task EditOneWorkplace(Workplace giveWorkplace, string description, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook);
    }
}
