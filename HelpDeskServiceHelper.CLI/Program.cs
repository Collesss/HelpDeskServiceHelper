using HelpDeskServiceHelper.HelpDeskHttpClient.Default.Implementations;

namespace HelpDeskServiceHelper.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HelpDeskHttpClientDefault();

            await client.GetCITypeDetails("Printer");
        }
    }
}
