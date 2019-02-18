using System;

namespace SweepstakesMGMT
{
    public class SweepstakesMGMT : ISweepstakesManager
    {
        SweepstakesStackManager<_Sweepstakes> sweepstakesStack = new Stack<_Sweepstakes>();
        public void InsertSweepstakes(_Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
        public _Sweepstakes GetSweepstakes()
        {
            _Sweepstakes sweepstakesFromStack = sweepstakesStack.Pop();
            return sweepstakesFromStack;
        }

        public void InsertSweepstakes(object p)
        {
            throw new System.NotImplementedException();
        }

        private class Stack<T>
        {
            public Stack()
            {
            }
        }

        private class SweepstakesStackManager<T>
        {
            internal _Sweepstakes Pop()
            {
                throw new NotImplementedException();
            }

            internal void Push(_Sweepstakes sweepstakes)
            {
                throw new NotImplementedException();
            }

            public static implicit operator SweepstakesStackManager<T>(Stack<_Sweepstakes> v)
            {
                throw new NotImplementedException();
            }
        }
    }

    internal interface ISweepstakesStackManager
    {
        _Sweepstakes GetSweepstakes();
    }
}