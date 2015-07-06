using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class Category : EntityBase
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

        public Category Select()
        {
            throw new NotImplementedException();
        }

        public List<Category> SelectAll()
        {
            try
            {
                List<Category> oCategoryList = new List<Category>();

                Category oCategory = new Category();

                oCategory.Id = 1;
                oCategory.name = "Engine";
                oCategoryList.Add(oCategory);

                oCategory = new Category();

                oCategory.Id = 2;
                oCategory.name = "Break";
                oCategoryList.Add(oCategory);

                oCategory = new Category();

                oCategory.Id = 3;
                oCategory.name = "Suspension";
                oCategoryList.Add(oCategory);

                return oCategoryList;

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
