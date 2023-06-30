using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAndLINQ
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }

        public static readonly IEnumerable<Comic> Catalog =
            new List<Comic>
            {
                new Comic{Name = "Johny America vs. the Pinko", Issue = 6},
                new Comic{Name = "Rock and Roll (edycja limitowana)" , Issue = 19},
                new Comic{Name = "Woman's Work", Issue = 36},
                new Comic{Name = "Hippie Madness (z błedami w druku)" , Issue = 57 },
                new Comic{Name = "Revenge of the New Wave Freak (uszkodzony)",Issue = 68 },
                new Comic{Name = "Black Monday", Issue = 74 },
                new Comic{Name = "Tribal Tattoo Madness" , Issue = 83 },
                new Comic{Name = "The Death of the Object", Issue = 97 },
            };

        public static readonly IReadOnlyDictionary<int, decimal> Prices =
            new Dictionary<int, decimal>
            {
                {6,3600M },
                {19, 500M },
                {36, 650M },
                {57, 13525M },
                {68,250M },
                {74, 75M },
                {83, 25.75M },
                {97,35.25M },
            };

        public override string ToString() => $"{Name}  (Number {Issue})";
    }
}
