namespace jculcayBT2.Vistas;

public partial class Vlogin : ContentPage
{
    string usuario1;
    string contrasena1;
    public Vlogin()
	{
		InitializeComponent();
	}
    public Vlogin(string usuario, string contrasena)
    {
        InitializeComponent();
        usuario1 = usuario;
        contrasena1 = contrasena;

    }

    private void btIngresar_Clicked(object sender, EventArgs e)
    {
        /*
       // Lista de objetos para almacenar usuarios y contrase�as
       List<object> usuarios = new List<object>
       {
           new { Usuario = "usuario1", contrasena = "contrase�a1" },
           new { Usuario = "usuario2", contrasena = "contrase�a2" },
           new { Usuario = "usuario3", contrasena = "contrase�a3" }
       };

       // Acceder a los datos de la lista
       foreach (var usuario in usuarios)
       {
           // Acceder a las propiedades del objeto utilizando reflexi�n
           var nombreUsuario = usuario.GetType().GetProperty("Usuario").GetValue(usuario);
           var contrasena = usuario.GetType().GetProperty("contrasena").GetValue(usuario);
           Console.WriteLine($"Usuario: {nombreUsuario}, Contrase�a: {contrasena}");
           DisplayAlert("Alerta","usuario: "+ nombreUsuario+"\nContrase�a "+ contrasena, "cerrar"); 

       }*/

        
        string[] usuarios = new string[] { "Carlos", "Ana", "Jose" };
        string[] contrasenas = new string[] { "carlos123", "ana123", "jose123" };

        usuario1= txtUsario.Text;
        contrasena1=txtContrsena.Text;
        //DisplayAlert("Alerta", "usuario: " + usuario1 + "\nContrase�a " + contrasena1, "cerrar");

        if (usuario1 == usuarios[0] && contrasena1 == contrasenas[0])
        {

            DisplayAlert("Alerta", "Bienvenido: " + usuario1, "cerrar");

        }

        else if (usuario1 == usuarios[1] && contrasena1 == contrasenas[1])
        {

            DisplayAlert("Alerta", "Bienvenido: " + usuario1, "cerrar");

        }
        else if (usuario1 == usuarios[2] && contrasena1 == contrasenas[2])
        {

            DisplayAlert("Alerta", "Bienvenido: " + usuario1, "cerrar");

        }
        else {
            DisplayAlert("Alerta", "Usuario/Contrase�a incorrecto", "cerrar");
        }
        
        

    }
}