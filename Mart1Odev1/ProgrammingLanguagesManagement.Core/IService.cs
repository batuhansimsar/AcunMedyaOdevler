using System.Collections.Generic;

namespace ProgrammingLanguagesManagement.Core
{
    // Generic service interface'i
    public interface IService<T> where T : class, IEntity
    {
        // Tüm entity'ler için ortak servis operasyonları
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
} 