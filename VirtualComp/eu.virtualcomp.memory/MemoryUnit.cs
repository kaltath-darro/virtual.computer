namespace VirtualComp.eu.virtualcomp.memory
{
    public class MemoryUnit
    {
        private bool a; // może zastosować Array; łatwiej będzie przy konwersji
        private bool b;
        private bool c;
        private bool d;
        private bool e;
        private bool f;
        private bool g;
        private bool h;

        public MemoryUnit(bool a, bool b, bool c, bool d, bool e,bool f, bool g, bool h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
        }

        public bool getA()
        {
            return a;
        }

        public bool getB()
        {
            return b;
        }

        public bool getC()
        {
            return c;
        }

        public bool getD()
        {
            return d;
        }

        public bool getE()
        {
            return e;
        }

        public bool getF()
        {
            return f;
        }

        public bool getG()
        {
            return g;
        }

        public bool getH()
        {
            return h;
        }

        public static MemoryUnit Init()
        {
            return new MemoryUnit(false, false, false, false, false, false, false, false);
        }

        public bool IsMax()
        {
            return a && b && c && d && e && f && g && h;
        }

        public static MemoryUnit Parse(string value)
        {
            //nie może być null i musi być 8
            char[] chars = value.ToCharArray();
            bool[] b = new bool[8];

            for (byte i = 0; i < 8; i++)
                b[i] = chars[i] == '1' ? true : false;

            return new MemoryUnit(b[0], b[1], b[2], b[3], b[4], b[5], b[6], b[7]);
        }
    }
}
