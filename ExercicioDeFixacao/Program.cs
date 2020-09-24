using System;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i=0; i<n; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');

                for (int j=0; j<n; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Diagonal principal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();
            Console.Write("Quantidade de negativos: ");

            int cont = 0;

            for(int i=0; i < n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.Write(cont);

        }
    }
}
