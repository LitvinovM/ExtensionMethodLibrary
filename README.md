# ExtensionMethodLibrary
Adds extension methods for standard types of .net

# For example

```csharp
[TestMethod]
 public void Percentage_Inteasdger_123()
{
    // Arrange
    var value = 123;
    var excepted = value * 0.1;
                
    // Act
    var actual = value.Percentage(10);
    
    // Assert
    Assert.AreEqual(excepted, actual);
}
        
[TestMethod]
public void Lighten_Half_Test()
{
    // Arrange
    var color = Color.Black;
    var expectedColor = Color.FromArgb(255, 255 / 2, 255 / 2, 255 / 2);
    
    // Act
    var actual = color.Lighten(50.0);
    
    // Assert
    Assert.IsTrue(SimpleCompareColor(expectedColor, actual));
}

[TestMethod]
public void FutureTest()
{
    // Arrange
    var timeSpanValue = TimeSpan.FromDays(123);
    var excepted = DateTime.Now.Add(timeSpanValue);
    
    // Act
    var actual = timeSpanValue.Future();
    
    // Assert
    Assert.AreEqual(excepted.Date, actual.Date);
}
 ```
