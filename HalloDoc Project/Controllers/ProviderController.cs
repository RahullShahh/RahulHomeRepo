using DAL.DataContext;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static HalloDoc_Project.Extensions.Enumerations;

namespace HalloDoc_Project.Controllers
{
    [CustomAuthorize("Physician")]

    public class ProviderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProviderController(ApplicationDbContext context)
        {
            _context=context;
        }
        public IActionResult ProviderDashboard()
        {
            return View();
        }
        //public IActionResult Dashboard()
        //{
        //    string? phyName = HttpContext.Request.Headers.Where(x => x.Key == "userName").FirstOrDefault().Value;
        //    int phyId = Convert.ToInt32(HttpContext.Request.Headers.Where(x => x.Key == "userId").FirstOrDefault().Value);

        //    if (phyName == null)
        //    {
        //        return RedirectToAction("submit_request_page", "Guest");
        //    }


        //    ProviderDashboardViewModel model = new ProviderDashboardViewModel();
        //    model.UserName = phyName;
        //    model.physicians = _context.Physicians;
        //    model.regions = _context.Regions;
        //    model.NewReqCount = _context.Requests.Count(r => r.Physicianid == phyId && r.Status == (short)RequestStatus.Unassigned);
        //    model.PendingReqCount = _context.Requests.Count(r => r.Physicianid == phyId && r.Status == (short)RequestStatus.Accepted);
        //    model.ActiveReqCount = _context.Requests.Count(r => r.Physicianid == phyId && ((r.Status == (short)RequestStatus.MDEnRoute) || (r.Status == (short)RequestStatus.MDOnSite)));
        //    model.ConcludeReqCount = _context.Requests.Count(r => r.Physicianid == phyId && r.Status == (short)RequestStatus.Conclude);
        //    model.casetags = _context.Casetags;

        //    return View("Header/Dashboard", model);

        //}
        //[HttpPost]
        //public async Task<ActionResult> PartialTable(int status, int page, int typeFilter, string searchFilter, int regionFilter)
        //{

        //    HttpContext.Session.SetInt32("currentStatus", status);
        //    HttpContext.Session.SetInt32("currentPage", page);
        //    HttpContext.Session.SetInt32("currentTypeFilter", typeFilter);
        //    HttpContext.Session.SetInt32("currentRegionFilter", regionFilter);
        //    HttpContext.Session.SetString("currentSearchFilter", searchFilter ?? "");

        //    int phyId = Convert.ToInt32(HttpContext.Request.Headers.Where(x => x.Key == "userId").FirstOrDefault().Value);

        //    int pageNumber = 1;
        //    if (page > 0)
        //    {
        //        pageNumber = page;
        //    }

        //    DashboardFilter filter = new DashboardFilter()
        //    {
        //        RequestTypeFilter = typeFilter,
        //        PatientSearchText = searchFilter,
        //        RegionFilter = regionFilter,
        //        pageNumber = pageNumber,
        //        pageSize = 5,
        //        status = status,
        //    };

        //    List<ProviderRequestViewModel> RequestList = await GetProviderRequests(filter, phyId);

        //    ProviderDashboardViewModel model = new ProviderDashboardViewModel();
        //    model.RequestList = RequestList;
        //    model.DashboardStatus = status;
        //    model.CurrentPage = pageNumber;
        //    model.filterOptions = filter;

        //    return PartialView("ProviderDashboardPartialTable", model);
        //}

        //public async Task<List<ProviderRequestViewModel>> GetProviderRequests(DashboardFilter dashboardParams, int physicianId)
        //{
        //    int pageNumber = dashboardParams.pageNumber;

        //    if (dashboardParams.pageNumber < 1)
        //    {
        //        pageNumber = 1;
        //    }

        //    List<short> validRequestTypes = new List<short>();
        //    switch (dashboardParams.status)
        //    {
        //        case (int)DashboardStatus.New:
        //            validRequestTypes.Add((short)RequestStatus.Unassigned);
        //            break;
        //        case (int)DashboardStatus.Pending:
        //            validRequestTypes.Add((short)RequestStatus.Accepted);
        //            break;
        //        case (int)DashboardStatus.Active:
        //            validRequestTypes.Add((short)RequestStatus.MDEnRoute);
        //            validRequestTypes.Add((short)RequestStatus.MDOnSite);
        //            break;
        //        case (int)DashboardStatus.Conclude:
        //            validRequestTypes.Add((short)RequestStatus.Conclude);
        //            break;
        //        case (int)DashboardStatus.ToClose:
        //            validRequestTypes.Add((short)RequestStatus.Cancelled);
        //            validRequestTypes.Add((short)RequestStatus.CancelledByPatient);
        //            validRequestTypes.Add((short)RequestStatus.Closed);

        //            break;
        //        case (int)DashboardStatus.Unpaid:
        //            validRequestTypes.Add((short)RequestStatus.Unpaid);
        //            break;
        //    }

        //    var query = (from r in _context.Requests
        //                 where (r.Physicianid == physicianId)
        //                 && validRequestTypes.Contains(r.Status)
        //                 join rc in _context.Requestclients on r.Requestid equals rc.Requestid
        //                 where (dashboardParams.RequestTypeFilter == 0 || r.Requesttypeid == dashboardParams.RequestTypeFilter)
        //                 && (dashboardParams.RegionFilter == 0 || rc.Regionid == dashboardParams.RegionFilter)
        //                 && (string.IsNullOrEmpty(dashboardParams.PatientSearchText) || (rc.Firstname + " " + rc.Lastname).ToLower().Contains(dashboardParams.PatientSearchText.ToLower()))
        //                 join form in _context.Encounterforms on r.Requestid equals form.Requestid into formGroup
        //                 from formItem in formGroup.DefaultIfEmpty()
        //                 select new ProviderRequestViewModel
        //                 {
        //                     IsHouseCall = (r.Status == (int)RequestStatus.MDOnSite) ? true : false,
        //                     RequestId = r.Requestid,
        //                     Email = rc.Email,
        //                     PatientName = rc.Firstname + " " + rc.Lastname,
        //                     RequestType = r.Requesttypeid,
        //                     PatientPhone = rc.Phonenumber,
        //                     Phone = r.Phonenumber,
        //                     Address = rc.Address,
        //                     IsFinalize = formItem.Isfinalize ? true : false,
        //                 }).ToList();
        //    return query;

        //}

    }

}
