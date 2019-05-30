using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoQualidade.Models
{
    public class Calculadora
    {
        public int DecimalParaBinario(int numero)
        {
            if (numero == 0 || numero == 1)
                return numero;
            List<int> resto = new List<int>();
            int resultado = numero;
            while (resultado > 0)
            {
                resto.Add(resultado % 2);
                resultado /= 2;
            }
            resto.Reverse();
            return Convert.ToInt32(string.Join("", resto));
        }

        public int BinarioParaDecimal(int numero)
        {
            List<char> digitos = numero.ToString().ToCharArray().ToList();
            digitos.Reverse();
            int total = 0;
            for (var cont = 0; cont < digitos.Count(); cont++)
            {
                int n = Convert.ToInt32(digitos[cont].ToString());
                int potencia = Convert.ToInt32(Math.Pow(2, cont));
                total += (potencia * n);
            }
            return total;
        }
    }
}