using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RagozinaAD.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            double degrees = value * (180 / 3.14);
            return Math.Round(degrees, 3);
        }
    }
}
