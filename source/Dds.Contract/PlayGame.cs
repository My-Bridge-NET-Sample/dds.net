﻿using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace Dds.Contract
{
    [Route("/play-game")]
    public class PlayGame : IReturn<PlayGameResponse>
    {
        public string PBN { get; set; }
    }

    public class PlayGameResponse
    {
        public string Play { get; set; }
    }
}