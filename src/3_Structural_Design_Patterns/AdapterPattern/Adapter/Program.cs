using Adapter;

var vectorObjects = new List<VectorObject>
{
    new VectorRectangle(1, 1, 10, 10),
    new VectorRectangle(3, 3, 6, 6)
};

Draw(vectorObjects);
Draw(vectorObjects);

void Draw(IEnumerable<VectorObject> list)
{
    void DrawPoint(Point p)
    {
        Console.Write(".");
    }

    foreach (var point in list.SelectMany(vo => vo, (vo, line) => new LineToPointAdapter(line))
                 .SelectMany(adapter => adapter))
    {
        DrawPoint(point);
    }
}