namespace PMath
{
    public class ldec : rat
    {
        private string Value = "";

        public ldec(int value)
        {
            Value = value;
        }

        public static ldec operator +(ldec a, ldec b)
        {
            //add
        }

        public static ldec operator -(ldec a, ldec b)
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
        }
    }
}