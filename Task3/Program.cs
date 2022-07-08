// A program that looks for the difference between the maximum and minimum array elements. Elements are real numbers

// Программа которая ищет разницу между максимальным и минимальным элементов массива. Элементы вещественные числа

Double[] CreateRandom(int size,int min, int max)
{
    Double[] array=new Double[size];
    for(int i=0;i<size; i++)
        array[i]=Math.Round(new Random().Next(min,max+1)+new Random().NextDouble(),3);
       
    return array;
}
// поиск максимального и минимальногоэлемента массива для их разницы
Double FindElements(Double[]myarray)
{
    double summ=0,maxel=myarray[0],minel=myarray[0];
    for(int i=0;i<myarray.Length;i++)
    {
        if (myarray[i]> maxel) 
            maxel=myarray[i];
    }

    for(int i=0;i<myarray.Length;i++)
    {
       
        if (myarray[i]<minel) 
            minel=myarray[i];
    }
        summ=Math.Round(maxel-minel,3);
            
    return summ;
}
//Вывод в консоль массива
void Print(Double[] myarray)
{
    for(int i=0;i<myarray.Length;i++)
        Console.Write(myarray[i]+"    ");
    Console.WriteLine();
}
//Задание входных значений для массива
Double[] EnterArray=CreateRandom(10,-999,999);
Print(EnterArray);
Console.WriteLine();
//Вывод  суммы элементов с нечетными индексами
Console.WriteLine("TThe difference between max and min-> "+FindElements(EnterArray));
