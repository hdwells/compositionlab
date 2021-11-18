namespace compositionlab
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;


    //constructor
        public Author(string tempName, char tempGender, string tempEmail)
        {
            this.name=tempName;
            this.gender=tempGender;
            this.email=tempEmail;
        }

        public void SetName(string tempName)
        {
            this.name=tempName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetGender(char tempGender)
        {
            this.gender=tempGender;
        }

        public char GetGender()
        {
            return gender;
        }

        public void SetEmail(string tempEmail)
        {
            this.email=tempEmail;
        }

        public string GetEmail()
        {
            return email;
        }
        
        public string ToString()
        {
            return "Name = " + name + " ,Gender = " + gender + " ,email = " + email;
        }
        
    }
}