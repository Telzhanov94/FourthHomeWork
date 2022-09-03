System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
void Skale(string x, double y)
{
    var x1=x[1]; var y1=x[3];
    double X1=Convert.ToDouble(x1.ToString()); double Y1=Convert.ToDouble(y1.ToString());    
    var x2=x[6]; var y2=x[8];
    double X2=Convert.ToDouble(x2.ToString()); double Y2=Convert.ToDouble(y2.ToString());
    var x3=x[11]; var y3=x[13];
    double X3=Convert.ToDouble(x3.ToString()); double Y3=Convert.ToDouble(y3.ToString());
    var x4=x[16]; var y4=x[18];
    double X4=Convert.ToDouble(x4.ToString()); double Y4=Convert.ToDouble(y4.ToString());
    Console.WriteLine($"({X1*y},{Y1*y})({X2*y},{Y2*y})({X3*y},{Y3*y})({X4*y},{Y4*y})");  
}
Console.WriteLine ("Введите ваши координаты как указано в примере");
Console.WriteLine("(0,0)(1,1)(2,2)(3,3)");
string coord = Console.ReadLine()??"0";
Console.Write ("Введите число масштабирования фигуры: ");
double skale = double.Parse(Console.ReadLine ()?? "0");
Skale(coord,skale);