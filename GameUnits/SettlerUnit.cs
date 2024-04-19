namespace GameUnits
{
    public class SettlerUnit : Unit // Heranca!!
    {

        public SettlerUnit(int mov = 1, int health = 3)
        : base(mov = 1, health = 3)
        // Unit(int, int)
        {
        }

        public override float Cost
        {
            get
            {
                return 5;
            }
        }
    }
}