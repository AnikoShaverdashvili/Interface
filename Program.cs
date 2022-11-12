// See https://aka.ms/new-console-template for more information


/*
 * Შექმენით ინტერფეისი IShape რომელსაც ექნება ფართობის და პერიმეტრის გამოთვლის მეთოდები.
 * Შექმენით პრიზმის, სამკუთხედის , მართკუთხედის, და ტრაპეციის კლასები. Ველები დაამატეთ საჭიროებისამებრ. Გააკეთეთ თითოეულ კლასში IShape-ის იმპლემენტაცია.
 */


using Interface;


Rectangle rectangle1 = new Rectangle(3, 5);
Console.WriteLine(rectangle1.GetArea());
Console.WriteLine(rectangle1.GetPerimeter());


Trapezoid trapezoid1 = new Trapezoid(2,3,4,5);
Trapezoid trapezoid2 = new Trapezoid(2, 3, 9);
Console.WriteLine(trapezoid1.GetArea());
Console.WriteLine(trapezoid2.GetPerimeter());


Triangle triangle = new Triangle(2, 5, 6, 8);
Console.WriteLine(triangle.GetArea());
Console.WriteLine(triangle.GetPerimeter());


Prism prism = new Prism(5, 6, 8);
Console.WriteLine(prism.GetArea());
Console.WriteLine(prism.GetPerimeter());

