using Android.Content;
using PeliculasFavoritas.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(WebView), typeof(CustomWebViewRenderer))]
namespace PeliculasFavoritas.Droid.Renderers
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        public CustomWebViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Settings.JavaScriptEnabled = true;
                Control.Settings.DomStorageEnabled = true;
                Control.Settings.DatabaseEnabled = true;
                Control.Settings.AllowFileAccess = true;
                Control.Settings.AllowContentAccess = true;
                Control.Settings.LoadsImagesAutomatically = true;
                Control.Settings.MixedContentMode = Android.Webkit.MixedContentHandling.AlwaysAllow;
                Control.Settings.UserAgentString = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";
            }
        }
    }
}
