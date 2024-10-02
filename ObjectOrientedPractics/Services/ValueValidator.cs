/// <summary>
/// Проверяет валидацию строк
/// </summary>
class ValueValidator
{
    /// <summary>
    /// Проверяет, что строка не превышает максимальное количество символов.
    /// </summary>
    /// <param name="value">Проверямая строка.</param>
    /// <param name="maxLength">Максимальное количество символов для свойства или объекта</param>
    /// <param name="propertyName">Имя свойства или объекта, которое
    ///подлежит проверке.</param>
    public void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength) {
            throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
        }
    }

    /// <summary>
    /// Проверяет находится ли значение в заданном диапазоне
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="lessValue">Минимальное значение.</param>
    /// <param name="moreValue">Максимальное значение.</param>
    /// <exception cref="ArgumentException"></exception>
    public void AssertNumberOnValue(double value, double lessValue, double moreValue)
    {
        if (value < lessValue || value > moreValue)
        {
            throw new ArgumentException($"{nameof(value)} должен быть больше {lessValue} и меньше {moreValue}.");
        }
    }

    /// <summary>
    /// Проверяет находится ли значение в заданном диапазоне
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="lessValue">Минимальное значение.</param>
    /// <param name="moreValue">Максимальное значение.</param>
    /// <exception cref="ArgumentException"></exception>
    public void AssertNumberOnIntValue(int value, int lessValue, int moreValue)
    {
        if (value < lessValue || value > moreValue)
        {
            throw new ArgumentException($"{value} должен быть больше {lessValue} и меньше {moreValue}.");
        }
    }


}
