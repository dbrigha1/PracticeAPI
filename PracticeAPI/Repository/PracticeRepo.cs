using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using PracticeAPI.Models;
using PracticeAPI.Models.Entity;

namespace PracticeAPI.Repository
{
    public class PracticeRepo : IPracticeRepo
    {
        private readonly PracticeContext _context;
        private readonly HttpContextBase _httpContext;
        public PracticeRepo(PracticeContext context, HttpContextBase httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }
        public async Task Create(PracticeEntity model)
        {
            var userId = _httpContext.User.Identity.GetUserId();
            _context.Practice.Add(model);
            await _context.SaveChangesAsync(userId);
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