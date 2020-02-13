namespace HealPowerApp
{
    public class Ludens : HasteItem
    {
        public Ludens(string name, int cost, Item[] itemList, int mana = 0, int ap = 0, int cdRed = 0, int healpower = 0) : base(name, cost, itemList, mana, ap, cdRed, healpower)
        {
        }
    }
}
