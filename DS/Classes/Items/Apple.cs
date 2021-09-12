namespace DS
{
    public class Apple : Item , IConsumable
    {
        public Apple(int hp = 20)
        {
            base.Stats = new Stats()
            {
                HP = 20,
            };
        }
        public void Use(Character character)
        {
            character.CurrentStats.HP += Stats.HP;
            throw new System.NotImplementedException();
        }
    }
}