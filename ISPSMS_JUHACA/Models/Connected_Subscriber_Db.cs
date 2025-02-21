using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Models
{
    public class Connected_Subscriber_Db
    {

        
            [Key]
            public int subs_id { get; set; }
            public string subs_name { get; set; }
            public string subs_contact_number { get; set; }
            public string subs_address { get; set; }
            public string subs_plan { get; set; }
            public string subs_status { get; set; }
            public string subs_duedate { get; set; }
            public string subs_current_duedate { get; set; }
            public string subs_installation_date { get; set; }
            public string subs_monthly_charge { get; set; }
            public string subs_balance { get; set; }
            public string subs_total_charge { get; set; }
            public string edit_button { get; set; }
            public string disconnect_button { get; set; }
      
    }
}
