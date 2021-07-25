using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
  class Program
  {
    static void Main(string[] args)
    {
      //сумма четных элеменов массива
      Console.Write("Введите количество элементов в массиве: ");
      int length = int.Parse(Console.ReadLine());
      int[] array = new int[length];
      for (int i = 0; i < length; i++)
      {
        Console.Write("Введите " + (i + 1) + "-й элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
      }
      int sum = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 0)
        {
          sum += array[i];
        }
      }
      Console.Write("Сумма четных элементов массива: " + sum);
      Console.ReadLine();
    }
    
  }
}
