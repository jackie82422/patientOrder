using System.ComponentModel.DataAnnotations.Schema;

namespace patientOrders.model;

public class OrderModel
{
    [Column("id")]
    public string Id { get; set; }
    
    [Column("patient_id")]
    public string? PatientId { get; set; }
    
    [Column("order_text")]
    public string? OrderText { get; set; }
    
    [Column("created_by")]
    public string? Creator { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}