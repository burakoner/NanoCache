namespace NanoCache.ServerExample.Extensions;

public static partial class ExtensionMethods
{
    /// <summary>
    ///     An object extension method that converts the @this to string or return an empty string if the value is null.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a string or empty if the value is null.</returns>
    public static string ToStringSafe(this object @this)
    {
        return @this == null || @this.GetType() == typeof(DBNull) ? "" : @this.ToString();
    }
}