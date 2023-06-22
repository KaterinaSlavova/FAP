using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство с имена наречено Data.Model.
/// </summary>
namespace Data.Model
{
    /// <summary>
    /// Клас Person, с атрибути Id, Name, Age, Height, Weight, BirthDate.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Задване на номер на потребителя.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Задаване на име на потребителя.
        /// </summary>
        [DisplayName("Име:")]
        public string Name { get; set; }

        /// <summary>
        /// Задаване на години на потребителя.
        /// </summary>
        [DisplayName("Години:")]
        public int Age { get; set; }

        /// <summary>
        /// Задаване на височина на потребителя.
        /// </summary>
        [DisplayName("Височина:")]
        public int Height { get; set; }

        /// <summary>
        /// Задаване на килограми на потребителя.
        /// </summary>
        [DisplayName("Килограми:")]
        public int Weight { get; set; }

        /// <summary>
        /// Задаване на пол на потребителя.
        /// </summary>
        [DisplayName("Пол:")]
        public string Gender { get; set; }

        /// <summary>
        /// Задаване на рожден ден на потребителя.
        /// </summary>
        [DisplayName("Дата на раждане:")]
        public DateTime BirthDate { get; set; }
    }
}
