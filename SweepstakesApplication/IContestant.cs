﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    public interface IContestant
    {
        void Notify(IContestant contestant);
    }
}