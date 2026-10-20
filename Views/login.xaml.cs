using System;


namespace CLASE3.Views;

public partial class Login : Window
{
    string usuario="" , contraseña ="";
    public Login()
	{
		InitializeComponent();
	}

    public Login(string usuarioNuevo, string contraseñaNueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        contraseña = contraseñaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text ?? string.Empty;
        string contrasena = txtContraseña.Text ?? string.Empty;

        if (usuario == "admin" && contrasena == "123456" )
        {
            Application.Current?.OpenWindow(new reporte());
            Navigation.PushAsync(new reporte());
            return;
        }

        await Page.DisplayAlert(
            "Error",
            "Usuario o contraseña incorrectos",
            "Aceptar");
    }

    private void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        Application.Current?.OpenWindow(new NewWindow1());
    }
}