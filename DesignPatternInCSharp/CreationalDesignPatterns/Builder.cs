using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.CreationalDesignPatterns
{
   class Burger
    {
        private int msize;
        private bool mCheese;
        private bool mPepperoni;
        private bool mLettuce;
        private bool mTomato;

        public Burger(BurgerBuilder builder)
        {
            msize = builder.Size;
            mCheese = builder.Cheese;
            mPepperoni = builder.Lettuce;
            mTomato = builder.Tomato;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();
            sb.Append($"This is {msize} inch burger");
            return sb.ToString();
        }
    }

    class BurgerBuilder
    {
        public int Size;
        public bool Cheese;
        public bool Pepperoni;
        public bool Lettuce;
        public bool Tomato;

        public BurgerBuilder(int size)
        {
            Size = size;
        }

        public BurgerBuilder AddCheese()
        {
            Cheese = true;
            return this;
        }

        public BurgerBuilder AddPepperoni()
        {
            Pepperoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            Lettuce = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            Tomato = true;
            return this;
        }

        public Burger Build()
        {
            return new Burger(this);
        }

        // var burger = new BurgerBuilder(4).AddCheese()
        //                                  .AddPepperoni().AddLettcue().AddTomato().Build();
                                            



    }
}
