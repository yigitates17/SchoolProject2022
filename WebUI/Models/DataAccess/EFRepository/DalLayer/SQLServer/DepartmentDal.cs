using WebUI.Models.DataAccess.EFRepository.Services;
using WebUI.Models.Entities;

namespace WebUI.Models.DataAccess.EFRepository.DalLayer.Concrete
{
    public class DepartmentOracleDal : IDepartmentOracleDal
    {
        public Department Add(Department entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = dbContext.Departments.Add(entity);

                dbContext.SaveChanges();

                return entity;
            }

        }

        public void Delete(Department entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = dbContext.Departments.Remove(entity);

                dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                return dbContext.Departments.Find(id);
            }
        }

        public List<Department> GetList()
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = dbContext.Departments.ToList();

                return result;

            }
        }

        public void Update(Department entity)
        {
            using (var dbContext = new SchoolProjectDbContext())
            {
                var result = dbContext.Departments.Update(entity);

                dbContext.SaveChanges();

            }
        }
    }

}
