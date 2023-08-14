using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    interface IDeveloper 
    {
        string Tool { get; set; }
        void Create();
        void Destroy();

    }
}
