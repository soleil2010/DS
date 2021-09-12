namespace DS
{
    public class Stats
    {
        //affects the physical damage of the used object, incr PHY ATK
        public int Attack;
        //affects the mouvement speed of the unit
        public int Speed;
        //affects the time between each attack of the unit
        public int AttackSpeed;
        //affects the magical damage of the spell, increment MAG ATK
        public int Magic;
        //reduces physical damages received by the unit
        public int Defense;
        //reduces magical attaks received by the unit
        public int Resistance;
        //affects the hit rate and critical hit of the unit
        public int Dexterity;
        //total of stamina the unit can use
        public float Stamina;
        //total of mana the unit can use
        public float Mana;
        //total health points that the unit has
        public int HP;

        public static Stats Zero()
        {
            return new Stats()
            {
                Attack = 0,
                Defense = 0,
                Dexterity = 0,
                Magic = 0,
                Mana = 0,
                Resistance = 0,
                Speed = 0,
                Stamina = 0,
                AttackSpeed = 0,
                HP = 0,
            };
        }
    }
}