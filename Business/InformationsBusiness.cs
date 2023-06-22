using Data;
using Data.Model;

/// <summary>
/// Пространство с имена наречено Business.
/// </summary>
namespace Business
{
    /// <summary>
    /// Клас InformationsBusiness.
    /// </summary>
    public class InformationsBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Взима всички цялата информация от базата данни.
        /// </summary>
        public List<Information> GetAllInformations()
        {
            using (context = new Context())
            {
                return context.Infs.ToList();
            }
        }

        /// <summary>
        /// Взема информация от базата данни по номер на информацията.
        /// </summary>
        public Information GetInformaton(int id)
        {
            using (context = new Context())
            {
                return context.Infs.Find(id);
            }
        }

        /// <summary>
        /// Вкарва информация в базата данни.
        /// </summary>
        public void AddInformation(Information inf)
        {
            using (context = new Context())
            {
                context.Infs.Add(inf);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Променя информация от базата данни по номер на информацията.
        /// </summary>
        public void UpdateInformation(Information inf)
        {
            using (context = new Context())
            {
                var item = context.Infs.Find(inf.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(inf);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Изтрива информация от базата данни по номер на информацията.
        /// </summary>
        public void DeleteInformation(int id)
        {
            using (context = new Context())
            {
                var inf = context.Infs.Find(id);
                if (inf != null)
                {
                    context.Infs.Remove(inf);
                    context.SaveChanges();
                }
            }
        }
    }


}