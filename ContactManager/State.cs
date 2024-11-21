using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public abstract class State
    {
        protected Application _application;
        public abstract void Run();
        public State(Application application)
        {
            _application = application;
        }
    }
}
