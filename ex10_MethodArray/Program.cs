int[] array ={15, 21, 39, 12, 23, 33, 13, 23, 33};

int n = array.Length; // длина (количество элементов массива
int find = 23; // поиск индекса по значению 23

int index = 0; // счетчик

while (index < n)
{
        if(array[index]==find)
        {
            Console.WriteLine(index);
            break;
        }
//     index =  index +1;
        index++;
}
