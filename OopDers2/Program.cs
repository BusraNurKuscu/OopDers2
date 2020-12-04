using System;

namespace OopDers2
{
    class Matris
    {
        private readonly int[,] _Data;

        public int N { get; set; }
        public Matris(int n = 3)
        {
            _Data = new int[n, n];
             for(int i= 0; i< N; i++)
            {
                for(int j=0; j<N; i++)
                {
                    _Data[i, j] = new Random().Next(0, 9);
                }
            }
        }
        public override string ToString()
        {
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; i++)
                {
                    Console.WriteLine($"{_Data[i,j],-3}");
                }
                Console.WriteLine(); ;
            }
            Console.WriteLine();
            return "";
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matris mat = new Matris();
            mat.ToString();
            Activator.CreateInstance(typeof(Matris), null);
            Console.ReadKey();

        }

    }
}
