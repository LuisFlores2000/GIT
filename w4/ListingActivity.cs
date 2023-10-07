using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private List<string> _userList = new List<string>();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


    // Constructors
    // Methods
    public ListingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    public void ReturnPrompt(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        var question = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        CountDown(8);
        Timer(seconds);
    }
    public void Timer(int seconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write("> ");
            _userList.Add(Console.ReadLine());
        }
        timer.Stop();
        int listLength = _userList.Count;
        Console.WriteLine($"\nYou listed {listLength} items!");
    }





}