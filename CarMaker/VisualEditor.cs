using Raylib_cs;

public class VisualEditor
{
    public VisualEditor()
    {

    }

    public void Start()
    {
        Raylib.InitWindow(800, 800, "Car Editor");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            

            Raylib.EndDrawing();
        }
    }
}
