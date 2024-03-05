using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Main
{
    public class Hero()
    {

        private int health = 0;
        private int speed = 0;
        public static int position_X = 0;
        public static int position_Y = 0;

    }

    class Programm()
    {

        public static int Game() { 
            while (true)
            {
                
            }
            return 0; 
        }

        public static void Main(string[] args)
        {
            Map.Render();  
        }
    }

    class Map()
    {
        public void Render_Map()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(".");
                }
            }
        }

        public static int Move(char a)
        {
            if (a == 'a')
            {
                Hero.position_X -= 1;
            }
            return 0;
        }

        internal static void Render()
        {
            throw new NotImplementedException();
        }
    }
}