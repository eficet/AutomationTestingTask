using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp.Authenticators;
using System.Linq;
//using NUnit.Framework;

namespace UnitTest.GetRequest
{
    [TestClass]
    public class UnitTest1
    {
        string id1 = "";
        string id2 = "";
       static string letters = "aqwertyuioplkjhgfdsazxcvbnmMNBVCXZASDFGHJKLPOIUYTREWQ123456789";
       static  Random  rand = new Random();
       string input1 = new string(Enumerable.Repeat(letters, 5).Select(s => s[rand.Next(s.Length)]).ToArray());
        string input2 = new string(Enumerable.Repeat(letters, 5).Select(s => s[rand.Next(s.Length)]).ToArray());

        public const String baseurl = "http://test.p3rsonal.com/api";

        [TestMethod]
        public void Genereted_Testing_POST_Usernameand_and_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", input1, input2);
            id1 = test;
            Assert.IsNotNull(test);

            Console.WriteLine("The returned id is :" + id1);
        }

        [TestMethod]
        public void Testing_POST_Usernameand_and_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "userrrrr", "1234");
            id1 = test;
            Assert.IsNotNull(test);

            Console.WriteLine("The returned id is :" + id1);
        }

        [TestMethod]

        public void Testing_POST_With_SAME_UsernameandPassword()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hajmo2", "1234");
            var test2 = object1.RRestsharpPOST(baseurl + "/users", "hajmo2", "1234");
            id1 = test;
            Assert.IsNotNull(test2);
             
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]

        public void generatedTesting_POST_With_SAME_UsernameandPassword()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", input1, input1);
            var test2 = object1.RRestsharpPOST(baseurl + "/users", input1, input2);
            id1 = test;
            Assert.IsNotNull(test2);

            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void Testing_POST_With_Usernameand_NoPassword()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hajmo4", "ss");
            id1 = test;
            Assert.IsNotNull(test);
             id1 = test;
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void Testing_POST_NO_Usernameand_with_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "", "1234");
            id1 = test;
            Assert.IsNotNull(test);
             
            Console.WriteLine("The returned id is :" + id1);
        }
     
        [TestMethod]
        public void Testing_POST_same_Usernameand_diff_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "12", "1234");
            var test1 = object1.RRestsharpPOST(baseurl + "/users", "12", "12345");
            id1 = test;
            Assert.IsNotNull(test1);
             
           // object1.id1 = test;
          // var test3= object1.RRestsharpDELETE(baseurl + "/users/1774");
            Console.WriteLine("The returned id is :" +test);
        }

        [TestMethod]
        public void Testing_POST_Username_CaseSensitive()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "faizz12", "1234");
            var test1 = object1.RRestsharpPOST(baseurl + "/users", "Faizz12", "1234");
            id1 = test;
            id2 = test1;
            Assert.IsNotNull(test1);

            // object1.id1 = test;
            // var test3= object1.RRestsharpDELETE(baseurl + "/users/1774");
            Console.WriteLine("The returned id is :" + test);
        }

        [TestMethod]
        public void Testing_PUT_new_UsernameandPassword_with_existing_id()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id2 = test;
            var test2 = object1.RRestsharpPUT(baseurl + "/users/"+id2, "hese2", "12343");
            Assert.IsNotNull(test2);
            id1 = test;
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void GeneratedTesting_PUT_new_UsernameandPassword_with_existing_id()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id2 = test;
            var test2 = object1.RRestsharpPUT(baseurl + "/users/" + id2, input1, input2);
            Assert.IsNotNull(test2);
            id1 = test;
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void Testing_PUT_same_UsernameandPassword_with_existing_id()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpPUT(baseurl + "/users/" +id1, "hese", "1234");
            Assert.IsNotNull(test);
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void Testing_PUT_same_Username_diff_Password_with_existing_id()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpPUT(baseurl + "/users/" + id1, "hese", "12345");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void Testing_PUT_Usernameand_and_Password_with_NONexisting_id()
        {
            UnitTest1 object1 = new UnitTest1();
            var test1 = object1.RRestsharpPUT(baseurl + "/users/" + "10000000", "hese", "12345");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned id is :" + id1);
        }

        [TestMethod]
        public void Testing_PUT_Empty_Usernameand_and_Empty_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpPUT(baseurl + "/users/" + id1, " ", "");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void GET_existing_user()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGET(baseurl + "/users/"+id1);
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void GET_NONexisting_user()
        {

            UnitTest1 object1 = new UnitTest1();
            var test1 = object1.RRestsharpGET(baseurl + "/users/" +"0112233");
            Assert.IsTrue(test1);
            Console.WriteLine("The returned id is :" + id1);
        }
        [TestMethod]
        public void GET_token_good_userANDpass_users_page()
        {
      
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/users/" , "hese","1234");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned Token is : \n" + test1);
        }

        [TestMethod]
        public void GET_token_From_token_page()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/token", "hese", "1234");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned Token is : \n" + test1);
        }

        [TestMethod]
        public void GET_token_right_username_wrong_password()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/token", "hese", "12");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned Token is : \n" + test1);
        }
        [TestMethod]
        public void GET_token_wrong_username_correct_password()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hesej", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/token", "hese", "1234");
            Assert.IsNotNull(test1);
            Console.WriteLine("The returned Token is : \n" + test1);
        }
        [TestMethod]
        public void GET_token_by_a_token()
        {

            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "heseooj", "12345");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/token", "heseooj", "12345");
            string token = test1;
            var test3 = object1.RRestsharpGETtoken(baseurl + "/token",token, "12345");
            Assert.IsNotNull(test3);
            Console.WriteLine("The returned Token is : \n" + test3);
        }
        [TestMethod]
        public void GET_resource_by_a_token()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/token","hese","1234");
            string token = test1;
            var test3 = object1.RRestsharpGETresource(baseurl + "/resource", token, "1234");
            Assert.IsTrue(test3);
        }
        [TestMethod]
        public void GET_resource_by_a_token_in_a_password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test1 = object1.RRestsharpGETtoken(baseurl + "/token", "hese", "1234");
            string token = test1;
            var test3 = object1.RRestsharpGETresource(baseurl + "/resource", "hese1", token);
            Assert.IsTrue(test3);
        }

        [TestMethod]
        public void GET_resource_good_usernameAndPassword()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test3 = object1.RRestsharpGETresource(baseurl + "/resource", "hese", "1234");
            Assert.IsTrue(test3);
        }
        [TestMethod]
        public void GET_resource_good_username_bad_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test3 = object1.RRestsharpGETresource(baseurl + "/resource", "hese", "12345");
            Assert.IsTrue(test3);
        }
        [TestMethod]
        public void GET_resource_bad_username_good_Password()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", "hese", "1234");
            id1 = test;
            var test3 = object1.RRestsharpGETresource(baseurl + "/resource", "hese1", "1234");
            Assert.IsTrue(test3);
        }
        [TestMethod]
        public void GeneratedDelete_existing_user()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", input1, input2);
            id1 = test;
            var test3 = object1.RRestsharpDELETE(baseurl + "/users/"+id1);
            Assert.IsTrue(test3);
        }
        [TestMethod]
        public void GeneratedDelete_nonexisting_user()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPOST(baseurl + "/users", input1, input2);
            id1 = test;
            var test3 = object1.RRestsharpDELETE(baseurl + "/users/00122222");
            Assert.IsTrue(test3);
        }
        [TestCleanup]
        public void cleaning (){
            UnitTest1 object1 = new UnitTest1();
            
            object1.RRestsharpDELETE(baseurl + "/users/"+id1);
            object1.RRestsharpDELETE(baseurl + "/users/" + id2);
        } 
        /*[TestMethod]
        public void Testing_PUT_With_UsernameandPassword()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpPUT(baseurl + "/users/1720", "hese", "1234");
            Assert.IsNotNull(test);
            string id = test;
            Console.WriteLine("The returned id is :" + id);
        }
       
        [TestMethod]
        public void Testing_GET_Token_With_correct_login()
        {
            UnitTest1 object1 = new UnitTest1();
            var test = object1.RRestsharpGETtoken(baseurl + "/users/1720", "hese", "1234");
            Assert.IsNotNull(test);
            string token = test;
            Console.WriteLine("The returned id is :" + token);

        }
        
        // my testing methods
       */
        public Boolean RRestsharpGET(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            if (((int)response.StatusCode) == 200)
            {
                Console.WriteLine("Testing GET request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test passed");

                Console.WriteLine(response);
                return true;
            }

            else
            {
                Console.WriteLine("Testing GET request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test failed");
                Console.WriteLine(response);
                return false;
            }
            
        }

        public string RRestsharpPOST(string url, string user, string pass)
        {
            var client = new RestClient(url);
            var values = new Dictionary<string, string>
              {
                  {"username", user},
                  {"password", pass}
              };
            
            var request = new RestRequest(Method.POST);
            var json = JsonConvert.SerializeObject(values);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            Console.WriteLine(json);
            request.AddParameter("Application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (((int)response.StatusCode) == 201)
            {
                Console.WriteLine("Testing POST request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test passed");
                Console.WriteLine(response.ContentType);
                //convrted json to object
                var jObject = JObject.Parse(response.Content);
                var id =(string)jObject.SelectToken("id");
                // var stuff  = JToken.Parse(JsonConvert.SerializeObject(response.Content)); ;
                // int id = d;
                Console.WriteLine(id);
                return (id);
                
            }

            else
            {
                Console.WriteLine("Testing POST request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test failed");
                Console.WriteLine(response);
               
                return null;
            }

           
        }
        public string RRestsharpPUT(string url, string user, string pass)
        {
            var client = new RestClient(url);
            var values = new Dictionary<string, string>
              {
                  {"username", user},
                  {"password", pass}
              };
            var request = new RestRequest(Method.PUT);
            var json = JsonConvert.SerializeObject(values);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            Console.WriteLine(json);
            request.AddParameter("Application/Json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (((int)response.StatusCode) == 201)
            {
                Console.WriteLine("Testing PUT request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test passed");
                // Console.WriteLine(mycontent);
                Console.WriteLine(response.Content);
                Console.WriteLine(response.ContentType);
                // response.Content.
                var myobj = JObject.Parse(response.Content);
                var id =(string)myobj.SelectToken("id");
                return (id);

            }

            else
            {
                Console.WriteLine("Testing PUT request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test failed");
                Console.WriteLine(response.StatusCode);
                return null;
            }
           
        }
        public string RRestsharpGETtoken(string url, string user, string pass)
        {
            var client = new RestClient("http://test.p3rsonal.com/api/token");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            //add authentication by username and password to the header
            client.Authenticator = new HttpBasicAuthenticator(user, pass);
            IRestResponse response = client.Execute(request);
            if (((int)response.StatusCode) == 200)
            {
                Console.WriteLine("Testing GET request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test passed");
                Console.WriteLine(response.Content);
                JObject obj1 = JObject.Parse(response.Content);
                string token = (string)obj1.SelectToken("token");
                return (token);
            }

            else
            {
                Console.WriteLine("Testing GET request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test failed");
                Console.WriteLine(response);
                Console.WriteLine("Status code " + response.StatusCode);
                return null;
            }

        }

        public Boolean RRestsharpGETresource(string url, string user, string pass)
        {
            var client = new RestClient("http://test.p3rsonal.com/api/resource");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            //add authentication by username and password to the header
            client.Authenticator = new HttpBasicAuthenticator(user, pass);
            IRestResponse response = client.Execute(request);
            if (((int)response.StatusCode) == 200)
            {
                Console.WriteLine("Testing GET request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test passed");
                Console.WriteLine(response.Content);
                JObject obj1 = JObject.Parse(response.Content);
                string token = (string)obj1.SelectToken("token");
                return true;
            }

            else
            {
                Console.WriteLine("Testing GET request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " Test failed");
                Console.WriteLine(response);
                Console.WriteLine("Status code " + response.StatusCode);
                return false;
            }

        }

        public Boolean RRestsharpDELETE(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            // client.Authenticator = new HttpBasicAuthenticator("hajmo", "1234");
            //add authentication by username and password to the header
            IRestResponse response = client.Execute(request);
            if (((int)response.StatusCode) == 200)
            {
                Console.WriteLine("Delete request for :" + url);
                Console.WriteLine("The status code " + (int)response.StatusCode + " DELETED!!");
                Console.WriteLine(response.Content);
                return true;
            }

            else
            {
                return false;
            }

        }
       
    }
}
