using System;

public static class RigthtTriangleFunctions
{
    /// <summary>
    /// Получение площади прямоугольного треугольника
    /// </summary>
    /// <param name="cathetus1">катет</param>
    /// <param name="cathetus2">катет</param>
    /// <param name="hypotenuse">гипотенуза</param>
    /// <returns>площадь прямоугольного треугольника</returns>
    public static double GetRigthTriangleArea(double cathetus1, double cathetus2, double hypotenuse)
    {
        _VerificateInput(cathetus1);
        _VerificateInput(cathetus2);
        _VerificateInput(hypotenuse);

        var area = _CalculateRigthTriangleArea(cathetus1, cathetus2);

        _VerificateResult(area);

        return area;
    }

    /// <summary>
    /// Вычисление площади прямоугольного треугольника
    /// </summary>
    /// <param name="cathetus1">катет</param>
    /// <param name="cathetus2">катет</param>
    /// <returns>площадь прямоугольного треугольника</returns>
    private static double _CalculateRigthTriangleArea(double cathetus1, double cathetus2)
    {
        var area = cathetus1 * cathetus2 / 2;
        return area;
    }

    /// <summary>
    /// Проверка входящих значений
    /// </summary>
    /// <param name="value">значение</param>
    private static void _VerificateInput(double value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException("Длина стороны треугольника не может быть меньше 0.");

        if (double.IsNaN(value) || double.IsInfinity(value))
            throw new ArgumentOutOfRangeException("Длина стороны треугольника не является значимым числом.");
    }

    /// <summary>
    /// Проверка результата
    /// </summary>
    /// <param name="value">значение</param>
    private static void _VerificateResult(double value)
    {
        if (double.IsPositiveInfinity(value))
            //todo При необходимости, можно использовать BigInteger для обработки больших значений.
            throw new ArgumentOutOfRangeException("Слишком большое значение длины стороны треугольника.");

        if (double.IsNegativeInfinity(value))
            //todo При необходимости, можно использовать Decimal для обработки малых значений.
            throw new ArgumentOutOfRangeException("Слишком маленькое значение длины стороны треугольника.");
    }

}

