using System.Collections.Generic;
using ProgrammingLanguagesManagement.Core;
using ProgrammingLanguagesManagement.DataAccess;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Business
{
    // Programlama dili servis sınıfı
    public class ProgrammingLanguageService : IService<ProgrammingLanguage>
    {
        private readonly ProgrammingLanguageRepository _repository;

        public ProgrammingLanguageService()
        {
            _repository = new ProgrammingLanguageRepository();
        }

        // Yeni programlama dili ekleme
        public void Add(ProgrammingLanguage entity)
        {
            // İş mantığı kontrolleri
            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new System.ArgumentException("Programlama dili adı boş olamaz.");
            }

            _repository.Add(entity);
        }

        // Programlama dili güncelleme
        public void Update(ProgrammingLanguage entity)
        {
            // İş mantığı kontrolleri
            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new System.ArgumentException("Programlama dili adı boş olamaz.");
            }

            _repository.Update(entity);
        }

        // Programlama dili silme
        public void Delete(ProgrammingLanguage entity)
        {
            _repository.Delete(entity);
        }

        // ID'ye göre programlama dili getirme
        public ProgrammingLanguage GetById(int id)
        {
            return _repository.GetById(id);
        }

        // Tüm programlama dillerini getirme
        public List<ProgrammingLanguage> GetAll()
        {
            return _repository.GetAll();
        }
    }
} 