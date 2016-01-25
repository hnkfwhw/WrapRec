﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapRec.Core
{
    public interface IExperiment
    {
		void Run(ExperimentManager manager, int repeatNum = 1);
    }
}
