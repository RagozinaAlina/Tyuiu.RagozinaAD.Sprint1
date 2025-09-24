using Tyuiu.RagozinaAD.Sprint1.Task7.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Рагозина А.Д | АСОиУБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Рагозина А.Д | АСОиУБ-25-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДВННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*              2                                                          *");
        Console.WriteLine("*         1+sin (x+y)                                                     *");
        Console.WriteLine("*   z  =  ----------  + x                                                 *");
        Console.WriteLine("*         2+|    x+2*x    |                                               *");
        Console.WriteLine("*           |x - ---------|                                               *");
        Console.WriteLine("*           |     2    2  |                                               *");
        Console.WriteLine("*           |1 + x  * y   |                                               *");

        double x, y;

        Console.WriteLine("Введите значение x:");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate (x,y));
        Console.ReadKey();

    }
}