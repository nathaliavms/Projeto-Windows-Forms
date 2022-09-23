using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CalcularNotas
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public CalcularNotas(double nota1, double nota2, double nota3, double nota4)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
        }

        public double MaiorValor()
        {
            if (Nota1 > Nota2 && Nota1 > Nota3 && Nota1 > Nota4)
            {
                return Nota1;
            }
            else if (Nota2 > Nota3 && Nota2 > Nota4)
            {
                return Nota2;
            }
            else if (Nota3 > Nota4)
            {
                return Nota3;
            }
            else
            {
                return Nota4;
            }
        }
        public double MenorValor()
        {
            if (Nota1 < Nota2 && Nota1 < Nota3 && Nota1 < Nota4)
            {
                return Nota1;
            }
            else if (Nota2 < Nota3 && Nota2 < Nota4)
            {
                return Nota2;
            }
            else if (Nota3 < Nota4)
            {
                return Nota3;
            }
            else
            {
                return Nota4;
            }
        }

        public double Media()
        {
             var calculo = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return calculo;
        }
        public double SomarPares()
        {
            double resultadopar1 = 0;
            double resultadopar2 = 0;
            double resultadopar3 = 0;
            double resultadopar4 = 0;
            double soma;
            if (Nota1 % 2 == 0 )
            {
                resultadopar1 = Nota1;
            }
            if (Nota2 % 2 == 0)
            {
                resultadopar2 = Nota2;
            }
            if (Nota3 % 2 == 0)
            {
                resultadopar3 = Nota3;
            }
            if (Nota4 % 2 == 0)
            {
                resultadopar4 = Nota4;
            }
            soma = resultadopar1 + resultadopar2 + resultadopar3 + resultadopar4;
            return soma;
        }
        public double SomarImpares()
        {
            double resultadoimpar1 = 0;
            double resultadoimpar2 = 0;
            double resultadoimpar3 = 0;
            double resultadoimpar4 = 0;
            double soma;
            if (Nota1 % 2 != 0)
            {
                resultadoimpar1 = Nota1;
            }
            if (Nota2 % 2 != 0)
            {
                resultadoimpar2 = Nota2;
            }
            if (Nota3 % 2 != 0)
            {
                resultadoimpar3 = Nota3;
            }
            if (Nota4 % 2 != 0)
            {
                resultadoimpar4 = Nota4;
            }
            soma = resultadoimpar1 + resultadoimpar2 + resultadoimpar3 + resultadoimpar4;
            return soma;
        }
        public double NotasMaior7()
        {
            double count = 0;

            if (Nota1 >= 7)
            {
                count++;
            }
            if (Nota2 >= 7)
            {
                count++;
            }
            if (Nota3 >= 7)
            {
                count++;
            }
            if (Nota4 >= 7)
            {
                count++;
            }
            return count++;
        }
    }
}
