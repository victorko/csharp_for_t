
namespace Examples.TypeConversions
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1
            sbyte sb1 = 5;
            short s1 = sb1;
            int i1 = s1;
            long l1 = i1;

            // 2
            long l2 = 3;
            //int i2 = l2;
            int i2 = (int)l2;

            // 3
            short s3 = 1000;
            sbyte sb3 = (sbyte)s3;

            // 4
            int i4 = -2;
            uint ui4 = (uint)i4;

            // 5 
            checked
            {
                int i5 = -2;
                uint ui5 = (uint)i5;
            }

            // 6
            int i6 = 10;
            double d6 = i6;

            // 7
            float f7 = 2.7f;
            int i7 = (int)f7;

            // 8
            string s8 = "aaa";
            object o8 = s8;
            string s8_1 = (string)o8;
            string s8_2 = o8 as string;

            // 9
            object o9 = new Examples.ValueReferenceTypes.Point(0, 0);
            string s9_1 = o9 as string;
            string s9_2 = (string)o9;
        }
    }
}
