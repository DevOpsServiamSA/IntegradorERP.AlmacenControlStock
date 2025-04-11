using IntegralAPI;

namespace AlmacenControlStock
{
    public class Modulo : BaseDevModulo
    {
        private static Modulo instance;

        private Modulo() { }

        public static Modulo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Modulo();
                }
                return instance;
            }
        }
    }
}
