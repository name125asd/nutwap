using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace nutwap
{
    public partial class nutloginWebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            string getUser = username.Text;
            string getPass = password.Text;
            string dataReturn = apitest(getUser, getPass);
            Response myObject = JsonConvert.DeserializeObject<Response>(dataReturn);

            name.Text = myObject.name;
            age.Text = myObject.age.ToString();
            email.Text = myObject.email;
            string test = myObject.address.ToString();
            address.Text = JsonConvert.SerializeObject(myObject.address);





        }
        public string apitest(string user, string pass)
        {
            

            string data = "";


            var requestData = new
            {
                user = user,
                pass = pass,

            };

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://localhost:44392/api/User"; // เปลี่ยน URL ของ API ตามที่คุณต้องการ

                // สร้าง JSON จากข้อมูล requestData
                string jsonData = JsonConvert.SerializeObject(requestData);
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                     data = response.Content.ReadAsStringAsync().Result;
                    // ทำงานกับ JSON ที่ได้รับจาก API
                }
                else
                {
                    // การดำเนินการเมื่อร้อยอาร์เควสต์ไม่สำเร็จ
                }
            } // HttpClient จะถูกปลดล็อกที่นี่และทรัพยากรถูกปลดล็อกโดยอัตโนมัติ

            return data;

        }


    }
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
    }

    public class Response
    {
        public string name { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public string email { get; set; }
        public bool is_student { get; set; }
    }

}