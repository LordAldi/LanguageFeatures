using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    interface IProductSelection
    {
        IEnumerable<Product> Products { get; }

        IEnumerable<string> Names => Products.Select(p => p.Name);
    }
}
