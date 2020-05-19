using InnergyInterpreter.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace InnergyInterpreter.Services
{
    public class InterpreterService : IInterpreterService
    {
        public void Execute(IEnumerable<string> input)
        {
            foreach(var text in input)
            {
                if (text.StartsWith("#")) continue;

                Material result = new Material();

                result.Name = Regex.Match(text, "[^;]*").ToString();
            }
        }
    }
}
