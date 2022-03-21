using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Car
{
    public Car() { }    //建構函式
    public string color;   //屬性
    private string name;

    /*
      virtual 虛擬方法，
      若希望或預料到基礎類別的這個方法在將來的派(衍)生類別中會被覆寫（override 或 new），
      則此方法必須被聲明為 virtual
    */
    public virtual void run()   //方法、動作    
    {
        Console.WriteLine($"車子的顏色是{this.color}");
    }
}

class InterfaceA : Interface
{
    void Interface.SampleMethod() {
    }
}


namespace ClassExercise01
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Car car1 = new Car();    //建立成員
            car1.color = "紅色";
            car1.run();

            CarA car2 = new CarA();
            car2.color = "藍色";
            car2.run();


            Random rnd = new Random();
            int num = rnd.Next(1, 101);    //產生1到100的亂數
            /*while (true)
            {
                Console.WriteLine("請輸入一個數：");
                string num2 = Console.ReadLine();

                if (Convert.ToInt32(num2) > num)
                {
                   
                    Console.WriteLine($"1~{num2}之間");
                }
                else if (Convert.ToInt32(num2) < num)
                {

                    
                    Console.WriteLine($"{num2}~{num}之間");
                }
                else
                {
                    Console.WriteLine("答對了!!!");
                    break;
                }
            }*/
            
            //await MyhttpClient();

            Console.Read();
        }

        static private async Task MyhttpClient()
        {
            HttpClient client = new HttpClient();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

    }
}

// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.


