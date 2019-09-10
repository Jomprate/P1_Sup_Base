namespace P1_Sup_Base.Logic
{
    public class Character
    {
        public Hp Hp;
        
        public int Strength;

        public int Resistance;

        public int level = 1;



        public void LevelUp() => level += 1;

        public void UpStrengh(int Strength) => Strength = Strength + (1 * ((level - 1) * 0.25));

        public void UpResistance(int Resistance) => Resistance = resistance + (1 * ((level - 1) * 0.25));

    }
}