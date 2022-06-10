using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Models
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options)
            : base(options) { }
        public virtual DbSet<ReportHeader> ReportHeader { get; set; }
        public virtual DbSet<D0> D0 { get; set; }
        public virtual DbSet<D0_Attachment> D0_Attachment { get; set; }
        public virtual DbSet<D0_EmergencyRespondAction> D0_EmergencyRespondAction { get; set; }
        public virtual DbSet<D1> D1 { get; set; }
        public virtual DbSet<D2> D2 { get; set; }
        public virtual DbSet<D2_Attachment> D2_Attachment { get; set; }
        public virtual DbSet<D2_AttachmentRecurring> D2_AttachmentRecurring { get; set; }
        public virtual DbSet<D2_AttachmentFailure> D2_AttachmentFailure { get; set; }
        public virtual DbSet<D2_ImageConform> D2_ImageConform { get; set; }
        public virtual DbSet<D2_ImageNoneConform> D2_ImageNoneConform { get; set; }
        public virtual DbSet<D3> D3 { get; set; }
        public virtual DbSet<D3_Attachment> D3_Attachment { get; set; }
        public virtual DbSet<D4> D4 { get; set; }
        public virtual DbSet<D4_Attachment> D4_Attachment { get; set; }
        public virtual DbSet<D4_CauseSource> D4_CauseSource { get; set; }      
        public virtual DbSet<D5> D5 { get; set; }
        public virtual DbSet<D5_Action> D5_Action { get; set; }
        public virtual DbSet<D5_Attachment> D5_Attachment { get; set; }
        public virtual DbSet<D6> D6 { get; set; }
        public virtual DbSet<D6_Action> D6_Action { get; set; }
        public virtual DbSet<D6_Attachment> D6_Attachment { get; set; }
        public virtual DbSet<D7> D7 { get; set; }
        public virtual DbSet<D7_A> D7_A { get; set; }
        public virtual DbSet<D7_B> D7_B { get; set; }
        public virtual DbSet<D7_C> D7_C { get; set; }
        public virtual DbSet<D7_Attachment> D7_Attachment { get; set; }
        public virtual DbSet<D8> D8 { get; set; }
        public virtual DbSet<D8_A> D8_A { get; set; }
        public virtual DbSet<D8_B> D8_B { get; set; }
        public virtual DbSet<D8_C> D8_C { get; set; }
        public virtual DbSet<D8_Attachment> D8_Attachment { get; set; }
        public virtual DbSet<RefCauseSource> RefCauseSource { get; set; }
        public virtual DbSet<RefFunction> RefFunction { get; set; }
        public virtual DbSet<RefPCAStatus> RefPCAStatus { get; set; }
        public virtual DbSet<RefStatus> RefStatus { get; set; }
        public virtual DbSet<WorkFlow> WorkFlow { get; set; }

        public virtual DbSet<EmpInfo> EmpInfo { get; set; }
        public virtual DbSet<EmpDepartment> EmpDepartment { get; set; }
        public virtual DbSet<EmpSection> EmpSection { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpInfo>(entity =>
            {
                entity.HasKey(e => e.EmpId);
                entity.ToView("EmpInfo");
            });

            modelBuilder.Entity<EmpDepartment>(entity =>
            {
                entity.HasKey(e => e.EmpDepartmentId);
                entity.ToView("EmpDepartment");
            });

            modelBuilder.Entity<EmpSection>(entity =>
            {
                entity.HasKey(e => e.EmpSectionId);
                entity.ToView("EmpSection");
            });


        }
    }
}
