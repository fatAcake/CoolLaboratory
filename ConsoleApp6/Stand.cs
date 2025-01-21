﻿using ConsoleApp6.Abstact_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Stand
    {
        public Engine engine;

        public Stand(Engine engine)
        {
            this.engine = engine;
        }
        public Task Work()
        {
            Task.Run(() =>
            {
                engine.Start(0.0f);
            };
        }
    }
}
