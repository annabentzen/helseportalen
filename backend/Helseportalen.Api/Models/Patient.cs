using System;

namespace Helseportalen.Api.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalIdentityNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class HealthRecord
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public DateTime RecordDate { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; } // free text from patient or personnel
        public string SymptomsJson { get; set; } // structured data
    }
}


/* for future development:
seperate models for different types of health records (e.g., Consultation, LabResult, Prescription)
every record can link to the specific doctor or healthcare personnel who created it */