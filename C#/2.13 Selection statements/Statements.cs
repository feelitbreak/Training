using System;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (third >= first && third >= second)
            {
                Console.WriteLine("Number {0} is the largest", third);
            }
            else
            {
                if (second >= first)
                {
                    Console.WriteLine("Number {0} is the largest", second);
                }
                else
                {
                    Console.WriteLine("Number {0} is the largest", first);
                }
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            if (third >= first && third >= second)
            {
                Console.WriteLine("Number {0} is the largest", third);
            }
            else
            {
                Console.WriteLine("Number {0} is the largest", second >= first ? second : first);
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (third >= first && third >= second)
            {
                Console.WriteLine("Number {0} is the largest", third);
            }
            else if (second >= first)
            {
                Console.WriteLine("Number {0} is the largest", second);
            }
            else
            {
                Console.WriteLine("Number {0} is the largest", first);
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads <= 0)
            {
                Console.WriteLine("No downloads.");
            }
            else if (countOfDailyDownloads < 100)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else if (countOfDailyDownloads < 1_000)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads < 10_000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads < 100_000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
        }

        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("The weekend.");
            }
            else if (dayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if (dayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("The last day of the work week.");
            }
            else
            {
                Console.WriteLine("The middle of the work week.");
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend.");
                    break;

                case DayOfWeek.Monday:
                    Console.WriteLine("The first day of the work week.");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("The last day of the work week.");
                    break;

                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }
            else if (arg is byte)
            {
                return $"{arg} is byte.";
            }
            else if (arg is short)
            {
                return $"{arg} is short.";
            }
            else if (arg is int)
            {
                return $"{arg} is int.";
            }
            else if (arg is long)
            {
                return $"{arg} is long.";
            }
            else if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }
            else if (arg is uint)
            {
                return $"{arg} is uint.";
            }
            else if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }
            else
            {
                return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte:
                    return $"{arg} is sbyte.";
                case byte:
                    return $"{arg} is byte.";
                case short:
                    return $"{arg} is short.";
                case int:
                    return $"{arg} is int.";
                case long:
                    return $"{arg} is long.";
                case ushort:
                    return $"{arg} is ushort.";
                case uint:
                    return $"{arg} is uint.";
                case ulong:
                    return $"{arg} is ulong.";
                default:
                    return $"{arg} is not integer.";
            }
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            return arg switch
            {
                sbyte => $"{arg} is sbyte.",
                byte => $"{arg} is byte.",
                short => $"{arg} is short.",
                int => $"{arg} is int.",
                long => $"{arg} is long.",
                ushort => $"{arg} is ushort.",
                uint => $"{arg} is uint.",
                ulong => $"{arg} is ulong.",
                _ => $"{arg} is not integer.",
            };
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch (month)
            {
                case Month.December:
                case Month.January:
                case Month.February:
                    Console.WriteLine("It's winter now.");
                    break;
                case Month.March:
                case Month.April:
                case Month.May:
                    Console.WriteLine("It's spring now.");
                    break;
                case Month.June:
                case Month.July:
                case Month.August:
                    Console.WriteLine("It's summer now.");
                    break;
                case Month.September:
                case Month.October:
                case Month.November:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number / 1_000_000_000 != 0)
            {
                return 10;
            }
            else if (number / 100_000_000 != 0)
            {
                return 9;
            }
            else if (number / 10_000_000 != 0)
            {
                return 8;
            }
            else if (number / 1_000_000 != 0)
            {
                return 7;
            }
            else if (number / 100_000 != 0)
            {
                return 6;
            }
            else if (number / 10_000 != 0)
            {
                return 5;
            }
            else if (number / 1_000 != 0)
            {
                return 4;
            }
            else if (number / 100 != 0)
            {
                return 3;
            }
            else if (number / 10 != 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public static byte GetLengthWithSwitchExpression(int number)
        {
            return number switch
            {
                { } when number / 1_000_000_000 != 0 => 10,
                { } when number / 100_000_000 != 0 => 9,
                { } when number / 10_000_000 != 0 => 8,
                { } when number / 1_000_000 != 0 => 7,
                { } when number / 100_000 != 0 => 6,
                { } when number / 10_000 != 0 => 5,
                { } when number / 1_000 != 0 => 4,
                { } when number / 100 != 0 => 3,
                { } when number / 10 != 0 => 2,
                _ => 1
            };
        }

        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month == 1)
            {
                return Month.January;
            }
            else if (month == 2)
            {
                return Month.February;
            }
            else if (month == 3)
            {
                return Month.March;
            }
            else if (month == 4)
            {
                return Month.April;
            }
            else if (month == 5)
            {
                return Month.May;
            }
            else if (month == 6)
            {
                return Month.June;
            }
            else if (month == 7)
            {
                return Month.July;
            }
            else if (month == 8)
            {
                return Month.August;
            }
            else if (month == 9)
            {
                return Month.September;
            }
            else if (month == 10)
            {
                return Month.October;
            }
            else if (month == 11)
            {
                return Month.November;
            }
            else if (month == 12)
            {
                return Month.December;
            }
            else
            {
                return null;
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;
                default:
                    return null;
            }
        }

        public static Month? GetMonthWithSwitchExpression(int month)
        {
            return month switch
            {
                1 => Month.January,
                2 => Month.February,
                3 => Month.March,
                4 => Month.April,
                5 => Month.May,
                6 => Month.June,
                7 => Month.July,
                8 => Month.August,
                9 => Month.September,
                10 => Month.October,
                11 => Month.November,
                12 => Month.December,
                _ => null,
            };
        }
    }
}
