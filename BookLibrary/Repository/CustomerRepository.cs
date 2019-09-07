using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Repository
{
    public class CustomerRepository
    {
        private Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext;

        public CustomerRepository()
        {
            this.booksLibraryDataContext = new Models.DBObjects.BookLibraryModelsDataContext();
        }
        public CustomerRepository(Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext)
        {
            this.booksLibraryDataContext = booksLibraryDataContext;
        }
        public List<CustomerModel> GetAllCustomers()
        {
            List<CustomerModel> customerList = new List<CustomerModel>();
            foreach (Models.DBObjects.Customer dbCustomer in booksLibraryDataContext.Customers)
            {
                customerList.Add(MapDbObjectToModel(dbCustomer));
            }
            return customerList;
        }
        public CustomerModel GetCustomerByID(Guid ID)
        {
            return MapDbObjectToModel(booksLibraryDataContext.Customers.FirstOrDefault(x => x.IDCustomer == ID));
        }
        public void InsertCustomer(CustomerModel customerModel)
        {
            customerModel.IDCustomer = Guid.NewGuid();
            booksLibraryDataContext.Customers.InsertOnSubmit(MapModelToDbObject(customerModel));
            booksLibraryDataContext.SubmitChanges();
        }
        public void UpdateCustomer(CustomerModel customerModel)
        {
            Models.DBObjects.Customer existingCustomer = booksLibraryDataContext.Customers.FirstOrDefault(x => x.IDCustomer == customerModel.IDCustomer);
            if (existingCustomer != null)
            {
                existingCustomer.IDCustomer = customerModel.IDCustomer;
                existingCustomer.Name = customerModel.Name;
                existingCustomer.EmailAddress = customerModel.EmailAddress;
                existingCustomer.Address = customerModel.Address;
                existingCustomer.PhoneNumber = customerModel.PhoneNumber;
                existingCustomer.CustomerSince = customerModel.CustomerSince;
                existingCustomer.BooksReturnedOnTime = customerModel.BooksReturnedOnTime;
                existingCustomer.MonthlyFeePayed = customerModel.MonthlyFeePayed;
                booksLibraryDataContext.SubmitChanges();
            }
        }
        public void DeleteCustomer(Guid ID)
        {
            Models.DBObjects.Customer customerToDelete = booksLibraryDataContext.Customers.FirstOrDefault(x => x.IDCustomer == ID);
            if (customerToDelete != null)
            {
                booksLibraryDataContext.Customers.DeleteOnSubmit(customerToDelete);
                booksLibraryDataContext.SubmitChanges();
            }
        }
        private CustomerModel MapDbObjectToModel(Models.DBObjects.Customer dbCustomer)
        {
            CustomerModel customerModel = new CustomerModel();
            if (dbCustomer != null)
            {
                customerModel.IDCustomer = dbCustomer.IDCustomer;
                customerModel.Name = dbCustomer.Name;
                customerModel.EmailAddress = dbCustomer.EmailAddress;
                customerModel.Address = dbCustomer.Address;
                customerModel.PhoneNumber = dbCustomer.PhoneNumber;
                customerModel.CustomerSince = dbCustomer.CustomerSince;
                customerModel.BooksReturnedOnTime = dbCustomer.BooksReturnedOnTime;
                customerModel.MonthlyFeePayed = dbCustomer.MonthlyFeePayed;

                return customerModel;
            }
            return null;
        }
        private Models.DBObjects.Customer MapModelToDbObject(CustomerModel customerModel)
        {
            Models.DBObjects.Customer dbCustomerModel = new Models.DBObjects.Customer();
            if (customerModel != null)
            {
                dbCustomerModel.IDCustomer = customerModel.IDCustomer;
                dbCustomerModel.Name = customerModel.Name;
                dbCustomerModel.EmailAddress = customerModel.EmailAddress;
                dbCustomerModel.Address = customerModel.Address;
                dbCustomerModel.PhoneNumber = customerModel.PhoneNumber;
                dbCustomerModel.CustomerSince = customerModel.CustomerSince;
                dbCustomerModel.BooksReturnedOnTime = customerModel.BooksReturnedOnTime;
                dbCustomerModel.MonthlyFeePayed = customerModel.MonthlyFeePayed;

                return dbCustomerModel;
            }
            return null;
        }


    }
}
