namespace RegxDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the First Name: ");
            string Fname = Console.ReadLine();
            Console.WriteLine("Please enter the Last Name: ");
            string Lname = Console.ReadLine();
            Console.WriteLine("Please enter the Phone Number: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Please enter the Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter the Password: ");
            string pass = Console.ReadLine();

            //Console.WriteLine("Rule 4");
            Patterns patterns = new Patterns();
            bool val1= patterns.boolvalidateFname(Fname);
            bool val2 = patterns.boolvalidateLname(Lname);
            bool val3 = patterns.boolvalidatePhone(phone);
            bool val4 = patterns.boolvalidateEmail(email);
            bool val5 = patterns.boolvalidatePassword(pass);
            if (val1)
            {
                Console.WriteLine("valid Firstname");

            }
            else { Console.WriteLine("Invalid Firstname"); }
            if(val2)
            {
                Console.WriteLine("valid Lastname");
            }
            else { Console.WriteLine("Invalid Lastname"); }
            if (val3)
            {
                Console.WriteLine("valid Phone Number");
            }
            else { Console.WriteLine("Invalid Phone Number"); }
            if (val4)
            {
                Console.WriteLine("valid Email");
            }
            else { Console.WriteLine("Invalid Email"); }
            if (val5)
            {
                Console.WriteLine("valid Password");
            }
            else { Console.WriteLine("Invalid Password"); }
        }
    }
}