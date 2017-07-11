using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            Console.Write("Введите строку:\n");
            m = Console.ReadLine();

            int gl, sgl, dig, lt;
            gl = sgl = dig = lt = 0;

            for(int i=0;i<m.Length;i++)
            {
                if (char.IsLetter(m[i]))
                {
                    if ((m[i] > 64 && m[i] < 91) || (m[i] > 96 && m[i] < 123))
                    {
                        Console.Write("Присутствует латиница!\n");
                        Console.ReadKey();
                        return;
                    }
                    if (char.ToLower(m[i]) == 'а' || m[i] == 'е' || m[i] == 'ё' || m[i] == 'и' || m[i] == 'о')
                    {
                        gl++;
                    }
                    else if (char.ToLower(m[i]) == 'у' || m[i] == 'ы' || m[i] == 'э' || m[i] == 'ю' || m[i] == 'я')
                    {
                        gl++;
                    }
                    else
                        sgl++;
                }
                else if (char.IsDigit(m[i]))
                    dig++;
                else if (char.IsPunctuation(m[i]))
                    lt++;
                
            }

            Console.Write("Гласных: {0}, согласных: {1}, цифр: {2}, знаков препинания: {3}\n", gl, sgl, dig, lt);

            Console.ReadKey();
        }
    }
}
