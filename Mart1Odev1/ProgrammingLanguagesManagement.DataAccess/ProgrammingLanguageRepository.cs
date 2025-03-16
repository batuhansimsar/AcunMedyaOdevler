using System.Collections.Generic;
using ProgrammingLanguagesManagement.Core;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.DataAccess
{
    // Programlama dili repository sınıfı
    public class ProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {
        // In-memory veri depolama
        private static List<ProgrammingLanguage> _programmingLanguages = new List<ProgrammingLanguage>();
        private static int _nextId = 1;

        // Yeni programlama dili ekleme
        public void Add(ProgrammingLanguage entity)
        {
            entity.Id = _nextId++;
            _programmingLanguages.Add(entity);
        }

        // Programlama dili güncelleme
        public void Update(ProgrammingLanguage entity)
        {
            var existingLanguage = _programmingLanguages.Find(x => x.Id == entity.Id);
            if (existingLanguage != null)
            {
                existingLanguage.Name = entity.Name;
            }
        }

        // Programlama dili silme
        public void Delete(ProgrammingLanguage entity)
        {
            _programmingLanguages.RemoveAll(x => x.Id == entity.Id);
        }

        // ID'ye göre programlama dili getirme
        public ProgrammingLanguage GetById(int id)
        {
            return _programmingLanguages.Find(x => x.Id == id);
        }

        // Tüm programlama dillerini getirme
        public List<ProgrammingLanguage> GetAll()
        {
            return _programmingLanguages;
        }
    }
} 