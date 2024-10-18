/// <summary>
/// Проверяет валидацию строк
/// </summary>
static class ValueValidator
{
    /// <summary>
    /// Проверяет, что строка не превышает максимальное количество символов.
    /// </summary>
    /// <param name="value">Проверямая строка.</param>
    /// <param name="maxLength">Максимальное количество символов для свойства или объекта</param>
    /// <param name="propertyName">Имя свойства или объекта, которое
    ///подлежит проверке.</param>
    public static void AssertStringOnLength(string value, int maxLength, string propertyName)
    {
        if (value.Length > maxLength) 
        {
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
    public static void AssertNumberOnValue(double value, int lessValue, int moreValue, string propertyName)
    {
        if (value < lessValue || value > moreValue)
        {
            throw new ArgumentException($"{propertyName} должен быть больше {lessValue} и меньше {moreValue}.");
        }
    }


    /// <summary>
    /// Определяет, содержит ли заданная строка хотя бы одну цифру.
    /// </summary>
    /// <param name="input">Строка, которую необходимо проверить.</param>
    /// <returns>
    /// Возвращает <c>true</c>, если строка содержит хотя бы одну цифру; 
    /// в противном случае возвращает <c>false</c>.
    /// </returns>
    public static bool IsNumeric(string inputString)
    {
        foreach (char c in inputString)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}
