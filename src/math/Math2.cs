namespace Algorithm
{
    public class Math2
    {
        public const uint BASE = 2;

        public static string Convert2(uint value)
        {
            uint[] result = new uint[32];
            for (int i = 31; i >= 0; i--)
            {
                uint mod = value % BASE;
                result[i] = mod;
                if (value < BASE)
                {
                    break;
                }
                else
                {
                    value = value / BASE;
                }
            }
            return string.Join("", result);
        }
    }
}
