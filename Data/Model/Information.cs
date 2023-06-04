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
    /// Клас Mark, с атрибути Id, Stud, Grade, Subject, Teacher, Date.
    /// </summary>
    public class Information
    {
        /// <summary>
        /// Задване на номер на ученика.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Задаване на име на ученика.
        /// </summary>

        public string Workout { get; set; }

        /// <summary>
        /// Задаване на оценки на ученика.
        /// </summary>

        public int Calories { get; set; }

        /// <summary>
        ///  Задаване на учебен предмет.
        /// </summary>

        public int Protein { get; set; }

        /// <summary>
        /// Задаване на име на учител.
        /// </summary>

        public int Fat { get; set; }

        /// <summary>
        /// Задаване на дата на въвеждане на информацията.
        /// </summary>

        public int Carbs { get; set; }

    }
}
