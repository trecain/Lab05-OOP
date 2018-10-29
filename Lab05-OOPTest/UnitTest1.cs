using System;
using Xunit;
using Lab05_OOP.Classes;
using Lab05_OOP;

namespace Lab05_OOPTest
{
    public class UnitTest1
    {

        /// <summary>
        /// creates a pig and runs methods and properties
        /// </summary>
        [Fact]
        public void CanCreateAPig()
        {
            Pig porky = new Pig("porky", 4, "oink", "stubby", "pink");
            Assert.Equal("*stomach growling* I'm hungry.", porky.RequestFood());
            Assert.True(porky.EatingFlys());
            Assert.Equal("zzzzzzzzzzzzzz", porky.Sleep());
            Assert.Equal(4, porky.Legs);
            Assert.True(porky.SunBathes);
            Assert.Equal("Burn !!!", porky.Bathes());
            Assert.True(porky.Carnivore());
            Assert.Equal("pink", porky.TailColor);
            Assert.Equal("porky", porky.Name);
            Assert.Equal("oink", porky.UserSpeech());
        }


        /// <summary>
        /// creates a cat and runs methods and properties
        /// </summary>
        [Fact]
        public void CanCreateCat()
        {
            Cat boogaloo = new Cat("boogaloo", 3, "purrr", "gray", "thick");
            Assert.Equal("boogaloo", boogaloo.Name);
            Assert.Equal(3, boogaloo.Legs);
            Assert.Equal("purrr", boogaloo.UserSpeech());
            Assert.Equal("Goodnight", boogaloo.Sleep());
            Assert.Equal("Grub out", boogaloo.RequestFood());
            Assert.Equal("thick", boogaloo.Type);
            Assert.Equal("gray", boogaloo.EyeColor);
        }


        /// <summary>
        /// create a duck and run methods and properties
        /// </summary>
        [Fact]
        public void CanCreateDuck()
        {
            Duck donald = new Duck("donald", 2, "quack", 10, true);
            Assert.Equal("donald", donald.Name);
            Assert.Equal(2, donald.Legs);
            Assert.Equal("quack", donald.UserSpeech());
            Assert.True(donald.EatsTrash);
            Assert.Equal(10, donald.RabiesLevel);
            Assert.True(donald.BiteSomeone());
            Assert.True(donald.SunBathes);
            Assert.Equal("Soaking those rays up", donald.Bathes());
        }


        /// <summary>
        /// create eagle and run methods and properties
        /// </summary>
        [Fact]
        public void CanCreateEagle()
        {
            Eagle american = new Eagle("midnight", 2, "cah", 15, false);
            Assert.Equal("midnight", american.Name);
            Assert.Equal(2, american.Legs);
            Assert.Equal("cah", american.UserSpeech());
            Assert.False(american.EatsTrash);
            Assert.True(american.BiteSomeone());
            Assert.Equal("zzzzzzzzzZZZZZZZZ", american.Sleep());
            Assert.True(american.CanScratch());
            Assert.Equal(15, american.RabiesLevel);
        }


        /// <summary>
        /// create mice and run methods and properties
        /// </summary>
        [Fact]
        public void CanCreateMice()
        {
            Mice momo = new Mice("momo", 4, "screech", 44, "black plague");
            Assert.Equal("momo", momo.Name);
            Assert.Equal(4, momo.Legs);
            Assert.Equal("screech", momo.UserSpeech());
            Assert.Equal(44, momo.RabiesLevel);
            Assert.True(momo.BiteSomeone());
            Assert.True(momo.Carnivore());
            Assert.Equal("Goodnight", momo.Sleep());
        }


        /// <summary>
        /// create turkey and run methods and properties
        /// </summary>
        [Fact]
        public void CanCreateTurkey()
        {
            Turkey wobbles = new Turkey("wobbles", 2, "gobble, gobble", "brown", "feathery");
            Assert.Equal("wobbles", wobbles.Name);
            Assert.Equal(2, wobbles.Legs);
            Assert.Equal("brown", wobbles.EyeColor);
            Assert.Equal("feathery", wobbles.TailColor);
            Assert.True(wobbles.Gobble());
            Assert.False(wobbles.Carnivore());
            Assert.Equal("*stomach growling* I'm hungry.", wobbles.RequestFood());
            Assert.Equal("Knocked out", wobbles.Sleep());
        }
      
    }
}
