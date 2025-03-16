using System.Collections.Generic;
using ProgrammingLanguagesManagement.Core;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.DataAccess
{
    // Teknoloji repository sınıfı
    public class TechnologyRepository : IRepository<Technology>
    {
        // In-memory veri depolama
        private static List<Technology> _technologies = new List<Technology>();
        private static int _nextId = 1;

        // Yeni teknoloji ekleme
        public void Add(Technology entity)
        {
            entity.Id = _nextId++;
            _technologies.Add(entity);
        }

        // Teknoloji güncelleme
        public void Update(Technology entity)
        {
            var existingTechnology = _technologies.Find(x => x.Id == entity.Id);
            if (existingTechnology != null)
            {
                existingTechnology.Name = entity.Name;
                existingTechnology.ProgrammingLanguageId = entity.ProgrammingLanguageId;
            }
        }

        // Teknoloji silme
        public void Delete(Technology entity)
        {
            _technologies.RemoveAll(x => x.Id == entity.Id);
        }

        // ID'ye göre teknoloji getirme
        public Technology GetById(int id)
        {
            return _technologies.Find(x => x.Id == id);
        }

        // Tüm teknolojileri getirme
        public List<Technology> GetAll()
        {
            return _technologies;
        }
    }
} 