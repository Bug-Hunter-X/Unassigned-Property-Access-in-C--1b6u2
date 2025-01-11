# Unassigned Property Access in C#

This repository demonstrates a common yet easily overlooked error in C#: accessing a property before it has been assigned a value.  While seemingly simple, this can lead to unexpected behavior, runtime exceptions (e.g., `NullReferenceException`), or subtle bugs that are difficult to track down.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file provides a corrected version demonstrating best practices.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE.
3. Run the `MyMethod()` function.  Observe the potential issue (depending on the property type). 
4. Compare to the solution in `bugSolution.cs` for best practices.

## Best Practices

* **Always initialize properties:** Assign a default value to properties in the class constructor or during declaration.
* **Null checks (for reference types):** If a property can be null, always check for null before accessing it.
* **Defensive programming:** Incorporate error handling (e.g., try-catch blocks) to gracefully handle potential exceptions.
* **Use the null-coalescing operator (`??`):** To provide a default value if the property is null.