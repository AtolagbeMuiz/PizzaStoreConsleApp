using System;

namespace Today_class
{
    class Program
    {
        static void Main(string[] args)
        {
        //     int smallPrice = 500;
        //     int mediumPrice = 1000;
        //     int largePrice = 1500;
        //     System.Console.WriteLine("Welcome to Sarah's Pizza Store \n our sizes are Small, Medium and Pizza. Pls select 1 for Small, 2 for Medium and 3 for Large");
        //     var result = int.Parse(Console.ReadLine());

        //    while(result > 3 || result < 1)
        //    {
        //        System.Console.WriteLine("Invalid Number \n Please enter a valid number between 1-3");
        //        result=int.Parse(Console.ReadLine());
        //    }

                //    if(result == 1)
                //    {
                //        System.Console.WriteLine("You have selected the small pizza size, Your total bill is {0}: ", smallPrice);
                //    }
                //    else if (result == 2)
                //    {
                //       System.Console.WriteLine("You have selected the medium pizza size, Your total bill is {0}: ", mediumPrice); 
                //    }
                //    else if (result == 3)
                //    {
                //        System.Console.WriteLine("You have selected the large pizza size, Your total bill is {0}: ", largePrice);
                //    }
                //     else
                //     {
                //         System.Console.WriteLine("Enter a Valid Number btween 1-3");
                //     }
                //     System.Console.WriteLine("Thank you for shopping with us");

                // switch(result)
                // {
                //     case 1:
                //     System.Console.WriteLine("You have selected the small pizza size, Your total bill is {0}: ", smallPrice);
                //     break;

                //     case 2:
                //     System.Console.WriteLine("You have selected the medium pizza size, Your total bill is {0}: ", mediumPrice);
                //     break;

                //     case 3:
                //     System.Console.WriteLine("You have selected the large pizza size, Your total bill is {0}: ", largePrice);
                //     break;

                //     // default:
                //     // System.Console.WriteLine("Enter a Valid Number btween 1-3");
                //     // break;
                // }
                //  System.Console.WriteLine("Thank you for shopping with us");



         Console.WriteLine("Welcome to Sarah Pizza store");
         int totalBill = 0;
         string decision = null;
          do 
           {
                int value = 0;
                    do
                    {
                            Console.WriteLine("small--500,medium --1000,large--1500");
                            Console.WriteLine("enter 1,2 or 3 for small,medium or large");
                            value = Convert.ToInt32(Console.ReadLine());

                        switch(value)
                        {
                            case 1:
                            totalBill+= 500;
                            break;
                            case 2:
                            totalBill+= 1000;
                            Console.WriteLine();
                            break;
                            case 3:
                            totalBill+= 1500;
                            Console.WriteLine();
                            break;
                            default:
                            Console.WriteLine();
                            break;
                        }
                    } while(value != 1 && value != 2 && value != 3);
                    
                Console.WriteLine("Do you want to continue shopping yes or no ");
                decision = Console.ReadLine();

            }while(decision != "no");
            
            Console.WriteLine("thank you for shopping with us");
            Console.WriteLine("your total bill is " + totalBill);
        }
    }
}
