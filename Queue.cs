namespace Task;

public class Queue
{
    private const int Capacity = 50;

    private string[] array = new string[Capacity];

    private int _pointer;
