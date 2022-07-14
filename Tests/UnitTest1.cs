using System;
using FluentUnit;
using FluentUnit.Distance;
using FluentUnit.Time;
using NUnit.Framework;

namespace Tests;

public class Tests {
    [SetUp]
    public void Setup() { }

    [Test]
    public void Test1() {
        Kilometers a = 12.0.Miles();
        var x = 10.0.Kilometers();
        var t = 2.0.Hours();

        // var qw = t - 1.2.Hours();
        var speed = x / t;
        Console.WriteLine(speed.Value);
        Assert.Pass();
    }
}
