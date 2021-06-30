﻿using System;
using QuanT2009_M1_AP.Intity;

namespace QuanT2009_M1_AP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var storeManager = new SanPham.Store();
            while (true)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("1. Add product records.");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id");
                Console.WriteLine("4. Exit");
                Console.WriteLine("***************************");
                Console.WriteLine("Please enter options (1-4): ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        storeManager.AddProductRecords();
                        break;
                    case 2:
                        storeManager.DisplayProductRecords();
                        break;
                    case 3:
                        storeManager.DeleteProduct();
                        break;
                }
                if (choice == 4)
                {
                    Console.WriteLine("Terminate the application!");
                    break;
                }
        }
    }
}