using TeamCollaboration.Models.Northwind;

namespace TeamCollaboration.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>> GetOrders();

        Task<List<CustomersType>> GetCustomers();

        Task<List<EmployeesType>> GetEmployees();

        Task<List<SuppliersType>> GetSuppliers();
    }
}