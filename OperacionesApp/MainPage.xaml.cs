using Microsoft.Maui.Controls;

namespace OperacionesApp
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Lógica para la pestaña de Suma
        private void Sumar_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valorsuma1.Text) || string.IsNullOrWhiteSpace(valorsuma2.Text) || string.IsNullOrWhiteSpace(valorsuma3.Text))
            {
                DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }
            if (EsNumero(valorsuma1.Text) && EsNumero(valorsuma2.Text) && EsNumero(valorsuma3.Text))
            {
                // Realizar la operación de suma
                double resultado = double.Parse(valorsuma1.Text) + double.Parse(valorsuma2.Text) + double.Parse(valorsuma3.Text);
                resultadoSuma.Text = $"Resultado: {resultado}";
            }
            else
            {
                DisplayAlert("Error", "Ingrese valores numéricos válidos", "OK");
            }
           
        }

        // Lógica para la pestaña de Resta
        private void Resta_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valorresta1.Text) || string.IsNullOrWhiteSpace(valorresta2.Text))
            {
                DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }
            if (EsNumero(valorresta1.Text) && EsNumero(valorresta2.Text))
            {
                // Realizar la operación de la resta
                double resultado = double.Parse(valorresta1.Text) - double.Parse(valorresta2.Text) ;
                resultadoResta.Text = $"Resultado: {resultado}";
            }
            else
            {
                DisplayAlert("Error", "Ingrese valores numéricos válidos", "OK");
            }

        }

        // Lógica para la pestaña de Multiplicación
        private void Multiplicacion_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valor1.Text) || string.IsNullOrWhiteSpace(valor2.Text) || string.IsNullOrWhiteSpace(valor3.Text))
            {
                DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }
            if (EsNumero(valor1.Text) && EsNumero(valor2.Text) && EsNumero(valor3.Text))
            {
                // Realizar la operación de multiplicacion
                double resultado = double.Parse(valor1.Text) * double.Parse(valor2.Text) * double.Parse(valor3.Text);
                resultadoMultilplicacion.Text = $"Resultado: {resultado}";
            }
            else
            {
                DisplayAlert("Error", "Ingrese valores numéricos válidos", "OK");
            }
        }


        // Lógica para la pestaña de División
        private void Division_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valordivi1.Text) || string.IsNullOrWhiteSpace(valordivi2.Text))
            {
                DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
                return;
            }
            if (EsNumero(valordivi1.Text) && EsNumero(valordivi2.Text))
            {
                // Realizar la operación de la División
                if (double.Parse(valordivi2.Text) == 0)
                {
                    DisplayAlert("Error", "No se puede dividir entre cero", "OK");              
                }
                else
                {
                    double resultado = double.Parse(valordivi1.Text) / double.Parse(valordivi2.Text);
                    resultadoDivision.Text = $"Resultado: {resultado}";
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese valores numéricos válidos", "OK");
            }
        }

        private bool EsNumero(string texto)
        {
            return double.TryParse(texto, out _);
        }

        // Lógica para el botón de Limpiar
        private void Limpiar_Clicked(object sender, System.EventArgs e)
        {
            valorsuma1.Text = valorsuma2.Text = valorsuma3.Text = valorresta1.Text = valorresta2.Text = valor1.Text= valor2.Text= valor3.Text=valordivi1.Text = valordivi2.Text = ""; 
            resultadoSuma.Text = resultadoResta.Text= resultadoMultilplicacion.Text  = resultadoDivision.Text = "";
        }
    }
}
