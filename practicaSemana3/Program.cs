using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaSemana3
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            loopwhile();
            Console.ReadKey();
        }

        //while
        //evalua la condicion y ejecuta las intrucciones 
        //si la condicion es verdadera 

        public static void loopwhile() {
            int[] nums = new int[3]; //crear un arreglo 

            //llenar arreglo 
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            //imprimir los numeros utilizando while 
            int i = 0;
            while(i < nums.Length)
            {
                Console.WriteLine("Indice {0}: {1}",i,nums[i]);
                i++;
            }

        }
}
}
