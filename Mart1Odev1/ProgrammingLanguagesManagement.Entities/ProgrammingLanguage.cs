using ProgrammingLanguagesManagement.Core;

namespace ProgrammingLanguagesManagement.Entities
{
    // Programlama dili entity'si
    public class ProgrammingLanguage : IEntity
    {
        // Programlama dilinin benzersiz kimliği
        public int Id { get; set; }

        // Programlama dilinin adı
        public string Name { get; set; }

        // Programlama diline ait teknolojiler
        public virtual ICollection<Technology> Technologies { get; set; }
    }
} 