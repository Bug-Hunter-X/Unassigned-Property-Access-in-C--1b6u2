public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public ExampleClass()
    {
        // Initialize in the constructor (best practice)
        MyProperty = 10;
    }

    public void MyMethod()
    {
        // Accessing a property after initialization
        int value = MyProperty * 2; 
    }
}