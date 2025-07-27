# BlazorApp1

Este es un proyecto frontend construido con **Blazor WebAssembly (.NET 8)** que demuestra el uso de componentes interactivos, estilos personalizados dinámicos y una arquitectura lista para integrarse con APIs REST.

## 🚀 Características

- ✅ Interfaz moderna con soporte para **cambio de temas (Oscuro y Rojo)** dinámico usando **JS interop**.
- ✅ Estructura modular con componentes Blazor (`MainLayout`, `NavMenu`, etc.).
- ✅ Navegación SPA con enrutamiento controlado desde `App.razor`.
- ✅ Personalización de estilos vía CSS (`theme.css`, `app.css`) para mejorar la experiencia visual.
- ✅ Integración con **GitHub** para control de versiones y trabajo colaborativo.
- ✅ Código limpio, mantenible y con buen soporte para escalabilidad.

## 🎨 Temas disponibles

Utilizando botones de cambio de tema, el usuario puede alternar entre:

- **Tema Oscuro:** fondo negro con texto claro.
- **Tema Rojo:** fondo rojo oscuro con texto contrastado.

Esto se logra usando clases CSS aplicadas dinámicamente mediante JS desde Blazor (`IJSRuntime`).

## 🧱 Estructura del Proyecto

