using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace InnergyInterpreter.Extensions
{
    public static class FormFileExtension
    {
        public static async Task<IEnumerable<string>> ReadAsStringAsync(this IFormFile file)
        {
            var result = new List<string>();
            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                    result.Add(await reader.ReadLineAsync());    
            }

            return result;
        }
    }
}
