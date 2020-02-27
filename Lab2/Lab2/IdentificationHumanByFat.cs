namespace Lab2
{
    public class ThinHuman : HumanDecorator
    {
        ThinHuman(Human human) : base(human)
        {
            
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 1;
        }
    }

    public class LowFatHuman : HumanDecorator
    {
        LowFatHuman(Human human) : base(human)
        {
            
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 0.95f;
        }
    }
    
    public class AverageFatHuman : HumanDecorator
    {
        AverageFatHuman(Human human) : base(human)
        {
            
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 0.9f;
        }
    }
    
    public class FatHuman : HumanDecorator
    {
        FatHuman(Human human) : base(human)
        {
            
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 0.85f;
        }
    }
}