using BlazorApp1.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace BlazorApp1.Services
{
    public class DocumentoService
    {
        private readonly HttpClient _httpClient;
        private const string Token = "ae8bad44-7348-11ee-b962-0242ac120002";
        private const string ApiUrl = "https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/DocumentosFillsCombos";

        public DocumentoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Documento>> ObtenerDocumentosAsync()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, ApiUrl);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"📦 JSON recibido: {json}");

                var documentos = JsonSerializer.Deserialize<List<Documento>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return documentos ?? new List<Documento>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al obtener documentos: {ex.Message}");
                return new List<Documento>();
            }
        }
    }
}
