using System;

namespace OopDers2
{
    class Program
    {
        private int [,] _Data { get; set; }
        public Program(int[,] data)
        {
             for(int i= 0; i< _Data.GetLength(0); i++)
            {
                for(int j=0; j<_Data.GetLength(1); i++)
                {
                    _Data[i, j] = data[i, j];
                }
            }
        }
       
    }
}
