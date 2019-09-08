using BookLibrary.Models;
using BookLibrary.Models.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Repository
{
    public class BorrowFormRepository
    {
        
        private Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext;
        public BorrowFormRepository()
        {
            this.booksLibraryDataContext = new Models.DBObjects.BookLibraryModelsDataContext();
        }
        public BorrowFormRepository(Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext)
        {
            this.booksLibraryDataContext = booksLibraryDataContext;
        }
        public List<BorrowFormModel> GetAllBorrowFormsByBookId(Guid id)
        {
            List<BorrowFormModel> borrowFormList = new List<BorrowFormModel>();
            List<BorrowForm> borrowForm = booksLibraryDataContext.BorrowForms.Where(x => x.IDBook == id).ToList();
            foreach (Models.DBObjects.BorrowForm dbBorrowForm in borrowForm)
            {
                BorrowFormModel borrowFormModel = new BorrowFormModel();
                borrowFormModel.IDBorrowForm = dbBorrowForm.IDBorrowForm;
                borrowFormModel.IDBook = dbBorrowForm.IDBook;
                borrowFormModel.IDCustomer = dbBorrowForm.IDCustomer;
                borrowFormModel.BorrowedFrom = dbBorrowForm.BorrowedFrom;
                borrowFormModel.BorrowedUntil = dbBorrowForm.BorrowedUntil;
                borrowFormModel.ReturnedOnTime = dbBorrowForm.ReturnedOnTime;
                borrowFormModel.ProperConditionsReturn = dbBorrowForm.ProperConditionsReturn;

                borrowFormList.Add(borrowFormModel);
            }
            return borrowFormList;
        }


        public List<BorrowFormModel> GetAllBorrowFormsByCustomerId(Guid id)
            {
                List<BorrowFormModel> borrowFormList = new List<BorrowFormModel>();
                List<BorrowForm> borrowForm = booksLibraryDataContext.BorrowForms.Where(y => y.IDCustomer == id).ToList();
                foreach (Models.DBObjects.BorrowForm dbBorrowForm in borrowForm)
                {
                    BorrowFormModel borrowFormModel = new BorrowFormModel();

                    borrowFormModel.IDBorrowForm = dbBorrowForm.IDBorrowForm;
                    borrowFormModel.IDBook = dbBorrowForm.IDBook;
                    borrowFormModel.IDCustomer = dbBorrowForm.IDCustomer;
                    borrowFormModel.BorrowedFrom = dbBorrowForm.BorrowedFrom;
                    borrowFormModel.BorrowedUntil = dbBorrowForm.BorrowedUntil;
                    borrowFormModel.ReturnedOnTime = dbBorrowForm.ReturnedOnTime;
                    borrowFormModel.ProperConditionsReturn = dbBorrowForm.ProperConditionsReturn;

                    borrowFormList.Add(borrowFormModel);
                }
                return borrowFormList;
            }
        public List<BorrowFormModel> GetAllBorrowForms()
        {
            List<BorrowFormModel> borrowFormList = new List<BorrowFormModel>();
            foreach (Models.DBObjects.BorrowForm dbBorrowForm in booksLibraryDataContext.BorrowForms)
            {
                borrowFormList.Add(MapDbObjectToModel(dbBorrowForm));
            }
            return borrowFormList;
        }
        public BorrowFormModel GetBorrowFormByID(Guid ID)
        {
            return MapDbObjectToModel(booksLibraryDataContext.BorrowForms.FirstOrDefault(x => x.IDBorrowForm == ID));
        }
        public void InsertBorrowForm(BorrowFormModel borrowFormModel)
        {
            borrowFormModel.IDBorrowForm = Guid.NewGuid();
            booksLibraryDataContext.BorrowForms.InsertOnSubmit(MapModelToDbObject(borrowFormModel));
            booksLibraryDataContext.SubmitChanges();
        }
        public void UpdateBorrowForm(BorrowFormModel borrowFormModel)
        {
            Models.DBObjects.BorrowForm existingBorrowForm = booksLibraryDataContext.BorrowForms.FirstOrDefault(x => x.IDBorrowForm == borrowFormModel.IDBorrowForm);
            if (existingBorrowForm != null)
            {
                existingBorrowForm.IDBorrowForm = borrowFormModel.IDBorrowForm;
                existingBorrowForm.IDBook = borrowFormModel.IDBook;
                existingBorrowForm.IDCustomer = borrowFormModel.IDCustomer;
                existingBorrowForm.BorrowedFrom = borrowFormModel.BorrowedFrom;
                existingBorrowForm.BorrowedUntil = borrowFormModel.BorrowedUntil;
                existingBorrowForm.ReturnedOnTime = borrowFormModel.ReturnedOnTime;
                existingBorrowForm.ProperConditionsReturn = borrowFormModel.ProperConditionsReturn;
                booksLibraryDataContext.SubmitChanges();
            }
        }
        public void DeleteBorrowForm(Guid ID)
        {
            Models.DBObjects.BorrowForm borrowFormToDelete = booksLibraryDataContext.BorrowForms.FirstOrDefault(x => x.IDBorrowForm == ID);
            if (borrowFormToDelete != null)
            {
                booksLibraryDataContext.BorrowForms.DeleteOnSubmit(borrowFormToDelete);
                booksLibraryDataContext.SubmitChanges();
            }
        }
        private BorrowFormModel MapDbObjectToModel(Models.DBObjects.BorrowForm dbBorrowForm)
        {
            BorrowFormModel borrowFormModel = new BorrowFormModel();
            if (dbBorrowForm != null)
            {
                borrowFormModel.IDBorrowForm = dbBorrowForm.IDBorrowForm;
                borrowFormModel.IDBook = dbBorrowForm.IDBook;
                borrowFormModel.IDCustomer = dbBorrowForm.IDCustomer;
                borrowFormModel.BorrowedFrom = dbBorrowForm.BorrowedFrom;
                borrowFormModel.BorrowedUntil = dbBorrowForm.BorrowedUntil;
                borrowFormModel.ReturnedOnTime = dbBorrowForm.ReturnedOnTime;
                borrowFormModel.ProperConditionsReturn = dbBorrowForm.ProperConditionsReturn;

                return borrowFormModel;
            }
            return null;
        }
        private Models.DBObjects.BorrowForm MapModelToDbObject(BorrowFormModel borrowFormModel)
        {
            Models.DBObjects.BorrowForm dbBorrowFormModel = new Models.DBObjects.BorrowForm();
            if (borrowFormModel != null)
            {
                dbBorrowFormModel.IDBorrowForm = borrowFormModel.IDBorrowForm;
                dbBorrowFormModel.IDBook = borrowFormModel.IDBook;
                dbBorrowFormModel.IDCustomer = borrowFormModel.IDCustomer;
                dbBorrowFormModel.BorrowedFrom = borrowFormModel.BorrowedFrom;
                dbBorrowFormModel.BorrowedUntil = borrowFormModel.BorrowedUntil;
                dbBorrowFormModel.ReturnedOnTime = borrowFormModel.ReturnedOnTime;
                dbBorrowFormModel.ProperConditionsReturn = borrowFormModel.ProperConditionsReturn;

                return dbBorrowFormModel;
            }
            return null;
        }


    }
}