﻿using Common;

namespace OOP01
{

    // What You Can Write Inside Namespace ??
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    // Access Modifier Allowed Inside Namespace
    // 1. Internal [Default]
    // 2. Public
    internal class Program
    {

        #region Part 01 Exception Handling and Protective Code

        #region Ex01
        //static void DoSomeCode()
        //{

        //    try
        //    {
        //        int X, Y, Z;

        //        X = int.Parse(Console.ReadLine()); // System.FormatException
        //        Y = int.Parse(Console.ReadLine());
        //        Z = X / Y; // System.DivideByZeroException

        //        int[] Numbers = { 1, 2, 3 }; // Size 3

        //        Numbers[10] = 100; //System.IndexOutOfRangeException

        //    }
        //    // If Any Exception Happend In Try Block
        //    // CLR Will Create Object From Class Of Exception
        //    // Through In Catch Block
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        // Log In File
        //        //Store In Database 
        //    }
        //}

        #endregion

        #region Ex02
        //static void DoSomeProtectiveCode()
        //{

        //    int X, Y, Z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("PLease Enter a First Number :");
        //        flag = int.TryParse(Console.ReadLine(), out X);

        //    } while (!flag);


        //    do
        //    {
        //        Console.WriteLine("PLease Enter a Second Number :");
        //        flag = int.TryParse(Console.ReadLine(), out Y);

        //    } while (!flag || Y == 0);




        //    // Try Parse ===> True - X = 10
        //    // Try Parse ===> Flase - X = 0

        //    Z = X / Y;

        //    int[] Numbers = null;
        //    if (Numbers?.Length > 10) // System.NullReferenceException
        //    {
        //        // Numbers = Null => Numbers?.Length = Null
        //        // Numbers = != Null => Numbers?.Length = Length 
        //        Numbers[10] = 100;
        //    }
        //}

        #endregion

        #endregion


        static void Main()

        {

            #region Part 01 Exception Handling and Protective Code

            ////DoSomeCode(); // RunTime Errors  (Exceptions)

            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // Close | Delete | Release | Deallocate Unmanged Resources
            //    // Open File 
            //    // Connection With Database 
            //    Console.WriteLine("Finally");
            //}

            #endregion


            #region Access Modifiers 

            //TypeA obj = new TypeA(); //Valid  

            ////TypeB obj2 = new Common.TypeB(); // Invalid [Internal]

            ////obj.X = 10; //Invalid

            ////obj.Y = 20; // Invalid

            //obj.Z = 30; // valid

            #endregion


        }
    }
}
