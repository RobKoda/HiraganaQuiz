namespace HiraganaQuiz.Models;

// ReSharper disable MemberCanBePrivate.Global - Accessed by code
public static class HiraganaToRomajis
{
    public static readonly Dictionary<string, string> HiraganaVowels = new()
        { { "あ", "a" }, { "い", "i" }, { "う", "u" }, { "え", "e" }, { "お", "o" } };
    public static readonly Dictionary<string, string> HiraganaK = new()
        { {"か", "ka"}, {"き", "ki"}, {"く", "ku"}, {"け", "ke"}, {"こ", "ko"} };
    public static readonly Dictionary<string, string> HiraganaG = new()
        { {"が", "ga"}, {"ぎ", "gi"}, {"ぐ", "gu"}, {"げ", "ge"}, {"ご", "go"} };
    public static readonly Dictionary<string, string> HiraganaS = new()
        { {"さ", "sa"}, {"し", "shi"}, {"す", "su"}, {"せ", "se"}, {"そ", "so"} };
    public static readonly Dictionary<string, string> HiraganaZ = new()
        { {"ざ", "za"}, {"じ", "ji"}, {"ず", "zu"}, {"ぜ", "ze"}, {"ぞ", "zo"} };
    public static readonly Dictionary<string, string> HiraganaT = new()
        { {"た", "ta"}, {"ち", "chi"}, {"つ", "tsu"}, {"て", "te"}, {"と", "to"} };
    public static readonly Dictionary<string, string> HiraganaD = new()
        { {"だ", "da"}, {"ぢ", "ji"}, {"づ", "zu"}, {"で", "de"}, {"ど", "do"} };
    public static readonly Dictionary<string, string> HiraganaN = new()
        { {"な", "na"}, {"に", "ni"}, {"ぬ", "nu"}, {"ね", "ne"}, {"の", "no"} };
    public static readonly Dictionary<string, string> HiraganaH = new()
        { {"は", "ha"}, {"ひ", "hi"}, {"ふ", "fu"}, {"へ", "he"}, {"ほ", "ho"} };
    public static readonly Dictionary<string, string> HiraganaB = new()
        { {"ば", "ba"}, {"び", "bi"}, {"ぶ", "bu"}, {"べ", "be"}, {"ぼ", "bo"} };
    public static readonly Dictionary<string, string> HiraganaP = new()
        { {"ぱ", "pa"}, {"ぴ", "pi"}, {"ぷ", "pu"}, {"ぺ", "pe"}, {"ぽ", "po"} };
    public static readonly Dictionary<string, string> HiraganaM = new()
        { {"ま", "ma"}, {"み", "mi"}, {"む", "mu"}, {"め", "me"}, {"も", "mo"} };
    public static readonly Dictionary<string, string> HiraganaY = new()
        { {"や", "ya"}, {"ゆ", "yu"}, {"よ", "yo"} };
    public static readonly Dictionary<string, string> HiraganaR = new()
        { {"ら", "ra"}, {"り", "ri"}, {"る", "ru"}, {"れ", "re"}, {"ろ", "ro"} };
    public static readonly Dictionary<string, string> HiraganaW = new()
        { {"わ", "wa"}, {"を", "wo"}, {"ん", "n"} };
    
    public static readonly Dictionary<string, string> HiraganaKi = new()
        { {"きゃ", "kya"}, {"きゅ", "kyu"}, {"きょ", "kyo"} };
    public static readonly Dictionary<string, string> HiraganaGi = new()
        { {"ぎゃ", "gya"}, {"ぎゅ", "gyu"}, {"ぎょ", "gyo"} };
    public static readonly Dictionary<string, string> HiraganaShi = new()
        { {"しゃ", "sha"}, {"しゅ", "shu"}, {"しょ", "sho"} };
    public static readonly Dictionary<string, string> HiraganaJi = new()
        { {"じゃ", "ja"}, {"じゅ", "ju"}, {"じょ", "jo"} };
    public static readonly Dictionary<string, string> HiraganaChi = new()
        { {"ちゃ", "cha"}, {"ちゅ", "chu"}, {"ちょ", "cho"} };
    public static readonly Dictionary<string, string> HiraganaNi = new()
        { {"にゃ", "nya"}, {"にゅ", "nyu"}, {"にょ", "nyo"} };
    public static readonly Dictionary<string, string> HiraganaHi = new()
        { {"ひゃ", "hya"}, {"ひゅ", "hyu"}, {"ひょ", "hyo"} };
    public static readonly Dictionary<string, string> HiraganaBi = new()
        { {"びゃ", "bya"}, {"びゅ", "byu"}, {"びょ", "byo"} };
    public static readonly Dictionary<string, string> HiraganaPi = new()
        { {"ぴゃ", "pya"}, {"ぴゅ", "pyu"}, {"ぴょ", "pyo"} };
    public static readonly Dictionary<string, string> HiraganaMi = new()
        { {"みゃ", "mya"}, {"みゅ", "myu"}, {"みょ", "myo"} };
    public static readonly Dictionary<string, string> HiraganaRi = new()
        { {"りゃ", "rya"}, {"りゅ", "ryu"}, {"りょ", "ryo"} };

    public static IEnumerable<Dictionary<string, string>> HiraganaBasics =>
    [
        HiraganaVowels,
        HiraganaK,
        HiraganaG,
        HiraganaS,
        HiraganaZ,
        HiraganaT,
        HiraganaD,
        HiraganaN,
        HiraganaH,
        HiraganaB,
        HiraganaP,
        HiraganaM,
        HiraganaY,
        HiraganaR,
        HiraganaW
    ];

    public static IEnumerable<Dictionary<string, string>> HiraganaCombined =>
    [
        HiraganaKi,
        HiraganaGi,
        HiraganaShi,
        HiraganaJi,
        HiraganaChi,
        HiraganaNi,
        HiraganaHi,
        HiraganaBi,
        HiraganaPi,
        HiraganaMi,
        HiraganaRi
    ];
}