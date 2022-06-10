using _8DSystem.Models;
using _8DSystem.Models.Views;
using _8DSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _8DSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICoreReport _report;
        private readonly IUserService _userService;
        private readonly INotify _notify;
        public HomeController(ILogger<HomeController> logger, ICoreReport report, IUserService userService, INotify notify)
        {
            _logger = logger;
            _report = report;
            _userService = userService;
            _notify = notify;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Edit2(Guid id)
        {
            var reportHeader = await _report.GetReport(id);
            var verifyRef = await _report.GetVerifyReference(reportHeader);
            var creator = _userService.GetCurrentEmpInfo(User.Identity.Name.Split('\\').Last());
            ViewBag.creator = creator;
            ViewBag.VerifyRef = verifyRef;
            return View(reportHeader);
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var reportHeader = await _report.GetReport(id);
            var verifyRef = await _report.GetVerifyReference(reportHeader);
            var creator = _userService.GetCurrentEmpInfo(User.Identity.Name.Split('\\').Last());
            ViewBag.creator = creator;
            ViewBag.VerifyRef = verifyRef;
            return View(reportHeader);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ReportHeader reportHeader, List<IFormFile> d0_attachments, List<IFormFile> d2_attachments, List<IFormFile> d3_attachments, List<IFormFile> d4_attachments, List<IFormFile> d5_attachments, List<IFormFile> d6_attachments, List<IFormFile> d7_attachments, List<IFormFile> d8_attachments, List<IFormFile> d2_attachmentRecurrings, List<IFormFile> d2_attachmentFailures, List<IFormFile> d2_ConformAttachments, List<IFormFile> d2_NonConformAttachments, string btnClick)
        {
            try
            {
                //Update Report
               
                await _report.EditReport(reportHeader, d0_attachments,d2_attachments, d3_attachments,  d4_attachments,d5_attachments,  d6_attachments, d7_attachments, d8_attachments, d2_attachmentRecurrings,d2_attachmentFailures, d2_ConformAttachments, d2_NonConformAttachments, btnClick);
                var report = await _report.GetReport(reportHeader.Id);
                if (report.WorkFlow.RefStatusId == StatusId.Completed || report.WorkFlow.RefStatusId == StatusId.WaitingApprove || report.WorkFlow.RefStatusId == StatusId.Rejected || report.WorkFlow.RefStatusId == StatusId.MgrApproved)
                {                   
                    _notify.SendEmail(report);
                }
                

                //return StatusCode(200, ret.Id);
                return StatusCode(200, report.Id);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        public async Task<IActionResult>  Create()
        {
            var refData = await _report.GetCreateReferences();
            var creator = _userService.GetCurrentEmpInfo(User.Identity.Name.Split('\\').Last());

            ViewBag.creator = creator;
            return View(refData);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ReportHeader reportHeader, List<IFormFile> d0_attachments, List<IFormFile> d2_attachments, List<IFormFile> d3_attachments, List<IFormFile> d4_attachments, List<IFormFile> d5_attachments, List<IFormFile> d6_attachments, List<IFormFile> d7_attachments, List<IFormFile> d8_attachments, List<IFormFile> d2_attachmentRecurrings, List<IFormFile> d2_attachmentFailures,List<IFormFile> d2_ConformAttachments, List<IFormFile> d2_NonConformAttachments)
        {
            try
            {
                await _report.AddReport(reportHeader, d0_attachments, d2_attachments, d3_attachments, d4_attachments, d5_attachments, d6_attachments, d7_attachments, d8_attachments, d2_attachmentRecurrings, d2_attachmentFailures, d2_ConformAttachments, d2_NonConformAttachments);

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

            return StatusCode(200, reportHeader.Id);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Detail()
        {
            var data = await _report.GetReport();
            return PartialView(data.ToList());
        }
        public async Task<FileResult> ViewfileD0(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D0s.Where(w=>w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D0_Attachments.FirstOrDefault(f => f.Id == fileId);
           // var fileData = fileD0.Where(w => w.Id == fileId).ToList();
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFileD0(Guid reportId, int fileId)
        {
            
            try
            {
                await _report.DeleteFileD0( reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D2AttachmentFailures(Guid reportId, int fileId)
        {
            

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D2s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D2_AttachmentFailures.FirstOrDefault(f => f.Id == fileId);            
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D2AttachmentFailures(Guid reportId, int fileId)
        {
           
            try
            {
                await _report.DeleteFile_D2AttachmentFailures(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D2AttachmentRecurrings(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D2s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D2_AttachmentFailures.FirstOrDefault(f => f.Id == fileId);
           
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D2AttachmentRecurrings(Guid reportId, int fileId)
        {
            
            try
            {
                await _report.DeleteFile_D2AttachmentRecurrings(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D2Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D2s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D2_Attachments.FirstOrDefault(f => f.Id == fileId);
            // var fileData = fileD0.Where(w => w.Id == fileId).ToList();
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D2Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D2Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D3Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D3s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D3_Attachments.FirstOrDefault(f => f.Id == fileId);
            // var fileData = fileD0.Where(w => w.Id == fileId).ToList();
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D3Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D3Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D4Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D4s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D4_Attachments.FirstOrDefault(f => f.Id == fileId);
            // var fileData = fileD0.Where(w => w.Id == fileId).ToList();
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D4Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D5Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D5Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D5s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D5_Attachments.FirstOrDefault(f => f.Id == fileId);
            // var fileData = fileD0.Where(w => w.Id == fileId).ToList();
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D5Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D5Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D6Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D6s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D6_Attachments.FirstOrDefault(f => f.Id == fileId);
           
            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D6Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D6Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D7Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D7s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D7_Attachments.FirstOrDefault(f => f.Id == fileId);

            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D7Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D7Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }
        public async Task<FileResult> Viewfile_D8Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);

            var data = await _report.GetReport(reportId);

            var dataAttach = data.D8s.Where(w => w.ReportHeaderId == reportId).ToList();
            var fileData = dataAttach.FirstOrDefault().D8_Attachments.FirstOrDefault(f => f.Id == fileId);

            return File(fileData.Content, fileData.ContentMimeType, fileData.ContentName);

        }
        public async Task<IActionResult> DeleteFile_D8Attachments(Guid reportId, int fileId)
        {
            //Guid.TryParse(reportId, out Guid idr);
            try
            {
                await _report.DeleteFile_D8Attachments(reportId, fileId);
                var ret = await _report.GetReport(reportId);
                return RedirectToAction(nameof(Edit), new { id = reportId });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }


        public IActionResult ActionTask() => PartialView();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
