﻿namespace Assignments05_OOp
{
    #region Part02 Q2
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {

        private readonly string storedUsername = "admin";
        private readonly string storedPassword = "admin";
        private readonly string storedRole = "Administrator";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    } 

    #endregion

    internal class Program
    {

        static void Main(string[] args)
        {
            #region 1.Question 1 MCQ

            //Answer Of Question 1 (MCQ) 
            /*
            1.B
            2.A
            3.B
            4.B
            5.D
            6.A
            7.B
            8.B
            9.B
            10.C
             */

            #endregion

            #region Part02 Q1

            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(4, 7);
            rectangle.DisplayShapeInfo();

            #endregion

            #region Part02 Q2

            IAuthenticationService authService = new BasicAuthenticationService();

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine("Authentication successful!");


                Console.Write("Enter role: ");
                string role = Console.ReadLine();

                if (authService.AuthorizeUser(username, role))
                {
                    Console.WriteLine("successful");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
            else
            {
                Console.WriteLine(" failed Inncorect UserName or Password.");
            } 

            #endregion


        }
    }
}
