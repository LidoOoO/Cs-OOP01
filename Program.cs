namespace Assingment
{


    #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

    //public enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    #endregion

    #region 2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

    //public enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}

    #endregion

    #region 3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

    //[Flags]
    //public enum Permissions : byte
    //{
    //    Delete = 1, Execute = 2, Read = 4, Write = 8
    //}

    #endregion

    #region 4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    #endregion

    #region 5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    #endregion
    internal class Program
    {

        #region 5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

        static double CalculateDistance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return (dx * dx) + ( dy * dy);
        }

        #endregion



        static void Main()
        {
            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //for(int i = 0; i <= 6; i++)
            //{
            //    WeekDays day = (WeekDays)Enum.Parse(typeof(WeekDays), i.ToString());
            //    Console.WriteLine(day);
            //}

            #endregion

            #region 2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");

            //if (Enum.TryParse(Console.ReadLine(), true, out Season season))
            //{
            //    string months = GetSeasonMonths(season);
            //    Console.WriteLine($"The months for {season} are: {months}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}


            //static string GetSeasonMonths(Season season)
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            return "March to May";
            //        case Season.Summer:
            //            return "June to August";
            //        case Season.Autumn:
            //            return "September to November";
            //        case Season.Winter:
            //            return "December to February";
            //        default:
            //            return "Unknown";
            //    }
            //}


            #endregion

            #region 3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //            Permissions userPermissions = Permissions.Read | Permissions.Write;
            //            Console.WriteLine($"user permissions : {userPermissions}");

            //            userPermissions |= Permissions.Delete;

            //            userPermissions ^= Permissions.Write;
            //;
            //            Console.WriteLine(userPermissions);

            //            if ((userPermissions & Permissions.Execute) == Permissions.Execute)
            //            {
            //                Console.WriteLine("Execute Is Existed");
            //            }

            //            else
            //            {
            //                Console.WriteLine("Execute Is Not Existed");
            //                userPermissions = userPermissions ^ Permissions.Execute;
            //                Console.WriteLine(userPermissions);
            //            }

            #endregion

            #region 4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color name (Red, Green, Blue):");

            //string X = Console.ReadLine();

            //if (Enum.TryParse(X, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{X} is not a primary color.");
            //}

            #endregion

            #region 5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            Console.WriteLine("Enter the X coordinate of the first point:");

            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate of the first point:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Point point1 = new Point(x1, y1);

            Console.WriteLine("Enter the X coordinate of the second point:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate of the second point:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Point point2 = new Point(x2, y2);

            double distance = CalculateDistance(point1, point2);
            Console.WriteLine($"The distance between the two points is: {distance}");



            #endregion

        }
    }
}
