using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class CarModel : EntityBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public bool Post()
        {
            throw new NotImplementedException();
        }

        public CarModel Select()
        {
            throw new NotImplementedException();
        }

        public List<CarModel> SelectAll()
        {
            try
            {
                List<CarModel> oCarModelList = new List<CarModel>();

                CarModel oCarModel = new CarModel();

                oCarModel.Id = 1;
                oCarModel.name = "Toyota Corolla Car EE-80-2E";
                oCarModel.group = new Group().SelectAll()[0];
                oCarModelList.Add(oCarModel);

                oCarModel = new CarModel();
                oCarModel.Id = 2;
                oCarModel.name = "Toyota Corolla Car AE-80-2E";
                oCarModel.group = new Group().SelectAll()[0];
                oCarModelList.Add(oCarModel);

                oCarModel = new CarModel();
                oCarModel.Id = 3;
                oCarModel.name = "Toyota Starlet Car EP-70";
                oCarModel.group = new Group().SelectAll()[0];
                oCarModelList.Add(oCarModel);

                oCarModel = new CarModel();
                oCarModel.Id = 4;
                oCarModel.name = "Toyota Corolla Car EE-90-2E";
                oCarModel.group = new Group().SelectAll()[1];
                oCarModelList.Add(oCarModel);

                oCarModel = new CarModel();
                oCarModel.Id = 5;
                oCarModel.name = "Toyota Corolla Car EE-101-4E";
                oCarModel.group = new Group().SelectAll()[2];
                oCarModelList.Add(oCarModel);

                return oCarModelList;
                

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        


        public bool Update()
        {
            throw new NotImplementedException();
        }

        private Group group;

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }
    }
}
