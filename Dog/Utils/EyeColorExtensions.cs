using DogNamespace;

namespace Dog.Utils
{
    public class EyeColorExtensions
    {
        public static bool TryParse(string value, out EyeColor eyeColor)
        {
            // Attempt to parse the string value into the enum
            switch (value)
            {
                case "Brown":
                    eyeColor = EyeColor.Brown;
                    return true;
                case "Blue":
                    eyeColor = EyeColor.Blue;
                    return true;
                case "Green":
                    eyeColor = EyeColor.Green;
                    return true;
                case "Amber":
                    eyeColor = EyeColor.Amber;
                    return true;
                case "Hazel":
                    eyeColor = EyeColor.Hazel;
                    return true;
                case "Mixed":
                    eyeColor = EyeColor.Mixed;
                    return true;
                default:
                    eyeColor = EyeColor.Unknown;
                    return false;
            }
        }
    }
}