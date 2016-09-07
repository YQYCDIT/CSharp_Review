using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationRuleExp
{
    /// <summary>
    /// The ContactModel.cs included many properties.
    /// And is binding with the input textbox respectively.
    /// 
    /// The Contact model implement INotifyPropertyChanged interface, 
    /// Therefore, the changes from the user interface windows can be notified to the model .
    /// </summary>
    public class ContactModel:INotifyPropertyChanged
    {
        
        //固话号码
        private string telePhone;
        public string TelePhone
        {
            get
            {
                return telePhone;
            }
            set
            {
                telePhone = value;
                NotifyPropertyChanged("TelePhone");
            }
        }

        //MobilePhone
        private string mobilePhone;
        public string MobilePhone
        {
            get
            {
                return mobilePhone;
            }
            set
            {
                mobilePhone = value;
                NotifyPropertyChanged("MobilePhone");
            }
        }

        //Email Address
        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }

        private string homePage;
        public string HomePage
        {
            get
            {
                return homePage;
            }
            set
            {
                homePage = value;
                NotifyPropertyChanged("HomePage");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }




    }
}
