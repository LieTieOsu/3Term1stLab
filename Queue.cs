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
    
    public string Dequeue()
    {
        if (_pointer == 0)
        {
            return null;
        }

        var value = array[0];
        _pointer--;
        for (var i = 0; i < _pointer; i++)
        {
            array[i] = array[i + 1];
        }
        return value;
    }
