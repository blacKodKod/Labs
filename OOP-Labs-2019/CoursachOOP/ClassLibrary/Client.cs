using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client
    {
        protected int numberCard;
        protected string password;
        protected int balance;
        string pin;

        public int NumberCard
        {
            get { return numberCard; }
            set { numberCard = value; }
        }

        public void setPassword(string _password)
        {
            password = _password;
        }

        public int putMoney(int sum)
        {
            if (balance == 0)
            {
                balance = sum;
                return balance;
            }
            else
            {
                balance += sum;
                return balance;
            }
        }

        public int getBalance()
        {
            return balance;
        }
        
        public int getMoney(int sum)
        {
            if(balance == 0)
            {                
                return 0;
            }
            else if(sum > balance)
            {
                return 0;
            }
            else
            {
                balance -= sum;
                return balance;
            }
        }

        public int putPhone(string num)
        {
            if (num == "")
                return 0;
            else
                return 1;
        }

        public string num1()
        {
            return pin = "1";
        }

        public string num2()
        {
            return pin = "2";
        }

        public string num3()
        {
            return pin = "3";
        }

        public string num4()
        {
            return pin = "4";
        }

        public string num5()
        {
            return pin = "5";
        }

        public string num6()
        {
            return pin = "6";
        }

        public string num7()
        {
            return pin = "7";
        }

        public string num8()
        {
            return pin = "8";
        }

        public string num9()
        {
            return pin = "9";
        }

        public string num0()
        {
            return pin = "0";
        }

        public string numPlus()
        {
            return pin = "+";
        }

        public string numMinus()
        {
            return pin = "-";
        }
    }
}