using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin2
{
    class Cat : Animal
    {
        public Cat(string name, List<string> breeds, string sound, string food)
            : base(name, breeds, sound, food)
        {
        }
    }
}
