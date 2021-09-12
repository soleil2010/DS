namespace DS
{
    public class Item
    {
        public Stats Stats { get; protected set; }
        
        public Item()
        {
        }

        public Item(Stats stats)
        {
            Stats = stats;
        }

    }
}