using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashboard
{
    public class BicycleSubject:ISubject
    {
        /// <summary>
        /// Hold a list of current registered observers
        /// </summary>
        List<IObserver> observerList;
        int currentRPM { get; set; }

        public BicycleSubject() { }
        /// <summary>
        /// Add a new Observer to the list
        /// </summary>
        /// <param name="o">IObserver to add</param>
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        /// <summary>
        /// Remove an Observer from this list
        /// </summary>
        /// <param name="o">IObserver to remove</param>
        public void RemoveObserver(IObserver o)
        {
            //TODO Check that it is in the list/Error checking
            observerList.Remove(o);
        }

        /// <summary>
        /// Notify all observers
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver currentObserver in observerList)
            {
                currentObserver.Update(currentRPM);
            }
        }
    }
}
