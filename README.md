# Proyecto Películas Favoritas en Xamarin Forms

Este proyecto es una aplicación móvil desarrollada en Xamarin Forms que muestra un carrusel de imágenes de películas favoritas y permite navegar a diferentes plataformas de streaming a través de una barra de navegación inferior.

## Características

- Carrusel de imágenes a pantalla completa con películas favoritas
- WebView mejorado para reproducir contenido de plataformas de streaming directamente en la app
- Barra de navegación inferior con iconos de plataformas de streaming
- Navegación a plataformas de streaming con URLs actualizadas:
  - Netflix: https://www.netflix.com/browse
  - Apple TV: https://tv.apple.com/
  - Amazon Prime: https://www.primevideo.com/-/es/offers/nonprimehomepage/ref=dv_web_force_root?language=es
  - Disney+: https://www.disneyplus.com/es-do
  - HBO Max: https://www.max.com/do/es
- Botón Home para volver al carrusel de imágenes
- Interfaz de usuario atractiva y responsive
- Nombre personalizado: Victor A. Quezada 23-EIST-8-001
- Colores personalizados para cada plataforma

## Requisitos

- Visual Studio 2019 o superior con Xamarin instalado
- .NET Framework
- Paquete NuGet: Xamd.ImageCarousel.Forms.Plugin

## Instalación

1. Clona este repositorio
2. Abre la solución en Visual Studio
3. Restaura los paquetes NuGet
4. Instala el paquete Xamd.ImageCarousel.Forms.Plugin desde el administrador de paquetes NuGet
5. Compila y ejecuta la aplicación

## Estructura del Proyecto

- **PeliculasFavoritas**: Proyecto compartido con la lógica y UI
- **PeliculasFavoritas.Android**: Proyecto específico para Android
- **PeliculasFavoritas.iOS**: Proyecto específico para iOS

## Solución de problemas con WebView

Si experimentas problemas con el WebView:

1. Asegúrate de que la aplicación tiene permisos de Internet
2. Verifica que los sitios web no estén bloqueando la visualización en WebView
3. Algunos sitios de streaming pueden requerir autenticación o tener restricciones para ser mostrados en WebViews
4. Los mensajes de alerta te ayudarán a diagnosticar problemas de carga

## Instrucciones de Uso

1. Al iniciar la aplicación, verás un carrusel de imágenes de películas a pantalla completa
2. Desliza horizontalmente para navegar por las imágenes
3. Utiliza los botones en la barra inferior para acceder a las diferentes plataformas de streaming
4. El contenido de las plataformas se cargará directamente en la aplicación a través del WebView
5. Utiliza el botón Home para volver al carrusel de imágenes
