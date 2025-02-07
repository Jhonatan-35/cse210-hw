using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> reflectionPrompts;

    public ReflectingActivity()
    {
        reflectionPrompts = new List<string>();
    }

    protected override string GetActivityName()
    {
        return "Reflection Activity";
    }

    protected override string GetActivityDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    protected override void InitializePrompts()
    {
        reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        reflectionPrompts.Add("Think of a time when you did something really difficult.");
        reflectionPrompts.Add("Think of a time when you helped someone in need.");
        reflectionPrompts.Add("Think of a time when you did something truly selfless.");
    }

    protected override List<string> GetReflectionQuestions()
    {
        return new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }
}
