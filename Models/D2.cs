using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
   
    public class D2
    {
        public D2()
        {
            D2_Attachments = new HashSet<D2_Attachment>();
            D2_AttachmentRecurrings = new HashSet<D2_AttachmentRecurring>();
            D2_AttachmentFailures = new HashSet<D2_AttachmentFailure>();
            D2_ImageNoneConforms = new HashSet<D2_ImageNoneConform>();
           D2_ImageConforms = new HashSet<D2_ImageConform>();
        }
        public int Id { get; set; }
        public string D2_DefineCustomerExperience { get; set; }
        public string D2_FailureMode { get; set; }
        public string D2_RequiredByTheSpecification { get; set; }
        public string D2_TheSpecificationDocument { get; set; }
        public string D2_ProblemSource { get; set; }
        public string D2_CustomerProblemTypeDefinition { get; set; }
        public decimal? D2_NumberOfPartsProducedWithinProblemBoundary { get; set; }
        public decimal? D2_NumberOfPartsAffected { get; set; }
        public decimal? D2_PercenOfPartsAffected { get; set; }
        public bool? D2_RecurringProblem { get; set; }
        public bool? D2_FailureModeInDPFMEA { get; set; }
        public bool? D2_SupSupplier { get; set; }
        public string D2_SupSupplierDetail { get; set; }
        public bool? D2_Organization { get; set; }
        public string D2_OrganizationDetail { get; set; }
        public bool? D2_Customer { get; set; }
        public string D2_CustomerDetail { get; set; }
        public bool? D2_Other1 { get; set; }
        public string D2_Other1Detail { get; set; }
        public bool? D2_CustomerOfCustomer { get; set; }
        public string D2_CustomerOfCustomerDetail { get; set; }
        public bool? D2_AircraftOperators { get; set; }
        public string D2_AircraftOperatorsDetail { get; set; }
        public bool D2_SpareParts { get; set; }
        public string D2_SparePartsDetail { get; set; }
        public bool D2_Other2 { get; set; }
        public string D2_Other2Detail { get; set; }
        public DateTime? D2_ProblemPartEarliestKnownOccurrenceDate { get; set; }
        public DateTime? D2_ProblemPartEarliestKnownAwarenessDate { get; set; }
        public DateTime? D2_ProblemPartEarliestKnownShipmentDate { get; set; }
     
        public Guid ReportHeaderId { get; set; }
        public virtual ReportHeader ReportHeader { get; set; }

        public virtual ICollection<D2_Attachment> D2_Attachments { get; set; }
        public virtual ICollection<D2_AttachmentRecurring> D2_AttachmentRecurrings { get; set; }
        public virtual ICollection<D2_AttachmentFailure> D2_AttachmentFailures { get; set; }
        public virtual ICollection<D2_ImageConform> D2_ImageConforms { get; set; }
        public virtual ICollection<D2_ImageNoneConform> D2_ImageNoneConforms { get; set; }
    }
}
