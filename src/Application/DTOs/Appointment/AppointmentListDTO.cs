using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinAgenda.src.Application.DTOs.Appointment
{
    public class AppointmentListDTO
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public required string PatientName { get; set; }
        public int DoctorId { get; set; }
        public required string DoctorName { get; set; } 
        public int SpecialtyId { get; set; }
        public required string SpecialtyName { get; set; }
        public int StatusId { get; set; }
        public required string StatusName { get; set; }
        public DateTime DAppointmentDate { get; set; }  
        public string Observation { get; set; } = "";
        public DateTime DCreated { get; set; }
        public DateTime? DLastUpdated { get; set; }
        public bool LActive { get; set; }
    }
}