using BrentEdwardsOnlineDotNetCore.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrentEdwardsOnlineDotNetCore.Controllers
{
    [Route("api/[controller]")]
    public class QualificationController : Controller
    {
        private ApplicationDbContext _context; // = new ApplicationDbContext();

        public QualificationController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        //[Authorize]
        public IEnumerable<Qualification> GetAll()
        {
            var result = this._context.Qualifications
                                      .Include(q => q.Provider)
                                      .Select(q => new Qualification {
                                                                        Name = q.Name,
                                                                        Description = q.Description,
                                                                        CertificateUrl = q.CertificateUrl,
                                                                        StartDate = q.StartDate,
                                                                        EndDate = q.EndDate,
                                                                        Provider = q.Provider });
            return result;
        }
    }
}
