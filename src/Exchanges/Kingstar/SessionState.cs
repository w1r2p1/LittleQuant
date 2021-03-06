﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LittleQuant.Exchanges.Kingstar
{
    public class SessionState
    {
        private int _requestID = 1;
        private int _orderRef;

        public int RequestID { get { return this._requestID; } set { this._requestID = value; } }
        public int FrontID { get; set; }
        public int SessionID { get; set; }
        public int OrderRef { get { return this._orderRef; } set { this._orderRef = value; } }

        public int NextRequestID()
        {
            return Interlocked.Increment(ref this._requestID);
        }

        public int NextOrderRef()
        {
            return Interlocked.Increment(ref this._orderRef);
        }
    }
}
