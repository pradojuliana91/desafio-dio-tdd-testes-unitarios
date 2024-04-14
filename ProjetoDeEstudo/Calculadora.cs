using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeEstudo
{
    public class Calculadora
    {

        private List<string> listahistorico;
        private string data;

        public Calculadora(string data) 
        {
            listahistorico = new List<string>();
            this.data = data;
        }

        public int somar(int valor1, int valor2) 
        { 
            int resultado = valor1 + valor2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public int dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;

            listahistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
            return resultado;
        }

        public List<string> historico()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}
