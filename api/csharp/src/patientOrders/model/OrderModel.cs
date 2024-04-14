using System.ComponentModel;

namespace patientOrders.model;

public class OrderModel
{
    public string Id { get; set; }
    
    public string? PatientId { get; set; }
    
    public string? OrderText { get; set; }
    
    public string? Creator { get; set; }
    
    public DateTime CreatedAt { get; set; }
}