using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PracticeAPI.Models;
using PracticeAPI.Models.Entity;

namespace PracticeAPI.Repository
{
    public class PracticeRepo : IPracticeRepo
    {
        private readonly PracticeContext _context;
        public PracticeRepo(PracticeContext context)
        {
            _context = context;
        }
        public async Task Create(PracticeEntity model)
        {
            _context.Practice.Add(model);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PracticeEntity>> GetAll()
        {
            return await _context.Practice.Where(x => true).ToListAsync();
        }

        public Task<PracticeEntity> GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(PracticeEntity model)
        {
            throw new NotImplementedException();
        }
    }
}