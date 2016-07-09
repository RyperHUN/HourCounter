using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HourCounter
{
    public abstract class Observable
    {
        protected LinkedList<Observer> observers;
        private void updateAllViews()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}