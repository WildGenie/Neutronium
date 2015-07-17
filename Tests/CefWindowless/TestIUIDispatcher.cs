﻿using CefGlue.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.CEFGlue.Test.CefWindowless
{
    internal class TestIUIDispatcher : IUIDispatcher
    {
        public Task RunAsync(Action act)
        {
            act();
            return Task.FromResult<object>(null);
        }


        public void Run(Action act)
        {
            act();
        }


        public Task<T> EvaluateAsync<T>(Func<T> compute)
        {
            return Task.FromResult(compute());
        }

        public T Evaluate<T>(Func<T> compute)
        {
            return compute();
        }
    }
}
