using System;
using System.Collections.Generic;
using System.Web;


namespace MyCalendar { 

    /// <summary>
    /// Valarm 的摘要描述
    /// </summary>
    public class Valarm
    {

        public string trigger { get; set; }
        public string action { get; set; }
        public string description { get; set; }

        public const string action_display = "Display";
        public const string description_reminder = "Reminder";


        private Valarm(){}

        public Valarm(string trigger) {

            this.trigger = trigger;
            this.action = Valarm.action_display;
            this.description = Valarm.description_reminder;

        }

        public Valarm(string trigger, string  action, string description) {

            this.trigger = trigger;
            this.action = action;
            this.description = description;
       
        }


     
    }


    


    


}

    