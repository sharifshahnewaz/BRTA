using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class Parts : EntityBase
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region IBase Members

        public bool Post()
        {
            throw new NotImplementedException();
        }

        public Parts Select()
        {
            throw new NotImplementedException();
        }

        public List<Parts> SelectAll()
        {
            try
            {
                List<Parts> oPartsList = new List<Parts>();

                Parts oParts = new Parts();

                oParts.Id = 1;
                oParts.group = new Group().SelectAll()[0];
                oParts.name = "Break Clipper Kit";
                oParts.partCategory = new Category().SelectAll()[1];
                oPartsList.Add(oParts);

                oParts = new Parts();

                oParts.Id = 2;
                oParts.group = new Group().SelectAll()[1];
                oParts.name = "Suspension Hengar Plate upper front right";
                oParts.partCategory = new Category().SelectAll()[2];
                oPartsList.Add(oParts);

                oParts = new Parts();

                oParts.Id = 3;
                oParts.group = new Group().SelectAll()[1];
                oParts.name = "Stearing dumper";
                oParts.partCategory = new Category().SelectAll()[2];
                oPartsList.Add(oParts);

                oParts = new Parts();

                oParts.Id = 4;
                oParts.group = new Group().SelectAll()[2];
                oParts.name = "Head light right";
                oParts.partCategory = new Category().SelectAll()[2];
                
                oPartsList.Add(oParts);


                return oPartsList;

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

        #endregion

        private Group group;

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }

        private Category partCategory;

        public Category PartCategory
        {
            get { return partCategory; }
            set { partCategory = value; }
        }
    }
}
