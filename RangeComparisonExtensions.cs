namespace RangeComparison;

public static class RangeComparisonExtensions
{
    // In Range Inclusive
    public static bool InRangeI<T>(this T value, T min, T max) where T : IComparable<T>
    {
        return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
    }

    // In Range Left (Minimum) Inclusive
    public static bool InRangeLI<T>(this T value, T min, T max) where T : IComparable<T>
    {
        return value.CompareTo(min) >= 0 && value.CompareTo(max) < 0;
    }

    // In Range Right (Maximum) Inclusive
    public static bool InRangeRI<T>(this T value, T min, T max) where T : IComparable<T>
    {
        return value.CompareTo(min) > 0 && value.CompareTo(max) <= 0;
    }

    // In Range Exclusive
    public static bool InRangeE<T>(this T value, T min, T max) where T : IComparable<T>
    {
        return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
    }
}
