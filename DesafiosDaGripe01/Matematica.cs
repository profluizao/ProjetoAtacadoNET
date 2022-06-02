using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosDaGripe01
{
    public static class Matematica
    {
        /// <summary>
        /// 1.1 - Desenvolva um método genérico que realize a operação matemática entre dois números e retorne o resultado. 
        /// A operação e os dois números devem ser passados por parâmetro no método.
        /// </summary>
        public static int Exercicio11(OperacaoEnum operacao, int num1, int num2) 
        {
            int result = 0;
            switch (operacao)
            {
                case OperacaoEnum.Adicao:
                    result = num1 + num2;
                    break;
                case OperacaoEnum.Divisao:
                    result = num1 / num2;
                    break;
                case OperacaoEnum.Multiplicacao:
                    result = num1 * num2;
                    break;
                case OperacaoEnum.Subtracao:
                    result = num1 - num2;
                    break;
            }
            return result;
        }

        /// <summary>
        /// 1.2 - Desenvolva um método genérico que calcule e retorne o volume de uma caixa d'água retangular. 
        /// Os valores devem ser passados por parâmetro no método.
        /// </summary>
        public static double Exercicio12(double comprimento, double largura, double altura)
        {
            return comprimento * largura * altura;
        }

        /// <summary>
        /// 1.3 - Desenvolva um método genérico que calcule e retorne o volume de um Cilindro qualquer. 
        /// Os valores devem ser passados por parâmetro no método.
        /// </summary>
        public static double Exercicio13(double raio, double altura)
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }

        /// <summary>
        /// 1.4 - Desenvolva um método genérico que calcule e retorne o volume de uma esfera. 
        /// Os valores devem ser passados por parâmetro no método.
        /// </summary>
        public static double Exercicio14(double raio)
        {
            return (4 * Math.PI * Math.Pow(raio, 3)) / 3;
        }
    }
}
