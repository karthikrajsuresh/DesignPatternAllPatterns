﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{

    /// <summary>
    /// Abstraction which represents the sent order and maintains a reference to the restaurant where the order is going.
    /// </summary>
    public abstract class SendOrder
    {
        //Reference to the Implementor
        public IOrderingSystem _restaurant;

        public abstract void Send();
    }
}