﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Blotters
    {
        public string Cleared => this.IsCleared == true ? "Settled" : "";
    }
}
