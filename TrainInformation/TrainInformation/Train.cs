using System;
using System.Collections.Generic;
using System.Text;

namespace TrainInformation
{
    struct Train
    {
        private string _nameDestination;
        public int _numberTrain;
        public int _timeDeparture;
        public Train(string NameDecstination, int numberTrain, int timeDeparture)
        {
            _nameDestination = NameDecstination;
            _numberTrain = numberTrain;
            _timeDeparture = timeDeparture;
        }
        public void UserOutput(int numberTrain, Train[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (numberTrain == array[i]._numberTrain)
                {
                    Console.WriteLine($"Destination`{array[i]._nameDestination},Train Number`{array[i]._numberTrain},Time of Departure`{array[i]._timeDeparture}");
                }
                else
                {
                    Console.WriteLine("The number is not used in train!");
                }
            }
        }
    }
}
