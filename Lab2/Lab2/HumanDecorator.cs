namespace Lab2
{
    public abstract class HumanDecorator : Human
    {
        protected readonly Human Human;
        protected HumanDecorator(Human human)
        {
            this.Human = human;
        }
    }
}