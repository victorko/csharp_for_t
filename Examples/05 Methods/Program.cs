using System;

namespace Examples.Methods
{
    class Program
    {


        int Sum(int a, int b)
        {
            return a + b;
        }



        enum LogMessageType
        {
            Debug,
            Info,
            Warning,
            Error
        }

        void WriteLog(string message, LogMessageType messageType, DateTime time = default(DateTime))
        {
            if (time == default(DateTime))
                time = DateTime.Now;

            Console.WriteLine("[{2} {1}] {0}", message, messageType, time);
        }



        int Sum2(params int[] args)
        {
            var result = 0;
            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }



        void GetStaticstics(int[] nums, out int min, out int max)
        {
            min = nums[0];
            max = nums[1];

            foreach (var num in nums)
            {
                if (num < min)
                    min = num;

                if (num > max)
                    max = num;
            }
        }



        void CountPositives(int[] nums, ref int counter)
        {
            foreach (var num in nums)
            {
                if (num > 0)
                    counter++;
            }
        }



        public static void Main(string[] args)
        {
            var program = new Program();

            var c1 = program.Sum(2, 3);

            var c2 = program.Sum(b: 3, a: 2);



            program.WriteLog("Hey!", LogMessageType.Info, DateTime.Today);

            program.WriteLog("Noooooooo!!!", LogMessageType.Error);



            var c3 = program.Sum2(2, 3);

            var c4 = program.Sum2(2, 3, 4);

            var c5 = program.Sum2();



            int min, max;
            int[] nums = new[] { 1, 2, 3, 4, 5 };
            program.GetStaticstics(nums, out min, out max);



            var counter = 0;
            program.CountPositives(new[] { 1, -1, 2, -2 }, ref counter);
            program.CountPositives(new[] { 1, 2, 3 }, ref counter);
        }
    }
}
