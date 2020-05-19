using InnergyInterpreter.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace InnergyInterpreter.Services
{
    public class InterpreterService : IInterpreterService
    {
        public IEnumerable<Material> Execute(IEnumerable<string> input)
        {
            var resultFin = new List<Material>();

            foreach(var text in input)
            {
                if (text.StartsWith("#")) continue;

                Material result = new Material();

                result.Id = Regex.Match(text, ";[^;]*").ToString().Substring(1);
                result.Name = Regex.Match(text, "[^;]*").ToString();

                var rest = text.Substring(text.LastIndexOf(';') + 1);
                string[] warehouses = rest.Split("|");

                var quantities = new List<MaterialQuantity>();

                foreach (var warehouse in warehouses)
                {
                    var quantity = new MaterialQuantity();

                    quantity.Quantity = Int32.Parse(warehouse.Substring(warehouse.IndexOf(",") + 1));

                    quantity.Warehouse = new Warehouse() { Name = Regex.Match(warehouse, "[^,]+").ToString() };

                    quantities.Add(quantity);
                }

                result.MaterialQuantities = quantities;

                resultFin.Add(result);
            }

            return resultFin;
        }
    }
}
