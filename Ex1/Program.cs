Console.Clear();
int Point1X = 35;
int Point1Y = 1;
int Point2X = 1;
int Point2Y = 20;
int Point3X = 70;
int Point3Y = 20;
Console.Clear();

Console.SetCursorPosition(Point1X, Point1Y);
Console.WriteLine("+");

Console.SetCursorPosition(Point2X, Point2Y);
Console.WriteLine("+");

Console.SetCursorPosition(Point3X, Point3Y);
Console.WriteLine("+");

int x = (Point1X - Point2X)/2;
int y = (Point2Y - Point1Y)/2;
Console.SetCursorPosition(x, y);
Console.WriteLine("+");

int count = 1; 

while (count < 1000) 
    {
        int rand_point = new Random().Next(0, 3);

        if (rand_point == 0)
            {
                x = (x + Point1X)/2;
                y = (y + Point1Y)/2;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+");
            }
        if (rand_point == 1)
            {
                x = (x + Point2X)/2;
                y = (y + Point2Y)/2;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+");
            }
        if (rand_point == 2)
            {
                x = (x + Point3X)/2;
                y = (y + Point3Y)/2;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("+");
            }
        count++;
    }
Console.SetCursorPosition(1, 21);