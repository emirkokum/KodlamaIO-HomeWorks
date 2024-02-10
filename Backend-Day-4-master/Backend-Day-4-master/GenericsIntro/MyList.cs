using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // <T> T => belli bir tip kullanıcağımızı gösterir örnegin string verirse str devam edecek int verirse int . T yerine herhangi bir şey yazılabilir
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        // string yazılsaydı sadece str kullanılabilecekti T verdigin zaman Hangi tipi isterse ilk basta belirtmek kaydıyla kullanabilir.
        // illa str int değil istediğin bir class ı da kullabilirsin. ornek => Product classı List<Product>
        public void Add(T item)
        {

            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
            Console.WriteLine(items);

        }
       
    }
}
