using System.Numerics;
using Raylib_cs;
using System;

public class Engine
{
    static readonly Vector2 screenSize = new(800, 800);

    Car c;
    VisualEditor ve;

    public Engine()
    {
        c = new()
        {
            MirrorPair = new()
        };

        ve = new();
    }

    public void Start()
    {
        string? prompt = "";

        while (true)
        {
            prompt = Console.ReadLine();

            if (prompt is null) continue;
            else prompt = prompt.ToLower();

            if (prompt == "list") ListCommands();
            if (prompt == "render") TryRender();
            if (prompt == "visual editor") c.Render(screenSize);

            if (prompt == "exit") c.Render(screenSize);
        }
    }

    public void ListCommands()
    {
        Console.Clear();
        Console.WriteLine("Available commands:\n");
        Console.WriteLine("List, list commands");
        Console.WriteLine("Visual Editor (or VE), edits the car with visual interface");
        Console.WriteLine("Render, renders the car in external window");
        Console.WriteLine("Exit, exit the program");
    }

    public void TryRender()
    {
        try
        {
            c.Render(screenSize);
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.WriteLine(e);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public void VisualEditor()
    {
        ve.Start();
    }
}
