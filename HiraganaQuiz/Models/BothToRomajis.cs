namespace HiraganaQuiz.Models;

// ReSharper disable MemberCanBePrivate.Global - Accessed by code
public static class BothToRomajis
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

    public static readonly Dictionary<string, string> KatakanaVowels = new()
        { { "ア", "a" }, { "イ", "i" }, { "ウ", "u" }, { "エ", "e" }, { "オ", "o" } };
    public static readonly Dictionary<string, string> KatakanaK = new()
        { {"カ", "ka"}, {"キ", "ki"}, {"ク", "ku"}, {"ケ", "ke"}, {"コ", "ko"} };
    public static readonly Dictionary<string, string> KatakanaG = new()
        { {"ガ", "ga"}, {"ギ", "gi"}, {"グ", "gu"}, {"ゲ", "ge"}, {"ゴ", "go"} };
    public static readonly Dictionary<string, string> KatakanaS = new()
        { {"サ", "sa"}, {"シ", "shi"}, {"ス", "su"}, {"セ", "se"}, {"ソ", "so"} };
    public static readonly Dictionary<string, string> KatakanaZ = new()
        { {"ザ", "za"}, {"ジ", "ji"}, {"ズ", "zu"}, {"ゼ", "ze"}, {"ゾ", "zo"} };
    public static readonly Dictionary<string, string> KatakanaT = new()
        { {"タ", "ta"}, {"チ", "chi"}, {"ツ", "tsu"}, {"テ", "te"}, {"ト", "to"} };
    public static readonly Dictionary<string, string> KatakanaD = new()
        { {"ダ", "da"}, {"ヂ", "ji"}, {"ヅ", "zu"}, {"デ", "de"}, {"ド", "do"} };
    public static readonly Dictionary<string, string> KatakanaN = new()
        { {"ナ", "na"}, {"ニ", "ni"}, {"ヌ", "nu"}, {"ネ", "ne"}, {"ノ", "no"} };
    public static readonly Dictionary<string, string> KatakanaH = new()
        { {"ハ", "ha"}, {"ヒ", "hi"}, {"フ", "fu"}, {"ヘ", "he"}, {"ホ", "ho"} };
    public static readonly Dictionary<string, string> KatakanaB = new()
        { {"バ", "ba"}, {"ビ", "bi"}, {"ブ", "bu"}, {"ベ", "be"}, {"ボ", "bo"} };
    public static readonly Dictionary<string, string> KatakanaP = new()
        { {"パ", "pa"}, {"ピ", "pi"}, {"プ", "pu"}, {"ペ", "pe"}, {"ポ", "po"} };
    public static readonly Dictionary<string, string> KatakanaM = new()
        { {"マ", "ma"}, {"ミ", "mi"}, {"ム", "mu"}, {"メ", "me"}, {"モ", "mo"} };
    public static readonly Dictionary<string, string> KatakanaY = new()
        { {"ヤ", "ya"}, {"ユ", "yu"}, {"ヨ", "yo"} };
    public static readonly Dictionary<string, string> KatakanaR = new()
        { {"ラ", "ra"}, {"リ", "ri"}, {"ル", "ru"}, {"レ", "re"}, {"ロ", "ro"} };
    public static readonly Dictionary<string, string> KatakanaW = new()
        { {"ワ", "wa"}, {"ヲ", "wo"}, {"ン", "n"} };

    public static readonly Dictionary<string, string> KatakanaKi = new()
        { {"キャ", "kya"}, {"キュ", "kyu"}, {"キョ", "kyo"} };
    public static readonly Dictionary<string, string> KatakanaGi = new()
        { {"ギャ", "gya"}, {"ギュ", "gyu"}, {"ギョ", "gyo"} };
    public static readonly Dictionary<string, string> KatakanaShi = new()
        { {"シャ", "sha"}, {"シュ", "shu"}, {"ショ", "sho"} };
    public static readonly Dictionary<string, string> KatakanaJi = new()
        { {"ジャ", "ja"}, {"ジュ", "ju"}, {"ジョ", "jo"} };
    public static readonly Dictionary<string, string> KatakanaChi = new()
        { {"チャ", "cha"}, {"チュ", "chu"}, {"チョ", "cho"} };
    public static readonly Dictionary<string, string> KatakanaNi = new()
        { {"ニャ", "nya"}, {"ニュ", "nyu"}, {"ニョ", "nyo"} };
    public static readonly Dictionary<string, string> KatakanaHi = new()
        { {"ヒャ", "hya"}, {"ヒュ", "hyu"}, {"ヒョ", "hyo"} };
    public static readonly Dictionary<string, string> KatakanaBi = new()
        { {"ビャ", "bya"}, {"ビュ", "byu"}, {"ビョ", "byo"} };
    public static readonly Dictionary<string, string> KatakanaPi = new()
        { {"ピャ", "pya"}, {"ピュ", "pyu"}, {"ピョ", "pyo"} };
    public static readonly Dictionary<string, string> KatakanaMi = new()
        { {"ミャ", "mya"}, {"ミュ", "myu"}, {"ミョ", "myo"} };
    public static readonly Dictionary<string, string> KatakanaRi = new()
        { {"リャ", "rya"}, {"リュ", "ryu"}, {"リョ", "ryo"} };

    public static IEnumerable<Dictionary<string, string>> BothBasics =>
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
        HiraganaW,
        KatakanaVowels,
        KatakanaK,
        KatakanaG,
        KatakanaS,
        KatakanaZ,
        KatakanaT,
        KatakanaD,
        KatakanaN,
        KatakanaH,
        KatakanaB,
        KatakanaP,
        KatakanaM,
        KatakanaY,
        KatakanaR,
        KatakanaW
    ];

    public static IEnumerable<Dictionary<string, string>> BothCombined =>
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
        HiraganaRi,
        KatakanaKi,
        KatakanaGi,
        KatakanaShi,
        KatakanaJi,
        KatakanaChi,
        KatakanaNi,
        KatakanaHi,
        KatakanaBi,
        KatakanaPi,
        KatakanaMi,
        KatakanaRi
    ];
}