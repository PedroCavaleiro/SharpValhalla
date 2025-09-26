namespace SharpValhalla.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// Returns a list of all cases of the specified enum type.
    /// </summary>
    /// <typeparam name="TEnum">The enum type.</typeparam>
    /// <returns>List of all enum cases.</returns>
    public static List<TEnum> AllCases<TEnum>() where TEnum : Enum =>
        Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();
}
