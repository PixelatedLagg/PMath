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

        //ported from https://www.programmingnotes.org/7818/cs-how-to-add-two-binary-strings-using-cs/
        //need to fix bugs - very important!
        public static ldec operator +(ldec a, ldec b)
        {
            var aLength = a.Bits.Length - 1;
            var bLength = b.Bits.Length - 1;
            var stack = new Stack<int>();
            var carry = 0;
            while (aLength >= 0 || bLength >= 0)
            {
                var aValue = 0;
                var bValue = 0;
                if (aLength >= 0)
                {
                    aValue = Convert.ToInt32(a.Bits[aLength--]);
                }
                if (bLength >= 0)
                {
                    bValue = Convert.ToInt32(b.Bits[bLength--]);
                }
                var sum = carry + aValue + bValue;
                carry = sum / 2;
                var digit = sum % 2;
                stack.Push(digit);
            }
            if (carry > 0)
            {
                stack.Push(carry);
            }
            BitArray result = new BitArray(stack.Count);
            while (stack.Count > 0)
            {
                result.Set(result.Length - stack.Count, stack.Peek() == 1);
                stack.Pop();
            }
            return new ldec() { Bits = result };
        }

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
        }

        public override string ToString()
        {
            //return string
        }*/
    }
}