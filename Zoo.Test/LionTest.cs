using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo.Lib;

namespace Zoo.Test
{
    public class LionTest
    {
        [Fact]
        public void Declare_LionWithNameOnly_HasCorrectName()
        {
            //arange
            Lion lion;

            //Act
            var name = "ABCD";
            lion = new Lion(name);
            var actual = lion.Name;

            var expected = name;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
