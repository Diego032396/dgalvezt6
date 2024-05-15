using dgalvezt6.Modelos;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace dgalvezt6.Vistas;

public partial class vInicio : ContentPage
{
	private const string Url = "http://192.168.0.103:80/appmovil/post.php";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Estudiante> estud;
	public vInicio()
	{
		InitializeComponent();
		obtener();
	}
	public async void obtener()
	{
		var conten = await cliente.GetStringAsync(Url);
		List<Estudiante> mostrarEst = JsonConvert.DeserializeObject<List<Estudiante>>(conten);
		estud = new ObservableCollection<Estudiante>(mostrarEst);
		listaEstudiantes.ItemsSource = estud;
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
		obtener();
    }

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.vAgregar());
        
    }

    private void listaEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var objestudiante =(Estudiante)e.SelectedItem;
		Navigation.PushAsync(new Vistas.vActualizar(objestudiante));

    }
}