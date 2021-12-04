using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class TowerBuilderKata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            int indexCounter = 0;
            StringBuilder tower = new StringBuilder();
            tower.Insert(0, "*", (2 * (nFloors - 1) + 1));
            List<string> listOfTowerStrings = new List<string>();
            listOfTowerStrings.Add(tower.ToString());

            for (int i = 0; i < tower.ToString().Length / 2; i++)
            {
                string currentFloor = tower.Replace('*', ' ', (0 + indexCounter), 1).ToString();
                currentFloor = tower.Replace('*', ' ', ((tower.ToString().Length - 1) - indexCounter), 1).ToString();
                listOfTowerStrings.Add(currentFloor);
                indexCounter++;
            }

            listOfTowerStrings.Reverse();

            string[] arrTower = listOfTowerStrings.ToArray();


            return arrTower;
        }
    }
}
