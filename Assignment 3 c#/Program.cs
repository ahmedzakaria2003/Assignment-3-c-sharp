namespace Assignment_3_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter your number");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("NO");

            //}
            #endregion
            #region Q2
            //Console.WriteLine("Enter your number");
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0)
            //{
            //    Console.WriteLine("Number is negative");
            //}
            //else
            //{
            //    Console.WriteLine("number is positive");
            //}

            #endregion
            #region Q3
            //Console.WriteLine("enter your first number");
            //int number01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter your second number");
            //int number02 = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter your third number");
            //int number03 = int.Parse(Console.ReadLine());

            //int max = Math.Max(number01, Math.Max(number02, number03));
            //int min = Math.Min(number01, Math.Min(number02, number03));

            //Console.WriteLine($"Max : {max} ");
            //Console.WriteLine($"Min : {min} ");
            #endregion
            #region Q4
            //Console.WriteLine("ENTER YOUR NUMBER");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("number is even");
            //}
            //else
            //{

            //    Console.WriteLine("number is odd");
            //}

            #endregion
            #region Q5
            //Console.WriteLine("Enter your chars");
            //string chars = Console.ReadLine();
            //if (chars == "a" || chars == "e" || chars == "i" || chars == "o" || chars == "u")
            //{
            //    Console.WriteLine("vowel");

            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}



            #endregion
            #region Q6
            //Console.WriteLine("ENTER YOUR NUMBER");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{

            //    Console.WriteLine($"{number} * {i} =   {number * i}  ");
            //}
            #endregion
            #region Q7
            //Console.WriteLine("enter first int");
            //int number01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second int");
            //int number02 = int.Parse(Console.ReadLine());
            //double result = Math.Pow(number01, number02);
            //Console.WriteLine($"{result}");

            #endregion
            #region Q8
            //Console.WriteLine("enter mark of subject 1");
            //int mark01 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter mark of subject 2");
            //int mark02 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter mark of subject 3");
            //int mark03 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter mark of subject 4");
            //int mark04 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter mark of subject 5");
            //int mark05 = int.Parse(Console.ReadLine());
            //double totalMarks = mark01 + mark02 + mark03 + mark04 + mark05;
            //Console.WriteLine($"total mark is  {totalMarks}");
            //double avg = totalMarks / 5;
            //Console.WriteLine($"Average is  {avg}");
            //double Perc = (totalMarks / 500) * 100;
            //Console.WriteLine($"Percentage is  {Perc}");
            #endregion
            #region Q9
            //Console.WriteLine("Enter Month");
            //int Months = int.Parse(Console.ReadLine());
            //switch (Months)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Day in Month : 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Day in Month : 30");
            //        break;
            //    case 2: // February
            //        Console.Write("Is it a leap year? (y/n): ");
            //        string leapYear = Console.ReadLine();
            //        if (leapYear == "y" || leapYear == "yes")
            //        {
            //            Console.WriteLine("29");
            //        }
            //        else
            //        {
            //            Console.WriteLine("28");

            //        }
            //        break;

            //}


            #endregion
            #region Q10
            //Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //double x3 = Convert.ToDouble(Console.ReadLine());
            //double y3 = Convert.ToDouble(Console.ReadLine());


            //if (AreCollinear(x1, y1, x2, y2, x3, y3))
            //{
            //    Console.WriteLine("The points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on the same straight line.");
            //}
            //static bool AreCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
            //{

            //    double slope1 = (y2 - y1) * (x3 - x2);
            //    double slope2 = (y3 - y2) * (x2 - x1);


            //    return slope1 == slope2;
            //}
            #endregion
            #region Q11
            Console.WriteLine("Enter the time (in hours) taken to complete the task:");
            double timeTaken = Convert.ToDouble(Console.ReadLine());
            if (timeTaken >= 2 && timeTaken <= 3)
            {
                Console.WriteLine("Highly Efficient"); 
            }
            else if (timeTaken > 3 && timeTaken <= 4)
            {
                Console.WriteLine("Instructed to increase speed"); 
            }
            else if (timeTaken > 4 && timeTaken <= 5)
            {
                Console.WriteLine("Provided with training to enhance speed");
            }
            else if (timeTaken > 5)
            {
                Console.WriteLine("Required to leave the company"); 
            }
            else
            {
                Console.WriteLine("Invalid input, time must be greater than 0 hours"); 
            }
            #endregion
        }
        }
}
