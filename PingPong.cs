using System;

class PingPong{
  static void Main(){
    Console.WriteLine("enter any number");
    string stringNumber = Console.ReadLine();
    int userNumber = int.Parse(stringNumber);
    Console.WriteLine("Your ping pong game starts here");

    for(int num=0; num<=userNumber; num++){
      
      if(num % 3 == 0 && num % 5 == 0){
        Console.WriteLine("Ping-Pong"); 
      }  
      else if(num % 3 == 0 ){
        Console.WriteLine("Ping");
      }
      else if(num % 5 == 0){
        Console.WriteLine("Pong");
      }else{
        Console.WriteLine(num);  
      }
    }
  }
}