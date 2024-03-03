using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pyramidenstumpf
{

    //Membervariabeln

    public class Pyramid
    {
        private double _DeckseiteA;
        private double _DeckseiteB;
        private double _BasisseiteA;
        private double _BasisseiteB;
        private double _Hoehe;

        public double DeckseiteA
        {
            get
            {
                return _DeckseiteA;
            }
            set
            {
                if (value < 1)
                    value = 1;
                _DeckseiteA = value;
            }
        }
        public double DeckseiteB
        {
            get
            {
                return _DeckseiteB;
            }
            set
            {
                if (value < 1)
                    value = 1;
                _DeckseiteB = value;
            }
        }
        public double BasisseiteA
        {
            get
            {
                return _BasisseiteA;
            }
            set
            {
                if (value < 1)
                    value = 1;
                _BasisseiteA = value;
            }
        }
        public double BasisseiteB
        {
            get
            {
                return _BasisseiteB;
            }
            set
            {
                if (value < 1)
                    value = 1;
                _BasisseiteB = value;
            }
        }
        public double Hoehe
        {
            get
            {
                return _Hoehe;
            }
            set
            {
                if (value < 1)
                    value = 1;
                _Hoehe = value;
            }
        }

        //Constructor

        public Pyramid()
        {
            DeckseiteA = 2;
            DeckseiteB = 2;
            BasisseiteA = 2;
            BasisseiteB = 2;
            Hoehe = 2;
        }

        public double PyramidVolume {
            get
            {
                return (Hoehe / 3) * (DeckseiteAB() + Math.Sqrt(DeckseiteAB() * BasisseiteAB()) + BasisseiteAB());
            }

        }

        public double PyramidLateralSurface { 
            get 
            {
                return (DeckseiteA + DeckseiteB + BasisseiteA + BasisseiteB) * Hoehe / 2;
            }
        }

        public double DeckseiteAB()
        {
            return DeckseiteA * DeckseiteB;
        }

        public double Deckseiteab {
            get
            {
                return DeckseiteA * DeckseiteB;
            }

        }

        public double Basisseiteab { 
            get
            {
                return BasisseiteA * BasisseiteB;
            }
        }

        public double BasisseiteAB() 
        {
            return BasisseiteA * BasisseiteB;
        }

    }
}
