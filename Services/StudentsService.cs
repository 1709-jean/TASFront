using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public class StudentsService : IStudentsServices
    {
        private HttpClient _httpClient;

        public StudentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Students>> GetAll()
        {
            var results = await  _httpClient.GetFromJsonAsync<IEnumerable<Students>>("api/Student");
            return results;
        }

        public async Task<Students> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Students>($"api/Student/{id}");
            return result;
        }
        //

         public async Task<Students> Update(int id, Students Student)
        {
           var response = await _httpClient.PutAsJsonAsync($"api/Student/{id}",Student);
           if(response.IsSuccessStatusCode){
           return await JsonSerializer.DeserializeAsync<Students>(await response.Content.ReadAsStreamAsync());
           }
           else {
               throw new Exception("Tidak Bisa Update Daftar Siswa");
           }
        }


         public async Task<Students> Add(Students obj){
            var response = await _httpClient.PostAsJsonAsync($"api/Student",obj);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Students>(
                    await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("Gagal Tambah Data Employee");
            }
        }


        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"api/Student/{id}");
        }
    }
}