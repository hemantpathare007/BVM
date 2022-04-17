using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BVM.Models
{
    public class RootObject 
    {
        public string OPERATION { get; set; }
        public string SENDERID { get; set; }
        public List<Customers> VALUES = new List<Customers>();
    }
    public class Customers
    {
        public int CUSTOMER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string GENDER { get; set; }
        public DateTime DOB { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string PANCARD { get; set; }
        public string ADHHAR { get; set; }
        public string ADDRESS { get; set; }
        public string PIN { get; set; }
        public string BRANCH { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string OFFICE_ADD { get; set; }
        public string OFFICE_PHONE { get; set; }
        public string WORK_EXP { get; set; }
        public string DESIGNATION { get; set; }
        public string ANNUAL_INCOME { get; set; }
        public string CASTE { get; set; }
        public string MEMBERSHIP_REASON { get; set; }
        public string VILLAGE_ADD { get; set; }
        public string VILL_DISTRICT { get; set; }
        public string VILL_STATE { get; set; }
        public string RESIDENTIAL_PROOF { get; set; }
        public string ID_PROOF { get; set; }
        public string REFERANCE_ID { get; set; }
        public string NOMINEE1 { get; set; }
        public string NOMINEE1_AGE { get; set; }
        public string NOMINEE1_RELATION { get; set; }
        public string NOMINEE1_ADD { get; set; }
        public string NOMINEE1_SHARE { get; set; }
        public string NOMINEE1_CONTACT { get; set; }
        public string NOMINEE2 { get; set; }
        public string NOMINEE2_AGE { get; set; }
        public string NOMINEE2_RELATION { get; set; }
        public string NOMINEE2_ADD { get; set; }
        public string NOMINEE2_SHARE { get; set; }
        public string NOMINEE2_CONTACT { get; set; }
        public string AMOUNT { get; set; }
        public bool ISACTIVE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public string UPDATEDBY { get; set; }
        public DateTime UPDATEDDATE { get; set; }
        public bool ISMEMBER { get; set; }

        //RECEIPTS table
        //public string ADHHAR  { get; set; }
        public string ENTRY_FEE { get; set; }
        public string TOTAL_SHARE { get; set; }
        public string STATIONARY { get; set; }
        public string SERVICE_CHARGE { get; set; }
        public string DAILY_AMT { get; set; }
        public string FD_AMT { get; set; }
        public string RD_AMT { get; set; }
        public string OTHERS { get; set; }
        //public string CREATEDDATE  { get; set; }
        //public string CREATEDBY  { get; set; }


        //REGPAYMENTDETAILS
        public string PAYMODE { get; set; }
        //public string ADHHAR  { get; set; }
        public string UPIPHONE { get; set; }
        public string UPITRANID { get; set; }
        public string CHECQUENO { get; set; }
        public string BANKNAME { get; set; }
        public string TOTALAMOUNT { get; set; }
        public string TRANSACTIONDATE { get; set; }
        //public string CREATEDDATE  { get; set; }
        //public string CREATEDBY  { get; set; }


        //[SHARES]
        public string SHARE_NO { get; set; }
        //public string ADHHAR  { get; set; }
        //public string CREATEDDATE  { get; set; }
        //public string CREATEDBY  { get; set; }
        //public string UPDATEDBY  { get; set; }
        //public DateTime UPDATEDDATE  { get; set; })





    }


    public class REGPAYMENTDETAILS
    {
        public string PAYMODE { get; set; }
        public string ADHHAR { get; set; }
        public string UPIPHONE { get; set; }
        public string UPITRANID { get; set; }
        public string CHECQUENO { get; set; }
        public string BANKNAME { get; set; }
        public string TOTALAMOUNT { get; set; }
        public string TRANSACTIONDATE { get; set; }
        public DateTime CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
    }



    public class RECEIPTS
    {
        public string ADHHAR { get; set; }
        public string ENTRY_FEE { get; set; }
        public string TOTAL_SHARE { get; set; }
        public string STATIONARY { get; set; }
        public string SERVICE_CHARGE { get; set; }
        public string DAILY_AMT { get; set; }
        public string FD_AMT { get; set; }
        public string RD_AMT { get; set; }
        public string OTHERS { get; set; }
        public string CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
    }

    public class SHARES
    {
        public string SHARE_NO { get; set; }
        public string ADHHAR { get; set; }
        public string CREATEDDATE { get; set; }
        public string CREATEDBY { get; set; }
        public string UPDATEDBY { get; set; }
        public string UPDATEDDATE { get; set; }
    }

}