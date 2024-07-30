// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f 

void Main()
{
    char[,] chars = {
        { 'a','c','b','g'},
        { 'n','j','r','l'}
    };
    
    PrintMatrix(chars);
    System.Console.Write(ChatToSrt(chars));
}

string ChatToSrt(char[,] simvol)
{
 string str = "";
 for(int i =0; i < simvol.GetLength(0); i++ )
 {
    for(int j = 0; j < simvol.GetLength(1); j++)
    {
        str += simvol[i,j];
    }
 }
 return str;
}

void PrintMatrix(char[,] matrixForPrint)
{
for (int i = 0; i < matrixForPrint.GetLength(0); i++)
{
for (int j = 0; j < matrixForPrint.GetLength(1); j++)
{
System.Console.Write(matrixForPrint[i,j] + "\t");
}
System.Console.WriteLine();
}

System.Console.WriteLine();
}

Main();