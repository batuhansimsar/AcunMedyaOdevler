using System.Collections.Generic;
using ProgrammingLanguagesManagement.Core;
using ProgrammingLanguagesManagement.DataAccess;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Business
{
    // Teknoloji servis sınıfı
    public class TechnologyService : IService<Technology>
    {
        private readonly TechnologyRepository _repository;
        private readonly ProgrammingLanguageService _programmingLanguageService;

        public TechnologyService()
        {
            _repository = new TechnologyRepository();
            _programmingLanguageService = new ProgrammingLanguageService();
        }

        // Yeni teknoloji ekleme
        public void Add(Technology entity)
        {
            // İş mantığı kontrolleri
            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new System.ArgumentException("Teknoloji adı boş olamaz.");
            }

            // Programlama dili kontrolü
            var programmingLanguage = _programmingLanguageService.GetById(entity.ProgrammingLanguageId);
            if (programmingLanguage == null)
            {
                throw new System.ArgumentException("Geçersiz programlama dili ID'si.");
            }

            _repository.Add(entity);
        }

        // Teknoloji güncelleme
        public void Update(Technology entity)
        {
            // İş mantığı kontrolleri
            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new System.ArgumentException("Teknoloji adı boş olamaz.");
            }

            // Programlama dili kontrolü
            var programmingLanguage = _programmingLanguageService.GetById(entity.ProgrammingLanguageId);
            if (programmingLanguage == null)
            {
                throw new System.ArgumentException("Geçersiz programlama dili ID'si.");
            }

            _repository.Update(entity);
        }

        // Teknoloji silme
        public void Delete(Technology entity)
        {
            _repository.Delete(entity);
        }

        // ID'ye göre teknoloji getirme
        public Technology GetById(int id)
        {
            return _repository.GetById(id);
        }

        // Tüm teknolojileri getirme
        public List<Technology> GetAll()
        {
            return _repository.GetAll();
        }
    }
} 