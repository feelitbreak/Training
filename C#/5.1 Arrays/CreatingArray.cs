using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return new int[0];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] array = { };
            return array;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static string[] CreateEmptyArrayOfStrings()
        {
            return new string[] { };
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static char[] CreateEmptyArrayOfCharacters()
        {
            return new char[] { };
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            const int n = 10;
            return new int[n];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            const int n = 20;
            return new bool[n];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            const int n = 5;
            return new string[n];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            const int n = 15;
            return new char[n];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            const int n = 18;
            return new double[n];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            const int n = 100;
            return new float[n];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            const int n = 1000;
            return new decimal[n];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            return new int[] { 123_456 };
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            return new int[] { 1_111_111, 9_999_999 };
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            return new int[] { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 923_943, 7_537, 4_162, 10_134 };
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            return new bool[] { true };
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            return new bool[] { true, false, true, false, true };
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            return new bool[] { false, true, true, false, true, true, false };
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            return new string[] { "one" };
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            return new string[] { "one", "two", "three" };
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            return new string[] { "one", "two", "three", "four", "five", "six" };
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            return new char[] { 'a' };
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            return new char[] { 'a', 'b', 'c' };
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            return new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            return new double[] { 1.12 };
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            return new double[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
        }

        public static double[] CreateDoubleWithNineElements()
        {
            return new double[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            return new float[] { 123_456_789.123456f };
        }

        public static float[] CreateFloatWithThreeElements()
        {
            return new float[] { 1_000_000.123456f, 2_223_334_444.123456f, 9_999.999999f };
        }

        public static float[] CreateFloatWithFiveElements()
        {
            return new float[] { 1.0123f, 20.012345f, 300.01234567f, 4_000.01234567f, 500_000.01234567f };
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            return new decimal[] { 10_000.123456m };
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            return new decimal[] { 1_000.1234m, 100_000.2345m, 100_000.3456m, 1_000_000.456789m, 10_000_000.5678901m };
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            return new decimal[] { 10.122112m, 200.233223m, 3_000.344334m, 40_000.455445m, 500_000.566556m, 6_000_000.677667m, 70_000_000.788778m, 800_000_000.899889m, 9_000_000_000.911991m };
        }
    }
}
