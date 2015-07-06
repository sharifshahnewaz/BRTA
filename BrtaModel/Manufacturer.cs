using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class Manufacturer : EntityBase
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

        public Manufacturer Select()
        {
            throw new NotImplementedException();
        }

        public List<Manufacturer> SelectAll()
        {
            try
            {
                List<Manufacturer> oManufacturerList = new List<Manufacturer>();

                Manufacturer oManufacturer = new Manufacturer();
                oManufacturer.Id = 1;
                oManufacturer.name = "Genuine";
                oManufacturerList.Add(oManufacturer);

                oManufacturer = new Manufacturer();
                oManufacturer.Id = 2;
                oManufacturer.name = "Japan";
                oManufacturerList.Add(oManufacturer);

                oManufacturer = new Manufacturer();
                oManufacturer.Id = 3;
                oManufacturer.name = "Others";
                oManufacturerList.Add(oManufacturer);

                oManufacturer = new Manufacturer();
                oManufacturer.Id = 4;
                oManufacturer.name = "Re-conditioned";
                oManufacturerList.Add(oManufacturer);

                return oManufacturerList;

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

        

    }
}
