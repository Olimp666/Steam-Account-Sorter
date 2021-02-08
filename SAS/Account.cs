using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SAS
{
    class Account
    {
        public Account()
        {

        }
        public Account(string id, double inv, double price, double balance, string currency)
        {
            this.ID = id;
            this.Inv = inv;
            this.Price = price;
            this.Balance = balance;
            this.Currency = currency;
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private string id;
        public double Inv
        {
            get { return inv; }
            set { inv = value; }
        }
        private double inv;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private double price;
        public double Balance
        {
            get { return balance; }
            set { Balance = value; }
        }
        private double balance;
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        private string currency;
        static public int rows; 
        public List<Account> InitializeAccs()
        {
            return Parse();
        }//
        static public string your_id;
        static public string language;
        private List<Account> Parse()
        {
            string[] regex=new string[5];
            if(language=="ru")
            {
                regex[0] = "СТИМАЙДИ: ([0-9]*)";
                regex[1] = "   Стоимость этих вещей: ([0-9]*.[0-9]*)";
                regex[2]= " Стоимость Аккаунта: ([0-9]*) рублей";
                regex[3] = "   Баланс: ([0-9]*.[0-9]*)";
                regex[4] = "   Баланс: [^\r\n\t\f\v ]* ([A-Z]{3})";
            }
            else if(language=="en")
            {
                regex[0] = "STEAM_ID: ([0-9]*)";
                regex[1] = "   Price of CS:GO items: ([0-9]*.[0-9]*)";
                regex[2] = " Price Of This Account: ([0-9]*) rubles";
                regex[3] = "   Balance: ([0-9]*.[0-9]*)";
                regex[4] = "   Balance: [^\r\n\t\f\v ]* ([A-Z]{3})";
            }
            List<Account> accs = new List<Account>();
            if (!Bazar.InStock)
            {
                Bazar.InStock = true;
                return accs;
            }
            StreamReader sr = new StreamReader(your_id+".txt");
            string str;
            while (!sr.EndOfStream)
            {
                Account Acc = new Account();
                for (int i = 0; i < rows; i++)
                {
                    str = sr.ReadLine();
                    Match m_id = Regex.Match(str, regex[0]);
                    Match m_inv = Regex.Match(str, regex[1]);
                    Match m_price = Regex.Match(str, regex[2]);
                    Match m_balance = Regex.Match(str, regex[3]);
                    Match m_currency = Regex.Match(str, regex[4]);
                    if (m_id.Groups[1].Success)
                        Acc.id = m_id.Groups[1].ToString();
                    else if (m_inv.Groups[1].Success)
                    {
                        string temp = m_inv.Groups[1].ToString().Replace(".", ",");
                        Acc.inv = Convert.ToDouble(temp);
                    }
                    else if (m_price.Groups[1].Success)
                        Acc.price = Convert.ToInt32(m_price.Groups[1].ToString());
                    else if (m_balance.Groups[1].Success)
                    {
                        string temp = m_balance.Groups[1].ToString().Replace(".", ",");
                        Acc.balance = Convert.ToDouble(temp);
                        if (m_currency.Groups[1].Success)
                            Acc.currency = m_currency.Groups[1].ToString();
                        else
                            Acc.currency = "—";
                    }
                }
                accs.Add(Acc);
            }
            sr.Close();
            return accs;
        }
    }   

}
