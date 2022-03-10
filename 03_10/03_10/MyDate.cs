﻿// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Text;
using _03_10;

// TODO: extindeti clasa MyDate cu alte operatii specifice. 
// getter/setter pentru cele 3 componente cu validare la setter
// AddDays, AddYear, AddMonths etc. 

internal class MyDate
{
    private int _year;
    private int _month;
    private int _day;
    
    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public int Month
    {
        get => _month;
        set
        {
            if (_month is > 12 or < 1)
            {
                throw new ValidationException();
            }

            _month = value;
        }
    }

    public int Day
    {
        get => _day;
        set
        {
            if (_day > GetDaysOfMonth() || _day < 1)
            {
                throw new ValidationException();
            }

            _day = value;
        }
    }

    public Day DayOfWeek
    {
        get => GetDayOfWeek();
    }

    public int DayOfYear
    {
        get => GetDayOfYear();
    }

    /// <summary>
    /// Copy constructor
    /// </summary>
    /// <param name="myDate"></param>
    public MyDate(MyDate myDate)
    {
        _year = myDate._year;
        _month = myDate._month;
        _day = myDate._day;
    }

    public MyDate(int year, int month, int day)
    {
        this._year = year;
        this._month = month;
        this._day = day;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        return sb.Append("[")
          .Append(_day.ToString())
          .Append("-")
          .Append(_month.ToString("0#"))
          .Append("-")
          .Append(_year.ToString())
          .Append("]")
          .ToString();
    }
    
    private Day GetDayOfWeek()
    {
        int century = _year / 100;
        int lastDigitsOfYear = _month < 3 ? _year % 100 - 1 : _year % 100;
        int month = _month switch
        {
            1 => 11,
            2 => 12,
            _ => _month - 2
        };
        int day = (int) (_day + Math.Floor(2.6 * month - 0.2) - 2 * century + lastDigitsOfYear +
                         Math.Floor(lastDigitsOfYear / 4.0) + Math.Floor(century / 4.0)) % 7;
        return Enum.Parse<Day>(day.ToString());
    }
    
    private int GetDayOfYear()
    {
        int day = 0;
        for (int i = 1; i < _month; ++i)
        {
            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                {
                    day += 31;
                    break;
                }
                case 4:
                case 6:
                case 9:
                case 11:
                {
                    day += 30;
                    break;
                }
                case 2:
                {
                    day += IsLeapYear() ? 29 : 28;
                    break;
                }
            } 
        }
        day += _day;
        return day;
    }

    public MyDate AddDays(int days)
    {
        _day += days;
        while (_day > GetDaysOfMonth())
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }

            _day = 1 + (_day - GetDaysOfMonth());
        }
        
        return this;
    }

    public MyDate AddMonths(int months)
    {
        _month += months;
        if (_month > 12)
        {
            _year += _month / 12;
            _month %= 12;
        }

        return this;
    }

    public MyDate AddYears(int years)
    {
        _year += years;
        return this;
    }
    
    public int GetDaysOfMonth()
    {
        switch (_month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
            {
                return 31;
            }
            case 4:
            case 6:
            case 9:
            case 11:
            {
                return 30;
            }
            case 2:
            {
                return IsLeapYear() ? 29 : 28;
            }
            default:
                return 30;
        }
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
        if (_day > 1)
        {
            _day--;
        }
        else
        {
            switch (_month)
            {
                case 1:
                    _day = 31;
                    _month = 12;
                    _year--;
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    _day = 31;
                    _month--;
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    _day = 30;
                    _month--;
                    break;
                case 3:
                    _day = 28;
                    if (IsLeapYear())
                        _day++;
                    _month--;
                    break;
            }

        }
    }

    public bool IsLeapYear()
    {
        return (_year % 4 == 0 && _year % 100 != 0) || (_year % 400 == 0);
    }

    public bool IsEqual(MyDate d)
    {
        //if (this.day == d.day && this.month == d.month && this.year == d.year)
        //    return true;
        //else
        //    return false;
        return (this._day == d._day 
             && this._month == d._month 
             && this._year == d._year);
    }

    internal bool LessThan(MyDate d2)
    {
        bool result;
        if (this._year < d2._year)
            result = true;
        else if (this._year > d2._year)
            result = false;
        else if (this._month < d2._month)
            result = true;
        else if (this._month > d2._month)
            result = false;
        else if (this._day < d2._day)
            result = true;
        else
            result = false;

        return result;
    }
    
    public static bool operator >(MyDate d1, MyDate d2)
    {
        return !d1.IsEqual(d2) && !d1.LessThan(d2);
    }

    public static bool operator <(MyDate d1, MyDate d2)
    {
        return d1 != d2 && !(d1 > d2);
    }
    
    public static MyDate operator -(MyDate d1, MyDate d2)
    {
        MyDate date = d1 > d2 ? new MyDate(d1.Year - d2.Year, d1.Month - d2.Month, d1.Day - d2.Day) : 
            new MyDate(d2.Year - d1.Year, d2.Month - d1.Month, d2.Day - d1.Day);

        while (date._day <= 0)
        {
            date._month -= 1;
            if (date._month == 0)
            {
                date._month = 12;
                date.Year -= 1;
            }
            date._day = date.GetDaysOfMonth() - (-1 * date.Day);
        }

        if (date._month == 0)
        {
            date._month = 12;
            date.Year -= 1;
        }
        return date;
    }
    
    public static MyDate operator +(MyDate d1, MyDate d2)
    {
        MyDate date = new MyDate(d1.Year + d2.Year, d1.Month + d2.Month, d1.Day + d2.Day);

        while (date._day > date.GetDaysOfMonth())
        {
            date._month += 1;
            if (date._month > 12)
            {
                date._month = 1;
                date.Year += 1;
            }

            date._day = 1 + (date._day - date.GetDaysOfMonth());
        }

        if (date._month > 12)
        {
            date._month = 1;
            date.Year += 1;
        }
        return date;
    }
}