using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RagozinaAD.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            char[] charArray = value.ToCharArray();

            Array.Reverse(charArray);
            string reversedvalue = new string(charArray);
            return value == reversedvalue;
        }
    }
}
