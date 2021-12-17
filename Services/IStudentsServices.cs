using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public interface IStudentsServices
    {
        Task<IEnumerable<Students>> GetAll();
        Task <Students> GetById(int id);

        Task Delete(int id);

        Task<Students> Add(Students employee);

        Task<Students> Update(int id,Students Student);

    }
}