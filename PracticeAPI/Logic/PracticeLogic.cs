using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using PracticeAPI.Models.Entity;
using PracticeAPI.Models.ViewEntity;
using PracticeAPI.Repository;

namespace PracticeAPI.Logic
{
    public class PracticeLogic : IPracticeLogic
    {
        private readonly IPracticeRepo _repo;
        private readonly IMapper _mapper;
        public PracticeLogic(IPracticeRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task Create(PracticeViewEntity viewEntity)
        {
            var entity = _mapper.Map<PracticeViewEntity, PracticeEntity>(viewEntity);
            await _repo.Create(entity);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PracticeEntity>> GetAll()
        {
            return await _repo.GetAll();
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