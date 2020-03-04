namespace Lab2
{
    public class FatPercantageDistributor : FatPercentageCalculator
    {
        public static Human DistributionByFat(Human human)
        {
            var fatPercentage = CalculateFatPercentage(human);
            
            if (human is Male)
            {
                if (fatPercentage <= 14)
                {
                    return new ThinHuman(human);
                }
                if (fatPercentage > 14 && fatPercentage <= 20)
                {
                    return new LowFatHuman(human);
                }
                if (fatPercentage > 20 && fatPercentage <= 28)
                {
                    return new AverageFatHuman(human);
                }
                if (fatPercentage > 28)
                {
                    return new FatHuman(human);
                }
            }
            else
            {
                if (fatPercentage <= 18)
                {
                    return new ThinHuman(human);
                }
                if (fatPercentage > 18 && fatPercentage <= 28)
                {
                    return new LowFatHuman(human);
                }
                if (fatPercentage > 28 && fatPercentage <= 38)
                {
                    return new AverageFatHuman(human);
                }
                if (fatPercentage > 38)
                {
                    return new FatHuman(human);
                }
            }

            return null;
        }
    }
}