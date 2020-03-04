namespace Lab2
{
    using System;

    public static class PhysActivityDistributor
    {
        private static int ChooseLevelActivity()
        {
            Console.WriteLine("1) Very light activity(typical office job (sitting, studying, little walking throughout a day))");
            Console.WriteLine("2) Light activity (any job where you mostly stand or walk (teaching, shop/lab work, some walking throughout a day))");
            Console.WriteLine("3) Moderate activity (jobs requiring physical activity (landscaping, cleaning, maintenance, jogging/biking/working out 2 hours/day)" );
            Console.WriteLine("4) Heavy activity (heavy manual labor (construction, dancer, athlete, hard physical activity min 4 hours/day)");
            Console.WriteLine("5) Very heavy activity (moderate to hard physical activity min 8 hours/day)");
            var choose = Console.ReadLine();
            var num = int.Parse(choose);

            return num;
        }

        public static Human DistributionByPhysActivity(Human human)
        {
            var num = ChooseLevelActivity();
            
            switch (num)
            {
                case 1:
                {
                    return new VeryLightActivityHuman(human);
                }
                case 2:
                {
                    return new LightActivityHuman(human);
                }
                case 3:
                {
                    return new ModerateActivityHuman(human);
                }
                case 4:
                {
                    return new HeavyActivityHuman(human);
                }
                case 5:
                {
                    return new VeryHeavyActivityHuman(human);
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}