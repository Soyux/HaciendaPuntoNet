﻿using MHBrokerLogic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerLogic.Connectivity
{
    public class Token : IToken
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
        public string refresh_expires_in { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public string id_token { get; set; }
        public string not_before_policy { get; set; }
        public string session_state { get; set; }
    }
}
