using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using App11.Model;

namespace App11.DataServices
{
    public class DataService
    {
        public DataService()
        {
        }


        public async Task<user> Login(string email)
        {
            HttpClient client = new HttpClient();
            
            string url = string.Format("http://slamtk1.somee.com/api/odata/UsersGet");
      
            var response = await client.GetStringAsync(url);

            var x = JsonConvert.DeserializeObject<UsersList>(response);
    
            user m = new user();

         
            m = x.Value.Find(i => i.Email == email);
        
            return m;
        }

        public async Task<List<hospital>> SearchHospital(string search)
        {
            HttpClient client = new HttpClient();

            string url = string.Format("http://slamtk1.somee.com/api/odata/HospitalsGet");
            var response = await client.GetStringAsync(url);
            var x = JsonConvert.DeserializeObject<hospitalList>(response);
            List<hospital> m = new List<hospital>();
            var s = x.value.FindAll(i => i.Name == search || i.City==search);
            m = s;
            return m;
        }

        public async Task<List<Major>> GetMajors()
        {
            HttpClient client = new HttpClient();

            string url = string.Format("http://slamtk1.somee.com/api/odata/MajorsGet");
            var response = await client.GetStringAsync(url);
            var x = JsonConvert.DeserializeObject<MajorList>(response);
            return x.value;
        }



        public async Task<List<FullDocRate>> GetDoctorRate(int doctorid)
        {
            HttpClient client = new HttpClient();


            string url = string.Format("http://slamtk1.somee.com/api/odata/DoctorCount");
            var response = await client.GetStringAsync(url);
            var x1 = JsonConvert.DeserializeObject<FullDocRateList>(response);
            List<FullDocRate> r = new List<FullDocRate>();

            var r1 = x1.value.FindAll(i => i.Doctor_ID == doctorid);
            r = r1;

            return r;
        }



        public async Task<List<FullHosRate>> GetHospitalRate(int hospitalid)
        {
            HttpClient client = new HttpClient();
           
            
            string url = string.Format("http://slamtk1.somee.com/api/odata/HospitalCount");
            var response = await client.GetStringAsync(url);
            var x1 = JsonConvert.DeserializeObject<FullHosRateList>(response);
            List<FullHosRate> r = new List<FullHosRate>();

            var r1 = x1.value.FindAll(i => i.Hospital_ID== hospitalid);
            r = r1; 
                        
            return r;
        }

        internal async Task<HospitalRate> createhosrate(HospitalRate hr1)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://slamtk1.somee.com/api/odata/HospitalRateGet");



            var json = JsonConvert.SerializeObject(hr1);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpRequestMessage h = new HttpRequestMessage();
            h.Content = content;
            h.Method = HttpMethod.Post;
            h.RequestUri = client.BaseAddress;


            HttpResponseMessage response = await client.SendAsync(h);
            if (response.IsSuccessStatusCode)
            {
                var response1 = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<HospitalRate>(response1);
                return result;
            }
            else
            {
                HospitalRate us2 = new HospitalRate()
                {   
                    Hospital_Quistions_ID = 0,
                };
                return us2;
            }
        }

        internal async Task<DoctorRate> createdocrate(DoctorRate dr1)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://slamtk1.somee.com/api/odata/DoctorRateGet");



            var json = JsonConvert.SerializeObject(dr1);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpRequestMessage h = new HttpRequestMessage();
            h.Content = content;
            h.Method = HttpMethod.Post;
            h.RequestUri = client.BaseAddress;


            HttpResponseMessage response = await client.SendAsync(h);
            if (response.IsSuccessStatusCode)
            {
                var response1 = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<DoctorRate>(response1);
                return result;
            }
            else
            {
                DoctorRate us2 = new DoctorRate()
                {
                    Doc_Quistions_ID = 0,
                };
                return us2;
            }
        }
        public async Task<user> createuser(user user1, bool isNewItem = false)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://slamtk1.somee.com/api/odata/UsersGet");



            var json = JsonConvert.SerializeObject(user1);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpRequestMessage h = new HttpRequestMessage();
            h.Content = content;
            h.Method = HttpMethod.Post;
            h.RequestUri = client.BaseAddress;


            HttpResponseMessage response = await client.SendAsync(h);
            if (response.IsSuccessStatusCode)
            {
                var response1 = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<user>(response1);
                return result;
            }
            else
            {
                user us2 = new user()
                {
                    ID = 0,
                };
                return us2;
            }

        }

        internal async Task<List<doctor>> SearchDoctor(string search)
        {
            HttpClient client = new HttpClient();

            string url = string.Format("http://slamtk1.somee.com/api/odata/DoctorsGet");
            var response = await client.GetStringAsync(url);
            var x = JsonConvert.DeserializeObject<doctorList>(response);
            List<doctor> m = new List<doctor>();
            var s = x.value.FindAll(i => i.Name == search);
            m = s;
            return m;
        }

        public async Task<hospital> createhospital(hospital hospital1)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://slamtk1.somee.com/api/odata/HospitalsGet");
            var json = JsonConvert.SerializeObject(hospital1);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpRequestMessage h = new HttpRequestMessage();
            h.Content = content;
            h.Method = HttpMethod.Post;
            h.RequestUri = client.BaseAddress;
            HttpResponseMessage response = await client.SendAsync(h);
            if (response.IsSuccessStatusCode)
            {
                var response1 = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<hospital>(response1);
                return result;
            }
            else
            {
                hospital hs2 = new hospital()
                {
                    ID = 0,
                };
                return hs2;
            }

        }

        public async Task<doctor> createdoctor(doctor doctor1)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://slamtk1.somee.com/api/odata/DoctorsGet");
            var json = JsonConvert.SerializeObject(doctor1);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpRequestMessage h = new HttpRequestMessage();
            h.Content = content;
            h.Method = HttpMethod.Post;
            h.RequestUri = client.BaseAddress;
            HttpResponseMessage response = await client.SendAsync(h);
            if (response.IsSuccessStatusCode)
            {
                var response1 = await response.Content.ReadAsStringAsync();
                doctor result = JsonConvert.DeserializeObject<doctor>(response1);
                doctor result1 = result;
                return result1;
            }
            else
            {
                doctor dc2 = new doctor()
                {
                    ID = 0,
                };
                return dc2;
            }

        }

        //  public async Task<List<UsersList>> GetDoctors(string userid)
        //{
        //  string url = string.Format("http://slamtk1.somee.com/api/odata/Deals({0})", userid);
        // var response = await client.GetStringAsync(url);
        // var x = JsonConvert.DeserializeObject<UsersList>(response);
        // return x.Value;
        // }

        //public async Task<List<todoItem>> GetTodoItemsAsync1()
        //{
        //    var response = await client.GetStringAsync("http://localhost:5000/api/todo/items");
        //    var todoItems1 = JsonConvert.DeserializeObject<List<todoItem>>(response);
        //    return todoItems1;
        //}

        ///// <summary>
        ///// Adds the todo item async.
        ///// </summary>
        ///// <returns>The todo item async.</returns>
        ///// <param name="itemToAdd">Item to add.</param>
        //public async Task<int> AddTodoItemAsync(todoItem itemToAdd)
        //{
        //    var data = JsonConvert.SerializeObject(itemToAdd);
        //    var content = new StringContent(data, Encoding.UTF8, "application/json");
        //    var response = await client.PostAsync("http://localhost:5000/api/todo/item", content);
        //    var result = JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
        //    return result;
        //}

        ///// <summary>
        ///// Updates the todo item async.
        ///// </summary>
        ///// <returns>The todo item async.</returns>
        ///// <param name="itemIndex">Item index.</param>
        ///// <param name="itemToUpdate">Item to update.</param>
        //public async Task<int> UpdateTodoItemAsync(int itemIndex, todoItem itemToUpdate)
        //{
        //    var data = JsonConvert.SerializeObject(itemToUpdate);
        //    var content = new StringContent(data, Encoding.UTF8, "application/json");
        //    var response = await client.PutAsync(string.Concat("http://localhost:5000/api/todo/", itemIndex), content);
        //    return JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
        //}

        ///// <summary>
        ///// Deletes the todo item async.
        ///// </summary>
        ///// <returns>The todo item async.</returns>
        ///// <param name="itemIndex">Item index.</param>
        //public async Task DeleteTodoItemAsync(int itemIndex)
        //{
        //    await client.DeleteAsync(string.Concat("http://localhost:5000/api/todo/", itemIndex));
        //}
    }
}
