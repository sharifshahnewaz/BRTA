using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class RepairsHistory : EntityBase
    {
        private Car car;

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
        private PartsDetail partsDetail;

        public PartsDetail PartsDetail
        {
            get { return partsDetail; }
            set { partsDetail = value; }
        }

        private User repairedBy;

        public User RepairedBy
        {
            get { return repairedBy; }
            set { repairedBy = value; }
        }

        private DateTime repairedTime;

        public DateTime RepairedTime
        {
            get { return repairedTime; }
            set { repairedTime = value; }
        }

       

        public bool Post()
        {
            throw new NotImplementedException();
        }

        public RepairsHistory Select()
        {
            throw new NotImplementedException();
        }

        public List<RepairsHistory> SelectAll()
        {
            return new List<RepairsHistory>();
        }
        bool  Update()
        {
            throw new NotImplementedException();
        }


        private string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
    }
}
