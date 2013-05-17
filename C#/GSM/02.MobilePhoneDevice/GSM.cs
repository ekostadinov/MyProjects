using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MobilePhoneDevice
{
    public class GSM //it is public because i use this class in my 3th project
    {
        public Battery gsmBattery;
        public Call phoneCall = new Call(DateTime.Today, DateTime.Now, null, 0 );
        public GSM IPhone4S;
        static public List<Call> callHistory = new List<Call>();
        static public List<Call> addCallsToHistory = new List<Call>();
        static public List<Call> removeCallsFromHistory = new List<Call>();
        static public List<Call> clearCallsHistory = new List<Call>();
        static public decimal calculateTotalCallsCost;
        

        private Battery battery = null;
        private string model = null;
        private string owner = null;
        private string manufacturer = null;
        private decimal? price = null;

      //public GSM() //Battery Battery, Call Call, List<Call> CallHistory
      //{
      //    this.battery.HoursTalk = battery.HoursTalk;
      //    this.battery.HoursStandby = battery.HoursStandby;
      //    this.battery.Model = battery.Model;
      //    this.battery.Type = battery.Type;
      //
      //    //this.Call.Date = Call.Date;
      //    //this.Call.Time = Call.Time;
      //    this.Call.CallDuration = Call.CallDuration;
      //    this.Call.DialedPhoneNumber = Call.DialedPhoneNumber;
      //    
      //    callHistory.Add(Call);
      //}

        static public decimal CalculateTotalCallsCost(List<Call> callHistory, decimal callPrice)
        {
            decimal totalCallsCostFinal = 0;
            decimal totalCallsCost = 0;
            callPrice = 0.27m;
            
            foreach (var call in GSM.CallHistory)
            {                
                totalCallsCost =  (call.CallDuration /  60) * callPrice; //find minutes talked

                if (call.CallDuration % 60 < 60) //rounding to whole minute
                {
                    totalCallsCostFinal += callPrice;
                }

                totalCallsCostFinal += totalCallsCost;
               
            }

            Console.WriteLine("If call price per minute is {0}eu, all log calls worth is: {1}eu", callPrice, totalCallsCostFinal);

            return totalCallsCostFinal;
        }

        static public void ClearCallsHistory()
        {
            callHistory.Clear();
        }

        static public void RemoveCallsFromHistory(Call myCall)
        {
            callHistory.Remove(myCall);        
        }


        static public void AddCallsToHistory(Call myCall)
        {
            callHistory.Add(myCall); //new Call(DateTime.Today, DateTime.Now, null, 0)          
        }

        public static List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public Call Call
        {
            get { return this.phoneCall; }
            set { this.phoneCall = value; }
        }
        public GSM iPhone4s
        {
            get { return this.IPhone4S; }
            set { this.IPhone4S = value; }
        }

        public Battery Battery
        {
             get{return this.battery;}
            set{this.battery = value; }
        }


        public string PhoneModel
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string PhoneOwner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string PhoneManufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public decimal? PhonePrice
        {
            get { return this.price; }
            set { this.price = value; }
        }

        //mendatory only model and manufacturer
        //so we need only battery and gsm

        public GSM(string model, string manufacturer)
        {
            this.PhoneModel = model;
            this.PhoneManufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.PhonePrice = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.PhoneOwner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery gsmBattery)
            : this(model, manufacturer, price, owner)
        {
            this.gsmBattery = gsmBattery;
        }

       
    }
}
