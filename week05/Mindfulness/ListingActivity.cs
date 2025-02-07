using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private List<string> listingPrompts;

    public ListingActivity()
    {
        listingPrompts = new List<string>();
    }

    protected override string GetActivityName()
    {
        return "Listing Activity";
    }

    protected override string GetActivityDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void InitializePrompts()
    {
        listingPrompts.Add("Who are people that you appreciate?");
        listingPrompts.Add("What are personal strengths of yours?");
        listingPrompts.Add("Who are people that you have helped this week?");
        listingPrompts.Add("When have you felt the Holy Ghost this month?");
        listingPrompts.Add("Who are some of your personal heroes?");
    }

    protected override List<string> GetReflectionQuestions()
    {
        return new List<string>();
    }
}
