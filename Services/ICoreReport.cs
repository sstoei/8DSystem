using _8DSystem.Models;
using _8DSystem.Models.Views;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Services
{
    public interface ICoreReport
    {
        Task<VerifyReference> GetVerifyReference(ReportHeader reportHeader);
        Task<CreateReference> GetCreateReferences();
        Task<Guid> AddReport(ReportHeader reportHeader, List<IFormFile> d0_attachments, List<IFormFile> d2_attachments, List<IFormFile> d3_attachments, List<IFormFile> d4_attachments, List<IFormFile> d5_attachments, List<IFormFile> d6_attachments, List<IFormFile> d7_attachments, List<IFormFile> d8_attachments, List<IFormFile> d2_attachmentRecurrings, List<IFormFile> d2_attachmentFailures, List<IFormFile> d2_ConformAttachments, List<IFormFile> d2_NonConformAttachments);
        Task<ReportHeader> GetReport(Guid id);
        Task<List<ReportHeader>> GetReport();
        Task EditReport(ReportHeader reportHeader, List<IFormFile> d0_attachments, List<IFormFile> d2_attachments, List<IFormFile> d3_attachments, List<IFormFile> d4_attachments, List<IFormFile> d5_attachments, List<IFormFile> d6_attachments, List<IFormFile> d7_attachments, List<IFormFile> d8_attachments, List<IFormFile> d2_attachmentRecurrings, List<IFormFile> d2_attachmentFailures, List<IFormFile> d2_ConformAttachments, List<IFormFile> d2_NonConformAttachments, string btnClick);

        Task DeleteFileD0(Guid id, int fileId);
        Task DeleteFile_D2AttachmentFailures(Guid id, int fileId);
        Task DeleteFile_D2AttachmentRecurrings(Guid id, int fileId);
        Task DeleteFile_D2Attachments(Guid id, int fileId);
        Task DeleteFile_D3Attachments(Guid id, int fileId);
        Task DeleteFile_D4Attachments(Guid id, int fileId);
        Task DeleteFile_D5Attachments(Guid id, int fileId);
        Task DeleteFile_D6Attachments(Guid id, int fileId);
        Task DeleteFile_D7Attachments(Guid id, int fileId);
        Task DeleteFile_D8Attachments(Guid id, int fileId);
    }
}
