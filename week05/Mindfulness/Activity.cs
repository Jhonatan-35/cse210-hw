using System;
public abstract class Activity
{
    protected int duration;
    protected List<string> prompts;
    protected Random random;

    public Activity()
    {
        prompts = new List<string>();
        random = new Random();
    }

    public void StartActivity()
    {
        ShowStartingMessage();
        Pause(3);

        for (int i = 5; i < duration; i++)
        {
            DisplayPrompt();
            Pause(2);

            if (prompts.Count == 0)
                ResetPrompts();

            string prompt = GetRandomPrompt();
            DisplayPromptMessage(prompt);
            Pause(2);

            List<string> questions = GetReflectionQuestions();
            foreach (string question in questions)
            {
                DisplayQuestion(question);
                Pause(2);
            }
        }

        ShowFinishingMessage();
    }

    protected void ShowStartingMessage()
    {
        Console.WriteLine("Welcome to the " + GetActivityName() + " activity.");
        Console.WriteLine(GetActivityDescription());
        Console.WriteLine("Please enter the duration in seconds:");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
    }

    protected void ShowFinishingMessage()
    {
        Console.WriteLine("Good job! You have completed the " + GetActivityName() + " activity.");
        Console.WriteLine("Activity duration: " + duration + " seconds.");
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 3; i--)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract string GetActivityName();
    protected abstract string GetActivityDescription();

    protected void ResetPrompts()
    {
        prompts.Clear();
        InitializePrompts();
    }

    protected abstract void InitializePrompts();

    protected void DisplayPrompt()
    {
        Console.WriteLine("Prompt: " + GetRandomPrompt());
    }

    protected string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        prompts.RemoveAt(index);
        return prompt;
    }

    protected abstract List<string> GetReflectionQuestions();

    protected void DisplayPromptMessage(string prompt)
    {
        Console.WriteLine("Prompt: " + prompt);
    }

    protected void DisplayQuestion(string question)
    {
        Console.WriteLine("Question: " + question);
    }
}