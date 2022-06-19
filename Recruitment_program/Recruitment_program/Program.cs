using System;

namespace Home_task_4
{
    internal class Program
    {
        public static string name { get; private set; }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please, enter employee info:");
                userInformation userInformation = new userInformation();
               


            }

        }
       

    }

    public class userInformation
    {
        public string _name;
        public string _surname;
        public string _fatherName;
        public string _age;
        public string _finCode;
        public string _phoneNumber;
        public string _position;
        public string _salary;

        public userInformation()
        {
           

            _name = GetTrueName("Name", GetCommand("Name"));
            _surname = GetTrueName("Surname", GetCommand("Surname"));
            _fatherName = GetTrueName("Father name", GetCommand("Father name"));
            _age = GetTrueAge("Age", GetCommand("Age"));//
            _finCode = GetTrueName("Id card", GetCommand("Id card"));
            _phoneNumber = GetTrueName("Phone number", GetCommand("Phone number"));
            _position = GetTrueName("Position", GetCommand("Position"));
            _salary = GetTrueName("Salary", GetCommand("Salary"));
        }

        string GetCommand(string requiredtext)
        {
            Console.Write($"{requiredtext}: ");
            return Console.ReadLine();
        }

        string GetTrueName(string requiredName, string value)
        {
            while (!isFirstLetterToUpper(value) || !isLengthFit(value) || !isNameConsistOfLetters(value))
            {
                value = GetCommand(requiredName);
            }

            return value;
        }

        string GetTrueAge(string targetAge, string value)
        {
            while (!isAgeRangeTrue(value))
            {
                value = GetCommand(targetAge);
            }

            return value;
        }
        
        bool isFirstLetterToUpper(string targetName)
        {
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                       'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < lowerLetters.Length; i++)
            {
                if (targetName[0] == lowerLetters[i])
                {
                    Console.WriteLine("Entered format incorrect! First letter of name,surname and father name must be capital!");
                    return false;
                }
            }
            return true;
        }
        bool isLengthFit(string targetName)
        {
            if (targetName.Length < 2 || targetName.Length > 20)
            {
                Console.WriteLine("Entered length incorrect! Name and surname must consist of a minimum of 2 and a maximum of 20 letters! ");
                return false;
            }
            return true;
        }
        bool isNameConsistOfLetters(string value)
        {
            char[] allCases = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
                                          'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                         'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < value.Length; i++)
            {
                bool isValidLetter = false;

                for (int j = 0; j < allCases.Length; j++)
                {
                    if (value[i] == allCases[j])
                    {
                        isValidLetter = true;
                        break;
                    }
                }

                if (!isValidLetter)
                {
                    Console.WriteLine("Entered format incorrect! First and last name must consist of letters only!");
                    return false;
                }
            }

            return true;
        }
        bool isAgeRangeTrue(string targetAge)
        {
            string[] ageRange = {"18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48",
            "49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65"};
            for (int i = 0; i < ageRange.Length; i++)
            {
                
                if (targetAge == ageRange[i])
                {
                    return true;
                }

            }

                    Console.WriteLine("Entered age invalid! Age range should be 18-65!");
            return false ;
        }
    }
}
