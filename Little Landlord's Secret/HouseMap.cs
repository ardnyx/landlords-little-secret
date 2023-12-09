using System;
using System.Linq;

namespace Little_Landlord_s_Secret
{
    internal class HouseMap
    {
        private string[,] KateRoom;
        private string[,] currentMap;
        public HouseMap()
        {
            InitializeKateRoom();
        }

        private void InitializeKateRoom()
        {
            KateRoom = new string[,]
            {
                {"0","0","0","0","0"},
                {"0","LEtters","B","0","0"},
                {"0","0","A","0","0"},
                {"0","0","START","0","0"},

            };
        }
        public void Display(int[] position)
        {
            Console.WriteLine("------------------------------------------------------------");
            for (int i = 1; i < KateRoom.GetLength(0)-1; i++)
            {
                Console.Write("|");
                for (int j = 0; j < KateRoom.GetLength(1)-1; j++)
                {
                    string loc = KateRoom[i, j];
                    if (position[0] == i && position[1] == j)
                    {
                        Console.Write($"(XX)\t");
                    }
                    else if (loc != "0")
                    {
                        Console.Write($"[{FilterLocationString(loc)}]\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.Write("|\n");
            }
            Console.WriteLine("---------------------------------------------------------\n");
        }

        public int[] GetNewPosition(int[] currentPosition, char direction)
        {
            int row = currentPosition[0];
            int col = currentPosition[1];

            switch (direction)
            {
                case 'W': row--; break;
                case 'S': row++; break;
                case 'A': col--; break;
                case 'D': col++; break;
            }

            return new int[] { row, col };
        }

        public bool IsValidPosition(int[] position)
        {
            int row = position[0];
            int col = position[1];

            return row >= 0 && row < KateRoom.GetLength(0) && col >= 0 && col < KateRoom.GetLength(1) && KateRoom[row, col] != "0";
        }

        private string FilterLocationString(string loc)
        {
            return new string(loc.Where(c => char.IsUpper(c) || char.IsDigit(c)).ToArray());
        }
    }
}
