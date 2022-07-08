// A program to find the number of even elements in an array of three-digit positive elements//Создание массива

// Программа по поиску количества четных элементов в массиве трехзначных положительных элементов

int[] CreateRandom(int size,int min, int max)
{
    int[] array=new int[size];
    for(int i=0;i<size; i++)
        array[i]=new Random().Next(min,max+1);
    return array;
}
// проверка на четность
int FindElements(int[]myarray)
{
    int summ=0;
    for(int i=0;i<myarray.Length;i++)
        if (myarray[i]%2==0)
            summ++;
            
    return summ;
}
//Вывод в консоль массива
void Print(int[] myarray)
{
    for(int i=0;i<myarray.Length;i++)
        Console.Write(myarray[i]+" ");
    Console.WriteLine();
}
//Задание входных значений для массива
int[] EnterArray=CreateRandom(20,100,999);
Print(EnterArray);
//Вывод количества четных элементов
Console.WriteLine("Number of positive elements-> "+FindElements(EnterArray));