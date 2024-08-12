using Api_Metrics_With_Prometheus.Dominio;
using Api_Metrics_With_Prometheus.Dominio.Register;
using Api_Metrics_With_Prometheus.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Api_Metrics_With_Prometheus.Repository
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RegisterRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(RegisterModel model)
        {
            await _dbContext.Register.AddAsync(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            RegisterModel register = await _dbContext.Register.FindAsync(id);
            if (register != null)
            {
                _dbContext.Register.Remove(register);
                await _dbContext.SaveChangesAsync();
            }
            throw new Exception("Register not found");
        }

        public async Task<IEnumerable<RegisterModel>> GetAllAsync()
        {
            IEnumerable<RegisterModel> registers = await _dbContext.Register.ToListAsync();
            return registers;
        }

        public async Task<RegisterModel> GetByIdAsync(long id)
        {
            RegisterModel register = await _dbContext.Register.FirstOrDefaultAsync(r=>r.id==id);
            if (register != null)
                return register;
            throw new Exception("Register not found");
        }

        

        public async Task UpdateAsync(RegisterModel model)
        {
            RegisterModel register = await _dbContext.Register.FirstOrDefaultAsync(r => r.id == model.id);
            if (register != null)
            {
                _dbContext.Register.Update(register);
                await _dbContext.SaveChangesAsync();
            }
            throw new Exception("Register not found");
        }
    }
}
