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
    /// Клас Student, с атрибути Id, Name, Email, Grade, BirthDate
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Задване на номер на ученика.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Задаване на име на ученика.
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// Задаване на имейл на ученика.
        /// </summary>

        public int Age { get; set; }

        /// <summary>
        /// Задаване на оценки на ученика.
        /// </summary>

        public int Heigtht { get; set; }

        /// <summary>
        /// Задаване на оценки на ученика.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Задаване на оценки на ученика.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Задаване на рожден ден на ученика.
        /// </summary>

        public DateTime BirthDate { get; set; }
    }
}
