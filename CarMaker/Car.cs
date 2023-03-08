using System.Numerics;
using Raylib_cs;
using System;

public class Car : Vehicle
{
    public Model ChassiModel { get; set; }
    public Material ChassiMat { get; set; }

    public Tire FrontPair { get; set; }
    public Tire BackPair { get; set; }

    public Mirror MirrorPair { get; set; }

    public EngineHood Hood { get; set; }

    public Car()
    {
        // ChassiMat = Raylib.GetMaterial(ref ChassiModel, 1);
    }

    public Car(Tire front, Tire back, Mirror mirrors, EngineHood hood)
    {
        FrontPair = front;
        BackPair = back;
        MirrorPair = mirrors;
        Hood = hood;
    }

    public void Render(Vector2 size)
    {
        Raylib.InitWindow((int)size.X, (int)size.Y, "Car Model");

        Camera3D camera = new(new(0, 5, 5), new(0, 0, 0), new(0, 1, 0), 60f, CameraProjection.CAMERA_PERSPECTIVE);
        Raylib.SetCameraMode(camera, CameraMode.CAMERA_ORBITAL);

        ChassiModel = Raylib.LoadModel("Models/Test.obj");
        MirrorPair.mirrorModel = Raylib.LoadModel("Models/Test2.obj");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.BeginMode3D(camera);

            Raylib.ClearBackground(Color.WHITE);


            Raylib.UpdateCamera(ref camera);

            Raylib.DrawModel(ChassiModel, new(0, 0, 0), 1, Color.RED);
            Raylib.DrawModel(MirrorPair.mirrorModel, new(0, 0, 0), 1, Color.RED);

            Raylib.EndMode3D();
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}
