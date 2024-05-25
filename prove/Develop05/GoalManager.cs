public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Goal Manager!");
        bool exitRequested = false;

        while (!exitRequested)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. List goals");
            Console.WriteLine("2. Create goal");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Display player info");
            Console.WriteLine("5. Save goals to file");
            Console.WriteLine("6. Load goals from file");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListGoalNames();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exitRequested = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Player score: " + _score);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("List of goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for this goal: ");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Invalid input. Enter a valid integer for points: ");
        }

        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string goalTypeChoice = Console.ReadLine();

        Goal newGoal;
        switch (goalTypeChoice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points); // Implement EternalGoal
                break;
            case "3":
                newGoal = new ChecklistGoal(name, description, points, 0, 0); // Implement ChecklistGoal
                break;
            default:
                Console.WriteLine("Invalid choice. Creating a Simple Goal by default.");
                newGoal = new SimpleGoal(name, description, points);
                break;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.Write("Enter the index of the goal you want to record an event for: ");
        int goalIndex;
        while (!int.TryParse(Console.ReadLine(), out goalIndex) || goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.Write("Invalid input. Enter a valid goal index: ");
        }

        var selectedGoal = _goals[goalIndex];
        selectedGoal.RecordEvent();
        _score += selectedGoal._points; // Update player score
        Console.WriteLine("Event recorded successfully!");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals()
    {
        _goals.Clear(); // Clear existing goals
        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Parse the line and create goal instances
                    // Add them to the _goals list
                }
            }
            Console.WriteLine("Goals loaded from file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}