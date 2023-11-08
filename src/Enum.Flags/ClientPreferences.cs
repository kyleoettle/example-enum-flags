namespace Enum.Flags
{
    [Flags]
    public enum ClientPreferences
    {
        None = 0,
        DarkMode = 1,
        LargeText = 2,
        AutoComplete = 4,
        AIAssist = 8,
        AutoOrder = 16
    }
}
