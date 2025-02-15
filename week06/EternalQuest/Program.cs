using System;


public class Program
{

    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

    // Add some example goals
       manager.AddGoal(new SimpleGoal("Run a Marathon", 1000));
       manager.AddGoal(new EternalGoal("Read Scriptures", 100));
       manager.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));

    // Record some progress on the goals
    manager.RecordEvent("Read Scriptures");
    manager.RecordEvent("Read Scriptures");
    manager.RecordEvent("Attend Temple");
   
    // Display the current status of the goals
    manager.DisplayStatus();
}
}




