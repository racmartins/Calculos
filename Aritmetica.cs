using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculos { 
    /// <summary>
    /// Implementa operações aritméticas.
    /// </summary>   
    
    internal static class Aritmetica
    {    
        /// <summary>
        /// Operação soma.
        /// </summary>
        /// <returns>Retorna a soma de dois números.</returns>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação subtração.
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        /// <summary>
    /// Tipo de conversão de temperatura a executar.
    /// </summary>
    public static enum ConversaoTemperatura
    {
        Nulo = 0,
        CelsiusFahrenheit,
        FahrenheitCelsius
    }
    public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
    {
        if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
        {
            return (temperatura * 1.8000 + 32);
        }
        else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
        {
            return ((temperatura - 32) / 1.8000);
        }

        return -1;
    }

    }
}
