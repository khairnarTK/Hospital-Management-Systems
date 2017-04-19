using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS.Web.Models
{
    public class PatientSurgeryReservation
    {
        public int Id { get; set; }
        public int Patient_Id {get;set;}
        public int OT_ID { get; set;}
        public String Patient_Name { get; set;}
        public string Assign_Doctor { get; set;}
        public string Symtoms { get; set;}
        public string Risk_Factor { get; set;}
        public string Surgery_Type { get; set;}
        public string Guardians_Name { get; set;}
        public string Guardians_Relation { get; set;}
        public string Surgery_Date { get; set;}
        public string Start_Time { get; set;}
        public string Ot_Total_hr{ get; set;}
        public string End_Time { get; set;}
        public string OT_Amount { get; set;}
        public string Deposit_Amount { get; set;}
        public string Balance { get; set;}
   }
}