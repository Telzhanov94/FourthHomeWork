Console.WriteLine ("Enter a variable k1");
int k1=int.Parse (Console.ReadLine()??"0");
Console.WriteLine ("Enter a variable b1");
int b1=int.Parse (Console.ReadLine()??"0");
Console.WriteLine ("Enter a variable k2");
int k2=int.Parse (Console.ReadLine()??"0");
Console.WriteLine ("Enter a variable b2");
int b2=int.Parse (Console.ReadLine()??"0");
if (k1==k2 & b1==b2) {Console.WriteLine("The functions match");}
else
{
for (int x=-100; x<100;x++)
{
    int y1 =k1*x+b1;
    int y2 =k2*x+b2; 
    if (y1==y2)
   {
    Console.Write ("Intersections of given lines at a point" + x +" " + y1 ); 
    Console.WriteLine();
   }
   else 
   {Console.WriteLine ("Given straight parallel");break;}
}
}