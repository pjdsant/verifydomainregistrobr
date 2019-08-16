using System;
using System.Net;
using System.Text;
using System.Threading;

namespace VerifyDomainRegistroBr
{
    class Program
    {
        public static string IntToAlpha(int x)
        {
            int lowChar;
            StringBuilder result = new StringBuilder();
            do
            {
                lowChar = (x - 1) % 26;
                x = (x - 1) / 26;
                result.Insert(0, (char)(lowChar + 65));
            } while (x > 0);
            return result.ToString();
        }

        static void Main(string[] args)
        {
            var strFind = "";
            var strDomain = ".com.br";

            var jx = 0;

            new Thread(ThreadOne).Start();
            ThreadOne();
            Console.ReadLine();

            new Thread(ThreadTwo).Start();
            ThreadTwo();
            Console.ReadLine();

            new Thread(ThreadThree).Start();
            ThreadThree();
            Console.ReadLine();

            new Thread(ThreadFour).Start();
            ThreadFour();
            Console.ReadLine();

            new Thread(ThreadFive).Start();
            ThreadFive();
            Console.ReadLine();

            void ThreadOne()
            {
                try
                {
                    for (int i = 704; i <= 2703; i++) //defina aqui o tamanho da sequencia gerada
                    {
                        jx = i;
                        WebRequest request = WebRequest.Create("https://rdap.registro.br/domain/" + IntToAlpha(i) + strDomain);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(IntToAlpha(i) + " = " + response.StatusCode);
                        }
                        response.Close();
                    }
                }
                catch (WebException we)
                {
                    Console.WriteLine(IntToAlpha(jx) + " = " + ((HttpWebResponse)we.Response).StatusCode);
                }
            }

            void ThreadTwo()
            {


                try
                {
                    for (int i = 2704; i <= 4703; i++) //defina aqui o tamanho da sequencia gerada
                    {
                        jx = i;
                        WebRequest request = WebRequest.Create("https://rdap.registro.br/domain/" + IntToAlpha(i) + strDomain);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(IntToAlpha(i) + " = " + response.StatusCode);
                        }
                        response.Close();
                    }
                }
                catch (WebException we)
                {
                    Console.WriteLine(IntToAlpha(jx) + " = " + ((HttpWebResponse)we.Response).StatusCode);
                }
            }

            void ThreadThree()
            {

                try
                {
                    for (int i = 4704; i <= 6703; i++) //defina aqui o tamanho da sequencia gerada
                    {
                        jx = i;
                        WebRequest request = WebRequest.Create("https://rdap.registro.br/domain/" + IntToAlpha(i) + strDomain);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(IntToAlpha(i) + " = " + response.StatusCode);
                        }
                        response.Close();
                    }
                }
                catch (WebException we)
                {
                    Console.WriteLine(IntToAlpha(jx) + " = " + ((HttpWebResponse)we.Response).StatusCode);
                }
            }

            void ThreadFour()
            {

                try
                {
                    for (int i = 6704; i <= 8703; i++) //defina aqui o tamanho da sequencia gerada
                    {
                        jx = i;
                        WebRequest request = WebRequest.Create("https://rdap.registro.br/domain/" + IntToAlpha(i) + strDomain);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(IntToAlpha(i) + " = " + response.StatusCode);
                        }
                        response.Close();
                    }
                }
                catch (WebException we)
                {
                    Console.WriteLine(IntToAlpha(jx) + " = " + ((HttpWebResponse)we.Response).StatusCode);
                }
            }

            void ThreadFive()
            {

                try
                {
                    for (int i = 8704; i <= 10703; i++) //defina aqui o tamanho da sequencia gerada
                    {
                        jx = i;
                        WebRequest request = WebRequest.Create("https://rdap.registro.br/domain/" + IntToAlpha(i) + strDomain);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(IntToAlpha(i) + " = " + response.StatusCode);
                        }
                        response.Close();
                    }
                }
                catch (WebException we)
                {
                    Console.WriteLine(IntToAlpha(jx) + " = " + ((HttpWebResponse)we.Response).StatusCode);
                }
            }
        }
    }
}
