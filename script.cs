
Console.WriteLine("Программа формирует массив из строк, длина которых меньше либо равна 3 символа");
string [] a = new string [] {"578","jhk","hello world"};
string [] b = new string [a.Length] ;
int i=0 , j = 0;
while (i<a.Length)
{
    if (a[i].Length>3){

    }
    else{
        b[j]=a[i];
        Console.WriteLine(b[j]);
        j++;
    }
    i++;

} 

