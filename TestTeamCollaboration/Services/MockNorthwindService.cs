using TeamCollaboration.Models.Northwind;

namespace TeamCollaboration.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<OrdersType>> GetOrders()
        {
            return Task.FromResult<List<OrdersType>>(new());
        }

        public Task<List<CustomersType>> GetCustomers()
        {
            return Task.FromResult<List<CustomersType>>(new());
        }

        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }

        public Task<List<SuppliersType>> GetSuppliers()
        {
            return Task.FromResult<List<SuppliersType>>(new());
        }
    }
}