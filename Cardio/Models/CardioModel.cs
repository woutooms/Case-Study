using System;
using Contentful.Core.Models;

namespace Cardio.Models
{
    public class CardioModel
    {
        public string Exercise { get; set; }
        public string Description { get; set; }

        public int Time { get; set; }

        public int Reps { get; set; }
        public int Session { get; set; }
        public Asset Image { get; set; }
    }
}
