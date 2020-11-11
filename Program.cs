using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            Tables();
           //  RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://api.adviceslip.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Console.WriteLine("Type any key to enter other than Enter");
                do
                {
                    HttpResponseMessage response = await client.GetAsync("advice");
                    if (response.IsSuccessStatusCode)
                    {
                        string resultContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(resultContent + "\n");

                    }

                } while (Console.ReadKey().Key == ConsoleKey.Enter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void Tables()
        {
            try
            {
                int j, i, n;
                do
                {
                    Console.Write("Input an Integer between 0 and 20 :");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n > 20 || n < 0)
                    {
                        Console.Write("Value must be between 0 and 20");
                        Console.Write("\n");
                    }
                    else
                    {
                        for (i = 0; i <= n; i++)
                        {
                            Console.Write(i + "\t");
                            for (j = 1; j <= n; j++)
                            {
                                if (i > 0) 
                                    Console.Write(i * j + "\t");
                                else Console.Write(j + "\t");
                            }
                            Console.Write("\n");
                        }
                    }
                } 
                
                while (n > 20 || n < 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}


