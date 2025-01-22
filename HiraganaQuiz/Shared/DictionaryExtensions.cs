namespace HiraganaQuiz.Shared;

public static class DictionaryExtensions
{
    public static Dictionary<string, string>
        ToCustomDictionary(this IEnumerable<Dictionary<string, string>> enumerable) =>
        enumerable
            .SelectMany(dict => dict)
            .GroupBy(kvp => kvp.Key)
            .ToDictionary(g => g.Key, g => string.Join(",", g.Select(kvp => kvp.Value)));
    
    public static string GetDisplayName(this Dictionary<string, string> dictionary) => string.Join("", dictionary.Select(kvp => $"{kvp.Key}"));

}