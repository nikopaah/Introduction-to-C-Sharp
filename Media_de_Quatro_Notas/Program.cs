using System;

namespace Media_de_Quatro_Notas
{
    /*  Cálculo de Média de 4 notas
        -----------
        Calculating the average of 4 grades */
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Como o C# é uma linguagem typada, nós devemos definir seu 
                  tipo logo ao definirmos as variáveis que iremos utilizar.
                -----------
                As C# is a typed language, we must define its type as soon
                  as we define the variables that we will use.
            */

            int Nota01 = 0;
            int Nota02 = 0;
            int Nota03 = 0; 
            int Nota04 = 0;

            int Media = 0;
            int Soma = 0;
            // ===================================================

            /*
                [ Dicionário de funções ] / [ Function dictionary ]

                : Console.WriteLine() 
                   -> Tudo que estiver entre parênteses será mostrado ao usuário
                   -> Everything in parentheses will be shown to the user

                : Console.SetCursorPosition(column, line)
                   -> Vai parar o cursor para o usuário digitar na coordenada inserida
                   -> Will stop the cursor for the user to type in the entered coordinate

                : Console.ReadLine()
                   -> Irá ler a próxima informação que o usuário digitar e apertar enter em seguida
                   -> It will read the next information the user types and press enter after that

                : Type.Parse()
                   -> Faz a conversão solicitada para um tipo específico
                   -> Does the requested conversion to a specific type
             */

            Console.WriteLine("Insira um valor para a Nota 01: "); // Enter a value for Grade 01:
            Console.SetCursorPosition(32, 0); 
            Nota01 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor para a Nota 02: "); // Enter a value for Grade 02:
            Console.SetCursorPosition(32, 1);
            Nota02 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor para a Nota 03: "); // Enter a value for Grade 03:
            Console.SetCursorPosition(32, 2); 
            Nota03 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor para a Nota 04: "); // Enter a value for Grade 04:
            Console.SetCursorPosition(32, 3);
            Nota04 = Int32.Parse(Console.ReadLine());
            // ===================================================

            /*  Fazemos a soma e o cáculo da média
                -----------
                We add and calculate the average */

            Soma = Nota01 + Nota02 + Nota03 + Nota04;
            Media = Soma / 4;
            // ===================================================

            /*  Mostramos ao usuário se ele repetiu por conta da nota ou não
                -----------
                We show the user if he repeated because of the grade or not */

            if (Media > 5)
            {
                Console.WriteLine("Você não reprovou :)"); // You didn't flunked :)
            }
            else {
                Console.WriteLine("Você reprovou >:("); // You flunked >:(
            }

            Console.WriteLine("Sua média foi: " + Media); // Your average was:
        }
    }
}
