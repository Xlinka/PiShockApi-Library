# PiShock API Library

The PiShock API Library is a C# DLL that provides convenient access to the PiShock API for controlling shock collars. It allows you to easily send shock, vibrate, and beep commands to the shock collar.

## Usage

### Installation

1. Clone or download the PiShock API Library repository.

2. Reference the `PiShockApi.dll` in your C# project.

### Example

```csharp
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        try
        {
            var client = new PiShockApiClient();

            var shockCommand = new ShockCommand
            {
                Username = "puppy73",
                Apikey = "5c678926-d19e-4f86-42ad-21f5a76126db",
                Code = "17519CD8GAP",
                Name = "TG_Bot_Script",
                Op = 0,
                Duration = 2,
                Intensity = 7
            };

            string response = await client.SendShockCommand(shockCommand);

            Console.WriteLine(response);
        }
        catch (PiShockApiException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
```
Make sure to replace the example values with your actual PiShock account credentials and desired shock command parameters.

### Error Handling
The PiShock API Library handles errors by throwing a PiShockApiException in case of API request failures or unexpected errors. It's recommended to catch and handle this exception appropriately in your code.


