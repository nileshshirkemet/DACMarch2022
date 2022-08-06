static class Printable
{
    //A fluent function is a method which returns a type to which other 
    //such function can be applied again
    public static IEnumerable<string> Capitalize<T>(this IEnumerable<T> source)
    {
        foreach(T entry in source)
            yield return entry.ToString().ToUpper();
    }

    public static IEnumerable<T> PrintEachWith<T>(this IEnumerable<T> source, Action<T> write)
    {
        foreach(T entry in source)
            write(entry);
        return source;
    }
}
