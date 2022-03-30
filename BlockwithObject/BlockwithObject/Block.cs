using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockwithObject
{
    internal class Block : Object
    {
        private int firstSide;
        private int secondSide;
        private int thirdSide;
        private int fourthSide;
        public Block(int firstSide,int secondSide,int thirdSide,int fourthSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.fourthSide = fourthSide;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Block block = (Block)obj;
            return (firstSide == block.firstSide) && (secondSide == block.secondSide) && (thirdSide == block.thirdSide) && (fourthSide == block.fourthSide);
        }
        public override string ToString()
        {
            return $"1st Side ` {firstSide} 2st Side {secondSide} 3st Side {thirdSide} 4st Side {fourthSide}";
        }

    }
}
