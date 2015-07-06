using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class Car : EntityBase
    {
        private string regNo;

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        

        public bool Post()
        {
            throw new NotImplementedException();
        }

        public Car Select()
        {
            throw new NotImplementedException();
        }

        public List<Car> SelectAll()
        {
            List<Car> oCarList = new List<Car>();

            Car oCar = new Car();
            oCar.carModel = new CarModel().SelectAll()[0];
            oCar.Id = 1;
            oCar.regNo = "DHK-KA-0001";
            oCarList.Add(oCar);

            oCar = new Car();
            oCar.carModel = new CarModel().SelectAll()[0];
            oCar.Id = 2;
            oCar.regNo = "DHK-KHA-3001";
            oCarList.Add(oCar);

            oCar = new Car();
            oCar.carModel = new CarModel().SelectAll()[1];
            oCar.Id = 3;
            oCar.regNo = "KHULNA-KA-9001";
            oCarList.Add(oCar);

            return oCarList;
        }

  

        public bool Update()
        {
            throw new NotImplementedException();
        }

        

        private CarModel carModel;

        public CarModel CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }
    }
}
