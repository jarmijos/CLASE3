namespace CLASE3.Views;

public partial class NewWindow1 : Window
{
	public NewWindow1()
	{
		InitializeComponent();
	}

    private async void Guardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text ?? string.Empty;
        string contrasena = txtContraseña.Text ?? string.Empty;

        Application.Current?.OpenWindow(new Login(usuario, contrasena));
        await Page.DisplayAlert("Alerta", "Usuario registrado exitosamente.", "Aceptar");

    }
}