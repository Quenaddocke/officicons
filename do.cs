/// <summary>
/// A direction on the horizontal axis.
/// </summary>
public enum HorizontalDirection
{
    Left = -1,
    Right = 1
}

// Usage
HorizontalDirection direction = HorizontalDirection.Left;
Console.WriteLine((int)direction); // Output: -1
