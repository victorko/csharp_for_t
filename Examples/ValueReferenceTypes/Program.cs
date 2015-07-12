using System;

namespace Examples.ValueReferenceTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Работа со ссылочным типом

            Point p1 = new Point(0, 0);
            Point p2 = p1;
            object p3 = p1;

            p1.Move(1, 1);
            Console.WriteLine("{0}  {1}  {2}", p1, p2, p3);

            p2.Move(1, 1);
            Console.WriteLine("{0}  {1}  {2}", p1, p2, p3);

            ((Point)p3).Move(1, 1);
            Console.WriteLine("{0}  {1}  {2}", p1, p2, p3); 

            #endregion

            Console.WriteLine("----------------------");

            #region Работа со значимым типом

            PointStruct ps1 = new PointStruct(0, 0);
            PointStruct ps2 = ps1;
            object ps3 = ps1;

            ps1.Move(1, 1);
            Console.WriteLine("{0}  {1}  {2}", ps1, ps2, ps3);

            ps2.Move(1, 1);
            Console.WriteLine("{0}  {1}  {2}", ps1, ps2, ps3);

            ((PointStruct)ps3).Move(1, 1);
            Console.WriteLine("{0}  {1}  {2}", ps1, ps2, ps3);

            #endregion
        }
    }
}
