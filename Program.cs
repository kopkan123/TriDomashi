Console.WriteLine("Введите номер одной из трех домашних: ");
int casess = Convert.ToInt32(Console.ReadLine());
switch(casess){
    case 1:
    Console.WriteLine("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int shag = a;
     for (int i = 1; i < b; i++)
     {
        shag = shag * a;        
     }
    Console.WriteLine("Вышло: " + shag);
    break;

     case 2:
     Console.WriteLine("введите число");
     int c = Convert.ToInt32(Console.ReadLine());
     int chslo = 0;
     while (c > 0)
     {
     int num = c % 10;
     c = c / 10;
     chslo = chslo + num;
     }
     Console.WriteLine("сумма трех чисел ровна: " + chslo);
    break;

     case 3:
     int[] Arrrey = new int[8] {4,9,1,2,5,2,11,8};
    
     
     Console.WriteLine(string.Join(", ", Arrrey));
    break;


}