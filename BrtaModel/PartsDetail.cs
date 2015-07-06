using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class PartsDetail : EntityBase  
    {
        private Manufacturer manufacturer;

        public Manufacturer Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int minimum;

        public int Minimum
        {
            get { return minimum; }
            set { minimum = value; }
        }

    
 


        public bool  Post()
        {
            throw new NotImplementedException();
        }

        public PartsDetail Select()
        {
            throw new NotImplementedException();
        }

        public List<PartsDetail> SelectAll()
        {
            try
            {
                List<PartsDetail> oPartDetailList = new List<PartsDetail>();

                PartsDetail oPartsDetail = new PartsDetail();
                oPartsDetail.Id = 1;
                oPartsDetail.count = 20;
                oPartsDetail.manufacturer = new Manufacturer().SelectAll()[0];
                oPartsDetail.minimum = 3;
                oPartsDetail.parts = new Parts().SelectAll()[0];
                oPartsDetail.price = 4000;
                oPartDetailList.Add(oPartsDetail);

                oPartsDetail = new PartsDetail();
                oPartsDetail.Id = 2;
                oPartsDetail.count = 24;
                oPartsDetail.manufacturer = new Manufacturer().SelectAll()[1];
                oPartsDetail.minimum = 5;
                oPartsDetail.parts = new Parts().SelectAll()[1];
                oPartsDetail.price = 5000;
                oPartDetailList.Add(oPartsDetail);

                oPartsDetail = new PartsDetail();
                oPartsDetail.Id = 3;
                oPartsDetail.count = 7;
                oPartsDetail.manufacturer = new Manufacturer().SelectAll()[0];
                oPartsDetail.minimum = 6;
                oPartsDetail.parts = new Parts().SelectAll()[1];
                oPartsDetail.price = 1000;
                oPartDetailList.Add(oPartsDetail);

                return oPartDetailList;

            

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

      

        private Parts parts;

       

        public Parts Parts
        {
            get { return parts; }
            set { parts = value; }
        }
    }
}
