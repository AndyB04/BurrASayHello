// Andrea Burr 
// 10-18-2022
//Git hub challange/ mini 1 redo  
Console.Clear();
bool playagain = true;

while (playagain){
    

Console.WriteLine("Hello what is your name?");
string myName = Console.ReadLine();
Console.WriteLine("Hello " + myName + " it's nice to meet you " );
Console.WriteLine("How is your day " + myName + "?");
string myDay = Console.ReadLine ();
Console.WriteLine("Im glad your day was " + myDay + " " + myName);
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}

