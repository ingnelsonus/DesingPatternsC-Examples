﻿using observer;
using observer.impl.observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Example2_Money
    {
        public void Run()
        {
            ConfigurationManager conf = ConfigurationManager.GetInstance();

            //Se establecen los valores por default.
            conf.setDefaultDateFormat("yyyy/MM/dd");
            conf.SetMoneyFormat("##.00");
            Console.WriteLine("Established configuration");

            //Se dan de alta lo observers
            DateFormatObserver dateFormatObserver = new DateFormatObserver();
            MoneyFormatObserver moneyFormatObserver = new MoneyFormatObserver();
            conf.AddObserver(dateFormatObserver);
            conf.AddObserver(moneyFormatObserver);
            Console.WriteLine("");

            //Se cambia la fonfiguratión
            conf.setDefaultDateFormat("dd/MM/yyyy");
            conf.SetMoneyFormat("###,#00.00");
            Console.WriteLine("");

            //Se realiza otro cambio en la configuración.
            conf.setDefaultDateFormat("MM/yyyy/dd");
            conf.SetMoneyFormat("###,#00");

            conf.RemoveObserver(dateFormatObserver);
            conf.RemoveObserver(moneyFormatObserver);
            Console.WriteLine("");

            //Se realiza otro cambio en la configuración.
            conf.setDefaultDateFormat("MM/yyyy");
            conf.SetMoneyFormat("###,##0.00");
        }
    }
}
