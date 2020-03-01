namespace Lab2
{
    // typical office job (sitting, studying, little walking throughout a day)
    public class VeryLightActivityHuman : HumanDecorator
    {
        public VeryLightActivityHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }

        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 1.3f;
        }
    }
    
    // any job where you mostly stand or walk (teaching, shop/lab work, some walking throughout a day)
    public class LightActivityHuman : HumanDecorator
    {
        public LightActivityHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }

        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 1.55f;
        }
    }
    
    // jobs requiring physical activity (landscaping, cleaning, maintenance, jogging/ biking/ working out 2 hours/day)
    public class ModerateActivityHuman : HumanDecorator
    {
        public ModerateActivityHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 1.65f;
        }
    }
    
    // heavy manual labor (construction, dancer, athlete, hard physical activity min 4 hours/day)
    public class HeavyActivityHuman : HumanDecorator
    {
        public HeavyActivityHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 1.8f;
        }
    }
    
    // moderate to hard physical activity min 8 hours/day 
    public class VeryHeavyActivityHuman : HumanDecorator
    {
        public VeryHeavyActivityHuman(Human human) : base(human)
        {
            this.Age = human.Age;
            this.Height = human.Height;
            this.Weight = human.Weight;
        }
        public override float GetDailyKCal()
        {
            return Human.GetDailyKCal() * 2;
        }
    }
}