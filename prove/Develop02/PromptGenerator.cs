public class PromptGenerator
{
    public string _lastPrompt = " ";

    public List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What did I forget to do today?",
            "Who did I help along the way today?",
            "If I had one thing I could do over today, what would it be?"
        };


    public void DisplayPrompt()
    {
        var random = new Random();
        int index = random.Next(this.prompts.Count);
        this._lastPrompt = prompts[index];
        Console.WriteLine(this._lastPrompt);
    }

    public string GetLastPrompt()
    {
        return this._lastPrompt;
    }

}