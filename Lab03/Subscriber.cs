using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Subscriber
    {
        public string Name;            // Ім'я абонента
        public string PhoneNumber;      // Номер телефону
        public string Address;          // Адреса абонента
        public int CallMinutesPerMonth; // Кількість хвилин дзвінків на місяць
        public int SMSPerMonth;         // Кількість SMS на місяць
        public double MonthlyFee;       // Щомісячна плата за послуги
        internal bool HasRoaming;
        internal bool HasDataPlan;

        public Subscriber()
        {
        }

        // Конструктор з параметрами
        public Subscriber(string name, string phoneNumber, string address, int callMinutes, int sms, double monthlyFee, bool hasRoaming, bool hasDataPlan)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            CallMinutesPerMonth = callMinutes;
            SMSPerMonth = sms;
            MonthlyFee = monthlyFee;
            HasRoaming = hasRoaming;
            HasDataPlan = hasDataPlan;
        }

        // Властивість для обчислення вартості за хвилину
        public double CostPerMinute
        {
            get
            {
                return GetCostPerMinute();
            }
        }

        // Метод для обчислення вартості за хвилину
        public double GetCostPerMinute()
        {
            if (CallMinutesPerMonth == 0)
            {
                return 0;
            }
            return MonthlyFee / CallMinutesPerMonth;
        }
    }
}