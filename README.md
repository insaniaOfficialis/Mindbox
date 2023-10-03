# Mindbox

Проект написан на net 6.0. В качестве Unit-тестов используется MSTest.

## Тестовое здание 1

Библиотека с фигурами и рассчётом площади создана в проекте [MindboxLibrary](https://github.com/insaniaOfficialis/Mindbox/tree/main/MindboxLibrary). После сборки [dll проекта](https://github.com/insaniaOfficialis/Mindbox/blob/main/MindboxLibrary.dll) добавлен в запускаемый проект [Mindbox](https://github.com/insaniaOfficialis/Mindbox/tree/main/Mindbox) и в проект тестов [MindboxLibrary](https://github.com/insaniaOfficialis/Mindbox/tree/main/MindboxLibrary). Рассчёт площади происходит в конструктарах фигур.

Доп.задания:
- Юнит-тесты: реализованы в тесте [треугольников](https://github.com/insaniaOfficialis/Mindbox/blob/main/MindBoxTests/TriangleTests.cs) и [кругов](https://github.com/insaniaOfficialis/Mindbox/blob/main/MindBoxTests/CircleTest.cs)
- Легкость добавления других фигур: для добавления фигур необходимо создать класс-наследник [Figure](https://github.com/insaniaOfficialis/Mindbox/blob/main/MindboxLibrary/MindboxLibrary/Entities/Figure.cs) и реализовать конструктор с рассчётом площади
- Вычисление площади фигуры без знания типа фигуры в compile-time: для выполнения тестов мы создаём класс Figure как экземпляр нужного класса-фигуры. Затем при вызове метод GetArea комплиятор будет динамически определять тип фигуры
- Проверку на то, является ли треугольник прямоугольным: для этого в класс [Triangle](https://github.com/insaniaOfficialis/Mindbox/blob/main/MindBoxTests/TriangleTests.cs) добавлен атрибут IsRectangular и метод CheckIsRectangular, вызываемый в конструкторе треугольника и записывающий, является ли треугольник прямоугольным


## Тестовое здание 2

На сервере была создана база Mindbox со следующей структурой:

![image](https://github.com/insaniaOfficialis/Mindbox/assets/94796519/8aaf4d2e-f3da-410d-8ccb-e1d02517c57a)

В таблицы были добавлены данные следующими скриптами

``` sql
INSERT Product([name]) VALUES ('А'), ('Б'), ('В'), ('Г'), ('Д'), ('Е'), ('Ё')
INSERT Category([name]) VALUES ('Ж'), ('З'), ('И'), ('Й'), ('К'), ('Л'), ('М')
```

``` sql
INSERT ProductCategory VALUES (1, 1), (1, 2), (2, 1), (2, 3), (3, 4)
```

Запрос для выборки данных по заданию:

``` sql
SELECT p.[name] 'product', ISNULL(c.[name], '') 'category'
FROM dbo.Product p
LEFT JOIN dbo.ProductCategory pc ON p.id = pc.id_product
LEFT JOIN dbo.Category c ON pc.id_catregory = c.id
```

Результат выборки:

![image](https://github.com/insaniaOfficialis/Mindbox/assets/94796519/d962a70a-bad9-480b-8f9f-9b920082afe4)
