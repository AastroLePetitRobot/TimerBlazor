using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimerBlazor.Services
{
    public class Counter
    {
         public  int nombre
        {
            get;

            set;
        }
        public int pas { get; set; }

        
        public void Decrement()
        {
            nombre = this.nombre - this.pas;
            NotifyStateChanged();
            
        }
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();



    }
}
