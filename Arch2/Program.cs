using System;

namespace Arch2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //TODO: Доавить символ в нач в кон, перевод в регистры, удаление символа
            MyString Test = new MyString();
            Test.value = "RwwWe";
            MyString temp = Test.RemoveBySymbol('w');
            Console.WriteLine(temp[2]);
        }
    }
}