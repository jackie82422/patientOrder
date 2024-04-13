using patientOrders.model;

namespace patientOrders.service;

public interface IPatientOrders
{
     Task<IEnumerable<PatientModel>> GetPatientsAsync(int pageNumber = 1, int pageSize = 10);

     Task<IEnumerable<OrderModel>?> GetOrdersByPatientAsync(string patientId);

     Task<bool> DeleteOrder(string orderId);

     Task<bool> AddOrder(string patientId, string orderContent, string doctorName);
}