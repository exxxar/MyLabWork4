internal class Program
{
    private static void Main(string[] args)
    {
      

        int num1 = 0, num2 = 0; //объявление двух переменных, иниуиализация их нулями 
   
        //вывод на консоль информации о приложении
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");
        //информируем пользователя о требуемом действии
        Console.WriteLine("Type a number, and then press Enter");
        num1 = Convert.ToInt32(Console.ReadLine());//считывание строки из консоли, преобразование текстовых данных к числовым, присвоение результата в переменную num1
        //информируем пользователя о требуемом действии
        Console.WriteLine("Type another number, and then press Enter");
        num2 = Convert.ToInt32(Console.ReadLine());//считывание строки из консоли, преобразование текстовых данных к числовым, присвоение результата в переменную num2
        //информируем пользователя о требуемом действии, предлагаем пользователю на выбор несколько вариантов действий
        Console.WriteLine("Choose an option from the following list:");
        Console.WriteLine("\ta - Add");
        Console.WriteLine("\ts - Subtract");
        Console.WriteLine("\tm - Multiply");
        Console.WriteLine("\td - Divide");
        Console.Write("Your option? ");
        //оператор множественного выбора свитч (переключатель)
        switch (Console.ReadLine())//считывание строки с вариантом для свитч с консоли
        {
            case "a"://условный оператор, если значение вводимых данных равно "а"
                Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2)); //форматированный вывод результата, выполнение операции сложения и конкатенации строк
                break; //завершение выполнение блока команд
            case "s"://условный оператор, если значение вводимых данных равно "s"
                Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2)); //форматированный вывод результата, выполнение операции вычитания и конкатенации строк
                break;//завершение выполнение блока команд
            case "m"://условный оператор, если значение вводимых данных равно "m"
                Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2)); //форматированный вывод результата, выполнение операции умножения и конкатенации строк
                break;//завершение выполнение блока команд
            case "d"://условный оператор, если значение вводимых данных равно "d"
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2)); //форматированный вывод результата, выполнение операции деления и конкатенации строк
                break;//завершение выполнение блока команд
            default://условный оператор, если значение вводимых данных не совпало не с одним из условий (case-ов)
                Console.WriteLine("You enter wrong option");
                break;//завершение выполнение блока команд
        }
        //оповещаем пользователя о заверешении работы программы кальлкулятора
        Console.Write("Press any key to close the Calculator console app...");
        Console.ReadKey(); //ожидаем нажатие любой клавиши перед закрытием
    }
}