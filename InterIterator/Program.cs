using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterIterator
{
    class Program
    {
        //--------------------------------------------------------------
        public static String getString()
        {
            String s = Console.ReadLine();
            return s;
        }
    //-------------------------------------------------------------
    public static char getChar()
    {
        String s = getString();
            return s != string.Empty ? s[0] :'s';
    }
    //-------------------------------------------------------------
    public static int getInt()
    {
        String s = getString();
        return Int32.Parse(s);
    }
    static void Main(string[] args)
        {
            LinkList theList = new LinkList();           // Создание списка
            ListIterator iter1 = theList.getIterator();  // Создание итератора
            long value;
            iter1.insertAfter(20);             // Вставка элементов
            iter1.insertAfter(40);
            iter1.insertAfter(80);
            iter1.insertBefore(60);
            while (true)
            {
                Console.Write("Enter first letter of show, reset, ");
                Console.Write("next, get, before, after, delete: ");
                
                object choice = getChar();         // Ввод команды
                if (choice == null) continue;
                switch (choice)
                {
                    case 'q': return;
                    case 's':                    // Вывод списка
                        if (!theList.isEmpty())
                            theList.displayList();
                        else
                            Console.WriteLine("List is empty");
                        break;
                    case 'r':                    // Возврат к первому элементу
                        iter1.reset();
                        break;
                    case 'n':                    // Переход к следующему элементу
                        if (!theList.isEmpty() && !iter1.atEnd())
                            iter1.nextLink();
                        else
                            Console.WriteLine("Can't go to next link");
                        break;
                    case 'g':                    // Получение текущего элемента
                        if (!theList.isEmpty())
                        {
                            value = iter1.getCurrent().dData;
                            Console.WriteLine("Returned " + value);
                        }
                        else
                            Console.WriteLine("List is empty");
                        break;
                    case 'b':                    // Вставка перед текущим элементом
                        Console.Write("Enter value to insert: ");
                        
                        value = getInt();
                        iter1.insertBefore(value);
                        break;
                    case 'a':                    // Вставка после текущего элемента
                        Console.Write("Enter value to insert: ");
                        
                        value = getInt();
                        iter1.insertAfter(value);
                        break;
                    case 'd':                    // Удаление текущего элемента
                        if (!theList.isEmpty())
                        {
                            value = iter1.deleteCurrent();
                            Console.WriteLine("Deleted " + value);
                        }
                        else
                            Console.WriteLine("Can't delete");
                        break;

                }
            }
        }
    }
}
