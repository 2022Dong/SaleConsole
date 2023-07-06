using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // Must after inheritant class eg. xxxBaseClass, Interface(s) <-- one super class, multi Interfaces
    public interface IProductModel // Must make it public. naming: I... ( vs adj. in Kotlin)
    {
        // NO public keyword. No need more code here
        string Title { get; set; } // property signature
        bool HasOrderBeenCompleted { get;}

        void ShipItem(CustomerModel customer); // method signature  NB: Using; VS Not {}
    }
}
