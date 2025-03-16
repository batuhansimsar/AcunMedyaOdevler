using ProgrammingLanguagesManagement.Core;

namespace ProgrammingLanguagesManagement.Entities
{
    // Teknoloji entity'si
    public class Technology : IEntity
    {
        // Teknolojinin benzersiz kimliği
        public int Id { get; set; }

        // Teknolojinin adı
        public string Name { get; set; }

        // Teknolojinin ait olduğu programlama dili
        public int ProgrammingLanguageId { get; set; }

        // Navigation property
        public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
} 