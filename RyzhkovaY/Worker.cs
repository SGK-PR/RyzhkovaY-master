using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RyzhkovaY
{
    public class Worker
    {
        private bool _cancelled = false;

        public void Cansel()
        {
            _cancelled = true;
        }
        public void Work(object param)
        {
            SynchronizationContext context = (SynchronizationContext)param;
            for(int i=0; i<=99; i++)
            {
                if (_cancelled)
                    break;

                Thread.Sleep(50);
                context.Send(OnProgressChanged, i);
            }
            context.Send(OnWorkCompleted, _cancelled);
        }

        public void OnProgressChanged(object i)
        {
            if (ProcessChanged != null)
                ProcessChanged((int)i);
        }
        public void OnWorkCompleted(object cancelled)
        {
            if (WorkCompleted!= null)
                WorkCompleted((bool)cancelled);
        }
        public event Action<int> ProcessChanged;
        public event Action<bool> WorkCompleted;

    }
}
