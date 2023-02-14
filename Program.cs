Console.WriteLine("начало работы");
string[] array = {"txt", "one", "R2D2", "Leo"};
string[] newArray =new string[4];
int count = 0;



for (int i = 0; i < array.Length; i++)
{
    int length = array[i].Length;

    if (length <= 3)
    {
        string s = array[i];
        //newArray[count] = array[i];
        newArray[count] = s;
        count++;
    }

}

for (int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);

}

Console.WriteLine("спасибо за просмотр!! привет с Новороссийска");
