using PracticeAPI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAPI.Repository
{
    public interface IPracticeRepo
    {
        Task<List<PracticeEntity>> GetAll();
        Task<PracticeEntity> GetOne(int id);
        Task Create(PracticeEntity model);
        Task Delete(int id);
        Task Update(PracticeEntity model);
    }
}
