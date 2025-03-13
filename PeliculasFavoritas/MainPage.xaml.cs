using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamd.ImageCarousel.Forms.Plugin.Abstractions;

namespace PeliculasFavoritas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadCarouselImages();
        }

        private void LoadCarouselImages()
        {
            // Crear una ObservableCollection de FileImageSource en lugar de List<string>
            var imageSources = new ObservableCollection<FileImageSource>();
            
            // Cargar imágenes al carrusel
            imageSources.Add(new FileImageSource { File = "img3.jpg" });
            imageSources.Add(new FileImageSource { File = "img4.jpg" });
            imageSources.Add(new FileImageSource { File = "img5.jpg" });
            imageSources.Add(new FileImageSource { File = "img6.jpg" });
            imageSources.Add(new FileImageSource { File = "img7.jpg" });
            
            imgSlider.Images = imageSources;
        }
        
        // Método para mostrar el carrusel y ocultar el WebView
        private void ShowCarousel()
        {
            imgSlider.IsVisible = true;
            streamingWebView.IsVisible = false;
            streamingWebView.Source = null; // Detener cualquier reproducción
        }
        
        // Método para mostrar el WebView y ocultar el carrusel
        private void ShowWebView(string url)
        {
            try
            {
                imgSlider.IsVisible = false;
                streamingWebView.IsVisible = true;
                
                // Crear un nuevo objeto UrlWebViewSource para asegurarnos de que se carga correctamente
                var webViewSource = new UrlWebViewSource
                {
                    Url = url
                };
                
                streamingWebView.Source = webViewSource;
                
                // Mostrar un mensaje de depuración
                DisplayAlert("Cargando sitio", $"Intentando cargar: {url}", "OK");
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error que ocurra
                DisplayAlert("Error", $"Error al cargar el sitio: {ex.Message}", "OK");
            }
        }
        
        // Manejador para el botón Home
        private void btn_home_Clicked(object sender, EventArgs e)
        {
            ShowCarousel();
        }

        // Manejadores para los botones de plataformas de streaming con URLs actualizadas
        private void btn_netflix_Clicked(object sender, EventArgs e)
        {
            ShowWebView("https://www.netflix.com/browse");
        }

        private void btn_apple_tv_Clicked(object sender, EventArgs e)
        {
            ShowWebView("https://tv.apple.com/");
        }

        private void btn_amazon_Clicked(object sender, EventArgs e)
        {
            ShowWebView("https://www.primevideo.com/-/es/offers/nonprimehomepage/ref=dv_web_force_root?language=es");
        }

        private void btn_Disney_Clicked(object sender, EventArgs e)
        {
            ShowWebView("https://www.disneyplus.com/es-do");
        }

        private void btn_HBO_Clicked(object sender, EventArgs e)
        {
            ShowWebView("https://www.max.com/do/es");
        }
        
        // Agregar evento para manejar la navegación del WebView
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            // Agregar manejador de eventos para la navegación
            streamingWebView.Navigating += (sender, e) => {
                // Mostrar un indicador de carga o mensaje
                DisplayAlert("Navegando", $"Cargando: {e.Url}", "OK");
            };
            
            streamingWebView.Navigated += (sender, e) => {
                // La página ha terminado de cargar
                DisplayAlert("Cargado", $"Sitio cargado: {e.Url}", "OK");
            };
        }
    }
}
