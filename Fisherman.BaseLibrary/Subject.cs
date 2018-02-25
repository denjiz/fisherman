using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public abstract class Subject
    {
        private List<IFishermanObserver> _observers = new List<IFishermanObserver>();

        public void Attach(IFishermanObserver observer)
        {
            _observers.Add(observer);
        }
        public void Delete(IFishermanObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(Object inObject)
        {
            foreach (IFishermanObserver observer in _observers)
            {
                observer.Update(inObject);
            }
        }
    }
}
