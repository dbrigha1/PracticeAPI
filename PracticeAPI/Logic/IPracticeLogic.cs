using PracticeAPI.Models.Entity;
using PracticeAPI.Models.ViewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAPI.Logic
{
    public interface IPracticeLogic
    {
        Task<List<PracticeViewEntity>> GetAll();
        Task<PracticeEntity> GetOne(int id);
        Task Create(PracticeViewEntity viewEntity);
        Task Delete(int id);
        Task Update(PracticeEntity model);
    }
}
