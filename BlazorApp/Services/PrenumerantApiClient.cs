using System.Net.Http.Json;

public class PrenumerantApiClient
{
    private readonly HttpClient _http;

    public PrenumerantApiClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<PrenumerantDto>> GetAllAsync()
    {
        return await _http.GetFromJsonAsync<List<PrenumerantDto>>("api/prenumerant")
               ?? new List<PrenumerantDto>();
    }

    public async Task<PrenumerantDto?> GetByIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<PrenumerantDto>($"api/prenumerant/{id}");
        }
        catch
        {
            return null;
        }
    }

    public async Task<PrenumerantDto?> GetByPrenumerantnummerAsync(int nummer)
    {
        try
        {
            return await _http.GetFromJsonAsync<PrenumerantDto>($"api/prenumerant/nummer/{nummer}");
        }
        catch
        {
            return null;
        }
    }

    public async Task<PrenumerantDto?> GetByPersonnummerAsync(string personnummer)
    {
        try
        {
            return await _http.GetFromJsonAsync<PrenumerantDto>($"api/prenumerant/personnummer/{personnummer}");
        }
        catch
        {
            return null;
        }
    }

    public async Task<PrenumerantDto?> CreateAsync(PrenumerantDto dto)
    {
        var response = await _http.PostAsJsonAsync("api/prenumerant", dto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<PrenumerantDto>();
    }

    public async Task<PrenumerantDto?> UpdateAsync(int id, PrenumerantDto dto)
    {
        var response = await _http.PutAsJsonAsync($"api/prenumerant/{id}", dto);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<PrenumerantDto>();
    }
}