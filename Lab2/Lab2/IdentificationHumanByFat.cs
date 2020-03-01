namespace Lab2
{
    public class ThinHuman : HumanDecorator
    {
        public ThinHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 1;
        }
    }

    public class LowFatHuman : HumanDecorator
    {
        public LowFatHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 0.95f;
        }
    }
    
    public class AverageFatHuman : HumanDecorator
    {
        public AverageFatHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 0.9f;
        }
    }
    
    public class FatHuman : HumanDecorator
    {
        public FatHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 0.85f;
        }
    }
}