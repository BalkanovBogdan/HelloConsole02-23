Console.WriteLine("Ведите 1 число");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите 2 число");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("большее" + numberA); 
    Console.WriteLine("меньшее" + numberB);
}
else
{
    Console.WriteLine("большее" + numberB); 
    Console.WriteLine("меньшее" + numberA);
}