using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class MyList<T> : IEnumerable, IEnumerator
    {
        private T[] _myList;
        T[] _tempList;
        private int position = -1;
        public MyList()
        {
            _myList = new T[0];
            _tempList = new T[0];
        }

        public int Count { get; private set; }
        public void Add(T item)
        {
            _tempList = _myList;
            _myList = new T[_myList.Length + 1];
            for (int i = 0; i < _tempList.Length; i++)
            {
                _myList[i] = _tempList[i];
            }

            _myList[_myList.Length - 1] = item;
            Count++;
        }

        //IEnumerator
        public object Current
        {
            get { return _myList[position]; }
        }

        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position < _myList.Length);
        }

        //IEnumerator
        public void Reset()
        {
            position = -1;
        }

        //IEnumerable
        public IEnumerator GetEnumerator()
        {

            //MyList'i IEnumerator tipinde döndürür, bu da foreach'e girebilmesini sağlar.
            return (IEnumerator)this;
            //HATA ÇÖZÜMÜ
            //System.InvalidCastException
            //Unable to cast object of type 'Test.MyList`1[System.String]' to type 'System.Collections.IEnumerator'.
            //Bu hatanın çözümü;
            //Bu return kodu, MyList sınıfını IEnumerator tipine dönüştürdüğü için, MyList'in IEnumerator arayüzünü
            //implement etmesi gerekir. Böylece; MyList, foreach döngüsü içinde çağrıldığında, iterasyon yapılırken 
            //burada tanımlanıp yazılan Current, MoveNext ve Reset metodları kullanılır.


            //_myList dizisini, Array sınıfının GetEnumerator metodunu kullanarak, IEnumerator tipinde döndürür.
            //Böylece; MyList sınıfının, IEnumerator arayüzünü implement etmesine gerek kalmaz.
            //return _myList.GetEnumerator(); //_myList dizisini IEnumerator tipinde döndürür.
        }
        //HATA ÇÖZÜMÜ
        //foreach statement cannot operate on variables of type 'MyList<string>' because 'MyList<string>' does not contain
        //a public instance or extension definition for 'GetEnumerator'. 
    }
}
//MY IMPLEMENTATION
//public int Count { get; private set; }
//T[] _array;
//public MyList()
//{
//    _array = new T[0];
//    Count = _array.Length;
//}

//public void Add(T item)
//{
//    _array.Append(item);
//    Count += 1;
//}

//public IEnumerator<T> GetEnumerator()
//{
//    foreach (var item in _array)
//    {
//        yield return item;
//    }
//}