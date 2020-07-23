using System;

public class Solution
{

    public static int FindRotationPoint(String[] words)
    {
        // Find the rotation point in the array
        if (words.Length <2) {
           return 0;
        }
        
        string firstItem = words[0];
        
        int floor = 0;
        int ceiling = words.Length - 1;
        int halfWay = words.Length / 2;
        
        while (floor < ceiling) {
            
            if (string.Compare(words[floor + halfWay], firstItem, StringComparison.Ordinal) <= 0) {
                ceiling = floor + halfWay;
            }
            
            else {
                floor = floor + halfWay;
            }
            
            halfWay = (ceiling - floor) / 2;
            
            if (floor + 1 == ceiling) {
                break;
            }
        }
        

        return ceiling;
    }


















    // Tests

    [Fact]
    public void SmallArrayTest()
    {
        var actual = FindRotationPoint(new string[] { "cape", "cake" });
        var expected = 1;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void MediumArrayTest()
    {
        var actual = FindRotationPoint(new string[] { "grape", "orange", "plum", "radish",
            "apple" });
        var expected = 4;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LargeArrayTest()
    {
        var actual = FindRotationPoint(
            new string[] { "ptolemaic", "retrograde", "supplant", "undulate", "xenoepist",
            "asymptote", "babka", "banoffee", "engender", "karpatka", "othellolagkage" });
        var expected = 5;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PossiblyMissingEdgeCaseTest()
    {
        // Are we missing any edge cases?
    }

    public static void Main(string[] args)
    {
        TestRunner.RunTests(typeof(Solution));
    }
}
