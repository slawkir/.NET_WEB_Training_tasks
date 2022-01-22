using System;

namespace Task_2._1._2._CUSTOM_PAINT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //образцы фигур для вывода
            string[] arrayOfShapes = new string[6];

            Circle circle = new Circle(15);
            arrayOfShapes[0] = circle.ShowInfFigure();

            Ring ring = new Ring(10, 20);
            arrayOfShapes[1] = ring.ShowInfFigure();

            Line line = new Line(25, 50, 10, 30);
            arrayOfShapes[2] = line.ShowInfFigure();

            Triangle triangle = new Triangle(3, 4, 5);
            arrayOfShapes[3] = triangle.ShowInfFigure();

            Square square = new Square(5);
            arrayOfShapes[4] = square.ShowInfFigure();

            Rectangle rectangle = new Rectangle(3, 4);
            arrayOfShapes[5] = rectangle.ShowInfFigure();


            //вывод редактора
            do
            {
                Console.WriteLine("1.Добавить фигуру");
                Console.WriteLine("2.Вывести фигуры");
                Console.WriteLine("3.Очистить холст");
                Console.WriteLine("4.Выход");
                int point = int.Parse(Console.ReadLine());
                switch (point)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Выберите тип фигуры:");
                        Console.WriteLine("1.Круг");
                        Console.WriteLine("2.Кольцо");
                        Console.WriteLine("3.Линия");
                        Console.WriteLine("4.Треугольник");
                        Console.WriteLine("5.Квадрат");
                        Console.WriteLine("6.Прямоугольник");

                        switch (int.Parse(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("Введите радиус: ");
                                double r = Double.Parse(Console.ReadLine());
                                Circle circle1 = new Circle(r);
                                Console.WriteLine(circle1.ShowInfFigure());
                                break;

                            case 2:
                                Console.WriteLine("Введите внутренний радиус: ");
                                double r1 = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите внешний радиус: ");
                                double r2 = Double.Parse(Console.ReadLine());
                                Ring ring1 = new Ring(r1, r2);
                                Console.WriteLine(ring1.ShowInfFigure());
                                break;

                            case 3:
                                Console.WriteLine("Введите координату X1 первой точки: ");
                                int x1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координату Y1 первой точки: ");
                                int y1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координату X2 первой точки: ");
                                int x2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координату Y2 первой точки: ");
                                int y2 = int.Parse(Console.ReadLine());
                                Line line1 = new Line(x1, y1, x2, y2);
                                Console.WriteLine(line1.ShowInfFigure());
                                break;

                            case 4:
                                Console.WriteLine("Введите длину стороны AB: ");
                                double AB = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите длину стороны BC: ");
                                double BC = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите длину стороны AC: ");
                                double AC = Double.Parse(Console.ReadLine());
                                Triangle triangle1 = new Triangle(AB, BC, AC);
                                Console.WriteLine(triangle1.ShowInfFigure());
                                break;

                            case 5:
                                Console.WriteLine("Введите длину стороны AB: ");
                                double sideSquare = Double.Parse(Console.ReadLine());

                                Square square1 = new Square(sideSquare);
                                Console.WriteLine(square1.ShowInfFigure());
                                break;

                            case 6:
                                Console.WriteLine("Введите длину стороны AB: ");
                                double side1 = Double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите длину стороны BC: ");
                                double side2 = Double.Parse(Console.ReadLine());
                                Rectangle rectangle1 = new Rectangle(side1, side2);
                                Console.WriteLine(rectangle1.ShowInfFigure());
                                break;
                        }
                        break;

                    case 2:
                        foreach (var item in arrayOfShapes)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                }
               
            } while (true);
            
        }
    }
}
