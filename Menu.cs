using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Proyecto_Regex
{
    public partial class Menu : Form
    {
        List<EjercicioExpresionRegular> ejercicios;

        public Menu()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Menu_Load(object sender, EventArgs e)
        {
            ejercicios = new List<EjercicioExpresionRegular>();

            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 1", "El conjunto de todas las cadenas que coinciden con palabras que contienen exactamente tres letras.", @"[a-zA-Z]{3}"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 2", "El conjunto de todas las cadenas que coinciden con palabras que contengan solo números enteros positivos de hasta tres dígitos.", @"\b\d{1,3}\b"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 3", "El conjunto de todas las cadenas que coinciden con palabras que contengan solo direcciones de correo electrónico validas.", @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 4", "El conjunto de todas las cadenas que coinciden con palabras que contengan solo números de teléfono en formato nacional (México).", @"^\+52\d{10}$"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 5", "El conjunto de todas las cadenas que coinciden con palabras que contengan solo cadenas con 3 letras minúsculas.", @"^[a-z]{3}$"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 6", "El conjunto de todas las cadenas que coinciden con palabras que comiencen con una vocal y terminen con una consonante.", @"[aeiouAEIOU][a-zA-Z][bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 7", "El conjunto de todas las cadenas que coinciden con números decimales (positivos o negativos) con hasta dos decimales.", @"[-+]?[0-9]*\.?[0-9]{1,2}"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 8", "El conjunto de todas las cadenas que coinciden con URL's que comiencen con 'http://' o 'https://'.", @"^(http|https)://(\*)"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 9", "El conjunto de todas las cadenas que coinciden con fechas en formato 'dd/mm/aaaa'.", @"(0[1-9]|[12]\d|3[01])/(0[1-9]|1[0-2])/((19|20)\d{2})\b"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 10", "El conjunto de todas las cadenas que coinciden con palabras que contengan solo letras y números, sin espacios ni caracteres especiales.", @"\w+"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 11", "El conjunto de todas las cadenas que coinciden con palabras que comiencen con una letra mayúscula seguida de letras minúsculas.", @"[A-Z][a-z]+"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 12", "El conjunto de todas las cadenas que coinciden con cadenas que contengan exactamente cinco caracteres alfanuméricos.", @"\w{5}"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 13", "El conjunto de todas las cadenas que coinciden con palabras que contengan exactamente cuatro letras y terminen con 'ing'.", @"[a-zA-Z]{4}ing"));
            ejercicios.Add(new EjercicioExpresionRegular("Ejercicio 14", "El conjunto de todas las cadenas que coinciden con direcciones MAC en formato 'XX:XX:XX:XX:XX:XX'.", @"([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})"));

            foreach (var ejercicio in ejercicios)
            {
                comboBoxEjercicios.Items.Add(ejercicio.Nombre);
            }
        }

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCadenaAEvaluar_TextChanged(object sender, EventArgs e)
        {
            string cadenaAEvaluar = txbCadenaAEvaluar.Text;

            int indiceSeleccionado = comboBoxEjercicios.SelectedIndex;
            if (indiceSeleccionado < 0) return;
            string expresionRegular = ejercicios[indiceSeleccionado].RegexPattern;

            rbValido.Checked = Regex.IsMatch(cadenaAEvaluar, expresionRegular);
            rbValido.ForeColor = (rbValido.Checked) ? Color.Green: Color.Red ;
            rbValido.Text = (rbValido.Checked) ? "Válido": "Inválido";

        }


        private void comboBoxEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBoxEjercicios.SelectedIndex;
            if (indiceSeleccionado < 0) return;
            string descripcion = ejercicios[indiceSeleccionado].Descripcion;
            lblDescripcion.Text = descripcion;
            txbCadenaAEvaluar.Enabled = true;
        }

        private void bttLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxEjercicios.SelectedIndex = -1;
            lblDescripcion.Text = "Esperando selección...";
            rbValido.Text = "Esperando entrada";
            rbValido.ForeColor = Color.Yellow; rbValido.Checked = false;
            txbCadenaAEvaluar.Text = string.Empty;
            txbCadenaAEvaluar.Enabled = false;
        }

        private void comboBoxEjercicios_SelectedValueChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBoxEjercicios.SelectedIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < ejercicios.Count)
            {
                string descripcion = ejercicios[indiceSeleccionado].Descripcion;
                lblDescripcion.Text = descripcion;
            }
        }
    }

    class EjercicioExpresionRegular
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string RegexPattern { get; set; }

        public EjercicioExpresionRegular(string nombre, string descripcion, string regexPattern)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            RegexPattern = regexPattern;
        }
    }
}
