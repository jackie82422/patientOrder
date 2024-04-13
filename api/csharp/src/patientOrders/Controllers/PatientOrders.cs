using Microsoft.AspNetCore.Mvc;
using patientOrders.model;
using patientOrders.service;

namespace patientOrders.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientOrders : Controller
{
    private readonly IPatientOrders _patientOrders;
    public PatientOrders(IPatientOrders patientOrders)
    {
        _patientOrders = patientOrders;
    }
    
    
    [HttpGet]
    public async Task<ActionResult<PatientModel>> Index(int pageSize=10, int pageNum=1)
    {
        var resp = await _patientOrders.GetPatientsAsync(pageNum, pageSize);
        return Ok(resp);
    }

    [HttpGet("order/{patientId}")]
    public async Task<ActionResult<IEnumerable<OrderModel>>> GetOrdersByPatient(string patientId)
    {
        var resp = await _patientOrders.GetOrdersByPatientAsync(patientId);
        return Ok(resp);
    }

    [HttpDelete("order/{orderId}")]
    public async Task<ActionResult> DeleteOrder(string orderId)
    {
        var resp = await _patientOrders.DeleteOrder(orderId);
        if (resp)
        {
            return NoContent();
        }
        else
        {
            return BadRequest();
        }
    }

    [HttpPut]
    public async Task<ActionResult> AddOrder([FromBody] OrderRequestModel request)
    {
        var resp = await _patientOrders.AddOrder(request.PatientId, request.OrderContent, request.DoctorName);
        if (resp)
        {
            return NoContent();
        }
        else
        {
            return BadRequest();
        } 
    }
}