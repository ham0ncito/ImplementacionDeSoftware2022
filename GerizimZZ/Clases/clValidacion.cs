using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace GerizimZZ.Clases
{
    internal class clValidacion
    {
        public void validacionTexto(TextBox texto, int NumeroMinimo, int NumeroMaximo, int ValoresRepetidos, bool noAceptaNumeros)
        {
            var comparador = StringComparer.InvariantCultureIgnoreCase;
            if (texto.Text.Length < NumeroMinimo || string.IsNullOrEmpty(texto.Text))
            {
                MessageBox.Show("Valor ingresado es menor al limite permitido de " + NumeroMinimo + " Caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valtxt(texto);
            }
            if (texto.Text.Length > NumeroMaximo)
            {
                MessageBox.Show("Valor ingresado es mayor al limite permitido de " + NumeroMaximo + " Caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valtxt(texto);
            }
    
            int contador = 0;
            string copiaText = texto.Text.ToLower();
            for (int i = 1; i < copiaText.Length; i++)
            {
                if (string.Equals(copiaText.Substring(i, 1), copiaText.Substring((i - 1), 1)) && copiaText.Length > 1)
                {
                    contador += 1;
                }

            }
            if (contador > ValoresRepetidos)
            {
                MessageBox.Show("Valores ingresados superan el maximo de valores repetidos #" + ValoresRepetidos + " Hay " + contador + " valores repetidos continuamente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valtxt(texto);
            }
            if(Regex.IsMatch(texto.Text, @"^[0-9]+$") && noAceptaNumeros)
            {
                MessageBox.Show("No se aceptan numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valtxt(texto);
            }
            if (Regex.IsMatch(texto.Text, @"^[0-9]+$") && !noAceptaNumeros)
            {
                MessageBox.Show("IngreseNumeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valtxt(texto);
            }



        }
            public void validacionNumero(string text, int numeroMinimo, int NumeroMaximo, int ValoresReptidos)
            {

            }
        public void valtxt(TextBox texto)
        {
            texto.Clear();
            texto.Focus();
        }
    }
}
