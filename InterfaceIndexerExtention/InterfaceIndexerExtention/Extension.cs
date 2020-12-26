using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIndexerExtention
{
    //1-ci shert - extension methodlar static class-da olmalidir
    //2-ci shert - extension methodlar static olmalidir
    //3-cu shert - hansi tipe extension yaziriqsa onun qabagina "this" keyword yazilmalidir
    public static class Extension
    {
        public static bool IsEmail(this string mail)
        {
            try
            {
                MailAddress address = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public static int Sum(this int n1,int n2)
        {
            return n1 + n2;
        }

        public static int GetPower(this int num,int power)
        {
            int result = 1;
            while (power > 0)
            {
                result *= num;
                power--;
            }
            return result;
        }
    }
}
