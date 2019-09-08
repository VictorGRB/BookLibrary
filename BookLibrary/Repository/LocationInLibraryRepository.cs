using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Repository
{
    public class LocationInLibraryRepository
    {
        private Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext;
        public LocationInLibraryRepository()
        {
            this.booksLibraryDataContext = new Models.DBObjects.BookLibraryModelsDataContext();
        }
        public LocationInLibraryRepository(Models.DBObjects.BookLibraryModelsDataContext booksLibraryDataContext)
        {
            this.booksLibraryDataContext = booksLibraryDataContext;
        }
        public List<LocationInLibraryModel> GetAllLocationsInLibrary()
        {
            List<LocationInLibraryModel> locationInLibraryList = new List<LocationInLibraryModel>();
            foreach (Models.DBObjects.LocationInLibrary dbLocationInLibrary in booksLibraryDataContext.LocationInLibraries)
            {
                locationInLibraryList.Add(MapDbObjectToModel(dbLocationInLibrary));
            }
            return locationInLibraryList;
        }
        public LocationInLibraryModel GetLocationInLibraryByID(Guid ID)
        {
            return MapDbObjectToModel(booksLibraryDataContext.LocationInLibraries.FirstOrDefault(x => x.IDLocationInLibrary == ID));
        }
        public void InsertLocationInLibrary(LocationInLibraryModel locationInLibraryModel)
        {
            locationInLibraryModel.IDLocationInLibrary = Guid.NewGuid();
            booksLibraryDataContext.LocationInLibraries.InsertOnSubmit(MapModelToDbObject(locationInLibraryModel));
            booksLibraryDataContext.SubmitChanges();
        }
        public void UpdateLocationInLibrary(LocationInLibraryModel locationInLibraryModel)
        {
            Models.DBObjects.LocationInLibrary existingLocationInLibrary = booksLibraryDataContext.LocationInLibraries.FirstOrDefault(x => x.IDLocationInLibrary == locationInLibraryModel.IDLocationInLibrary);
            if (existingLocationInLibrary != null)
            {
                existingLocationInLibrary.IDLocationInLibrary = locationInLibraryModel.IDLocationInLibrary;
                existingLocationInLibrary.Name = locationInLibraryModel.Name;
                existingLocationInLibrary.Floor = locationInLibraryModel.Floor;
                existingLocationInLibrary.Sector = locationInLibraryModel.Sector;
                existingLocationInLibrary.Shelf = locationInLibraryModel.Shelf;
                booksLibraryDataContext.SubmitChanges();
            }
        }
        public void DeleteLocationInLibrary(Guid ID)
        {
            Models.DBObjects.LocationInLibrary locationInLibraryToDelete = booksLibraryDataContext.LocationInLibraries.FirstOrDefault(x => x.IDLocationInLibrary == ID);
            if (locationInLibraryToDelete != null)
            {
                booksLibraryDataContext.LocationInLibraries.DeleteOnSubmit(locationInLibraryToDelete);
                booksLibraryDataContext.SubmitChanges();
            }
        }
        private LocationInLibraryModel MapDbObjectToModel(Models.DBObjects.LocationInLibrary dbLocationInLibrary)
        {
            LocationInLibraryModel locationInLibraryModel = new LocationInLibraryModel();
            if (dbLocationInLibrary != null)
            {
                locationInLibraryModel.IDLocationInLibrary = dbLocationInLibrary.IDLocationInLibrary;
                locationInLibraryModel.Name = dbLocationInLibrary.Name;
                locationInLibraryModel.Floor = dbLocationInLibrary.Floor;
                locationInLibraryModel.Sector = dbLocationInLibrary.Sector;
                locationInLibraryModel.Shelf = dbLocationInLibrary.Shelf;

                return locationInLibraryModel;
            }
            return null;
        }
        private Models.DBObjects.LocationInLibrary MapModelToDbObject(LocationInLibraryModel locationInLibraryModel)
        {
            Models.DBObjects.LocationInLibrary dbLocationInLibraryModel = new Models.DBObjects.LocationInLibrary();
            if (locationInLibraryModel != null)
            {
                dbLocationInLibraryModel.IDLocationInLibrary = locationInLibraryModel.IDLocationInLibrary;
                dbLocationInLibraryModel.Name = locationInLibraryModel.Name;
                dbLocationInLibraryModel.Floor = locationInLibraryModel.Floor;
                dbLocationInLibraryModel.Sector = locationInLibraryModel.Sector;
                dbLocationInLibraryModel.Shelf = locationInLibraryModel.Shelf;

                return dbLocationInLibraryModel;
            }
            return null;
        }


    }
}