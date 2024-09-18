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
}
