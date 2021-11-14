using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.StructuralDesignPattern
{
    interface ILion
    {
        void Roar();
    }

    class AfricanLion : ILion
    {
        public void Roar()
        {
            throw new NotImplementedException();
        }
    }

    class AsiaLion : ILion
    {
        public void Roar()
        {
            throw new NotImplementedException();
        }
    }

    class Hunter
    {
        public void Hunt(ILion lion)
        {

        }
    }

    class WildDog
    {
        public void bark()
        {

        }
    }

    class WildDogAdapter : ILion
    {
        private WildDog wildDog;
        public WildDogAdapter(WildDog dog)
        {
            wildDog = dog;
        }

        public void Roar()
        {
            wildDog.bark();
        }
    }

    //var wildDog = new WildDog();
    //var wildDogAdapter = new WildDogAdapter(wildDog);

    //var hunter = new Hunter();
    //hunter.Hunt(wildDogAdapter);

}
