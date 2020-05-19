using System.Collections.Generic;

namespace InnergyInterpreter.Services
{
    public interface IInterpreterService
    {
        public void Execute(IEnumerable<string> input);
    }
}
