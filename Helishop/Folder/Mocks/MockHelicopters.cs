using Helishop.Folder.Interfaces;
using Helishop.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helishop.Folder.Mocks
{
    public class MockHelicopters : IAllHelicopters
    {
        private readonly IHelicopterCategory helicopterCategory = new MockCategory();

        public IEnumerable<Helicopter> Helicopters
        {
            get
            {
                return new List<Helicopter>
                {
                    new Helicopter 
                    {
                        name = "Robinson R66 Turbine",
                        description = "Первый вертолет с газотурбинным двигателем в линейке Robinson, вертолет R66 turbine внешне похож на R44, однако отличается от предыдущей модели габаритами и новым типом двигателя. Кабина этого вертолета рассчитана на пять человек; кроме того, вертолет Robinson R66 имеет вместительный багажник. Мощный высокопроизводительный двигатель Rolls-Royce RR300 был разработан специально для Robinson R66 turbine.",
                        image = "/img/RobinsonR66Turbine.jpg",
                        price = 1157000,
                        issueYear = 2020,
                        fuel = "TC-1(керосин)",
                        flightRange = 610,
                        flightHours = 350,
                        enginesCount = 1,
                        Category = helicopterCategory.AllCategories.First()
                    },
                    new Helicopter
                    {
                        name = "Robinson R44 Raven I",
                        description = "Легкий многоцелевой вертолет Robinson R44 Raven I рассчитан на четырех человек - трех пассажиров и одного пилота. Это простое в эксплуатации транспортное средство надежно, что подтверждает мировая статистика. В серийном выпуске вертолет уже более 17-ти лет, за это время работа его систем многократно оптимизировалась, с целью сделать полеты эффективными, при низких операционных затратах. Стоит отметить, что Robinson R44 Raven I оснащен поршневым карбюраторным двигателем. Но летные характеристики этого воздушного судна (в частности, аэродинамика и скорость) таковы, что в эксплуатации он не уступает моделям с газотурбинными двигателями.",
                        image = "/img/RobinsonR44RavenI.jpg",
                        price = 549000,
                        issueYear = 2010,
                        fuel = "TC-1(керосин)",
                        flightRange = 619,
                        flightHours = 650,
                        enginesCount = 1,
                        Category = helicopterCategory.AllCategories.First()
                    },
                    new Helicopter
                    {
                        name = "Airbus Helicopters H130",
                        description = "Многофункциональный легкий одномоторный вертолет AIRBUS Helicopters H130 (ранее Eurocopter EC130 T2). В сравнении с предыдущим представителем этого модельного ряда, машина получила на 70% реконструированный фюзеляж. Это просторный вертолет, вмещающий одного пилота и семь пассажиров, предназначенный для выполнения различных задач, от патрулирования до воздушного туризма и VIP-перевозок.",
                        image = "/img/AirbusHelicoptersH130.jpg",
                        price = 3350000,
                        issueYear = 2015,
                        fuel = "TC-1(керосин)",
                        flightRange = 644,
                        flightHours = 800,
                        enginesCount = 1,
                        Category = helicopterCategory.AllCategories.Last()
                    },
                    new Helicopter
                    {
                        name = "Airbus Helicopters H125",
                        description = "Легкий однодвигательный вертолет AIRBUS Helicopters H125 (ранее Еurocopter AS350 B3), оборудован мощным двигателем с цифровой системой управления FADEC. При полной загрузке вертолет может подниматься на 7 тысяч метров. Воздушное судно адаптировано к полетам в экстремальных условиях, включая перелеты в высокогорной местности и в условиях жаркого климата. Первый полет вертолета H125 (Еurocopter AS350) состоялся в 1997-м году, и с тех пор машина постоянно совершенствуется.",
                        image = "/img/AirbusHelicoptersH125.jpg",
                        price = 2850000,
                        issueYear = 2019,
                        fuel = "100LL(бензин)",
                        flightRange = 1313,
                        flightHours = 134,
                        enginesCount = 2,
                        Category = helicopterCategory.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Helicopter> AllHelicopters => throw new NotImplementedException();

        public Helicopter getObjectHelicopter(int helicopterID)
        {
            throw new NotImplementedException();
        }
    }
}
