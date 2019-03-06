/* PROBLEM: 
 * Fizz Buzz - Write a program that prints the numbers from 1 to 100. 
 * But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
 * For numbers which are multiples of both three and five print “FizzBuzz”. 
 * 
 * 
 */

using System;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uma nova instancia da classe para poder usar os outros métodos
            //não se pode usar "this" dentro de um método static
            Program FB = new Program();
            FB.FizzBuzz();
        }

        /*
         * cria o loop para fazer a contagem e chama o método verificaMultiplo
         */
        public void FizzBuzz()
        {
            int count = 1;

            while(count < 101)
            {
                Console.WriteLine(this.VerificaMultiplo(count));
                count++;
            }
            
        }

        /*
         * verifica se o número é múltiplo de 3, de 5, de ambos ou de nehum dos dois 
         * e retorna um valor diferente para cada caso
         *  
         */
        private String VerificaMultiplo(int numero)
        {
            /* o resto da divisão por 3 sendo zero indica um número múltiplo de 3
             * o resto da divisão por 5 sendo zero indica um número múltiplo de 5
             */
            if (numero%3 == 0 && numero%5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                if(numero%3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    if (numero % 5 == 0)
                    {
                        return "Buzz";
                    }
                    else
                    {
                        return numero.ToString();
                    }
                }
            }
        }

    }
}
