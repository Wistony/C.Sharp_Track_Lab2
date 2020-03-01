namespace Lab2
{
    using System;

    public class FatPercentageCalculator
    {
        protected static float CalculateFatPercentage(Human human)
        {
            var bmi = BmiCalculator.GetBmi(human);
            if (human is Male)
            {
                return (1.2f * bmi) + (0.23f * human.Age) - 16.2f;
            }
            else
            {
                return (1.2f * bmi) + (0.23f * human.Age) - 5.4f;
            }
        }

        public static void GetFatPercentage(Human human)
        {
            var fatPercentage = CalculateFatPercentage(human);
            Console.WriteLine($"Your fat percentage is {fatPercentage}");
        }

        public static void AnalyseFatPercentage(Human human)
        {
            var fatPercentage = CalculateFatPercentage(human);

            if (human is Male)
            {
                if (fatPercentage <= 2)
                {
                    Console.WriteLine("Not a table value, you need deep examination");
                }
                if (fatPercentage > 2 && fatPercentage <= 4)
                {
                    Console.WriteLine("You is essential fat");
                }
                if (fatPercentage > 6 && fatPercentage <= 13)
                {
                    Console.WriteLine("You have athletic body");
                }
                if (fatPercentage > 13 && fatPercentage <= 17)
                {
                    Console.WriteLine("You have fitness body");
                }
                if (fatPercentage > 17 && fatPercentage <= 25)
                {
                    Console.WriteLine("You have average body");
                }
                if (fatPercentage > 25)
                {
                    Console.WriteLine("You have obese body");
                }
            }
            else
            {
                if (fatPercentage <= 2)
                {
                    Console.WriteLine("Not a table value, you need deep examination");
                }
                if (fatPercentage > 10 && fatPercentage <= 12)
                {
                    Console.WriteLine("You is essential fat");
                }
                if (fatPercentage > 12 && fatPercentage <= 20)
                {
                    Console.WriteLine("You have athletic body");
                }
                if (fatPercentage > 20 && fatPercentage <= 24)
                {
                    Console.WriteLine("You have fitness body");
                }
                if (fatPercentage > 24 && fatPercentage <= 31)
                {
                    Console.WriteLine("You have average body");
                }
                if (fatPercentage > 31)
                {
                    Console.WriteLine("You have obese body");
                }
            }
        }
    }
}