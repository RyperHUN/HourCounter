using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    [Serializable]
    public abstract class Observable
    {
        [NonSerialized]
        protected static LinkedList<Observer> observers;
        protected void updateAllViews()
        {
            foreach(Observer observer in observers)
            {
                observer.update();
            }
        }
        public void addObserver(Observer o)
        {
            observers.AddLast(o);
        }
        public Observable()
        {
            observers = new LinkedList<Observer>();
        }
    }
}