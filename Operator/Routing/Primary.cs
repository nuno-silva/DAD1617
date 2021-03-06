﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operator.Routing;
using CommonTypes.RemoteInterfaces;
using CommonTypes;

namespace Operator.Routing
{
    class Primary : RoutingPolicy
    {
        IDictionary<string, IList<IOperatorService>> ops;
        /* FIXME maybe ops can be in the superclass */

        public Primary(IDictionary<string, IList<IOperatorService>> ops)
        {
            this.ops = ops;
            Logger.debugWriteLine("RoutingPolicy: Primary (" + ops.Count + " subscribers)");
        }

        public void outputTuple(IList<string> tuple)
        {
            Logger.debugWriteLine("Primary outputTuple to "+ops.Count+" subscribers: " + tuple.ElementAt(0));
            foreach (IList<IOperatorService> replicas in ops.Values)
            {
                // PRIMARY: send to the first replica
                replicas.ElementAt(0).emitTuple(tuple);
            }
        }
    }
}
