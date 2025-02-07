using System;
using System.Collections.Generic;
public class BreathingActivity :Activity
{
    protected override string GetActivityName()
    {
        return "Breathing Activity";
    }

    protected override string GetActivityDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void InitializePrompts()
    {
        prompts.Add("Breathe in...");
        prompts.Add("Breathe out...");
    }

    protected override List<string> GetReflectionQuestions()
    {
        return new List<string>();
    }
}
