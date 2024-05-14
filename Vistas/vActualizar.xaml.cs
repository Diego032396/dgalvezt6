using dgalvezt6.Modelos;

namespace dgalvezt6.Vistas;

public partial class vActualizar : ContentPage
{
	public vActualizar(Estudiante datos)
	{
		InitializeComponent();
        TxtNombre.Text= datos.ToString();
        TxtApellido.Text= datos.ToString();
        TxtEdad.Text= datos.ToString();
	}

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {

    }

    private void tnbActualizar_Clicked(object sender, EventArgs e)
    {

    }
}