using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPAcalculation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tFirst Semester Of 100 Level.");
            Console.Write("Enter Students Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Course 1: ");
            string course1Name = Console.ReadLine();
            Console.Write("Enter Course 2: ");
            string course2Name = Console.ReadLine();
            Console.Write("Enter Course 3: ");
            string course3Name = Console.ReadLine();
            Console.Write("Enter Course 4: ");
            string course4Name = Console.ReadLine();
            Console.Write("Entre Course 5: ");
            string course5Name = Console.ReadLine();

            int course1Credit = 2;
            int course2Credit = 2;
            int course3Credit = 2;
            int course4Credit = 2;
            int course5Credit = 2;

            Console.WriteLine();
            Console.Write($"Enter Score for {course1Name} ");
            int score1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter score for {course2Name} ");
            int score2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter score for {course3Name} ");
            int score3 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write($"Enter score for {course4Name} ");
            int score4 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter score for {course5Name} ");
            int score5 = Convert.ToInt32(Console.ReadLine());

            int course1Score = score1;
            int course2Score = score2;
            int course3Score = score3;
            int course4Score = score4;
            int course5Score = score5;

            int totalCreditUnite = 0;
            totalCreditUnite += course1Credit;
            totalCreditUnite += course2Credit;
            totalCreditUnite += course3Credit;
            totalCreditUnite += course4Credit;
            totalCreditUnite += course5Credit;

            int totalScorePoints = 0;
            totalScorePoints += course1Credit * course1Score;
            totalScorePoints += course2Credit * course2Score;
            totalScorePoints += course3Credit * course3Score;
            totalScorePoints += course4Credit * course4Score;
            totalScorePoints += course5Credit * course5Score;

            decimal gradePointAverage = (decimal)totalScorePoints / totalCreditUnite;

            int leadingDigit = (int)gradePointAverage;
            int trailingDigits = (int)(gradePointAverage * 100) - (leadingDigit * 100);

            Console.WriteLine();
            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\tScore\tCredit Unite");

            Console.WriteLine($"{course1Name}\t\t{course1Score}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{course2Score}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{course3Score}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Score}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Score}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");
            Console.WriteLine();
            
            Console.Write($"Your Grade for {course1Name} is: "); Condition1(score1);
            Console.Write($"Your Grade for {course2Name} is: "); Condition2(score2);
            Console.Write($"Your Grade for {course3Name} is: "); Condition3(score3);
            Console.Write($"Your Grade for {course4Name} is: "); Condition4(score4);
            Console.Write($"Your Grade for {course5Name} is: "); Condition5(score5);



            Console.ReadLine();

        }

        public static void Condition1(int score1)
        {
            if (score1 >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score1 >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (score1 >= 40)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }

        public static void Condition2(int score2)
        {
            if (score2 >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score2 >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (score2 >= 40)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }

        public static void Condition3(int score3)
        {
            if (score3 >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score3 >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (score3 >= 40)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }

        public static void Condition4(int score4)
        {
            if (score4 >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score4 >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (score4 >= 40)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }

        public static void Condition5(int score5)
        {
            if (score5 >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score5 >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (score5 >= 40)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }
    }
}
