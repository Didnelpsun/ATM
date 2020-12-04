
namespace ATM.Object
{
    public class Bank
    {
        public int id;
        public string name;

        public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public Bank(int id)
        {
            ID = id;
        }

        public Bank(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
