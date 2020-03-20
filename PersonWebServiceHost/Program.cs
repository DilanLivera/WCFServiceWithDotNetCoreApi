using System;
using System.ServiceModel;

namespace PersonWebServiceHost
{
    class Program
    {
        static void Main()
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(PersonWebService.PersonService)))
                {
                    host.Open();
                    Console.WriteLine("Person Service Host started @ " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
