using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    public class Maze
    {
        private int width;
        private int hight;
        private Player player;
        public IMazeObject[,] MazeObjectArray;
        public Maze(int width, int hight)
        {
            this.width = width;
            this.hight = hight;
            MazeObjectArray = new IMazeObject[width, hight];
            player = new Player() { x = 1, y = 1 };
        }
        public void MazeDrow()
        {
            Console.Clear();
            Console.WriteLine("Start");
            for (int y = 0; y < hight; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 37 && y == 18)
                    {
                        MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(MazeObjectArray[x, y].Icon);
                    }
                    else if (x == 0 || y == 0 || x == width - 1 || y == hight - 1)
                    {
                        MazeObjectArray[x, y] = new Wall();
                        Console.Write(MazeObjectArray[x, y].Icon);
                    }
                    else if (x % 2 == 0 && y % 2 == 0)
                    {
                        MazeObjectArray[x, y] = new Wall();
                        Console.Write(MazeObjectArray[x, y].Icon);
                    }
                    else if (x % 5 == 0 && y % 5 == 0)
                    {
                        MazeObjectArray[x, y] = new Wall();
                        Console.Write(MazeObjectArray[x, y].Icon);
                    }
                    else if (x == player.x && y == player.y)
                    {
                        Console.Write(player.Icon);

                    }
                    else
                    {
                        MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(MazeObjectArray[x, y].Icon);
                    }
                }
                Console.WriteLine();
            }

        }
        public void MovePlayer()
        {
            var UserInput = Console.ReadKey();
            var Key = UserInput.Key;
            switch (Key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
            }
        }
        private void UpdatePlayer(int dx, int dy)
        {
            int NewX = player.x + dx;
            int NewY = player.y + dy;

            if (NewX < width && NewX >= 0 && NewY < hight && NewY >= 0 && MazeObjectArray[NewX, NewY].Isolid == false)
            {
                player.x = NewX;
                player.y = NewY;
                MazeDrow();
            }

        }
    }
}
