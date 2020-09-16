using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLimit = int.Parse(Console.ReadLine());
            int lettterLimit = int.Parse(Console.ReadLine());

            for (int i = 1; i < numberLimit; i++)
            {
                for (int j = 1; j < numberLimit; j++)
                {
                    for (int k = 0; k < lettterLimit; k++)
                    {
                        for (int l = 0; l < lettterLimit; l++)
                        {
                            int lastNumber = Math.Max(i, j);
                            for (int m = lastNumber + 1; m <= numberLimit; m++)
                            {
                                 Console.Write($"{i}{j}{(char) (k + 97)}{(char) (l + 97)}{m} ");
                            }                   
                        }
                        
                    }
                    
                }
                
            }
        }
    }
}
