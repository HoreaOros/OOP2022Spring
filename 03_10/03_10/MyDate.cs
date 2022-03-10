// See https://aka.ms/new-console-template for more information
using System.Text;
// TODO: extindeti clasa MyDate cu alte operatii specifice. 
// getter/setter pentru cele 3 componente cu validare la setter
// AddDays, AddYear, AddMonths etc. 

internal class MyDate
{
    private int year;
    private int month;
    private int day;

    /// <summary>
    /// Copy constructor
    /// </summary>
    /// <param name="myDate"></param>
    public MyDate(MyDate myDate)
    {
        year = myDate.year;
        month = myDate.month;
        day = myDate.day;
    }

    public MyDate(int year, int month, int day)
    {
        this.year = year;
        this.month = month;
        this.day = day;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        return sb.Append("[")
          .Append(day.ToString())
          .Append("-")
          .Append(month.ToString("0#"))
          .Append("-")
          .Append(year.ToString())
          .Append("]")
          .ToString();
    }

    internal int DaysTo(MyDate d2)
    {
        MyDate minDate, maxDate;
        if (this.LessThan(d2))
        {
            minDate = new MyDate(this);
            maxDate = new MyDate(d2);
        }
        else
        {
            maxDate = new MyDate(this);
            minDate = new MyDate(d2);
        }

        int diff = 0;

        while (!minDate.IsEqual(maxDate))
        {
            maxDate.Decrement();
            diff++;
        }

        return diff;
    }

    private void Decrement()
    {
        if (day > 1)
        {
            day--;
        }
        else
        {
            switch (month)
            {
                case 1:
                    day = 31;
                    month = 12;
                    year--;
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    day = 31;
                    month--;
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    day = 30;
                    month--;
                    break;
                case 3:
                    day = 28;
                    if (IsLeapYear())
                        day++;
                    month--;
                    break;
            }

        }
    }

    public bool IsLeapYear()
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public bool IsEqual(MyDate d)
    {
        //if (this.day == d.day && this.month == d.month && this.year == d.year)
        //    return true;
        //else
        //    return false;
        return (this.day == d.day 
             && this.month == d.month 
             && this.year == d.year);
    }

    internal bool LessThan(MyDate d2)
    {
        bool result;
        if (this.year < d2.year)
            result = true;
        else if (this.year > d2.year)
            result = false;
        else if (this.month < d2.month)
            result = true;
        else if (this.month > d2.month)
            result = false;
        else if (this.day < d2.day)
            result = true;
        else
            result = false;

        return result;
    }
}