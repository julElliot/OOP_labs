using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    [Serializable]
    public class Brochure: Book
    {
        public bool IsCatalog
        {
            get; set;
        }

        public Brochure() {}

        public Brochure(Category category, string name, int edition, bool periodicity, string author, string binding, bool illustratedBookend, bool isCatalog)
            : base(category, name, edition, periodicity, author, binding, illustratedBookend)
        {
            IsCatalog = isCatalog;
        }

        public void OutPutInfo(Brochure brochure)
        {
            Console.WriteLine("Целевая аудитория: {0}; название: {1}; тираж: {2};" +
                " периодическое: {3}; каталог: {4}", brochure.Category.TargetAudience,
                brochure.Name, brochure.Edition, brochure.Periodicity, brochure.IsCatalog);
       
        }
    }
}
