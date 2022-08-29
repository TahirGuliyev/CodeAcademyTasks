using System;
using System.Diagnostics;
using System.Net;

namespace ConsoleApp5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "https://medium.com/",
                "https://buttigieg.medium.com/one-year-in-parenting-has-taught-us-about-vulnerability-and-gratitude-170f6e94cbad"

            };
            foreach (string s in list)
            {
                Stopwatch st = new Stopwatch();
                st.Start();

                var client = new HttpClient();
                var content = await client.GetStringAsync(s);
                st.Stop();
                Console.WriteLine(content.Length + " " + st.ElapsedMilliseconds);


            }
        }
        
    }

}