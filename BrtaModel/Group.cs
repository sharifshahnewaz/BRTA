using System;
using System.Collections.Generic;
using System.Text;


namespace BrtaModel
{
    public class Group : EntityBase
    {
        private int no;

        public int No
        {
            get { return no; }
            set { no = value; }
        }

    

        public bool Post()
        {
            throw new NotImplementedException();
        }

        public Group Select()
        {
            throw new NotImplementedException();
        }

        public List<Group> SelectAll()
        {
            try
            {
                List<Group> groupList = new List<Group>();

                Group oGroup;
                for (int i = 1; i <= 60; i++)
                {
                    oGroup = new Group();
                    oGroup.Id = i;
                    oGroup.no = i;
                    groupList.Add(oGroup);
                }

                    return groupList;

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
