public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned a value.
        int value = MyProperty * 2; // Potential problem: MyProperty might be 0
    }
}