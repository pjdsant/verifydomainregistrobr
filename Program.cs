using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VerifyDomainRegistroBr
{
    class Program
    {
        static void Main(string[] args)
        {
            var strDomain = "pjsito.com.br";
            //var requisicaoWeb = WebRequest.CreateHttp("https://rdap.registro.br/domain/" + strDomain);
            //requisicaoWeb.Method = "GET";
            //requisicaoWeb.UserAgent = "VerifyDomainRegistroBr";

            // Create a request for the URL.   
            WebRequest request = WebRequest.Create("https://rdap.registro.br/domain/" + strDomain);
           
            // If required by the server, set the credentials.  
            //request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
           // WebResponse response = request.GetResponse();
            // Display the status.  

            try
            {
                HttpWebResponse response =(HttpWebResponse)request.GetResponse();
                Console.WriteLine( response.StatusCode);
            }
            catch (WebException we)
            {
                Console.WriteLine(((HttpWebResponse)we.Response).StatusCode);
            }


            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server. 
            // The using block ensures the stream is automatically closed. 
            /*
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
            }
            */

            // Close the response.  
            //response.Close();

            Console.ReadLine();

        }
    }
}
