namespace Enum.Flags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var preferences = ClientPreferences.LargeText | ClientPreferences.AutoComplete | ClientPreferences.AutoOrder;
            Console.WriteLine($"Preferences String value: {preferences}");
            Console.WriteLine($"Preferences Integer value: {(int)preferences}");
            
            Console.WriteLine($"Preferences HasFlag:None: {preferences.HasFlag(ClientPreferences.None)}");
            Console.WriteLine($"Preferences HasFlag:DarkMode: {preferences.HasFlag(ClientPreferences.DarkMode)}");
            Console.WriteLine($"Preferences HasFlag:LargeText: {preferences.HasFlag(ClientPreferences.LargeText)}");
            Console.WriteLine($"Preferences HasFlag:AutoComplete: {preferences.HasFlag(ClientPreferences.AutoComplete)}");
            Console.WriteLine($"Preferences HasFlag:AIAssist: {preferences.HasFlag(ClientPreferences.AIAssist)}");
            Console.WriteLine($"Preferences HasFlag:AutoOrder: {preferences.HasFlag(ClientPreferences.AutoOrder)}");

            var selectedPreferences =
                System.Enum.GetValues(typeof(ClientPreferences))
                .Cast<ClientPreferences>()
                .Where(p => preferences.HasFlag(p));
            foreach (var selectedPreference in selectedPreferences)
                Console.WriteLine($"Preferences in Array: {selectedPreference}");
            
            Console.ReadKey();
        }
    }
}
// The exmaple displays the following output
// Preferences String value: LargeText, AutoComplete, AutoOrder
// Preferences Integer value: 22
// Preferences HasFlag:None: True
// Preferences HasFlag:DarkMode: False
// Preferences HasFlag:LargeText: True
// Preferences HasFlag:AutoComplete: True
// Preferences HasFlag:AIAssist: False
// Preferences HasFlag:AutoOrder: True
// Preferences in Array: None
// Preferences in Array: LargeText
// Preferences in Array: AutoComplete
// Preferences in Array: AutoOrder