using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Helseportalen.Api.Data;
using Helseportalen.Api.Models;

namespace Helseportalen.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthRecordController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HealthRecordController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/healthrecord/{patientId}
        [HttpGet("{patientId}")]
        public async Task<ActionResult<IEnumerable<HealthRecord>>> GetRecords(Guid patientId)
        {
            return await _context.HealthRecords
                .Where(r => r.PatientId == patientId)
                .ToListAsync();
        }

        // POST: api/healthrecord
        [HttpPost]
        public async Task<ActionResult<HealthRecord>> CreateRecord(HealthRecord record)
        {
            record.Id = Guid.NewGuid();
            record.CreatedAt = DateTime.UtcNow;
            _context.HealthRecords.Add(record);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetRecords), new { patientId = record.PatientId }, record);
        }
    }
}
