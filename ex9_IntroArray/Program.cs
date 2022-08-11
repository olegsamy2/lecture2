// Задача нахождения максимума из 9 Ex9
// 3var

int Max(int arg1, int arg2, int arg3 )	
{	
                 int result = arg1;	
                if (arg2 > result) result = arg2;	
                if (arg3 > result) result = arg3;	
                        return result;	
}	
	
int[] array ={15, 21, 39, 12, 23, 33, 13, 23, 33};
// array[0]= 12; // присвоем нулевому элементу индексом 0 значение 12, сейчас 15

// Console.WriteLine(array[4]);
// int max=  Max (	
//                    Max (a1, b1, c1),	
//                     Max (a2, b2, c2), 	
//                    Max (a3, b3, c3));

int result=  Max (	
                   Max (array[0], array[1], array[2]),
                    Max (array[3], array[4], array[5]),
                   Max (array[6], array[7], array[8])
                );
	
Console.WriteLine(result);	
