using System;

namespace calculoGotejamento
{
    class Program
    {
        static void Main(string[] args)
        {
            float volume;
            float tempo;
            float micro;
            float macro;
            float resultadoMicro;
            float resultadoMacro;

            Console.WriteLine("Cálculo de gotejamento por hora.");
            Console.WriteLine("Entre com o volume total em ml.");
            volume = float.Parse( Console.ReadLine());
            if ( volume <= 0)
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Fechando aplicativo...");
                Environment.Exit(0);
            }
            Console.WriteLine("Entre com o tempo total em horas.");
            tempo = float.Parse( Console.ReadLine());
            if (volume <= 0)
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Fechando aplicativo...");
                Environment.Exit(0);
            }

            //calculation result

            resultadoMacro = calculoMacro( volume, tempo );
            resultadoMicro = calculoMicro( volume, tempo );

            Console.WriteLine($"Macrogotas: {resultadoMacro} gotas por minuto.");
            Console.WriteLine($"Microgotas: {resultadoMicro} microgotas por minuto.");

            //métodos
            float calculoMacro(float volumeml, float tempohora )
            {
                macro = volumeml / (tempohora * 3);
                return macro;
            }

            float calculoMicro(float volumeml2, float tempohora2 )
            {
                micro = volumeml2 / tempohora2;
                return micro;
            }
        }
    }
}
