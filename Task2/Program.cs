// a program to search for the sum of array elements with odd indexes

// программа по поиску суммы элементов массива с нечетными индексами

int[] CreateRandom(int size,int min, int max)
{
    int[] array=new int[size];
    for(int i=0;i<size; i++)
        array[i]=new Random().Next(min,max+1);
    return array;
}
// проверка на нечетность индекса
int FindElements(int[]myarray)
{
    int summ=0;
    for(int i=0;i<myarray.Length;i++)
        if (i%2!=0)
            summ=summ+myarray[i];
            
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
int[] EnterArray=CreateRandom(30,-999,999);
Print(EnterArray);
//Вывод  суммы элементов с нечетными индексами
Console.WriteLine("Sum of elements with odd indexes-> "+FindElements(EnterArray));
