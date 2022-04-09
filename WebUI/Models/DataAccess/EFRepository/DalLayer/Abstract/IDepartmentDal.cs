using WebUI.Models.DataAccess.EFRepository.Services;
using WebUI.Models.Entities;

namespace WebUI.Models.DataAccess.EFRepository.DalLayer.Abstract
{
    public interface IDepartmentDal:IDbService<Department>
    {
            T Get(int id);
            T Add(T entity);
            void Update(T entity);
            void Delete(int id);
            List<T> GetList();
    }
}
