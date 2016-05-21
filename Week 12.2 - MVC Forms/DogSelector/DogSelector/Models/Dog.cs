using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models
{
    public class Dog
    {
        public enum EScale
        {
            Low,
            Medium,
            High,
            NoPreference
        }

        public enum ELength
        {
            Short,
            Medium,
            Long
        }

        public enum ESize
        {
            Miniature,
            Small,
            Medium,
            Large,
            Giant
        }
        public String BreedName { get; set; }
        public String DisplayName { get; set; }
        public EScale ActivityLevel { get; set; }
        public ELength CoatLength { get; set; }
        public Boolean Drools { get; set; }
        public Boolean GoodWithChildren { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public ESize Size { get; set; }
        public String ImageName { get; set; }
    }
}