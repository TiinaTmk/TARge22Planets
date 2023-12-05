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
                    "https://science.nasa.gov/image-detail/pia19968-charonmoon/",
                    "https://solarsystem.nasa.gov/system/news_items/main_images/2386_Clyde_Tombaugh_with_the_Telescope_3200.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://solarsystem.nasa.gov/system/news_items/main_images/12597_PIA19936-FigureA_web.jpg"
                }
         },
            new()
            {
                Name = "Ceres",
                Subtitle = "The dwarf planet",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between " +
                "Mars and Jupiter and the only dwarf planet located in the inner " +
                "Solar System. It was the first dwarf planet to be visited by a " +
                "spacecraft, NASA's Dawn mission.",
                AccentColorStart = Color.FromArgb("#735f42"),
                AccentColorEnd = Color.FromArgb("#c5b59e"),
                Images = new()
                {
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/pia19063-main.jpg",
                    "https://solarsystem.nasa.gov/system/news_items/main_images/1452_Ceres_Square_Dawn_DLR_Main_Dawn.png",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://solarsystem.nasa.gov/system/news_items/main_images/9174_PIA23095-CeresAtOccatorCrater-Dawn-AHAMO-20180614.gif"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The dwarf planet",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located beyond Neptune " +
                "in the scattered disc, a distant area of icy bodies that are " +
                "not within the Kuiper Belt. It is one of the fastest rotating " +
                "large objects in our Solar System.",
                AccentColorStart = Color.FromArgb("#704d31"),
                AccentColorEnd = Color.FromArgb("#c69e7b"),
                Images = new()
                {
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19968-charonmoon-jpg.webp?w=2048&format=webp",
                    "https://smd-cms.nasa.gov/wp-content/uploads/2023/01/hubble-pluto-stsci-01evsrjcapn1afkxej1d7e1njd.png?w=2048&format=webp",
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA20544/PIA20544~orig.jpg%3Fw=855%26h=582%26fit=clip%26crop=faces%252Cfocalpoint"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "The dwarf planet",
                HeroImage = "makemake.png",
                Description = "MakeMake is a dwarf planet and a member of the " +
                "scattered disc, located in the outermost regions of our Solar " +
                "System. It was discovered in 2005 and is named after the creation " +
                "deity of the Rapa Nui people of Easter Island.",
                AccentColorStart = Color.FromArgb("#535953"),
                AccentColorEnd = Color.FromArgb("#a3a999"),
                Images = new()
                {
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/makemake_art.jpg",
                    "https://solarsystem.nasa.gov/system/news_items/main_images/4704_PIA21064-FigureA-web.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://solarsystem.nasa.gov/system/news_items/main_images/14216_MakeMake_web.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The dwarf planet",
                HeroImage = "eris.png",
                Description = "Eris is a dwarf planet and a scattered disc object " +
                "in the outermost regions of the Solar System. It was discovered " +
                "in 2005 and is known for its relatively high mass and large size.",
                AccentColorStart = Color.FromArgb("#454c5c"),
                AccentColorEnd = Color.FromArgb("#99a5b5"),
                Images = new()
                {
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/eris_web.png",
                    "https://solarsystem.nasa.gov/system/news_items/main_images/1828_PIA11141-web.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://solarsystem.nasa.gov/system/news_items/main_images/2330_Eris_FigA-web.gif"
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