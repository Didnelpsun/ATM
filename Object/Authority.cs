
namespace ATM.Object
{
    class Authority
    {
        private int id;
        private float draw;
        private float loan;
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
        public float Draw
        {
            set
            {
                draw = value;
            }
            get
            {
                return draw;
            }
        }
        public float Loan
        {
            set
            {
                loan = value;
            }
            get
            {
                return loan;
            }
        }
        public Authority()
        {
            id = 0;
            draw = 1000;
            loan = 0;
        }
        public Authority(int i, float d, float l)
        {
            id = i;
            draw = d;
            loan = l;
        }
    }
}
