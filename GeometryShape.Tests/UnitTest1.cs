using GeometryShape;
using System;
using Xunit;

namespace GeometryShape.Tests;

public class RectangleTests
{
    [Fact]
    public void СозданиеПрямоугольника_КорректныеРазмеры_Успех()
    {
        var rect = new Rectangle(5, 10);
        Assert.Equal(5, rect.Width);
        Assert.Equal(10, rect.Height);
    }

    [Fact]
    public void Прямоугольник_Площадь_ВозвращаетКорректноеЗначение()
    {
        var rect = new Rectangle(4, 5);
        Assert.Equal(20, rect.Area());
    }

    [Fact]
    public void Прямоугольник_Периметр_ВозвращаетКорректноеЗначение()
    {
        var rect = new Rectangle(4, 5);
        Assert.Equal(18, rect.Perimeter());
    }

    [Theory]
    [InlineData(0, 5)]
    [InlineData(-1, 5)]
    [InlineData(5, 0)]
    [InlineData(-3, -4)]
    public void СозданиеПрямоугольника_НекорректныеРазмеры_ВыбрасываетИсключение(double width, double height)
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(width, height));
    }
}

public class TriangleTests
{
    [Fact]
    public void СозданиеТреугольника_КорректныеСтороны_Успех()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(3, triangle.SideA);
        Assert.Equal(4, triangle.SideB);
        Assert.Equal(5, triangle.SideC);
    }

    [Fact]
    public void Треугольник_Площадь_ВозвращаетКорректноеЗначение()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.Area());
    }

    [Fact]
    public void Треугольник_Периметр_ВозвращаетКорректноеЗначение()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(12, triangle.Perimeter());
    }

    [Fact]
    public void СозданиеТреугольника_НекорректныеСтороны_ВыбрасываетИсключение()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 4, 5));
    }

    [Fact]
    public void Треугольник_Площадь_НамеренноеНевыполнение()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(100, triangle.Area());
    }
}