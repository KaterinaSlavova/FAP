using Data;
using Data.Model;

/// <summary>
/// Пространство с имена наречено Business.
/// </summary>
namespace Business
{
    /// <summary>
    /// Клас PersonsBusiness.
    /// </summary>
    public class PersonsBusiness
    {
        private Context context { get; set; }

        /// <summary>
        /// Взема всички потребители от базата данни.
        /// </summary>
        public List<Person> GetAllPeople()
        {
            using (context = new Context())
            {
                return context.People.ToList();
            }
        }

        /// <summary>
        /// Намира потребител по номер.
        /// </summary>
        public Person GetInfPerson(int id)
        {
            using (context = new Context())
            {
                return context.People.Find(id);
            }
        }

        /// <summary>
        ///  Добавя потребител в базата данни.
        /// </summary>
        public void AddPerson(Person person)
        {
            using (context = new Context())
            {
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Променя информацията за потребител в базата данни по номер.
        /// </summary>
        public void UpdateInformation(Person person)
        {
            using (context = new Context())
            {
                var item = context.People.Find(person.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(person);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Изтрива потребител от базата данни по номер.
        /// </summary>
        public void DeletePerson(int id)
        {
            using (context = new Context())
            {
                var person = context.People.Find(id);
                if (person != null)
                {
                    context.People.Remove(person);
                    context.SaveChanges();
                }
            }
        }

    }

}