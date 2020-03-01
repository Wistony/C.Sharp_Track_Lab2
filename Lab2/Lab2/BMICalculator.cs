namespace Lab2
{
    using System;

    public static  class BmiCalculator   // body mass index 
    {
        public static float GetBmi(Human human)
        {
            return human.Weight / (human.Height * human.Height / 10000f);
        }
        public static void AnalyseBmi(Human human)
        {
            var bmi = GetBmi(human);

            if (bmi <= 16)
            {
                Console.WriteLine("You have expressed deficiency of body weigh");
            }
            if (bmi > 16 && bmi <= 18.5)
            {
                Console.WriteLine("You have deficient body weight");
            }
            if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("You have normal(healthy) weight");
            }
            if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("You have overweight");
            }
            if (bmi > 30 && bmi <= 35)
            {
                Console.WriteLine("You have obese class I ");
            }
            if (bmi > 35 && bmi <= 40)
            {
                Console.WriteLine("You have obese class II ");
            }
            if (bmi > 40)
            {
                Console.WriteLine("You have obese class III ");
            }
        }
    }
}