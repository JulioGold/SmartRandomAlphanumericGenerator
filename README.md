# SmartRandomAlphanumericGenerator  
Generate random alphanumeric strings with options.  
  
```
Install-Package SmartRandomAlphanumericGenerator
```  

## Usage

Bellow a sample  

```csharp
class Program
{
    static void Main(string[] args)
    {
        ISRAGenerator srag = new SRAGenerator();
        srag.UseNumbers = false;
        srag.UseLowercaseLetters = false;
        srag.UseUppercaseLetters = true;
        srag.UseSymbols = false;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(srag.Generate(10));
        }

        Console.ReadKey();
    }
}
```
  
Danke   