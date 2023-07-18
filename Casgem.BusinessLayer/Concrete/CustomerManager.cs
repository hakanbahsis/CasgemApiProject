using Casgem.BusinessLayer.Abstract;
using Casgem.DataAccessLayer.Abstract;
using Casgem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer entity)
        {
           _customerDal.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
