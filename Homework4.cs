namespace Week5Lecture1;
class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("a = ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("b = ");
    int b = Convert.ToInt32(Console.ReadLine());

    int largest_number = largest(a,b);
    Console.WriteLine($"The largest_number is: " + largest_number);
    
    // call Q2
    Console.WriteLine("Input N and shape");
    int N = Convert.ToInt16(Console.ReadLine());
    string shape = Console.ReadLine();
    PrintTra(N, shape);
    }

    static int largest(int a, int b){
        if (a >= b)
        return a;
    else 
        return b;
    }
     

     static void PrintTra(int N, string shape){
        if(shape == "left"){
            for(int i=1;i<=N;i++)
            {
                for(int j=1;j<=i;j++)
                    Console.Write("*");
                Console.WriteLine(" "); 
            }
                Console.WriteLine("\n");
            }

            
            else if (shape == "right"){
            for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j<= N-i; j++)
                        Console.Write(" ");
                    for (int k = 1; k <= i; k++)
                        Console.Write("*");
                    Console.WriteLine(" ");

                }
        }
     }
}        
                
                
                
     
     

            
            
         




            
            
    
   
   
   
    
   
   
   
   
    //     string first_name = "Alice";
    //     string last_name = "Smith";
    //     bool driver_licnse = false;
    //     double history = 90;
    //     double math = 100;
    //     StudentSummary(first_name,last_name,driver_license, history, math);

    // static void StuInfo(string FirstName, string LastName, bool DriverLicense){
    //     Console.WriteLine($"Student's full name: {FirstName} {LastName}");
    //     Console.WriteLine($"Student has a driver license: {DriverLicense}");

    // }
    // static double TotalGrade(double Course1=0, double Course2=0, double Course3=0){
    //     double sum = Course1+Course2+Course3;
    //     return sum;
    // }
    // static void StudentSummary(string _FirstName, string _LastName, bool _DriverLicense, double _Course1=0,double _Course2=0 double _Course3=0{
    //     StuInfo(_FirstName,_LastName,_DriverLicense);
    //     double total_grade = TotalGrade(_Course1,_3,Course2,_Course);
    //     Console.WriteLine($"Student's total grade: {total_grade} points");
    // }
    





//          Print(CourseName:"Math", PointGrade:98.5);
//          Print(StuName: "Alice", StuID: 12345);

//      } 

//     static void Print(string CourseName, double PointGrade){
//         Console.WriteLine($"The Grade of {CourseName} is: {PointGrade}");
//     }
//    static void Print(string StuName, int StuID){
//         Console.WriteLine($"The Student ID of {StuName} is {StuID}");
//     }
// }




       
  






















  
  /////////////////////Wek5Lecture1/////////////////
    //    int balanceBob = 1000;
    //    Console.WriteLine($"The initial Account Balance: {balanceBob}");
    //    refDeposit(accountBalance :ref balanceBob, amount: 500);
    //    refWithdraw(accountBalance :ref balanceBob,amount: 300 );
    //    Console.WriteLine($"Account Balance for Bob: {balanceBob}");
      
        // double avg1 = ThreeNumAvg(A:1.5, B:5.5, C:6.5);
        // Console.WriteLine($"Average of three given Valuse: {avg1}");
        // double avg2 = ThreeNumAvg(A:1.5, C:5.5);
        // Console.WriteLine($"Average of two given Values: {avg2}");

    // static double ThreeNumAvg(double A, double C, double B =3.5){
    //     double three_avg = (A+B+C)/3;
    //     return three_avg;

    // }
        // Console.WriteLine("Please Put input two integers");
        // int integer1 = getInteger();
        // int integer2 = getInteger();
        // int sum = TwoSum(integer1,integer2);
        // Console.WriteLine($"{integer1}+{integer2}"={sum}");

        

    






     
 