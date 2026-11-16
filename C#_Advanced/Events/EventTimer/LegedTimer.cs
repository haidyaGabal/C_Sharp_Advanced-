
using System;
using System.Threading;

namespace C__Advanced.Events.EventTimer
{
    public delegate void TickAction(int remaining);
    public delegate void TimerEndedAction();

    public class LegedTimer
    {
        public event TickAction? TickAction;
        public event TimerEndedAction? TimerEnded;

        private int _second;

        public LegedTimer(int second)
        {
            if (second < 0)
                throw new ArgumentOutOfRangeException(nameof(second));

            _second = second;
        }

        public void Start()
        {
            while (_second > 0)
            {
                OnTickCompleted(_second);

                Thread.Sleep(1000);

                _second--;
            }

            OnTimerFinished();
        }

        protected virtual void OnTickCompleted(int remaining)
        {
            TickAction?.Invoke(remaining);
        }

        protected virtual void OnTimerFinished()
        {
            TimerEnded?.Invoke();
        }
    }
}
