﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt alta 10 tane yıldız oluşturma


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }



            #endregion

            #region Yan Yana 10 tane yıldız oluşturma


            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }



            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 yıldız


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }



            #endregion

            #region Dik üçgen


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }



            #endregion

            #region Ters Dik üçgen


            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }



            #endregion

            #region Baklava Dilimi

            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for(int j = n-1; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k<=2; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = n -1; i >= 1; i--)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i -1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            #endregion

            #region Piramit

            n = 5;
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }



            #endregion

            #region ters piramit

            int x = 5; 

            for(int i = x; i >= 1; i--)
            {
                for (int j = x - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            #endregion

            Console.Read();


        }
    }
}