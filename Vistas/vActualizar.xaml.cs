using dgalvezt6.Modelos;
using System.Net;

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

    private async void btnEliminar_Clicked(object sender, EventArgs e)
    {


        Navigation.PushAsync(new Vistas.vInicio());
    }

    private async void tnbActualizar_Clicked(object sender, EventArgs e)
	{

        Navigation.PushAsync(new Vistas.vInicio());

    }
}