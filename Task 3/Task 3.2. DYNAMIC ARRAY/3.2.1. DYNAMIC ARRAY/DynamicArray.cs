using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3._2._1._DYNAMIC_ARRAY
{
    public class DynamicArray<T> //: IEnumerable<>, IEnumerable<T>
    {
        T[] dynamicArray;
        //private int Length;
       

        //1. Конструктор без параметров
        public DynamicArray()
        {
            dynamicArray = new T[8];
        }

        //2. Конструктор с одним целочисленным параметром 
        public DynamicArray(int capacity)
        {
            dynamicArray = new T[capacity];
        }

        //3. Конструктор, который в качестве параметра принимает коллекцию, реализующую интерфейс IEnumerable<T>
        public DynamicArray(IEnumerable<T> listToArray)
        {
            dynamicArray = listToArray.ToArray();
            Length += (from item in dynamicArray select item).Count();
        }

        //4.Метод Add, добавляющий в конец массива один элемент.
        public void Add(T addedElement)
        {
            if (Length == dynamicArray.Length)
            {
                
                LengthMultiplier(Length);   //dynamicArray.Length *= 2;
            }
            dynamicArray.Append<T>(addedElement);
        }
        public void LengthMultiplier(int length)
        {
            int finalCapacity = dynamicArray.Length;
            while (finalCapacity < length)
            {
                finalCapacity *= 2;
            }
            T[] tempArr = new T[finalCapacity];
            for (int i = 0; i < Length; i++)
            {
                tempArr[i] = dynamicArray[i];
            }
            dynamicArray = tempArr;
        }

        //5. Метод AddRange, добавляющий в конец массива содержимое коллекции, реализующей интерфейс IEnumerable<T>
        public void AddRange(IEnumerable<T> addedCollection)
        {
            int finalLength = addedCollection.Count() + dynamicArray.Length;
            if (Length <= finalLength)
            {
                LengthMultiplier(finalLength);
            }
            foreach (var item in addedCollection)
            {
                dynamicArray.Append(item);
            }
        }

        //6. Метод Remove, удаляющий из коллекции указанный элемент.
        public bool Remove(int removedIndex)
        {
            for (int i = 0; i < dynamicArray.Length; i++)
            {
                if (i == removedIndex)
                {
                    Array.Copy(dynamicArray, i + 1, dynamicArray, i, Length - 1);
                }
                return true;
            }
            return false;
        }

        //7. Метод Insert, позволяющий добавить элемент в произвольную позицию массива
        public bool Insert(int index, T element)
        {
            if ((index < 0) || (index > Length))
            {
                throw new ArgumentOutOfRangeException("Out of array bounds");
            }
            else
            {
                try
                {
                    if (Capacity == Length)
                    {
                        Capacity *= 2;
                        Array.Resize(ref dynamicArray, Capacity);
                    }
                    Array.Copy(dynamicArray, index, dynamicArray, index + 1, Length - index);
                    dynamicArray[index] = element;
                    Length++;

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        //8. Свойство Length — получение количества элементов
        public int Length { get; private set; }


        //9. Свойство Capacity — получение ёмкости: длины внутреннего массива.
        public int Capacity { get; private set; }


        //10. Методы, реализующие интерфейсы IEnumerable и IEnumerable<T>
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }
        }


        //11. Индексатор, позволяющий работать с элементом с указанным номером.
        T Indexer(int index)
        {
            return dynamicArray[index];
        }
    }
}
