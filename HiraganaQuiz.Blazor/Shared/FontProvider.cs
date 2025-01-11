namespace HiraganaQuiz.Blazor.Shared;

public static class FontProvider
{
    private static readonly string[] Fonts = ["Noto Sans JP", "Kosugi Maru", "Sawarabi Mincho", "Yusei Magic", "Kaisei Decol", "M PLUS Rounded 1c", "Kosugi", "Kiwi Maru", "Noto Serif JP", "Zen Kurenaido"];

    public static string GetRandomFont() => Fonts[new Random().Next(Fonts.Length)];
}