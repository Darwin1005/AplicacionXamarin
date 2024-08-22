using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciclaPeru.vISTAS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void ingresar_Clicked(object sender, EventArgs e)
        {

        }

        private async void registrarse_Clicked(object sender, EventArgs e)
        {
            // Crea una instancia de la página a la que deseas navegar
            var registroPage = new registro();

            // Usa el objeto Navigation para navegar a la nueva página
            await Navigation.PushAsync(registroPage);
        }
    }
}