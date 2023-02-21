namespace Phone_Book_1._0
{
    public class Contact
    {
        private string picture;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
      
        }

        private string name;

        public string Name
        {

            get { return name; }
            set { name = value; }
        }

        private string phone;

        public string Phone 
        {
            get { return phone; }
            set { phone = value; }
        }

        public Contact(string picture, string name, string phone) 
        {
            this.picture = picture;
            this.name = name;
            this.phone = phone;
        }
    }
    }

