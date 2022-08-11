int[] array = new int[10];       // создаем новый массив с 10тью элементами		
		
void FillArray(int[] collection)	// заполняет массив числами	
{		
                    int length = collection.Length;	// получения длины массива	
                     int index = 0;		
                    while(index < length)  // границы массива	
                    {		
                      collection[index] = new Random().Next(1, 10);   
                      // положить целое случайное число из диапозона 1…10		
                    index++;		
                    }		
}
void PrintArray(int[]col) // для печати массива

{
    int count = col.Length;
    int position = 0; // текущая позиция
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find) // для поиска значения
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index]== find)
        {
            position = index; // если значение найденно, оно присваевается
                              // переменной position

        }
        index++;
    }
    return position; 
}

FillArray(array);
PrintArray(array);
Console.WriteLine(); // делаем пустую строчку

int pos = IndexOf(array, 4); // поищем значение 4 в массиве
Console.WriteLine(pos); 