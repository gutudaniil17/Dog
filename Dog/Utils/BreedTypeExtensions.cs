using DogNamespace;

namespace Dog.Utils
{
    public class BreedTypeExtensions
    {
        public static bool TryParse(string value, out BreedType breed)
        {
            // Attempt to parse the string value into the enum
            switch (value)
            {
                case "Labrador":
                    breed = BreedType.Labrador;
                    return true;
                case "Beagle":
                    breed = BreedType.Beagle;
                    return true;
                case "Bulldog":
                    breed = BreedType.Bulldog;
                    return true;
                case "GermanShepherd":
                    breed = BreedType.GermanShepherd;
                    return true;
                case "GoldenRetriever":
                    breed = BreedType.GoldenRetriever;
                    return true;
                case "Poodle":
                    breed = BreedType.Poodle;
                    return true;
                case "Rottweiler":
                    breed = BreedType.Rottweiler;
                    return true;
                default:
                    breed = BreedType.Unknown;
                    return false;
            }
        }
    }
}