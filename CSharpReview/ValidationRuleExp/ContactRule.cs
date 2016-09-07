using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidationRuleExp
{
    public class ContactRule:ValidationRule
    {
        public int checkType { get; set; }
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                if(checkType==0)
                {
                    if(value == null||string.IsNullOrEmpty(value.ToString().Trim())||!IsTelePhone(value.ToString().Trim()))
                    {
                        return new ValidationResult(false,"Unvalid Tel Number");
                    }
                }
                else if(checkType==1)
                {
                    if(value==null||string.IsNullOrEmpty(value.ToString().Trim())||!IsMobilePhone(value.ToString().Trim()))
                    {
                        return new ValidationResult(false, "Unvalid Mobile Number");
                    }
                }
                else if(checkType==2)
                {
                    if(value==null||string.IsNullOrEmpty(value.ToString().Trim())||!IsEmail(value.ToString().Trim()))
                    {
                        return new ValidationResult(false, "Unvalid Email Address");
                    }
                } 
                else if(checkType==3)
                {
                    if(value==null||string.IsNullOrEmpty(value.ToString().Trim())||!IsHomePage(value.ToString().Trim()))
                    {
                        return new ValidationResult(false, "Unvalid HomePage");
                    }
                }
                return new ValidationResult(true, null);

            }
            catch(Exception e)
            {
                return new ValidationResult(false, e.Message);
            }
        }

        private bool IsTelePhone(string telePhone)
        {
            return Regex.IsMatch(telePhone, @"^(\d{3,4}-)?\d{6,8}$");
        }

        private bool IsMobilePhone(string mobilePhone)
        {
            return Regex.IsMatch(mobilePhone, @"^[1]([3][0-9]{1}|59|58|88|89)[0-9]{8}$");
        }

        private bool IsEmail(string email)
        {
            return Regex.IsMatch(email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        private bool IsHomePage(string homePage)
        {
            return Regex.IsMatch(homePage, @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
    }
}
