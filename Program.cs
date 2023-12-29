using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12;
            Math(ref number);
            Console.WriteLine(number);
            int[] array = { 2, 5, 8, 9 };
            KvadrataYukselt(ref array);
            Console.WriteLine(array);
            string str = "Hikmet Abbasov";
            BosluquSil(ref str);
            Console.WriteLine(str);
        }

        //Verilmiş ədədi kvadratına yüksəldən metod. (Metodu cağırdıqdan sonra variable kvadratına yüksəlmiş olmalıdı)

        static void  Math( ref int number)
        {
            number *= number;
            
            
        }

        //Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yüksəlmiş array-ə çevirən metod
        static void KvadrataYukselt(ref int[] array)
        {
           for(int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }
        }




        //Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
        static void BosluquSil(ref string str)
        {
            string newStr = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i]!=' ')
                {
                    newStr += str[i];
                }
                
            }
            str = newStr;
        }


        //Parameter olaraq integer array variable-i ve bir integer value qebul eden 
        //ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.


        static void Add(ref int[] array, int number)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for(int i = 0; i < array.Length; i++)
            {
                newArray[index] = array[i];
                index++;
            }
            array = newArray;
        }
    }
}
