using dgalvezt6.Modelos;
using System.Net;

namespace dgalvezt6.Vistas;

public partial class vActualizar : ContentPage
{
    Estudiante estud;
    public vActualizar(Estudiante datos)
	{
        
		InitializeComponent();
        estud = datos;
        initializer();
	}
    private void initializer()
    {
        TxtNombre.Text = estud.nombre;
        TxtApellido.Text = estud.apellido;
        TxtEdad.Text = estud.edad.ToString() ;
        Txtcodigo.Text = estud.codigo.ToString();
    }



    private async void btnEliminar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            cliente.UploadValues("http://192.168.0.103:80/appmovil/post.php?codigo=" + Txtcodigo.Text, "DELETE", parametros);
            DisplayAlert("OK", "Registro Eliminado", "Cerrar");
            Navigation.PushAsync(new Vistas.vInicio());

        }
        catch (Exception)
        {

            DisplayAlert("Alert", "error", "Cerrar");
        }

        
    }

    private async void tnbActualizar_Clicked(object sender, EventArgs e)
	{

        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            cliente.UploadValues("http://192.168.0.103:80/appmovil/post.php?nombre=" + TxtNombre.Text + "&apellido=" + TxtApellido.Text + "&edad=" + TxtEdad.Text + "&codigo=" + Txtcodigo.Text, "PUT", parametros);
            Navigation.PushAsync(new Vistas.vInicio());
        }
        catch (Exception)
        {

            DisplayAlert("Alert", "error", "Cerrar");
        }


    }
}