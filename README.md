## Задачи (30.06.2018)
- Протестировать методы сортировки (задания первого дня) на массивах большой размерности.
  - [Решение](https://github.com/valerycadovic/NET.S.2018.Chadovich.01/blob/master/Algorithms.Tests/Algorithms_Test.cs#L47)
- Реализовать алгоритм FindNthRoot, позволяющий вычислять корень n-ой степени ( n ∈ N ) из вещественного числа а методом Ньютона с заданной точностью. Разработать модульные тесты (NUnit и (или) MS Unit Test) для тестирования метода.
  - [Решение](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/Day3/Algorithms.cs#L20)
  - [Тесты](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/Day3.Tests/Algorithms_Test.cs#L10)
- Реализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), если такого числа не существует.
Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода. Примерные тест-кейсы
  - [TestCase(12, ExpectedResult = 21)]
  - [TestCase(513, ExpectedResult = 531)]
  - [TestCase(2017, ExpectedResult = 2071)]
  - [TestCase(414, ExpectedResult = 441)]
  - [TestCase(144, ExpectedResult = 414)]
  - [TestCase(1234321, ExpectedResult = 1241233)]
  - [TestCase(1234126, ExpectedResult = 1234162)]
  - [TestCase(3456432, ExpectedResult = 3462345)]
  - [TestCase(10, ExpectedResult = -1)]
  - [TestCase(20, ExpectedResult = -1)]
Добавить к методу FindNextBiggerNumber возможность вернуть время нахождения заданного числа, рассмотрев различные языковые возможности. Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода.
  - [Решение](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/Day3/Algorithms.cs#L61)
  - [Тесты](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/Day3.Tests/Algorithms_Test.cs#L28)
- выполнить сравнительный анализ скорости вычислений для реализаций алгоритмов с использованием строк и операции целочисленного деления для задачи [#6](https://github.com/EPM-RD-NETLAB/.NET-Framework-modules/tree/master/M2.%20Basic%20Coding%20in%20C%23) на массивах большой размерности с большим количеством элементов порядка int.MaxValue.
  - [Решение](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/SpeedTest.linq)
- Разработать класс, позволяющий выполнять вычисления НОД по алгоритму Евклида для двух, трех и т.д. целых чисел (http://en.wikipedia.org/wiki/Euclidean_algorithm , https://habrahabr.ru/post/205106/, https://habrahabr.ru/post/205106/ ). Методы класса помимо вычисления НОД должны предоставлять дополнительную возможность определения значение времени, необходимое для выполнения расчета. Добавить к разработанному классу методы, реализующие алгоритм Стейна (бинарный алгоритм Евклида) для расчета НОД двух, трех и т.д. целых чисел (http://en.wikipedia.org/wiki/Binary_GCD_algorithm, https://habrahabr.ru/post/205106/ ), а также методы, предоставляющие дополнительную возможность определения значение времени, необходимое для выполнения расчета. Рассмотреть различные возможности реализации методов, возвращающих время вычисления НОД. Разработать модульные тесты.
  - [Решение](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/Day3/GCD.cs)
  - [Тесты](https://github.com/valerycadovic/NET.S.2018.Chadovich.03/blob/master/NET.S.2018.Chadovich.03/Day3.Tests/GCD_Test.cs)
