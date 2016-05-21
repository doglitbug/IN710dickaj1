using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models

{
    public class DatabaseManager
    {
        public List<Dog> makeDatabase()
        {
            List<Dog> newDatabase = new List<Dog>();
            #region Population of Dog database
            Dog afghanHound = new Dog();
            afghanHound.BreedName = "afghanHound";
            afghanHound.DisplayName = "Afghan Hound";
            afghanHound.ActivityLevel = Dog.EScale.High;
            afghanHound.CoatLength = Dog.ELength.Long;
            afghanHound.Drools = false;
            afghanHound.GoodWithChildren = false;
            afghanHound.GroomingLevel = Dog.EScale.High;
            afghanHound.IntelligenceLevel = Dog.EScale.Low;
            afghanHound.SheddingLevel = Dog.EScale.High;
            afghanHound.Size = Dog.ESize.Large;
            afghanHound.ImageName = "AfghanHound.jpg";
            newDatabase.Add(afghanHound);


            Dog bassetHound = new Dog();
            bassetHound.BreedName = "BassetHound";
            bassetHound.DisplayName = "Basset Hound";
            bassetHound.ActivityLevel = Dog.EScale.Medium;
            bassetHound.CoatLength = Dog.ELength.Short;
            bassetHound.Drools = true;
            bassetHound.GoodWithChildren = true;
            bassetHound.GroomingLevel = Dog.EScale.Low;
            bassetHound.IntelligenceLevel = Dog.EScale.Medium;
            bassetHound.SheddingLevel = Dog.EScale.Low;
            bassetHound.Size = Dog.ESize.Medium;
            bassetHound.ImageName = "BassetHound.jpg";
            newDatabase.Add(bassetHound);

            Dog beagle = new Dog()
            {
                BreedName = "Beagle",
                DisplayName = "Beagle",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.Medium,
                IntelligenceLevel = Dog.EScale.Medium,
                SheddingLevel = Dog.EScale.Low,
                Size = Dog.ESize.Medium,
                ImageName = "Beagle.jpg"
            };
            newDatabase.Add(beagle);

            Dog bichonFrise = new Dog()
            {
                BreedName = "BichonFrise",
                DisplayName = "Bichon Frise",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.Low,
                Size = Dog.ESize.Small,
                ImageName = "Bichonfrise.jpg"
            };
            newDatabase.Add(bichonFrise);



            Dog borzoi = new Dog()
            {
                BreedName = "Borzoi",
                DisplayName = "Borzoi",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Long,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.High,
                Size = Dog.ESize.Large,
                ImageName = "Borzoi.jpg"
            };
            newDatabase.Add(borzoi);

            Dog bulldog = new Dog()
            {
                BreedName = "Bulldog",
                DisplayName = "Bull Dog",
                ActivityLevel = Dog.EScale.Medium,
                CoatLength = Dog.ELength.Short,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = Dog.EScale.Low,
                IntelligenceLevel = Dog.EScale.Medium,
                SheddingLevel = Dog.EScale.Low,
                Size = Dog.ESize.Medium,
                ImageName = "Bulldog.jpg"
            };
            newDatabase.Add(bulldog);


            Dog cav = new Dog()
            {
                BreedName = "CavalierKingCharlesSpaniel",
                DisplayName = "Cavalier King Charles Spaniel",
                ActivityLevel = Dog.EScale.Medium,
                CoatLength = Dog.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.Medium,
                SheddingLevel = Dog.EScale.Medium,
                Size = Dog.ESize.Small,
                ImageName = "CavalierKingCharlesSpaniel.jpg"
            };
            newDatabase.Add(cav);

            Dog chowchow = new Dog()
            {
                BreedName = "Chowchow",
                DisplayName = "Chow Chow",
                ActivityLevel = Dog.EScale.Medium,
                CoatLength = Dog.ELength.Long,
                Drools = true,
                GoodWithChildren = false,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.High,
                Size = Dog.ESize.Large,
                ImageName = "Chowchow.jpg"
            };
            newDatabase.Add(chowchow);

            Dog dalmation = new Dog()
            {
                BreedName = "Dalmation",
                DisplayName = "Dalmation",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Short,
                Drools = false,
                GoodWithChildren = false,
                GroomingLevel = Dog.EScale.Medium,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.Low,
                Size = Dog.ESize.Large,
                ImageName = "Dalmation.jpg"
            };
            newDatabase.Add(dalmation);

            Dog goldenRetriever = new Dog()
            {
                BreedName = "GoldenRetriever",
                DisplayName = "Golden Retriever",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.Medium,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.High,
                Size = Dog.ESize.Large,
                ImageName = "GoldenRetriever.jpg"
            };
            newDatabase.Add(goldenRetriever);

            Dog maltese = new Dog()
            {
                BreedName = "Maltese",
                DisplayName = "Maltese",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Long,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.High,
                Size = Dog.ESize.Miniature,
                ImageName = "Maltese.jpg"
            };
            newDatabase.Add(maltese);

            Dog newfoundland = new Dog()
            {
                BreedName = "Newfoundland",
                DisplayName = "Newfoundland",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.Medium,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.High,
                Size = Dog.ESize.Giant,
                ImageName = "newfoundland.jpg"
            };
            newDatabase.Add(newfoundland);

            Dog oldEnglishSheepdog = new Dog()
            {
                BreedName = "OldEnglishSheepdog",
                DisplayName = "Old English Sheepdog",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Long,
                Drools = true,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.High,
                IntelligenceLevel = Dog.EScale.Medium,
                SheddingLevel = Dog.EScale.High,
                Size = Dog.ESize.Giant,
                ImageName = "OldEnglishSheepdog.jpg"
            };
            newDatabase.Add(oldEnglishSheepdog);

            Dog pug = new Dog()
            {
                BreedName = "Pug",
                DisplayName = "Pug",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Short,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.Low,
                IntelligenceLevel = Dog.EScale.Low,
                SheddingLevel = Dog.EScale.Low,
                Size = Dog.ESize.Miniature,
                ImageName = "Pug.jpg"
            };
            newDatabase.Add(pug);


            Dog westHighlandWhiteTerrier = new Dog()
            {
                BreedName = "WestHighlandWhiteTerrier",
                DisplayName = "West Highland White Terrier",
                ActivityLevel = Dog.EScale.High,
                CoatLength = Dog.ELength.Medium,
                Drools = false,
                GoodWithChildren = true,
                GroomingLevel = Dog.EScale.Medium,
                IntelligenceLevel = Dog.EScale.High,
                SheddingLevel = Dog.EScale.Medium,
                Size = Dog.ESize.Small,
                ImageName = "WestHighlandWhiteTerrier.jpg"
            };
            newDatabase.Add(westHighlandWhiteTerrier);
            #endregion
            return newDatabase;
        }
      
    }
}