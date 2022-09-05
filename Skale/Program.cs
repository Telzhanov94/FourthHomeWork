System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
Console.WriteLine("Сколько точек вы зададите?");
int value = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ("Введите ваши координаты как указано в примере");
Console.WriteLine("(0,0) (1,1) (2,2) (3,3)");
string coord = Console.ReadLine()??"0";
Console.Write ("Введите число масштабирования фигуры: ");
double skale = double.Parse(Console.ReadLine ()?? "0");
char [] ToTrim = {'(',')',','};
coord=coord.Replace(",", " ").Replace("(","").Replace(")","");
string [] coordin=coord.Split(" ");
double [] array = new double [coord.Length];
for (int i=0; i<value*2;i++)
array[i]=Convert.ToDouble(coordin[i])*skale;
Console.WriteLine();
Console.Write("Новые координаты вашей фигуры: ");
for (int i=0; i<value*2;i++)
{Console.Write ($"({array[i]},{array[i+1]}) ");i++;}