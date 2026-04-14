using Xunit;

using System;

namespace ClinicCore.Tests

{

    public class PatientTests

    {

        [Fact] // Атрибут говорит системе, что это тест

        public void CalculateAge_ShouldReturnCorrectAge_WhenBirthdayPassed()

        {

            // 1. Arrange (Подготовка данных)

            // Создаем пациента, который родился ровно 20 лет назад

            var patient = new Patient

            {

                BirthDate = DateTime.Today.AddYears(-20)

            };

            // 2. Act (Выполнение действия)

            int age = patient.CalculateAge();

            // 3. Assert (Проверка)

            Assert.Equal(20, age); // Ожидаем 20

        }

        [Fact]

        public void CalculateAge_ShouldReturnOneYearLess_WhenBirthdayIsTomorrow()

        {

            // 1. Arrange

            // Человек родился 20 лет назад, но ДР только завтра. Ему должно быть 19.

            var patient = new Patient

            {

                BirthDate = DateTime.Today.AddYears(-20).AddDays(1)

            };

            // 2. Act

            int result = patient.CalculateAge();

            // 3. Assert

            Assert.Equal(19, result);

        }


    }

}
