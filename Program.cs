using System;

namespace RegixDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("::::::::::Welcome To User Regestration Program::::::::::::: ");
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("**Press 0 For Exit**");
            Console.WriteLine("**1.Enter  A Valid First Name Starts With Upper Case & Min. 3 Characters");
            Console.WriteLine("**2.Enter  A Valid Last Name Starts With Upper Case & Min. 3 Characters");
            Console.WriteLine("**3.Enter  A Valid Email Address E.g.-abc111@abcde.com");
            Console.WriteLine("**4.Enter The Mobile Number With Country Code E.g.- 91 9918106385 **");
            Console.WriteLine("**5.Enter The Password For Minimum 8 Characters**");
            Console.WriteLine("**6.Enter The Password For Should Have Atleast 1 UpperCase **");
            Console.WriteLine("**7.Enter The Password For Should Have Atleast 1 Numeric Number **");
            Console.WriteLine("**8.Enter The Password For Should Have Atleast 1 Special Character **");
            Console.WriteLine("**9.Enter A Valid Email Address E.g.- abc@yahoo.com **");


            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please Enter The Pincode");
                    string pattern = Console.ReadLine();
                    Pattern patterns = new Pattern();
                    bool val = patterns.ValidatePinCode(pattern);

                    if (val)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 2:
                    Console.WriteLine("Please Enter The FirstName");
                    string pattrns = Console.ReadLine();
                    UserFirstName pattern1 = new UserFirstName();
                    bool val1 = pattern1.ValidateFirstName(pattrns);

                    if (val1)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 3:
                    Console.WriteLine("Please Enter The LastName");
                    string pattrns2 = Console.ReadLine();
                    UserLastName pattern2 = new UserLastName();  
                    bool val2 = pattern2.ValidateLastName(pattrns2);

                    if (val2)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 4:
                    Console.WriteLine("Please Enter The Email");
                    string pattrns3= Console.ReadLine();
                    Email pattern3= new Email();
                    bool val3 = pattern3.ValidateEmail(pattrns3);

                    if (val3)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 5:
                
                    Console.WriteLine("Please Enter The Mobile Number With Country Code");
                    string pattrn4 = Console.ReadLine();
                    MobileFormate PhoneNumber = new MobileFormate();
                    bool val4 = PhoneNumber.ValidateMobileNumber(pattrn4);

                    if (val4)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 6:
                    Console.WriteLine("Please Enter Password E.g - AghjKLMT");
                    string pattrn5 = Console.ReadLine();
                    PasswordRule1 password = new PasswordRule1();
                    bool val5 = password.ValidatePassword (pattrn5);

                    if (val5)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 7:

                
                    Console.WriteLine("Please Enter Password E.g- Avghyuih");
                    string pattrn6 = Console.ReadLine();
                    PasswordRule2 password2 = new PasswordRule2();
                    bool val6 = password2.ValidatePasswordTwo(pattrn6);

                    if (val6)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 8:
                    Console.WriteLine("Please Enter Password E.g- B1mhHYjKO");
                    string pattrn7 = Console.ReadLine();
                    PasswordRule3 password3 = new PasswordRule3();
                    bool val7 = password3.ValidatePasswordThree(pattrn7);

                    if (val7)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

                case 9:
                    Console.WriteLine("Please Enter Password ");
                    string pattrn8 = Console.ReadLine();
                    ValidEmailAddress password9 = new ValidEmailAddress();
                    bool val8 = password9.ValidateEmailAdd(pattrn8);

                    if (val8)
                        Console.WriteLine("Pattern Matched");
                    else
                        Console.WriteLine("Pattern Not Matched");
                    break;

            }
        }
    }
}