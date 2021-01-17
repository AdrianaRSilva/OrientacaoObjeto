using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjeto
{
    class Triangulo
    {
        //Entrada de dados
        public double A;
        public double B;
        public double C;

        //Função area
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz =Math.Sqrt(p *(p-A) * (p-B) * (p-C));
            return raiz
        }

    }
}
