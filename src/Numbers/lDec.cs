using System.Collections;

namespace PMath
{
    public class ldec : num
    {
        private BitArray Bits;

        public ldec() { }

        
        public ldec(int value)
        {
            Bits = new BitArray(32);
            int pos = 31, i = 0;
            while (i < 32)
            {
                if ((value & (1 << i)) != 0)
                {
                    Bits[pos] = true;
                }
                else
                {
                    Bits[pos] = false;
                }
                pos--;
                i++;
            }
        }

        //need to fix bugs - very important!
        public static ldec operator +(ldec a, ldec b)
        {
            BitArray carry = And(a.Bits, b.Bits), result = Xor(a.Bits, b.Bits);
            Console.WriteLine("aids!");
            while (carry.Length != 1)
            {
                BitArray shiftedCarry = Left(carry, 1);
                carry = And(result, shiftedCarry);
                result = Xor(result, shiftedCarry);
            }
            return new ldec() { Bits = result };
        }

        private static BitArray And(BitArray a, BitArray b) => a.And(b);

        private static BitArray Xor(BitArray a, BitArray b) => a.Xor(b);

        private static BitArray Or(BitArray a, BitArray b) => a.Or(b);

        private static BitArray Not(BitArray a) => a.Not();

        private static BitArray Left(BitArray a, int b) => a.LeftShift(b);

        private static BitArray Right(BitArray a, int b) => a.RightShift(b);

        /*public static ldec operator -(ldec a, ldec b)
        {
            //subtract
        }

        public static ldec operator *(ldec a, ldec b)
        {
            //multiply
        }

        public static pirr operator /(ldec a, ldec b)
        {
            //divide (return possible irrational)
        }



        public static ldec operator +(int a, ldec b)
        {
            //add
        }

        public static ldec operator -(int a, ldec b)
        {
            //subtract
        }

        public static ldec operator *(int a, ldec b)
        {
            //multiply
        }

        public static pirr operator /(int a, ldec b)
        {
            //divide (return possible irrational)
        }*/

        //idea: storing algo progress as string to eventually return
        public override string ToString()
        {
            string result = "";
            /*n = 0
            for d in digits:
                n = 10 * n + d
            return n*/
            return result;
        }
    }
}