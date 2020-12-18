using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1_LISTA_1_V2
{
    class Retangulo
    {
        #region Atributos
        private double basE;
        private double altura;
        private double area;
        #endregion;
        #region Construtores
        public Retangulo() 
        {
            basE = 0;
            altura = 0;
            calcularArea();
        }
        public Retangulo(double basE,double altura)
        {
            this.basE = basE;
            this.altura = altura;
            calcularArea();
        }
        #endregion
        #region set e gets
        public void setBase(double basE)
        {
            this.basE = basE;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getBase()
        {
            return basE;
        }
        public double getAltura()
        {
            return altura;
        }
        public double getArea()
        {
            return area;
        }
        #endregion
        #region metodos
        public void calcularArea()
        {
            area = basE * altura;
        }
        #endregion
    }
}
