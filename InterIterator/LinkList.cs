using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterIterator
{
    class LinkList
    {
        private Link first;            // Ссылка на первый элемент в списке
                                       // -------------------------------------------------------------
        public LinkList()              // Конструктор
        { first = null; }           // Список пока не содержит элементов
                                    // -------------------------------------------------------------
        public Link getFirst()         // Получение первого элемента
        { return first; }
        // -------------------------------------------------------------
        public void setFirst(Link f)   // Присваивание нового значения first 
        { first = f; }
        // -------------------------------------------------------------
        public bool isEmpty()       // true, если список пуст
        { return first == null; }
        // -------------------------------------------------------------
        public ListIterator getIterator()  // Получение итератора
        {
            return new ListIterator(this);  // Инициализация списком this
        }
        // -------------------------------------------------------------
        public void displayList()
        {
            Link current = first;       // От начала списка
            while (current != null)      // Перемещение до конца списка
            {
                current.displayLink();   // Вывод текущего элемента
                current = current.next;  // Переход к следующему элементу
            }
            Console.WriteLine("");
        }
        // -------------------------------------------------------------
    }  // Конец класса LinkList
}
