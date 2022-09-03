int k1=1;
int k2=1;
int b1=4;
int b2=4;
for (int x=-100; x<100;x++)
{
    int y1 =k1*x+b1;
    int y2 =k2*x+b2; 
    if (y1==y2)
   {
    Console.Write ("Intersections of given lines at a point" + x +" " + y1 ); 
    Console.WriteLine();
   }
   else {Console.WriteLine ("Given straight parallel");}
}