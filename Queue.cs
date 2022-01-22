namespace Task;

public class Queue
{
    private const int Capacity = 50;

    private string[] array = new string[Capacity];

    private int _pointer;
    
    public void Enqueue(string value)
    {
        if (_pointer == array.Length)
        {
            throw new Exception("Stack overflowed");
        }

        array[_pointer] = value;
        _pointer++;
    }
    
