using System;
using System.Diagnostics;
using _03_10;
using NUnit.Framework;

namespace Test_03_10;

public class Tests
{
    public void Setup()
    {
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

    [Test]
    public void DayAddition()
    {
        Assert.That(new MyDate(2022, 10, 10).AddDays(100), Is.EqualTo(new MyDate(2023, 1, 18)));
        Assert.That(new MyDate(2022, 10, 21).AddDays(1000), Is.EqualTo(new MyDate(2025, 7, 17)));
    }

    [Test]
    public void MonthAddition()
    {
        Assert.That(new MyDate(2022, 10, 10).AddMonths(356), Is.EqualTo(new MyDate(2052, 6, 10)));
        Assert.That(new MyDate(2022, 10, 10).AddMonths(6432), Is.EqualTo(new MyDate(2558, 10, 10)));
    }

    [Test]
    public void YearAddition()
    {
        Assert.That(new MyDate(2022, 10, 1).AddYears(12561), Is.EqualTo(new MyDate(2022 + 12561, 10, 1)));
        Assert.That(new MyDate(222, 1, 1).AddYears(222), Is.EqualTo(new MyDate(444, 1, 1)));
    }

    [Test]
    public void DayOfWeekTest()
    {
        Assert.That(new MyDate(2022, 3, 8).DayOfWeek, Is.EqualTo(Day.Tuesday));
        Assert.That(new MyDate(2022, 3, 11).DayOfWeek, Is.EqualTo(Day.Friday));
    }

    [Test]
    public void DayOfYearTest()
    {
        Assert.That(new MyDate(2022, 12, 31).DayOfYear, Is.EqualTo(365));
        Assert.That(new MyDate(2022, 3, 10).DayOfYear, Is.EqualTo(69));
    }
} 