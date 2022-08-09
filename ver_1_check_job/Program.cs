// Задача: написать программу, которая из имеющегося массива срок формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"]->["2",":-)"]
// ["1234","1567","-2","computer science"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]

string[] texts=new string[4]{"hello","2","world",":-)"};
int count = 0;
for (int i = 0; i < texts.Length; i++)
{
      if (texts[i].Length <= 3)
        {
            count++;
        }
}
string[] result=new string[count];
void Main(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
Main(texts,result);
for (int i = 0; i < result.Length; i++)
{
      Console.WriteLine(result[i]);
}