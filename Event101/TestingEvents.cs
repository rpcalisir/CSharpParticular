using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event101
{
    public class TestingEvents
    {
        //Definition of event
        public event EventHandler OnSpacePressed;

        //Trigger event
        public void Update(string input)
        {
            if (input == "s")
            {
                OnSpacePressed?.Invoke(this, EventArgs.Empty);
            }
            OnSpacePressed += Test_OnSpacePressed;
        }

        //Subscribe to the event
        //Subscriber method signature must be same with event
        private void Test_OnSpacePressed(object sender, EventArgs e)
        {
            Console.WriteLine("!Space");
        }

        public void Start(string input)
        {
        }
    }
}
