using System.Text;

namespace _03_10;

public static class MyDateFormat
{
    public static string Format(MyDate date, string? format)
    {
        if (format is {Length: 1})
        {
            switch (format[0])
            {
                case 'O':
                case 'o':
                {
                    return $"{date.Year}-{date.Month}-{date.Day}";
                }
                case 'R':
                case 'r':
                {
                    return $"{string.Join("", date.DayOfWeek.ToString().Take(3))}, {date.Day} {string.Join("", date.MonthString.Take(3))} {date.Year}";
                }    
            }   
        }

        if (format == null)
            throw new NullReferenceException("Format cannot be null");

        return FormatCustomized(date, format);
    }

    private static string FormatCustomized(MyDate date, ReadOnlySpan<char> format)
    {
        StringBuilder result = new StringBuilder();
        int tokenLen;
        for (int i = 0; i < format.Length;i += tokenLen)
        {
            char ch = format[i];
            switch (ch)
            {
                case 'd':
                {
                    tokenLen = ParseRepeatPattern(format, i, 'd');
                    switch (tokenLen)
                    {
                        case 1:
                            result.Append(date.Day.ToString("0"));
                            break;
                        case 2:
                            result.Append(date.Day.ToString("00"));
                            break;
                        case 3:
                            result.Append(String.Join("", date.DayOfWeek.ToString().Take(3)));
                            break;
                        default:
                        {
                            result.Append(date.DayOfWeek.ToString());
                            break;
                        }
                    }
                    break;
                }
                case 'M':
                {
                    tokenLen = ParseRepeatPattern(format, i, 'M');
                    switch (tokenLen)
                    {
                        case 1:
                        {
                            result.Append(date.Month.ToString("0"));
                            break;
                        }
                        case 2:
                        {
                            result.Append(date.Month.ToString("00"));
                            break;
                        }
                        case 3:
                        {
                            result.Append(String.Join("", date.MonthString.Take(3)));
                            break;
                        }
                        case 4:
                        {
                            result.Append(date.MonthString);
                            break;
                        }
                    }
                    break;
                }
                case 'y':
                {
                    tokenLen = ParseRepeatPattern(format, i, 'y');
                    switch (tokenLen)
                    {
                        case 1:
                        {
                            result.Append(date.Year % 100);
                            break;
                        }
                        case 2:
                        {
                            result.Append((date.Year % 100).ToString("00"));
                            break;
                        }
                        default:
                        {
                            result.Append(date.Year);
                            break;
                        }
                    }

                    break;
                }
                default:
                {
                    tokenLen = 1;
                    result.Append(format[i]);
                    break;
                }
            }
        }

        Console.WriteLine($"Formatted string: {result.ToString()}");
        return result.ToString();
    }


    private static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar)
    {
        int len = format.Length;
        int index = pos + 1;
        
        while (index < len && format[index] == patternChar)
        {
            ++index;
        }

        return index - pos;
    }
}