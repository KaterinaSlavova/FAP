using Data;
using Data.Model;

/// <summary>
/// Пространство с имена наречено Business.
/// </summary>
namespace Business
{
    /// <summary>
    /// Клас MarksBusiness.
    /// </summary>
    public class InformationsBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Взима всички оценки от базата данни.
        /// </summary>
        public List<Information> GetAllInformations()
        {
            using (context = new Context())
            {
                return context.Informations.ToList();
            }
        }

        /// <summary>
        /// Взема оценка от базата данни по номер на ученика.
        /// </summary>
        public Information GetInformaton(int id)
        {
            using (context = new Context())
            {
                return context.Informations.Find(id);
            }
        }

        /// <summary>
        /// Вкарва оценка в базата данни.
        /// </summary>
        public void AddInformation(Information inf)
        {
            using (context = new Context())
            {
                context.Informations.Add(inf);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Променя оценка от базата данни по номер на ученика.
        /// </summary>
        public void UpdateInformation(Information inf)
        {
            using (context = new Context())
            {
                var item = context.Informations.Find(inf.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(inf);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Изтрива оценка от базата данни по номер на ученика.
        /// </summary>
        public void DeleteInformation(int id)
        {
            using (context = new Context())
            {
                var inf = context.Informations.Find(id);
                if (inf != null)
                {
                    context.Informations.Remove(inf);
                    context.SaveChanges();
                }
            }
        }
    }


}