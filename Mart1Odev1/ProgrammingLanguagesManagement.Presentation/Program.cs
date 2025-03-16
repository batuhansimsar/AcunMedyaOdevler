using System;
using System.Collections.Generic;
using ProgrammingLanguagesManagement.Business;
using ProgrammingLanguagesManagement.Entities;

namespace ProgrammingLanguagesManagement.Presentation
{
    class Program
    {
        private static readonly ProgrammingLanguageService _programmingLanguageService = new ProgrammingLanguageService();
        private static readonly TechnologyService _technologyService = new TechnologyService();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nProgramlama Dilleri ve Teknolojileri Yönetim Sistemi");
                Console.WriteLine("1. Programlama Dili Ekle");
                Console.WriteLine("2. Teknoloji Ekle");
                Console.WriteLine("3. Programlama Dillerini Listele");
                Console.WriteLine("4. Teknolojileri Listele");
                Console.WriteLine("5. Programlama Dili Güncelle");
                Console.WriteLine("6. Teknoloji Güncelle");
                Console.WriteLine("7. Programlama Dili Sil");
                Console.WriteLine("8. Teknoloji Sil");
                Console.WriteLine("9. Çıkış");
                Console.Write("\nSeçiminiz: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProgrammingLanguage();
                        break;
                    case "2":
                        AddTechnology();
                        break;
                    case "3":
                        ListProgrammingLanguages();
                        break;
                    case "4":
                        ListTechnologies();
                        break;
                    case "5":
                        UpdateProgrammingLanguage();
                        break;
                    case "6":
                        UpdateTechnology();
                        break;
                    case "7":
                        DeleteProgrammingLanguage();
                        break;
                    case "8":
                        DeleteTechnology();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }
        }

        private static void AddProgrammingLanguage()
        {
            Console.Write("Programlama Dili Adı: ");
            string name = Console.ReadLine();

            var language = new ProgrammingLanguage { Name = name };
            try
            {
                _programmingLanguageService.Add(language);
                Console.WriteLine("Programlama dili başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        private static void AddTechnology()
        {
            Console.Write("Teknoloji Adı: ");
            string name = Console.ReadLine();

            Console.Write("Programlama Dili ID: ");
            if (int.TryParse(Console.ReadLine(), out int languageId))
            {
                var technology = new Technology { Name = name, ProgrammingLanguageId = languageId };
                try
                {
                    _technologyService.Add(technology);
                    Console.WriteLine("Teknoloji başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz ID!");
            }
        }

        private static void ListProgrammingLanguages()
        {
            var languages = _programmingLanguageService.GetAll();
            Console.WriteLine("\nProgramlama Dilleri:");
            foreach (var language in languages)
            {
                Console.WriteLine($"ID: {language.Id}, Ad: {language.Name}");
            }
        }

        private static void ListTechnologies()
        {
            var technologies = _technologyService.GetAll();
            Console.WriteLine("\nTeknolojiler:");
            foreach (var technology in technologies)
            {
                var language = _programmingLanguageService.GetById(technology.ProgrammingLanguageId);
                Console.WriteLine($"ID: {technology.Id}, Ad: {technology.Name}, Programlama Dili: {language?.Name ?? "Bilinmiyor"}");
            }
        }

        private static void UpdateProgrammingLanguage()
        {
            Console.Write("Güncellenecek Programlama Dili ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var language = _programmingLanguageService.GetById(id);
                if (language != null)
                {
                    Console.Write("Yeni Ad: ");
                    language.Name = Console.ReadLine();

                    try
                    {
                        _programmingLanguageService.Update(language);
                        Console.WriteLine("Programlama dili başarıyla güncellendi!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Hata: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Programlama dili bulunamadı!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz ID!");
            }
        }

        private static void UpdateTechnology()
        {
            Console.Write("Güncellenecek Teknoloji ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var technology = _technologyService.GetById(id);
                if (technology != null)
                {
                    Console.Write("Yeni Ad: ");
                    technology.Name = Console.ReadLine();

                    Console.Write("Yeni Programlama Dili ID: ");
                    if (int.TryParse(Console.ReadLine(), out int languageId))
                    {
                        technology.ProgrammingLanguageId = languageId;

                        try
                        {
                            _technologyService.Update(technology);
                            Console.WriteLine("Teknoloji başarıyla güncellendi!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Hata: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz Programlama Dili ID!");
                    }
                }
                else
                {
                    Console.WriteLine("Teknoloji bulunamadı!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz ID!");
            }
        }

        private static void DeleteProgrammingLanguage()
        {
            Console.Write("Silinecek Programlama Dili ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var language = _programmingLanguageService.GetById(id);
                if (language != null)
                {
                    _programmingLanguageService.Delete(language);
                    Console.WriteLine("Programlama dili başarıyla silindi!");
                }
                else
                {
                    Console.WriteLine("Programlama dili bulunamadı!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz ID!");
            }
        }

        private static void DeleteTechnology()
        {
            Console.Write("Silinecek Teknoloji ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var technology = _technologyService.GetById(id);
                if (technology != null)
                {
                    _technologyService.Delete(technology);
                    Console.WriteLine("Teknoloji başarıyla silindi!");
                }
                else
                {
                    Console.WriteLine("Teknoloji bulunamadı!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz ID!");
            }
        }
    }
}
