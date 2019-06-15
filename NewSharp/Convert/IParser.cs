namespace NewSharp.Convert
{
    public interface IParser<T>
    {
        Option<T> TryParse(string input);
        Result<T, TError> Parse<TError>(string input);
    }
}
