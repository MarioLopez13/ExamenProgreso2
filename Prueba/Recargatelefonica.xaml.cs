namespace Prueba;

public partial class Recargatelefonica : ContentPage
{
    private int count = 5;
    public Recargatelefonica()
	{
		InitializeComponent();
	}
    private void OnAmountChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            var radioButton = sender as RadioButton;
            count = int.Parse(radioButton.Value.ToString());
            lblcount.Text = $"Ha seleccionado una recarga de: {count} dólares";
        }
    }

    private async void OnRechargeClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Confirmacion", $"¿Desea recargar {count} dolares?", "Si", "No");
        if (confirm)
        {
            string phoneNumber = entnumerotelefonoML.Text;
            string operatorName = picker.SelectedItem.ToString();
            string rechargeDetails = $"Se hizo una recarga de {count} dólares en la siguiente fecha; {DateTime.Now.ToString("dd/MM/yyyy")}";
            await DisplayAlert("Finalizado", "Recarga exitosa", "OK");
        }
    }
}


