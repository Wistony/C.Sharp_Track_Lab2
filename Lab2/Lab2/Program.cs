using System;

namespace Lab2
{
    public static class Program
    {
        private static void Main()
        {
            var age = InputAge();
            var weight = InputWeight();
            var height = InputHeight();
            var human = InputGender(age,weight,height);

            human = FatPercantageDistributor.DistributionByFat(human);
            human = PhysActivityDistributor.DistributionByPhysActivity(human);
            
            var flag = true;
            while (flag)
            {
                Console.WriteLine("1) BMI ");
                Console.WriteLine("2) Fat Percentage");
                Console.WriteLine("3) Daily intake of calories");
                Console.WriteLine("4) Exit");
                var choice = Console.ReadLine();
                var num = int.Parse(choice);
                
                switch (num)
                {
                    case 1:
                    {
                        var bmi = BmiCalculator.GetBmi(human);
                        Console.WriteLine($"Your BMI - {bmi}");
                        BmiCalculator.AnalyseBmi(human);
                        break;
                    }
                    case 2:
                    {
                        FatPercentageCalculator.GetFatPercentage(human);
                        FatPercentageCalculator.AnalyseFatPercentage(human);
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"Your normal intake of calories - {human.GetDailyKCal()}");
                        break;
                    }
                    case 4:
                    {
                        flag = false;
                        break;
                    }
                }
            }

        }

        private static Human InputGender(int age, float weight, float height)
        { 
            Console.WriteLine("Enter your gender:");
            Console.WriteLine("1) Male");
            Console.WriteLine("2) Female");
            var choice = Console.ReadLine();
            var gender = int.Parse(choice);
            
            switch (gender)
            {
                case 1:
                {
                    return new Male(age, weight, height);
                }
                case 2:
                {
                    return new Female(age, weight, height);
                }
                default:
                {
                    return null;
                }
            }
        }
        private static int InputAge()
        {
            var age = 0;
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Age");
                var strAge = Console.ReadLine();

                if (InputValidation.AgeIsValid(strAge))
                {
                    age = int.Parse(strAge);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Incorrect Age, please try again");
                }
            }

            return age;
        }
        
        private static float InputWeight()
        {
            float weight = 0;
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Weight");
                var strWeight = Console.ReadLine();

                if (InputValidation.WeightIsValid(strWeight))
                {
                    weight = float.Parse(strWeight);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Incorrect Weight, please try again");
                }
            }

            return weight;
        }
        
        private static float InputHeight()
        {
            float height = 0;
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Height");
                var strHeight = Console.ReadLine();

                if (InputValidation.WeightIsValid(strHeight))
                {
                    height = float.Parse(strHeight);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Incorrect Height, please try again");
                }
            }

            return height;
        }
        
    }
}
