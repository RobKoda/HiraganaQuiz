using HiraganaQuiz.Models;
using HiraganaQuiz.Shared;

namespace HiraganaQuiz.Apps;

public class BasicGame
{
    private IEnumerable<Dictionary<string, string>> SelectedKanaGroups { get; set; } = [HiraganaToRomajis.HiraganaAll];
    
    private  Dictionary<string, string> SelectedKanas => SelectedKanaGroups.ToCustomDictionary();
    private const int PromptsLength  = 4;

    public (string, string) GetNextPrompt()
    {
        var promptResult = string.Empty;
        var answerResult = string.Empty;
        var random = new Random();
        var selectedKanasKeys = new List<string>(SelectedKanas.Keys);
        
        for (var i = 0; i < PromptsLength; i++)
        {
            var hiragana = selectedKanasKeys[random.Next(selectedKanasKeys.Count)];
            promptResult += hiragana;
            answerResult += SelectedKanas[hiragana];
        }
        
        return (promptResult, answerResult);
    }
}