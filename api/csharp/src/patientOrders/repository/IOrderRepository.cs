using patientOrders.model;

namespace patientOrders.repository;

public interface IOrderRepository
{
    Task<IEnumerable<OrderModel>?> GetOrdersByPatient(string patientId);
    Task<OrderModel?> GetOrderById(string orderId);
    Task<int> AddOrder(string patientId, string orderText, string doctorName);
    Task<int> DeleteOrder(string orderId);
}