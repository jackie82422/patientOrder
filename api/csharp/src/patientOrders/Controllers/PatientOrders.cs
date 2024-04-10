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
    public async Task<ActionResult<Patient>> Index()
    {
        var resp = await _patientOrders.GetPatientsAsync();
        return Ok(resp);
    }
}