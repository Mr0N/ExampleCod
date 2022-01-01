// See https://aka.ms/new-console-template for more information
using BufferEnumerable;
int linqCounter = 0;
byte[] array = { 0, 0, 1, 0, 1 };

var bytes = array.Where(a =>
{
    linqCounter++;
    return a > 0;
});
bool x = bytes.Last() == bytes.First();
Console.WriteLine(linqCounter);