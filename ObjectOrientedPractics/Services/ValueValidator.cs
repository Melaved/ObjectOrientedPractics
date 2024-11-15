using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует валидацию статистических данных.
    /// </summary>
    class ValueValidator
    {
        /// <summary>
        /// Проверяет, что строка не превышает заданную длину.
        /// </summary>
        /// <param name="value">Строка, которую мы проверяем.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="propertyName">Имя проверяемого объекта.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} ожидается меньше {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое число.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Имя проверяемого объекта.</param>
        public static void AssertStringOnLength(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentOutOfRangeException($"{propertyName} ожидается больше {minLength} и меньше {maxLength}");
            }
        }
    }
}
