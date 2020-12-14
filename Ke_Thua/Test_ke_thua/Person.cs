namespace Test_ke_thua
{
    public class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string ShowInfo()
        {   
            return $"{firstName}\t {lastName}";

        }

    }
}