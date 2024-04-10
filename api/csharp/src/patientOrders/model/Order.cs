namespace patientOrders.model;

public class Order
{
    public class Prescription
    {
        public string PrescriptionText { get; set; } 
        public string PrescribingDoctor { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
    }

    public class PatientPrescription
    {
        public int PatientId { get; set; }
        public List<Prescription> Prescriptions { get; set; }
    }
}