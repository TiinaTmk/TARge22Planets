using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }


           },
            new ()
            {
                Name = "Earth",
                Subtitle = "The home planet",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the " +
                "only astronomical object known to harbor life. About 29.2% of " +
                "Earth's surface is land, and 70.8% is water. Its atmosphere " +
                "contains oxygen, essential for life, and protects living " +
                "organisms from harmful solar radiation.",
                AccentColorStart = Color.FromArgb("#2a6f5e"),
                AccentColorEnd = Color.FromArgb("#8fd8a0"),
                Images = new List<string>
                {
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png"

                }
                },
            new()
            {
                Name = "Pluto",
                Subtitle = "The dwarf planet Pluto",
                HeroImage = "pluto.png",
                Description = "Pluto, designated as 134340 Pluto, is a dwarf planet " +
                "in our Solar System's Kuiper Belt, a ring of bodies beyond " +
                "Neptune. It was the ninth and smallest planet in the Solar " +
                "System before being reclassified as a dwarf planet by the " +
                "International Astronomical Union (IAU) in 2006.",
                AccentColorStart = Color.FromArgb("#4c5067"),
                AccentColorEnd = Color.FromArgb("#b3b8c1"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_1280&f_webp/https://images-assets.nasa.gov/image/PIA20037/PIA20037~orig.jpg%3Fw=1041%26h=717%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/01/hubble-pluto-stsci-01evsrjcapn1afkxej1d7e1njd.png?w=1280&format=webp",
                    "https://science.nasa.gov/_ipx/animated_true&w_1280&f_webp/https://images-assets.nasa.gov/image/PIA20544/PIA20544~orig.jpg%3Fw=855%26h=582%26fit=clip%26crop=faces%252Cfocalpoint"
                }
         },
            new()
            {
                Name = "Ceres",
                Subtitle = "The dwarf planet Ceres",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between " +
                "Mars and Jupiter and the only dwarf planet located in the inner " +
                "Solar System. It was the first dwarf planet to be visited by a " +
                "spacecraft, NASA's Dawn mission.",
                AccentColorStart = Color.FromArgb("#735f42"),
                AccentColorEnd = Color.FromArgb("#c5b59e"),
                Images = new()
                {
                    "https://t3.ftcdn.net/jpg/02/71/65/66/240_F_271656664_Vgdjv5mqCxFesA1DtM4e8GUZmhSWNbti.jpg",
                    "https://t4.ftcdn.net/jpg/00/80/43/55/240_F_80435515_9svCUogTzn9Wt1sjoMkcxheCFU9PVnJU.jpg",
                    "https://t4.ftcdn.net/jpg/05/14/37/43/240_F_514374324_BC765PP2fEC1fQONTW0zhIFcSQdx2SEh.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The dwarf planet Haumea",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located beyond Neptune " +
                "in the scattered disc, a distant area of icy bodies that are " +
                "not within the Kuiper Belt. It is one of the fastest rotating " +
                "large objects in our Solar System.",
                AccentColorStart = Color.FromArgb("#704d31"),
                AccentColorEnd = Color.FromArgb("#c69e7b"),
                Images = new()
                {
                    "https://t3.ftcdn.net/jpg/03/60/71/32/240_F_360713257_GGpXjLHfb7ygmMqufUDu4zM0tMlAjIqp.jpg",
                    "https://static.wikia.nocookie.net/planet-archives/images/2/2d/Haumea.png/revision/latest?cb=20131012022005",
                    "https://cdn.mos.cms.futurecdn.net/JMePZFEJNcVnNawYzrCv96.jpg" }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The dwarf planet MakeMake",
                HeroImage = "makemake.png",
                Description = "MakeMake is a dwarf planet and a member of the " +
                "scattered disc, located in the outermost regions of our Solar " +
                "System. It was discovered in 2005 and is named after the creation " +
                "deity of the Rapa Nui people of Easter Island.",
                AccentColorStart = Color.FromArgb("#535953"),
                AccentColorEnd = Color.FromArgb("#a3a999"),
                Images = new()
                {
                    "https://pbs.twimg.com/media/Ex2HVFTWQAAuRnO.jpg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROIUZOHcY6ifuZ01KlpSJ0XNvXV_jOhoQdfQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNsq-bxiTmjhCCdT6xffaaDN1MgmuZqnj2UQ&usqp=CAU"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The dwarf planet Eris",
                HeroImage = "eris.png",
                Description = "Eris is a dwarf planet and a scattered disc object " +
                "in the outermost regions of the Solar System. It was discovered " +
                "in 2005 and is known for its relatively high mass and large size.",
                AccentColorStart = Color.FromArgb("#454c5c"),
                AccentColorEnd = Color.FromArgb("#99a5b5"),
                Images = new()
                {
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/06/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun-jpeg.webp?w=1280&format=webp",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd5nzS0cinpnCDelIiKnorqzbGyXyck9KXiQ&usqp=CAU",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuPZ5HEs_2XAVEvn621NphxRo6e13rEyrM-w&usqp=CAU"
                }
            } };



        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
