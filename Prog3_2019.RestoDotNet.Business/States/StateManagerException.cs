using System;

namespace Prog3.RestoDotNet.Business.States
{
    public class StateManagerException : Exception
    {
        public StateManagerException(string message) : base($"Invalid Waiter-state management. {message}")
        {
        }
    }
}
