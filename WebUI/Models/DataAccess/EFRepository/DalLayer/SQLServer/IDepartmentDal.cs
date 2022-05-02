using WebUI.Models.DataAccess.EFRepository.Services;
using WebUI.Models.Entities;

namespace WebUI.Models.DataAccess.EFRepository.DalLayer
{
    public interface IDepartmentOracleDal : IDbService<Department>
    {
        public Department Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Department entity)
        {
            throw new NotImplementedException();
        }

        void Delete(Department department);
    }
}
