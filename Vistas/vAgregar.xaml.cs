using System.Net;

namespace dgalvezt6.Vistas;

public partial class vAgregar : ContentPage
{
	public vAgregar()
	{
		InitializeComponent();
	}

    private void btnGuardad_Clicked(object sender, EventArgs e)
    {
		try
		{
			WebClient cliente = new WebClient();
			var parametros = new System.Collections.Specialized.NameValueCollection();
			parametros.Add("nombre", TxtNombre.Text);
			parametros.Add("apellido",TxtApellido.Text);
			parametros.Add("edad",TxtEdad.Text);
			cliente.UploadValues("http://192.168.0.103:80/appmovil/post.php", "POST", parametros);
			Navigation.PushAsync(new vInicio());

		}
		catch (Exception)
		{

			DisplayAlert("","", "");
		}
    }
}