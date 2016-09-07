using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DelegateEvent
{
    public delegate void Startdelegate();
    
    class EventDemo:Form
    {
        public event Startdelegate StartEvent;

        public EventDemo()
        {
            Button clickMe = new Button();
            clickMe.Parent = this;
            clickMe.Text = "Click Me";
            clickMe.Location = new Point((ClientSize.Width - clickMe.Width) / 2, (ClientSize.Height - clickMe.Height) / 2);

            //An EventHandler delegate is assigned to the button's click event
            clickMe.Click += new EventHandler(OnClickMeClicked);

            StartEvent += new Startdelegate(OnStartEvent);
            StartEvent();

        }

        public void OnClickMeClicked(object sender, EventArgs e)
        {
            MessageBox.Show("You Clicked My Button");
        }

        public void OnStartEvent()
        {
            MessageBox.Show("I Just Started!");
        }

        static void Main(string[] args)
        {
            Application.Run(new EventDemo());
        }
        
    }
}
