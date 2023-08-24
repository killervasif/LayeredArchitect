using DataAccessLayer.Entities;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories.Interfaces;

namespace DataAccessLayer.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _dbContext;

        public MemberRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Member item)
        {
            _dbContext.Members.Add(item);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _dbContext.Members.FirstOrDefault(e => e.Id == id);
            if (item != null)
            {
                _dbContext.Members.Remove(item);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Member> Find(Func<Member, bool> predicate)
        {
            return _dbContext.Members.Where(predicate).ToList();
        }

        public Member? Get(int id)
        {
            return _dbContext.Members.Find(id);
        }

        public IEnumerable<Member> GetAll()
        {
            return _dbContext.Members;
        }

        public void Update(Member item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
