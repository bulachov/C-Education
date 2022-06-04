Console.WriteLine ("Please input UserName") ;
string Username = Console.ReadLine() ;
Console.WriteLine ("Hello, World!") ;
Console.Write ("and you ") ;
Console.Write (Username) ;
Console.WriteLine (" Please Look first number") ;
int firstnumber = new Random().Next(1, 50) ;
Console.Write ( firstnumber ) ;
Console.Write ( " this second  " ) ;
int secondN = new Random().Next(5, 35) ;
Console.Write (secondN) ;
int sum = firstnumber + secondN ;
Console.WriteLine (" Это их сумма ");
Console.Write ( sum ) ;


