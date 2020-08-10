using SCM.CodingTest.BRE.Lib;
using System;
using System.Net.NetworkInformation;

namespace SCM.CodeTesting.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Physical product \n");
            Console.Write("2. Book \n");
            Console.Write("3. Membership \n");
            Console.Write("4. Upgrade to membership \n");
            Console.Write("5. Video learning ski \n");
            Console.Write("6. Physical product or Book \n");

            IProcessActivity processActivity = null; 
            Console.Write("Enter the payment source -  ");
            int paymrent =Convert.ToInt32( Console.ReadLine());

            switch (paymrent)
            {
                case (int)PaymentSource.Physical_Product:
                    processActivity = new PhysicalPayment();
                    processActivity.Process();
                    break;
                case (int)PaymentSource.Book:
                    processActivity = new Duplicate_Packaging_Slip();
                    processActivity.Process();
                    break;
                case (int)PaymentSource.Membership:
                    processActivity = new Activate_Membership();
                    processActivity.Process();
                    break;
                case (int)PaymentSource.Upgrade_to_Membership:
                    processActivity = new Upgrade_Membership();
                    processActivity.Process();
                    break;
                case (int)PaymentSource.Video_Learning_to_Ski:
                    processActivity = new FirstAid();
                    processActivity.Process();
                    break;
                case (int)PaymentSource.Physical_Product_or_Book:
                    processActivity = new Commision_Payment();
                    processActivity.Process();
                    break;
                default:
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine(processActivity.Process().Result);
            Console.ReadKey();

        }
    }
}
