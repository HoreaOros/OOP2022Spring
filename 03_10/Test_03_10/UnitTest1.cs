using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using _03_10;
using NUnit.Framework;

namespace Test_03_10;

public class Tests
{
    private static IEnumerable<TestCaseData> DayOfWeekCases
    {
        get
        {
            Random rnd = new Random();
            for (int i = 1; i <= 1000; ++i)
            {
                DateTime dt = DateTime.Today
                    .AddDays(rnd.Next(-1000, 1000))
                    .AddMonths(rnd.Next(-1000, 1000))
                    .AddYears(rnd.Next(-100, 100));
                MyDate date = new MyDate(dt.Year, dt.Month, dt.Day);
                int dayOfWeek = (int) dt.DayOfWeek;

                yield return new TestCaseData(date, Enum.Parse<Day>(dayOfWeek.ToString()))
                    .Returns(Enum.Parse<Day>(dayOfWeek.ToString()));
            }
        }
    }

    private static IEnumerable<TestCaseData> DayOfYearCases
    {
        get
        {
            Random rnd = new Random();
            for (int i = 1; i <= 1000; ++i)
            {
                DateTime dt = DateTime.Today
                    .AddDays(rnd.Next(-1000, 1000))
                    .AddMonths(rnd.Next(-1000, 1000))
                    .AddYears(rnd.Next(-100, 100));
                
                MyDate date = new MyDate(dt.Year, dt.Month, dt.Day);
                int dayOfYear = dt.DayOfYear;

                yield return new TestCaseData(date, dayOfYear).Returns(dayOfYear);
            }
        }
    }

    private static IEnumerable<TestCaseData> DayAdditionCases
    {
        get
        {
            for (int i = -1000; i <= 1000; ++i)
            {
                DateTime now = DateTime.Today;
                DateTime dt = DateTime.Today.AddDays(i);

                MyDate date = new MyDate(now.Year, now.Month, now.Day);
                yield return new TestCaseData(date, i).Returns(new MyDate(dt.Year, dt.Month, dt.Day));
            }
        }
    }

    private static IEnumerable<TestCaseData> MonthAdditionCases
    {
        get
        {
            for (int i = -1000; i <= 1000; ++i)
            {
                DateTime now = DateTime.Today;
                DateTime dt = DateTime.Today.AddMonths(i);

                MyDate date = new MyDate(now.Year, now.Month, now.Day);
                
                yield return new TestCaseData(date, i).Returns(new MyDate(dt.Year, dt.Month, dt.Day));
            } 
        }
    }


    [Test]
    public void EqualityTest()
    {
        Assert.That(new MyDate(2022, 10, 10), Is.EqualTo(new MyDate(2022, 10, 10)));
        Assert.That(new MyDate(2022, 10, 10), Is.Not.EqualTo(new MyDate(2021, 10, 10)));
    }

    [Test]
    public void AdditionTest()
    {
        MyDate date1 = new MyDate(2022, 10, 10);
        MyDate date2 = new MyDate(0, 2, 22);
        Assert.That(date1 + date2, Is.EqualTo(new MyDate(2023, 1, 1)));
    }

    [Test]
    public void SubtractionTest()
    {
        MyDate date1 = new MyDate(2022, 10, 10);
        MyDate date2 = new MyDate(0, 2, 22);
        Assert.That(date1 - date2, Is.EqualTo(new MyDate(2022, 7, 19)));
    }

    [TestCaseSource("DayAdditionCases")]
    public MyDate DayAddition(MyDate date, int days)
    {
        return date.AddDays(days);
    }

    [TestCaseSource("MonthAdditionCases")]
    public MyDate MonthAddition(MyDate date, int months)
    {
        return date.AddMonths(months);
    }

    [Test]
    public void YearAddition()
    {
        Assert.That(new MyDate(2022, 10, 1).AddYears(12561), Is.EqualTo(new MyDate(2022 + 12561, 10, 1)));
        Assert.That(new MyDate(222, 1, 1).AddYears(222), Is.EqualTo(new MyDate(444, 1, 1)));
    }
    
    
    [TestCaseSource("DayOfWeekCases")]
    public Day DayOfWeekTest(MyDate date, Day result)
    {
        return date.DayOfWeek;
    }

    [TestCaseSource("DayOfYearCases")]
    public int DayOfYearTest(MyDate date, int result)
    {
        return date.DayOfYear;
    }
} 