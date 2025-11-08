# AmazingEndemicSpecies.cs
Web-API for [aes.shenlu.me](https://aes.shenlu.me/) Amazing Endemic Species API is compiled and released based on information from the IUCN Red List API. It gathers 100 endemic species from 40 different countries and regions until now.

## Example
```cs
using AmazingEndemicSpeciesApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new AmazingEndemicSpecies();
            string randomSpecies = await api.GetRandomSpecies();
            Console.WriteLine(randomSpecies);
        }
    }
}
```
