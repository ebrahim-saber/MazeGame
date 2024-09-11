namespace MazeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maze game !");
            Console.WriteLine("Use arrows to move the player..");
            Thread.Sleep(1000);

            Maze maze = new Maze(40, 20);
            while (true)
            {
                maze.MazeDrow();
                maze.MovePlayer();
            }
        }
    }
}
