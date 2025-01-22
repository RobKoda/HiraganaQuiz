using HiraganaQuiz.Shared;

namespace HiraganaQuiz.Apps;

public class BasicGame
{
    private const int PromptsLength  = 4;

    public List<Dictionary<string, string>> SelectedKanaGroups { get; } = [];
    private Dictionary<string, string> SelectedKanas => SelectedKanaGroups.ToCustomDictionary();
    
    public (string, string) GetNextPrompt()
    {
        if (SelectedKanaGroups.Count == 0) return (string.Empty, string.Empty);
        
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