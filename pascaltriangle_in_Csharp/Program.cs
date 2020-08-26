using System;

namespace pascaltriangle_in_Csharp
{
    class Program
    {
       public static void Main()
       {
            int n,c=1,space,i,j;

            // "i" is variable for rows
            // "j" is variable for index number in row 
            // "n" is number of rows we want to display
                      
            Console.Write("\n Please enter how many rows in Pascal's triangle you want to display: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");	
            for(i=0;i<n;i++)
            {
                for(space=1;space<=n-i;space++)
                Console.Write("  ");
                for(j=0;j<=i;j++)
                {
                    if (j==0||i==0)
                        c=1;
                    else
                    c=c*(i-j+1)/j;
                    Console.Write("{0}   ",c);
                }
                Console.Write("\n");
            }
            Console.Write("\n");    
        }
    }
}	


