//Пользователь вводит с клавиатуры М чисел. Посчитайте сколько
//чисел больше 0 ввел пользователь.



using static System.Console;
string[] NewArray = FillGetParams(5);
int[] array = ConvertArrayToInt(NewArray);  
WriteLine(String.Join(" ", array));
int positivSum = 0;
for (int i = 0; i < 5; i++)
{
   if (array[i] > 0)
   {
      positivSum = positivSum+1;    
   } 
}
WriteLine($"Количество положительных чисел = {positivSum}");
ReadLine();
string[] FillGetParams(int size)
{
    string[] array = new string[size];
    for(int i = 0; i < array.Length; i++)
    { 
        WriteLine("Введите число для " +  i  +  "индекс");
        array[i]= ReadLine();
    }
    return array;
}

int[] ConvertArrayToInt(string[] array)
{
    int[] numberArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    { 
        //char c = array[i] [0] ;
        //if(! Char.IsDigit(c))
       // {
        //  WriteLine("Неверно введен массив "); 
        //  break; 
       // }
        //else
       // {
            numberArray[i]=Convert.ToInt32(array[i]);
       // }
    }
    return numberArray;
}