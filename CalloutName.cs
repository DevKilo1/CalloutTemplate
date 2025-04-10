﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CitizenFX.Core;
using FivePD.API;
using Kilo.Commons.Utils;

namespace Callouts
{
    public class CalloutName : Callout
    {
        public CalloutName()
        {
            ShortName = "CalloutName";
            CalloutDescription = "";
            StartDistance = 120f;
            ResponseCode = 3;
        }

        public async override Task OnAccept()
        {
            
        }
        
        public override void OnStart(Ped closest)
        {
        }

        public override void OnCancelBefore()
        {
           
        }
    }
}