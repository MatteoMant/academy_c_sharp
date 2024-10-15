// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#if DEBUG
    int i = 10;
#endif

#if RELEASE
    int i = 20;
#endif

for(int j = 1; j <= i; j++)
{
    Console.WriteLine(j.ToString());
}