using System;

namespace Lab2
{
    /*
    public enum BodyType
    {
        Ectomorph, //схильний до худорлявості
        Mesomorph, //спортивний і мускулистий від природи
        Endomorph  //схильний до набору зайвої ваги
    }; */
    public enum PhysActivity
    {
        Min = 1200,
        Low = 1375,
        Medium = 1550,
        High = 1725,
        VeryHigh = 1900
    };

    public enum Gender
    {
        Female,
        Male
    };
    
    public class Human
    {
        public int Age { get; private set; }
        public float Weight { get; private set; }
        public float Height { get; private set; }
        public Gender Gender { get; private set; }
        public PhysActivity Activity { get; private set; }

        public Human(int age, float weight, float height, Gender gender, PhysActivity act)
        {
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.Gender = gender;
            this.Activity = act;
        }
    }
    public class KilocaloriesCalculator
    {
        public static void CalculateKCal(Human hum)
        {
            float bmr = 10 * hum.Weight + 6.25f * hum.Height - 5 * hum.Age; //basal metabolic rate 
            
            if (hum.Gender == Gender.Female)
            {
               bmr -= 161;
            }
            else
            {
                bmr += 5;
            }
            
            bmr = bmr * (int) hum.Activity / 1000;
            Console.WriteLine(bmr);
        }
    }
    
    
}