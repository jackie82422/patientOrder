using patientOrders.model;
using patientOrders.repository;

namespace patientOrders.service;

public class PatientOrders : IPatientOrders
{
    private readonly IPatientRepository _patientRepository;
    private readonly IOrderRepository _orderRepository;

    public PatientOrders(IPatientRepository patientRepository, IOrderRepository orderRepository)
    {
        _patientRepository = patientRepository;
        _orderRepository = orderRepository;
    }
    
    public async Task<IEnumerable<PatientModel>> GetPatientsAsync(int pageNumber, int pageSize)
    {
        return await _patientRepository.GetPatients(pageNumber, pageSize);
    }

    public async Task<IEnumerable<OrderModel>?> GetOrdersByPatientAsync(string patientId)
    {
        return await _orderRepository.GetOrdersByPatient(patientId);
    }

    public async Task<bool> DeleteOrder(string orderId)
    {
        return await _orderRepository.DeleteOrder(orderId) == 1;
    }

    public async Task<bool> AddOrder(string patientId, string orderContent, string doctorName)
    {
        return await _orderRepository.AddOrder(patientId, orderContent, doctorName) == 1;
    }
}