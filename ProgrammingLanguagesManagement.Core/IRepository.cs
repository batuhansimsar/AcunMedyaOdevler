using System.Collections.Generic;

namespace ProgrammingLanguagesManagement.Core
{
    // Generic repository interface'i
    public interface IRepository<T> where T : class, IEntity
    {
        // Tüm entity'ler için ortak CRUD operasyonları
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
} 