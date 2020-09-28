using Framework.EF.ContextFrameWork;

namespace Framework.EF
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly ApplicationContextDb _context;

        public CustomerRepository(ApplicationContextDb context)
        {
            _context = context;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
        }
    }
}