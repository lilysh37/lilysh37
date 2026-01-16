using System;

namespace ClinicCore

{

    public class Patient

    {

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        /// <summary>

        /// Метод вычисляет возраст пациента.

        /// Если день рождения еще не наступил в этом году - возраст уменьшается на 1.

        /// </summary>

        public int CalculateAge()

        {

            var today = DateTime.Today;

            var age = today.Year - BirthDate.Year;

            // Если текущая дата меньше дня рождения в текущем году, вычитаем год

            if (BirthDate.Date > today.AddYears(-age))

            {

                age--;

            }

            return age;

        }

    }

}
