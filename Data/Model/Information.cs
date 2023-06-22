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
    /// Клас Information, с атрибути Id, Workout, Calories, Protein, Fat, Carbs.
    /// </summary>
    public class Information
    {
        /// <summary>
        /// Задване на номер на информацията.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Задаване на вид тренировка.
        /// </summary>
        [DisplayName("Вид тренировка:")]
        public string Workout { get; set; }

        /// <summary>
        /// Задаване на калории.
        /// </summary>
        [DisplayName("Калории:")]
        public int Calories { get; set; }

        /// <summary>
        ///  Задаване на протеин.
        /// </summary>
        [DisplayName("Протеини:")]
        public int Protein { get; set; }

        /// <summary>
        /// Задаване на мазнини.
        /// </summary>
        [DisplayName("Мазнини:")]
        public int Fat { get; set; }

        /// <summary>
        /// Задаване на въглехидрати.
        /// </summary>
        [DisplayName("Въглехидрати:")]
        public int Carbs { get; set; }

    }
}
