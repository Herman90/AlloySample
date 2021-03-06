﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.Channels
{
    public class MobileResolution: IDisplayResolution
    {
        public string Id => GetType().FullName;
        public string Name => "Mobile (320x480)";
        public int Width => 320;
        public int Height => 480;
    }
}