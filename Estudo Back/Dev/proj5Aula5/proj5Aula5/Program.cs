using System;

namespace proj5Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = Console.ReadLine().Split(" ");

            int M = int.Parse(vect[0]);
            int N = int.Parse(vect[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            for (int i = 0; i < M; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }





            for (int i = 0; i < M; i++)
            {

                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(s[j]);
                }
            }



            for (int i = 0; i < M; i++)
            {
                                
                for (int j = 0; j < N; j++)
                {

                    C[i,j] = A[i, j] + B[i,j];

                }
            }

            for (int i = 0; i < M; i++)
            {

                for (int j = 0; j < N; j++)
                {

                    Console.Write(C[i,j] + " ");

                }

                Console.WriteLine();
            }

        }
    }
}
