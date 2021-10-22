using System;

namespace ConsoleApp1
{
    class User
    {
        
        private int age;
        private string login;
        private string email;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18!");
                }
                else
                {
                    age = value;    
                }
            }
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен содержать не менее 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                string str = value;
                char ch = '@';
                int indexOfChar = str.IndexOf(ch);
                if (indexOfChar == -1)
                {
                    Console.WriteLine("Ваш email не содержит символ @!");
                }
                else
                {
                    email = value;
                }
            }
        }
    }
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0 && value > (b + c))
                {
                    Console.WriteLine("Длина стороны привышает сумму двух других сторон");
                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0 && value > (a + c))
                {
                    Console.WriteLine("Длина стороны привышает сумму двух других сторон");
                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0 && value > (b + a))
                {
                    Console.WriteLine("Длина стороны привышает сумму двух других сторон");
                }
                else
                {
                    c = value;
                }
            }
        }
        public double Square()
        {
        }

        public double Perimeter()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Введите возраст");
            user.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите логин");
            user.Login = Console.ReadLine();
            Console.WriteLine("Введите название почты");
            user.Email = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Login);
            Console.WriteLine(user.Email);
        }
    }
}
