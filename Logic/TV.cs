using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface TV:Switcher,Locker
    { 
      void SwitchTheChannelAhead();
      void SwitchTheChannelBack();
      void IncreaseTheSound();
      void DecreaseTheSound();

    }
}
