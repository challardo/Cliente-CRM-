﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente__CRM_
{
    public interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
       // void notifyObservers();
    }
}
