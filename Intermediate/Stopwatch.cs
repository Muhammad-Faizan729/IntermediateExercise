using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        public void StartWatch()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running!..");
            }
            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void StopWatch()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already stopped!..");
            }
            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetIntervals()
        {
            return _endTime - _startTime;
        }
    }
}
