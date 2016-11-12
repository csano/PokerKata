using FluentAssertions;
using PokerKata.Cards;
using PokerKata.Cards.Values;
using Xunit;

namespace PokerKata.UnitTests.Cards.Values.Comparing
{
    public class TestValue : Value
    {
        public override int Rank => 100;

        public override string ToString()
        {
            return "ZZZZ";
        }
    }

    public class ComparingJackValue : ComparingValue<JackValue> { }
    public class ComparingTenValue : ComparingValue<TenValue> { }
    public class ComparingNineValue : ComparingValue<NineValue> { }
    public class ComparingEightValue : ComparingValue<EightValue> { }
    public class ComparingSevenValue : ComparingValue<SevenValue> { }
    public class ComparingSixValue : ComparingValue<SixValue> { }
    public class ComparingFiveValue : ComparingValue<FiveValue> { }
    public class ComparingFourValue : ComparingValue<FourValue> { }
    public class ComparingThreeValue : ComparingValue<ThreeValue> { }
    public class ComparingTwoValue : ComparingValue<TwoValue> { }

    public abstract class ComparingValue<T> where T: Value, new()
    {
        [Fact]
        public void ReturnsZeroIfBothAreTheSame()
        {
            var value = new T();

            var result = value.CompareTo(value);

            result.ShouldBeEquivalentTo(0);
        }

        [Fact]
        public void ReturnsValueLessThanOneIfValueBeingComparedToIsNull()
        {
            var value = new T();

            var result = value.CompareTo(null);

            result.Should().BeLessThan(0);
        }

        [Fact]
        public void ReturnValueMoreThanZeroIfValueComesBeforeTheOther()
        {
            var value1 = new T();
            var value2 = new TestValue();

            var result = value1.CompareTo(value2);

            result.Should().BeGreaterThan(0);
        }

        [Fact]
        public void ReturnsValueLessThanOneIfValueIsToFollowValueBeingComparedTo()
        {
            var value1 = new TestValue();
            var value2 = new T();

            var result = value1.CompareTo(value2);

            result.Should().BeLessThan(0);
        }
    }
}