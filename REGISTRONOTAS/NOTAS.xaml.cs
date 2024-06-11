namespace JPEDRAZAT2.REGISTRONOTAS;

public partial class NOTAS : ContentPage
{
	public NOTAS()
	{
		InitializeComponent();
	}
    private void OnCalculateButtonClicked(object sender, EventArgs e)
    {
        try
        {
            // Obtener valores de entrada
            string nombre = StudentPicker.SelectedItem?.ToString();
            double notaSeguimiento1 = Convert.ToDouble(NotaSeguimiento1Entry.Text);
            double examen1 = Convert.ToDouble(Examen1Entry.Text);
            double notaSeguimiento2 = Convert.ToDouble(NotaSeguimiento2Entry.Text);
            double examen2 = Convert.ToDouble(Examen2Entry.Text);
            DateTime fecha = FechaDatePicker.Date;

            // Calcular notas parciales y nota final
            double notaParcial1 = (notaSeguimiento1 * 0.3) + (examen1 * 0.2);
            double notaParcial2 = (notaSeguimiento2 * 0.3) + (examen2 * 0.2);
            double notaFinal = notaParcial1 + notaParcial2;

            // Determinar el estado
            string estado;
            if (notaFinal >= 7)
            {
                estado = "Aprobado";
            }
            else if (notaFinal >= 5)
            {
                estado = "Complementario";
            }
            else
            {
                estado = "Reprobado";
            }

            // Mostrar resultado en un DisplayAlert
            string resultado = $"Nombre: {nombre}\n" +
                               $"Fecha: {fecha.ToShortDateString()}\n" +
                               $"Nota Parcial 1: {notaParcial1:F2}\n" +
                               $"Nota Parcial 2: {notaParcial2:F2}\n" +
                               $"Nota Final: {notaFinal:F2}\n" +
                               $"Estado: {estado}";

            DisplayAlert("Resultado", resultado, "OK");
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", "Por favor, ingrese valores válidos en todos los campos.", "OK");
        }
    }
}
