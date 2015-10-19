using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        Droid[] droidCollection;
        int droidCollectionLength;

        public DroidCollection(int size)
        {
            droidCollection = new Droid[size];
            droidCollectionLength = 0;
        }

        public void AddNewDroid(Droid newDroid)
        {
            droidCollection[droidCollectionLength] = newDroid;
            droidCollectionLength++;
        }

        public string[] GetPrintStringForAllItems()
        {
            string[] allItemsString = new string[droidCollectionLength];
            int counter = 0;

            if (droidCollectionLength > 0)
            {
                foreach (Droid droid in droidCollection)
                {
                    if (droid != null)
                    {
                        allItemsString[counter] = droid.ToString();
                        counter++;
                    }
                }
            }
            return allItemsString;
        }

        public void DisplayAllDroids(string[] allItemsOutput)
        {
            Console.WriteLine();
            foreach (string itemOutput in allItemsOutput)
            {
                Console.WriteLine(itemOutput);
            }
        }




    }
}
