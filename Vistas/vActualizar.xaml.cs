using dgalvezt6.Modelos;

namespace dgalvezt6.Vistas;

public partial class vActualizar : ContentPage
{
	public vActualizar(Estudiante datos)
	{
		InitializeComponent();
        TxtNombre.Text= datos.nombre.ToString();
       TxtApellido.Text= datos.apellido.ToString();
       TxtEdad.Text= datos.edad.ToString();
	}

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {


    }

    private void tnbActualizar_Clicked(object sender, EventArgs e)
    {

    }
}