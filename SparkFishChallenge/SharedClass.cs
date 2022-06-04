using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkFishChallenge
{
    public class SharedClass : ISharedClass
    {
        public SharedClass()
        {

        }

        public int GetFirstNumber()
        {
            int FirstNumber = 0;

            Console.WriteLine("Enter your 1st number, 0 is the default so you can just hit enter :)");

            string? LowerNumber = Console.ReadLine();

            if (LowerNumber == "0" || LowerNumber == "")
            {
                return FirstNumber;
            }
            else
            {
                while (ValidateEntry(LowerNumber) == 0)
                {
                    Console.WriteLine("Please enter a valid number!");

                    LowerNumber = Console.ReadLine();


                }

            }

            FirstNumber = (int)Convert.ToInt64(LowerNumber);

            return FirstNumber;
        }

        public int GetSecondNumber(int LowerNumber)
        {
            int SecondNumber = 0;

            Console.WriteLine("Enter your 2nd number, make it larger than the 1st");

            string? HighNumber = Console.ReadLine();

            while (ValidateEntry(HighNumber) == 0)
            {
                Console.WriteLine("Please enter a valid number!");

                HighNumber = Console.ReadLine();


            }

            SecondNumber = (int)Convert.ToInt64(HighNumber);

            while (!IsSecondHigher(LowerNumber, SecondNumber))
            {
                Console.WriteLine("2nd Number must be greater that your 1st number, please enter a new number!");

                HighNumber = Console.ReadLine();

                SecondNumber = (int)Convert.ToInt64(HighNumber);
            }



            return SecondNumber;
        }

        public void GetSelectedPosition(int TotalPositions, int LowNumber, int HighNumber)
        {
            int LastPosition = TotalPositions -1;
            int PositionSelected = 0;
            
            Console.WriteLine($"There are { TotalPositions } positions, please select a number between 0 and { LastPosition }");

            string? SelectedPosition = Console.ReadLine();

            if (SelectedPosition == "")
            {
                SelectedPosition = "0";
            }

            PositionSelected = (int)Convert.ToInt64(SelectedPosition);

            while (PositionSelected > LastPosition)
            {
                Console.WriteLine($"The position you select must be less than or equal to {LastPosition}, please enter a valid number");

                SelectedPosition = Console.ReadLine();

                PositionSelected = (int)Convert.ToInt64(SelectedPosition);
            }
            
            GetRequestedPosition(PositionSelected, LowNumber, HighNumber);
        }

        private int ValidateEntry(string EnteredNumber)
        {
            int ReturnNumber;

            bool isNumber = int.TryParse(EnteredNumber, out ReturnNumber);

            return ReturnNumber;
        }

        public bool IsSecondHigher(int LowNumber, int HighNumber)
        {
            if (LowNumber > HighNumber)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetTotalNumberOfPositions(int LowNumber, int HighNumber)
        {
            int TotalPositions = 0;
            for (int i = LowNumber; i <= HighNumber; i++)
            {
                TotalPositions++;
            }

            return TotalPositions;
        }

         public void GetRequestedPosition(int RequestedPostion, int FirstNumber, int SecondNumber)
        {
            IList<int> intlist = new List<int>();
            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                intlist.Add(i);
            }
                
            int YourNumber = intlist[RequestedPostion];
            Console.WriteLine($"Your Number is {YourNumber}");
        }
    }
}
