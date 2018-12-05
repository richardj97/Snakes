using System.Drawing;

namespace Snakes.Components
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class Settings
    {
        public static string Username { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction Dir { get; set; }
        public static Color BrushCol { get; set; }
        public static Color BrushCol2 { get; set; }
        public static Color BrushCol3 { get; set; }

        public Settings()
        {
            Points = 0;
            GameOver = false;
            Dir = Direction.Down;
        }
    }
}
