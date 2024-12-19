using System;
using DogNamespace;

namespace Dog.Models
{
    public class Dog
    {
        public Dog()
        {
            Name = "Unknown";
            Weight = 0.0;
            Breed = BreedType.Unknown;
            IsVaccinated = false;
            BirthDate = DateTime.MinValue;
            Color = "Unknown";
            Height = 0.0f;
            OwnerName = "Unknown";
            EyeColor = EyeColor.Unknown;
            SexType = SexType.Unknown;
        }

        public Dog(
            string name,
            double weight,
            BreedType breed,
            bool isVaccinated,
            DateTime birthDate,
            string color,
            float height,
            string ownerName,
            EyeColor eyeColor,
            SexType sexType)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Weight = weight;
            Breed = breed;
            IsVaccinated = isVaccinated;
            BirthDate = birthDate;
            Color = color ?? throw new ArgumentNullException(nameof(color));
            Height = height;
            OwnerName = ownerName ?? throw new ArgumentNullException(nameof(ownerName));
            EyeColor = eyeColor;
            SexType = sexType;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public BreedType Breed { get; set; }
        public bool IsVaccinated { get; set; }
        public DateTime BirthDate { get; set; }
        public string Color { get; set; }
        public float Height { get; set; }
        public string OwnerName { get; set; }
        public EyeColor EyeColor { get; set; }
        public SexType SexType { get; set; }

        public override string ToString()
        {
            return $"Dog Details:" +
                   $"\nName: {Name}" +
                   $"\nWeight: {Weight} kg" +
                   $"\nBreed: {Breed}" +
                   $"\nVaccinated: {(IsVaccinated ? "Yes" : "No")}" +
                   $"\nBirth Date: {BirthDate.ToShortDateString()}" +
                   $"\nColor: {Color}" +
                   $"\nHeight: {Height} cm" +
                   $"\nOwner: {OwnerName}" +
                   $"\nEye Color: {EyeColor}" +
                   $"\nSex: {SexType}";
        }
    }
}