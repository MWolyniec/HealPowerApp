namespace HealPowerApp
{
    public class Archangel : HasteItem
    {
        private int ap;


        public override int Ap { get => ap + CountApFromMana(); }



        public Archangel(string name, int cost, Item[] itemList, int mana = 0, int ap = 0, int cdRed = 0, int healpower = 0) : base(name, cost, itemList, mana, ap, cdRed, healpower)
        {
        }

        private int CountApFromMana()
        {
            var mana = 0;
            foreach (var item in ItemList)
            {
                mana = mana + item.Mana;
            }
            return (int)(mana * 0.03);
        }


    }
}
