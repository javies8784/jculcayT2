namespace jculcayBT2.Vistas;

public partial class CalculoNotas : ContentPage
{
	public CalculoNotas()
	{
		InitializeComponent();
	}

    private void btLimpiar_Clicked(object sender, EventArgs e)
    {
        txtSeguimientoP1.Text = "";
        txtSeguimientoP2.Text = "";
        txtExamenP1.Text = "";
        txtExamenP2.Text = "";
        notaP1.Text = "";
        notaP2.Text = "";
        pkEstudiantes.SelectedIndex = -1;


        

    }

    private void btCalulo_Clicked(object sender, EventArgs e)
    {
        string estudiante = " ";
        if (pkEstudiantes.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un estudiante", "Cerrar");

        }
        else
        {
            estudiante = pkEstudiantes.Items[pkEstudiantes.SelectedIndex].ToString();

        }

        double Nsg1 = double.Parse(txtSeguimientoP1.Text) * 0.3;
        double Nex1 = double.Parse(txtExamenP1.Text) * 0.2;
        double nota1 = Nsg1 + Nex1;

        double Nsg2 = double.Parse(txtSeguimientoP2.Text) * 0.3;
        double Nex2 = double.Parse(txtExamenP2.Text) * 0.2;
        double nota2 = Nsg2 + Nex2;

        double notaf = nota1 + nota2;

        notaP1.Text = nota1.ToString("N2");
        notaP2.Text = nota2.ToString("N2");
        string estado = " ";
        string fecha = DateTime.Now.ToShortDateString();

        if (notaf >= 7)
        {
            estado = "APROBADO";
        }
        if (notaf >= 5 && notaf <= 6.9)
        {
            estado = "COMPLEMENTARIO";

        }
        if (notaf < 5)
        {
            estado = "REPROBADO";

        }

        DisplayAlert("Alerta", "Nombre: " + estudiante + "\nFecha: " + fecha + "\nNota Parcial 1: " + nota1.ToString("N2") + "\nNota Parcial 2: " + nota2.ToString("N2") + "\nNota Final: " + notaf.ToString("N2") + "\nEstado: " + estado, "cerrar");


    }
}