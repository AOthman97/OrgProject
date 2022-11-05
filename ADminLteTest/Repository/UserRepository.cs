using ADminLteTest.Entites;
using ADminLteTest.Infra;
using ADminLteTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ADminLteTest.Repository
{
    public class UserRepository : IGenericRepositroy<User>
    {
        private readonly OrgDbContext _dbContext;
        public UserRepository(OrgDbContext dbDataContext)
        {
            _dbContext = dbDataContext;
        }
        public async Task<bool> Delete(object Id)
        {
            try
            {
                User user = await _dbContext.Users.FindAsync(Id);
                if (user == null)
                    return false;
                _dbContext.Users.Remove(user);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetTById(object Id)
        {
            User? user = await _dbContext.Users.FindAsync(Id);
            return user;
        }

        public async Task<bool> Insert(User entity)
        {
            try
            {
                await _dbContext.Users.AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }  
        }

        public async Task<bool> Update(User entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.Update(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
