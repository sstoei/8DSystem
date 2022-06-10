using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class D0
    {
        public D0(){
            D0_Attachments = new HashSet<D0_Attachment>();
            D0_EmergencyRespondActions = new HashSet<D0_EmergencyRespondAction>();
          
        }


      
        public int Id { get; set; }
        public string D0_Comment { get; set; }
        [StringLength(100)]
        public string D0_PartNumber { get; set; }
        public string D0_PartDescription { get; set; }
        [StringLength(100)]
        public string D0_PONum { get; set; }
        public string D0_POItem { get; set; }
        public string D0_CustomerContact { get; set; }
        public string D0_WitnessedBy { get; set; }
        public string D0_AffectedCustomerProduct { get; set; }
        public string D0_CustomerReference { get; set; }
        public bool? D0_DeliveryAffected { get; set; }
        public bool? D0_SuspectRootCauseIdentified { get; set; }
        public bool? D0_RootCauseVerified { get; set; }
        public bool? D0_EmergencyRespondAction { get; set; }
        public bool? D0_RecurringProblem  { get; set; }       
       

        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }
        public virtual ICollection<D0_Attachment> D0_Attachments { get; set; }
        public virtual ICollection<D0_EmergencyRespondAction> D0_EmergencyRespondActions { get; set; }
        
    }
}
