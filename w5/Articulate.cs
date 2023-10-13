/*
Polymorphism is a programming concept that allows objects of different types to respond to the same method call in different ways. This is achieved by using a common base class and derived classes that override the base class methods.
Benefit of Polymorphism: Polymorphism makes code more flexible and reusable. It allows you to write code that is generic and can be used with different types of objects without having to make changes to the code.
Application of Polymorphism: Polymorphism can be used in a variety of ways. For example, you can use polymorphism to implement different types of data structures, such as lists, stacks, and queues. You can also use polymorphism to implement different types of algorithms, such as sorting and searching algorithms.
 
 Example code
*/
public class Goal
{
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    public int Value { get; set; }

    public Goal(string name, int value)
    {
        Name = name;
        IsComplete = false;
        Value = value;
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name, value)
    {
    }

    public void RecordEvent()
    {
        // Increment the goal's value.
        Value++;
    }
}

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public void RecordEvent()
    {
        // Increment the goal's current count.
        CurrentCount++;

        // If the goal has been completed, increment the goal's value.
        if (CurrentCount == TargetCount)
        {
            Value++;
        }
    }
}
