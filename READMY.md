# 🧪 Prueba Técnica Blazor WebAssembly

Este proyecto es el resultado de una prueba técnica que consiste en consumir una API REST protegida con token Bearer, visualizar sus datos y aplicar funcionalidades básicas de una SPA con Blazor WebAssembly (.NET 8).

---

## 🧩 Tecnologías utilizadas

- **Blazor WebAssembly (.NET 8)**
- **C#**
- **HttpClient + Token Bearer**
- **Serialización JSON**
- **Bootstrap (interfaz responsive)**
- **HTML / Razor Components**

---

## 🚀 Funcionalidades Implementadas

### 🔐 Autenticación con Token Bearer

Se configura el `HttpClient` para enviar un token Bearer en cada petición:

```csharp
_httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", Token);
    Token utilizado: ae8bad44-7348-11ee-b962-0242ac120002

    Consumo de API REST
Se realiza un GET hacia:

https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos

 Renderizado de Documentos
Los datos se muestran en una tabla en la página /documentos:




Estado (activo/inactivo)

@foreach (var doc in documentos)
{
    <tr>
        <td>@doc.Codigo</td>
        <td>@doc.Descripcion</td>
        <td>@(doc.VActiva ? "Activo" : "Inactivo")</td>
    </tr>
}

 Contador Funcional
En la ruta /counter, se encuentra un componente interactivo que incrementa un número cada vez que se hace clic en un botón.

Autor
Harvey Bernal — Desarrollador Jr.
Con pasión por aprender y seguir creciendo en el desarrollo web con .NET 