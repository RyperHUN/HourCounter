using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    public abstract class Observable
    {
        protected LinkedList<Observer> observers;
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