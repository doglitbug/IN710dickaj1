using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashboard
{
    interface ISubject
    {
        void AddObserver(IObserver o);
        void Removeobserver(IObserver o);
        void NotifyObservers();
    }
}
