// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 10;

#if RELEASE
    i = 20;
#endif

for(int j = 1; j <= i; j++)
{
    Console.WriteLine(j.ToString());
}