using InnergyInterpreter.Models;
using System.Collections.Generic;

namespace InnergyInterpreter.Services
{
    public interface IInterpreterService
    {
        public IEnumerable<Material> Execute(IEnumerable<string> input);
    }
}
