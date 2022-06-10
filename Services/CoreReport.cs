using _8DSystem.Models;
using _8DSystem.Models.Views;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Services
{
    public class CoreReport : ICoreReport
    {
        private readonly CoreContext _db;
        private readonly IConfiguration _conf;
        public CoreReport(CoreContext db, IConfiguration configuration)
        {
            _db = db;
            _conf = configuration;
        }
        public async Task<VerifyReference> GetVerifyReference(ReportHeader reportHeader)
        {
            return new VerifyReference()
            {
                RefCauseSources = await _db.RefCauseSource.Where(w => w.Active).ToListAsync(),
                RefFunctions = await _db.RefFunction.Where(w => w.Active).ToListAsync(),
                EmpInfos = await _db.EmpInfo.Where(w => w.EmpStatus == 1 && !string.IsNullOrWhiteSpace(w.EmpEmail)).ToListAsync(),
                RefPCAStatuses = await _db.RefPCAStatus.Where(w => w.Active).ToListAsync()
            };
        }
        private string GetCode()
        {
            //SAT-8D-22-001

            string yy = DateTime.Now.ToString("yy");
            string prefix = "SAT-8D";
            try
            {
                var lastNo = _db.ReportHeader.OrderByDescending(o => o.Id).Select(s => s.Code).FirstOrDefault();
                int running = 0;
                if (lastNo != null)
                {
                    string[] spId = lastNo.Split("-");

                    if (spId[2] == yy)
                    {
                        running = Convert.ToInt32(spId[3]) + 1;
                    }
                    else
                    {
                        running = 1;
                    }
                    return prefix + "-" + yy + "-" + running.ToString("D3");

                }
                else
                {
                    return prefix + "-" + yy + "-001";
                }
            }
            catch
            {
                return prefix + "-" + yy + "-001";
            }
        }
        public async Task<Guid> AddReport(ReportHeader reportHeader, List<IFormFile> d0_attachments, List<IFormFile> d2_attachments, List<IFormFile> d3_attachments, List<IFormFile> d4_attachments, List<IFormFile> d5_attachments, List<IFormFile> d6_attachments, List<IFormFile> d7_attachments, List<IFormFile> d8_attachments, List<IFormFile> d2_attachmentRecurrings, List<IFormFile> d2_attachmentFailures, List<IFormFile> d2_ConformAttachments, List<IFormFile> d2_NonConformAttachments)
        {
            reportHeader.Code = GetCode();

            await _db.AddAsync(reportHeader);
            _db.SaveChanges();

            var d0 = _db.D0.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d0_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d0.D0_Attachments.Add(new D0_Attachment
                {
                    D0Id = d0.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
           

            var d2 = _db.D2.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d2_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_Attachments.Add(new D2_Attachment
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_attachmentRecurrings)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_AttachmentRecurrings.Add(new D2_AttachmentRecurring
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_attachmentFailures)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_AttachmentFailures.Add(new D2_AttachmentFailure
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_ConformAttachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_ImageConforms.Add(new D2_ImageConform
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_NonConformAttachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_ImageNoneConforms.Add(new D2_ImageNoneConform
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d3 = _db.D3.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d3_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d3.D3_Attachments.Add(new D3_Attachment
                {
                    D3Id = d3.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d4 = _db.D4.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d4_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d4.D4_Attachments.Add(new D4_Attachment
                {
                    D4Id = d4.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d5 = _db.D5.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d5_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d5.D5_Attachments.Add(new D5_Attachment
                {
                    D5Id = d5.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d6 = _db.D6.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d6_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d6.D6_Attachments.Add(new D6_Attachment
                {
                    D6Id = d6.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d7 = _db.D7.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d7_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d7.D7_Attachments.Add(new D7_Attachment
                {
                    D7Id = d7.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d8 = _db.D8.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d8_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d8.D8_Attachments.Add(new D8_Attachment
                {
                    D8Id = d8.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            _db.SaveChanges();

            return reportHeader.Id;
        }
        public async Task EditReport(ReportHeader reportHeader, List<IFormFile> d0_attachments, List<IFormFile> d2_attachments, List<IFormFile> d3_attachments, List<IFormFile> d4_attachments, List<IFormFile> d5_attachments, List<IFormFile> d6_attachments, List<IFormFile> d7_attachments, List<IFormFile> d8_attachments, List<IFormFile> d2_attachmentRecurrings, List<IFormFile> d2_attachmentFailures, List<IFormFile> d2_ConformAttachments, List<IFormFile> d2_NonConformAttachments, string btnClick)
        {
            var report = await _db.ReportHeader.FindAsync(reportHeader.Id);
            report.DateClosed = reportHeader.DateClosed;
            report.DateOpened = reportHeader.DateOpened;
            report.DateTargetedClosure = reportHeader.DateTargetedClosure;
            report.DateEffectivenessCheck = reportHeader.DateEffectivenessCheck;
            report.DateClosureD0 = reportHeader.DateClosureD0;
            report.DateClosureD1 = reportHeader.DateClosureD1;
            report.DateClosureD2 = reportHeader.DateClosureD2;
            report.DateClosureD3 = reportHeader.DateClosureD3;
            report.DateClosureD4 = reportHeader.DateClosureD4;
            report.DateClosureD5 = reportHeader.DateClosureD5;
            report.DateClosureD6 = reportHeader.DateClosureD6;
            report.DateClosureD7 = reportHeader.DateClosureD7;
            report.DateClosureD8 = reportHeader.DateClosureD8;
            report.NcrNo = reportHeader.NcrNo;
            report.WorkFlowId = reportHeader.WorkFlowId;


            var dataD0 = report.D0s.ToList();
            var dataD1 = report.D1s.ToList();
            var dataD2 = report.D2s.ToList();
            var dataD3 = report.D3s.ToList();
            var dataD4 = report.D4s.ToList();
            var dataD5 = report.D5s.ToList();
            var dataD6 = report.D6s.ToList();
            var dataD7 = report.D7s.ToList();
            var dataD8 = report.D8s.ToList();

            dataD0[0].D0_Comment = reportHeader.D0s.ToList()[0].D0_PartNumber;
            dataD0[0].D0_PartNumber = reportHeader.D0s.ToList()[0].D0_PartNumber;
            dataD0[0].D0_PartDescription = reportHeader.D0s.ToList()[0].D0_PartDescription;
            dataD0[0].D0_PONum = reportHeader.D0s.ToList()[0].D0_PONum;
            dataD0[0].D0_POItem = reportHeader.D0s.ToList()[0].D0_POItem;
            dataD0[0].D0_CustomerContact = reportHeader.D0s.ToList()[0].D0_CustomerContact;
            dataD0[0].D0_WitnessedBy = reportHeader.D0s.ToList()[0].D0_WitnessedBy;
            dataD0[0].D0_AffectedCustomerProduct = reportHeader.D0s.ToList()[0].D0_AffectedCustomerProduct;
            dataD0[0].D0_DeliveryAffected = reportHeader.D0s.ToList()[0].D0_DeliveryAffected;
            dataD0[0].D0_SuspectRootCauseIdentified = reportHeader.D0s.ToList()[0].D0_SuspectRootCauseIdentified;
            dataD0[0].D0_RootCauseVerified = reportHeader.D0s.ToList()[0].D0_RootCauseVerified;
            dataD0[0].D0_EmergencyRespondAction = reportHeader.D0s.ToList()[0].D0_EmergencyRespondAction;
            dataD0[0].D0_RecurringProblem = reportHeader.D0s.ToList()[0].D0_RecurringProblem;
            dataD0[0].D0_CustomerReference = reportHeader.D0s.ToList()[0].D0_CustomerReference;

            //D0_EmergencyRespondActions 
            if (dataD0[0].D0_EmergencyRespondActions.Any())
            {
                var dataD0Action = dataD0[0].D0_EmergencyRespondActions.ToList();
                _db.RemoveRange(dataD0Action);
            }
        
            if (reportHeader.D0s.ToList()[0].D0_EmergencyRespondActions != null)
            {
                foreach (var d in reportHeader.D0s.ToList()[0].D0_EmergencyRespondActions)
                {
                    dataD0[0].D0_EmergencyRespondActions.Add(new D0_EmergencyRespondAction
                    {
                        D0Id = dataD0[0].Id,
                        Action = d.Action,
                        TeamMemberId = d.TeamMemberId,
                        TeamMemberName = d.TeamMemberName,
                        TeamMemberEmail = d.TeamMemberEmail,
                        DateFinish = d.DateFinish,
                        DateStart = d.DateStart,
                        Metric = d.Metric,
                        Eff = d.Eff,
                        PartId = d.PartId
                        
                    });
                }
               
            }

            if (dataD1.Any())
            {
                _db.RemoveRange(report.D1s);
            }
            if (reportHeader.D1s != null)
            {
                foreach (var d in reportHeader.D1s)
                {
                    report.D1s.Add(new D1
                    {
                        ReportHeaderId = d.ReportHeaderId,
                        RefFunctionId = d.RefFunctionId,
                        D1_EmployeeId = d.D1_EmployeeId,
                        D1_Email = d.D1_Email,
                        D1_EmployeeName = d.D1_EmployeeName,
                        D1_DateStart = d.D1_DateStart,
                        D1_PhoneNo = d.D1_PhoneNo,                      

                    });
                }
            }

            //D2
            dataD2[0].D2_DefineCustomerExperience = reportHeader.D2s.ToList()[0].D2_DefineCustomerExperience;
            dataD2[0].D2_FailureMode = reportHeader.D2s.ToList()[0].D2_FailureMode;
            dataD2[0].D2_RequiredByTheSpecification = reportHeader.D2s.ToList()[0].D2_RequiredByTheSpecification;
            dataD2[0].D2_TheSpecificationDocument = reportHeader.D2s.ToList()[0].D2_TheSpecificationDocument;
            dataD2[0].D2_ProblemSource = reportHeader.D2s.ToList()[0].D2_ProblemSource;
            dataD2[0].D2_CustomerProblemTypeDefinition = reportHeader.D2s.ToList()[0].D2_CustomerProblemTypeDefinition;
            dataD2[0].D2_NumberOfPartsProducedWithinProblemBoundary = reportHeader.D2s.ToList()[0].D2_NumberOfPartsProducedWithinProblemBoundary;
            dataD2[0].D2_NumberOfPartsAffected = reportHeader.D2s.ToList()[0].D2_NumberOfPartsAffected;
            dataD2[0].D2_RecurringProblem = reportHeader.D2s.ToList()[0].D2_RecurringProblem;
            dataD2[0].D2_FailureModeInDPFMEA = reportHeader.D2s.ToList()[0].D2_FailureModeInDPFMEA;
            dataD2[0].D2_SupSupplier = reportHeader.D2s.ToList()[0].D2_SupSupplier;
            dataD2[0].D2_SupSupplierDetail = reportHeader.D2s.ToList()[0].D2_SupSupplierDetail;
            dataD2[0].D2_Organization = reportHeader.D2s.ToList()[0].D2_Organization;
            dataD2[0].D2_OrganizationDetail = reportHeader.D2s.ToList()[0].D2_OrganizationDetail;
            dataD2[0].D2_Customer = reportHeader.D2s.ToList()[0].D2_Customer;
            dataD2[0].D2_CustomerDetail = reportHeader.D2s.ToList()[0].D2_CustomerDetail;
            dataD2[0].D2_Other1 = reportHeader.D2s.ToList()[0].D2_Other1;
            dataD2[0].D2_Other1Detail = reportHeader.D2s.ToList()[0].D2_Other1Detail;
            dataD2[0].D2_CustomerOfCustomer = reportHeader.D2s.ToList()[0].D2_CustomerOfCustomer;
            dataD2[0].D2_CustomerOfCustomerDetail = reportHeader.D2s.ToList()[0].D2_CustomerOfCustomerDetail;
            dataD2[0].D2_AircraftOperators = reportHeader.D2s.ToList()[0].D2_AircraftOperators;
            dataD2[0].D2_AircraftOperatorsDetail = reportHeader.D2s.ToList()[0].D2_AircraftOperatorsDetail;
            dataD2[0].D2_SpareParts = reportHeader.D2s.ToList()[0].D2_SpareParts;
            dataD2[0].D2_SparePartsDetail = reportHeader.D2s.ToList()[0].D2_SparePartsDetail;
            dataD2[0].D2_Other2 = reportHeader.D2s.ToList()[0].D2_Other2;
            dataD2[0].D2_Other2Detail = reportHeader.D2s.ToList()[0].D2_Other2Detail;
            dataD2[0].D2_ProblemPartEarliestKnownAwarenessDate = reportHeader.D2s.ToList()[0].D2_ProblemPartEarliestKnownAwarenessDate;
            dataD2[0].D2_ProblemPartEarliestKnownOccurrenceDate = reportHeader.D2s.ToList()[0].D2_ProblemPartEarliestKnownOccurrenceDate;
            dataD2[0].D2_ProblemPartEarliestKnownShipmentDate = reportHeader.D2s.ToList()[0].D2_ProblemPartEarliestKnownShipmentDate;

            //D3
            dataD3[0].CopyFromD0 = reportHeader.D3s.ToList()[0].CopyFromD0;

            if (dataD3[0].D3_Actions.Any())
            {
                _db.RemoveRange(dataD3[0].D3_Actions);
            }
            var actionD3 = dataD3[0].D3_Actions.ToList();
            if (reportHeader.D3s.ToList()[0].D3_Actions != null)
            {
                foreach (var d in reportHeader.D3s.ToList()[0].D3_Actions)
                {
                    dataD3[0].D3_Actions.Add(new D3_Action
                    {
                        D3Id = dataD3[0].Id,
                        D3_Detail = d.D3_Detail,
                        D3_TeamMember = d.D3_TeamMember,
                        D3_TeamMemberName = d.D3_TeamMemberName,
                        D3_TeamMemberEmail = d.D3_TeamMemberEmail,
                        D3_DateFinish = d.D3_DateFinish,
                        D3_DateStart = d.D3_DateStart,
                        D3_Eff = d.D3_Eff,
                        D3_Metric = d.D3_Metric,
                        D3_PartId = d.D3_PartId,

                    });
                }
            }

            dataD4[0].D4_HasEscapePointCausesBeenAddressed = true;//reportHeader.D4s.ToList()[0].D4_HasEscapePointCausesBeenAddressed;
            dataD4[0].D4_CanCausesExplainDifferences = reportHeader.D4s.ToList()[0].D4_CanCausesExplainDifferences;
            dataD4[0].D4_IdentifyCausesInProcessFMEA = reportHeader.D4s.ToList()[0].D4_IdentifyCausesInProcessFMEA;
            dataD4[0].D4_FishBone = reportHeader.D4s.ToList()[0].D4_FishBone;
            dataD4[0].D4_FiveWhy = reportHeader.D4s.ToList()[0].D4_FiveWhy;

            dataD4[0].FishBone_Main = reportHeader.D4s.ToList()[0].FishBone_Main;
            dataD4[0].FishBone_Machine = reportHeader.D4s.ToList()[0].FishBone_Machine;
            dataD4[0].FishBone_Manufacturing = reportHeader.D4s.ToList()[0].FishBone_Manufacturing;
            dataD4[0].FishBone_Measurement = reportHeader.D4s.ToList()[0].FishBone_Measurement;
            dataD4[0].FishBone_Material = reportHeader.D4s.ToList()[0].FishBone_Material;
            dataD4[0].FishBone_Environment = reportHeader.D4s.ToList()[0].FishBone_Environment;
           
            dataD4[0].DefineTheProblem = reportHeader.D4s.ToList()[0].DefineTheProblem;
            dataD4[0].Why1 = reportHeader.D4s.ToList()[0].Why1;
            dataD4[0].Why2 = reportHeader.D4s.ToList()[0].Why2;
            dataD4[0].Why3 = reportHeader.D4s.ToList()[0].Why3;
            dataD4[0].Why4 = reportHeader.D4s.ToList()[0].Why4;

            dataD4[0].How1 = reportHeader.D4s.ToList()[0].How1;
            dataD4[0].How2 = reportHeader.D4s.ToList()[0].How2;
            dataD4[0].How3 = reportHeader.D4s.ToList()[0].How3;
            dataD4[0].How4 = reportHeader.D4s.ToList()[0].How4;

            var actionD4 = dataD4[0].D4_CauseSources.ToList();
            if (actionD4.Any())
            {
                _db.RemoveRange(actionD4);
            }
            if (reportHeader.D4s.ToList()[0].D4_CauseSources != null)
            {
                foreach (var d in reportHeader.D4s.ToList()[0].D4_CauseSources)
                {
                    dataD4[0].D4_CauseSources.Add(new D4_CauseSource
                    {
                        D4Id = dataD4[0].Id,
                        RefCauseSourceId = d.RefCauseSourceId,
                        CauseDescription = d.CauseDescription,
                        VerificationMethod = d.VerificationMethod,
                        Verified = d.Verified,
                        Date = d.Date,
                    });
                }
            }

            var actionD5 = dataD5[0].D5_Actions.ToList();
            if (actionD5.Any())
            {
                _db.RemoveRange(actionD5);
            }
            if (reportHeader.D5s.ToList()[0].D5_Actions != null)
            {
                foreach (var d in reportHeader.D5s.ToList()[0].D5_Actions)
                {
                    dataD5[0].D5_Actions.Add(new D5_Action
                    {
                        D5Id = dataD5[0].Id,
                        RefCauseSourceId = d.RefCauseSourceId,
                        Detail = d.Detail,
                        VerificationMethod = d.VerificationMethod,
                        Verify = d.Verify,
                        Date = d.Date,
                    });
                }
            }

            var actionD6 = dataD6[0].D6_Actions.ToList();

            if (actionD6.Any())
            {
                _db.RemoveRange(actionD6);
            }
            if (reportHeader.D6s.ToList()[0].D6_Actions != null)
            {
                foreach (var d in reportHeader.D6s.ToList()[0].D6_Actions)
                {
                    dataD6[0].D6_Actions.Add(new D6_Action
                    {
                        D6Id = dataD6[0].Id,
                        Detail = d.Detail,
                        ImplementationPlan = d.ImplementationPlan,
                        TeamMemberId = d.TeamMemberId,
                        TeamMemberEmail = d.TeamMemberEmail,
                        TeamMemberName = d.TeamMemberName,
                        CustomerConcurrence = d.CustomerConcurrence,
                        ImplementActionDate = d.ImplementActionDate,
                        VerificationMethod = d.VerificationMethod,
                        RefPCAStatusId = d.RefPCAStatusId,
                       
                    });
                }
            }

            var actionD7A = dataD7[0].D7_As.ToList();
            if (actionD7A.Any())
            {
                _db.RemoveRange(actionD7A);
            }
            if (reportHeader.D7s.ToList()[0].D7_As != null)
            {
                foreach (var d in reportHeader.D7s.ToList()[0].D7_As)
                {
                    dataD7[0].D7_As.Add(new D7_A
                    {
                        D7Id = dataD7[0].Id,
                        PreventiveAction = d.PreventiveAction,
                        PAImplementationPlan = d.PAImplementationPlan,
                        TeamMemberId = d.TeamMemberId,
                        TeamMemberEmail = d.TeamMemberEmail,
                        TeamMemberName = d.TeamMemberName,
                        TargetDate = d.TargetDate,
                        ActualDate = d.ActualDate,
                        RefPCAStatusId = d.RefPCAStatusId,

                    });
                }
            }

            var actionD7B = dataD7[0].D7_Bs.ToList();
            if (actionD7B.Any())
            {
                _db.RemoveRange(actionD7B);
            }
            if (reportHeader.D7s.ToList()[0].D7_Bs != null)
            {
                foreach (var d in reportHeader.D7s.ToList()[0].D7_Bs)
                {
                    dataD7[0].D7_Bs.Add(new D7_B
                    {
                        D7Id = dataD7[0].Id,
                        Process = d.Process,
                        Responsible = d.Responsible,
                        PlanValidationDate = d.PlanValidationDate,
                       
                    });
                }
            }

            var actionD7C = dataD7[0].D7_Cs.ToList();
            if (actionD7C.Any())
            {
                _db.RemoveRange(actionD7C);
            }
            if (reportHeader.D7s.ToList()[0].D7_Cs != null)
            {
                foreach (var d in reportHeader.D7s.ToList()[0].D7_Cs)
                {
                    dataD7[0].D7_Cs.Add(new D7_C
                    {
                        D7Id = dataD7[0].Id,
                        NatureOfRevisionNo1 = d.NatureOfRevisionNo1,
                        NatureOfRevisionNo2 = d.NatureOfRevisionNo2,
                        NatureOfRevisionNo3 = d.NatureOfRevisionNo3,
                        NatureOfRevisionNo4 = d.NatureOfRevisionNo4,
                        NatureOfRevisionNo5 = d.NatureOfRevisionNo5,
                        NatureOfRevisionNo6 = d.NatureOfRevisionNo6,
                        NatureOfRevisionNo7 = d.NatureOfRevisionNo7,
                        NatureOfRevisionNo8 = d.NatureOfRevisionNo8,
                        NatureOfRevisionNo9 = d.NatureOfRevisionNo9,
                        NatureOfRevisionNo10= d.NatureOfRevisionNo10,
                        NatureOfRevisionNo11 = d.NatureOfRevisionNo11,
                        NatureOfRevisionNo12 = d.NatureOfRevisionNo12,
                        NatureOfRevisionNo13 = d.NatureOfRevisionNo13,
                        NatureOfRevisionNo14 = d.NatureOfRevisionNo14,
                        NatureOfRevisionNo15 = d.NatureOfRevisionNo15,

                        Resp1 = d.Resp1,
                        Resp2 = d.Resp2,
                        Resp3 = d.Resp3,
                        Resp4 = d.Resp4,
                        Resp5 = d.Resp5,
                        Resp6 = d.Resp6,
                        Resp7 = d.Resp7,
                        Resp8 = d.Resp8,
                        Resp9 = d.Resp9,
                        Resp10 = d.Resp10,
                        Resp11 = d.Resp11,
                        Resp12 = d.Resp12,
                        Resp13 = d.Resp13,
                        Resp14 = d.Resp14,
                        Resp15 = d.Resp15,

                        PlanDate1 = d.PlanDate1,
                        PlanDate2 = d.PlanDate2,
                        PlanDate3 = d.PlanDate3,
                        PlanDate4 = d.PlanDate4,
                        PlanDate5 = d.PlanDate5,
                        PlanDate6 = d.PlanDate6,
                        PlanDate7 = d.PlanDate7,
                        PlanDate8 = d.PlanDate8,
                        PlanDate9 = d.PlanDate9,
                        PlanDate10= d.PlanDate10,
                        PlanDate11 = d.PlanDate11,
                        PlanDate12 = d.PlanDate12,
                        PlanDate13 = d.PlanDate13,
                        PlanDate14 = d.PlanDate14,
                        PlanDate15 = d.PlanDate15,

                        ActualDate1  = d.ActualDate1 ,
                        ActualDate2  = d.ActualDate2 ,
                        ActualDate3  = d.ActualDate3 ,
                        ActualDate4  = d.ActualDate4 ,
                        ActualDate5  = d.ActualDate5 ,
                        ActualDate6  = d.ActualDate6 ,
                        ActualDate7  = d.ActualDate7 ,
                        ActualDate8  = d.ActualDate8 ,
                        ActualDate9  = d.ActualDate9 ,
                        ActualDate10 = d.ActualDate10,
                        ActualDate11 = d.ActualDate11,
                        ActualDate12 = d.ActualDate12,
                        ActualDate13 = d.ActualDate13,
                        ActualDate14 = d.ActualDate14,
                        ActualDate15 = d.ActualDate15,
                       

                    });
                }
            }
           

            var actionD8A = dataD8[0].D8_As.ToList();
            if (actionD8A.Any())
            {
                _db.RemoveRange(actionD8A);
            }
            if (reportHeader.D8s.ToList()[0].D8_As != null)
            {
                foreach (var d in reportHeader.D8s.ToList()[0].D8_As)
                {
                    dataD8[0].D8_As.Add(new D8_A
                    {
                        D8Id = dataD8[0].Id,
                        PlanDate = d.PlanDate,                      
                        ActualDate = d.ActualDate,

                    });
                }
            }
            
            if(reportHeader.WorkFlowId == 6)
            {
                var actionD8B = dataD8[0].D8_Bs.ToList();

                if (actionD8B.Any())
                {
                    _db.RemoveRange(actionD8B);
                }
                if (reportHeader.D8s.ToList()[0].D8_Bs != null)
                {
                    foreach (var d in reportHeader.D8s.ToList()[0].D8_Bs)
                    {
                       
                        dataD8[0].D8_Bs.Add(new D8_B
                        {
                            D8Id = dataD8[0].Id,
                            Title1 = d.Title1,
                            Title2 = d.Title2,
                            Signature1 = d.Signature1,
                            Signature2 = d.Signature2,
                            Date1 = DateTime.Now,
                            Date2 = DateTime.Now


                        });
                    }
                }

            }
         

            var actionD8C = dataD8[0].D8_Cs.ToList();
            if (actionD8C.Any())
            {
                _db.RemoveRange(actionD8C);
            }
            if (reportHeader.D8s.ToList()[0].D8_Cs != null)
            {
                foreach (var d in reportHeader.D8s.ToList()[0].D8_Cs)
                {

                    dataD8[0].D8_Cs.Add(new D8_C
                    {
                        D8Id = dataD8[0].Id,
                        When = d.When,
                        Where = d.Where,
                        How = d.How,                       

                    });
                }
            }



            await _db.SaveChangesAsync();

            var d0 = _db.D0.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d0_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d0.D0_Attachments.Add(new D0_Attachment
                {
                    D0Id = d0.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }


            var d2 = _db.D2.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d2_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_Attachments.Add(new D2_Attachment
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_attachmentRecurrings)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_AttachmentRecurrings.Add(new D2_AttachmentRecurring
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_attachmentFailures)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_AttachmentFailures.Add(new D2_AttachmentFailure
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_ConformAttachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_ImageConforms.Add(new D2_ImageConform
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }
            foreach (var file in d2_NonConformAttachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d2.D2_ImageNoneConforms.Add(new D2_ImageNoneConform
                {
                    D2Id = d2.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d3 = _db.D3.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d3_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d3.D3_Attachments.Add(new D3_Attachment
                {
                    D3Id = d3.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d4 = _db.D4.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d4_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d4.D4_Attachments.Add(new D4_Attachment
                {
                    D4Id = d4.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d5 = _db.D5.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d5_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d5.D5_Attachments.Add(new D5_Attachment
                {
                    D5Id = d5.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d6 = _db.D6.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d6_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d6.D6_Attachments.Add(new D6_Attachment
                {
                    D6Id = d6.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d7 = _db.D7.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d7_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d7.D7_Attachments.Add(new D7_Attachment
                {
                    D7Id = d7.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            var d8 = _db.D8.Where(w => w.ReportHeaderId == reportHeader.Id).FirstOrDefault();
            foreach (var file in d8_attachments)
            {
                using var ms = new MemoryStream();
                file.CopyTo(ms);
                d8.D8_Attachments.Add(new D8_Attachment
                {
                    D8Id = d8.Id,
                    Content = ms.ToArray(),
                    ContentName = file.FileName,
                    ContentMimeType = file.ContentType
                });

            }

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<CreateReference> GetCreateReferences()
        {

            return new CreateReference()
            {
                EmpSections = await _db.EmpSection.ToListAsync(),
                EmpInfos = await _db.EmpInfo.Where(w => !string.IsNullOrWhiteSpace(w.EmpEmail)).ToListAsync(),
                EmpDepartments = await _db.EmpDepartment.ToListAsync(),
                RefCauseSources = await _db.RefCauseSource.ToListAsync(),
                RefFunctions = await _db.RefFunction.Where(w => w.Active).ToListAsync(),
                RefPCAStatuses = await _db.RefPCAStatus.Where(w => w.Active).ToListAsync(),
                WorkFlows = await _db.WorkFlow.ToListAsync(),

            };
        }

        public async Task<List<ReportHeader>> GetReport() => await _db.ReportHeader.ToListAsync();

        public async Task<ReportHeader> GetReport(Guid id) =>

           await _db.ReportHeader
            .Include(i => i.WorkFlow).ThenInclude(t => t.RefStatus)
            .FirstOrDefaultAsync(f => f.Id == id);

        public async Task<List<ReportHeader>> GetMyTask()
        { 
            var report = await _db.ReportHeader
                .Include(i=>i.WorkFlow).ThenInclude(t=>t.RefStatus).ToListAsync();

            return report;
        }

        public async Task DeleteFileD0( Guid reportId, int fileId)
        {
           // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D0s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D0_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D2AttachmentFailures(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D2s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D2_AttachmentFailures.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D2AttachmentRecurrings(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D2s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D2_AttachmentRecurrings.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D2Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D2s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D2_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D3Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D3s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D3_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D4Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D4s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D4_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        } 
        public async Task DeleteFile_D5Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D5s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D5_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D6Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D6s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D6_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D7Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D7s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D7_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task DeleteFile_D8Attachments(Guid reportId, int fileId)
        {
            // Guid.TryParse(reportId, out Guid idr);
            var report = await _db.ReportHeader.FindAsync(reportId);
            var data = report.D8s.Where(w => w.ReportHeaderId == reportId).ToList();
            var attachments = data.FirstOrDefault().D8_Attachments.Where(x => x.Id == fileId);
            _db.RemoveRange(attachments);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
