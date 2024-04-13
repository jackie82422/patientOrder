using System.ComponentModel.DataAnnotations;

namespace patientOrders.model;

public class OrderRequestModel
{ 
        [Required]
        public string PatientId { get; set; }

        [Required]
        public string DoctorName { get; set; }

        [Required]
        public string OrderContent { get; set; }
}