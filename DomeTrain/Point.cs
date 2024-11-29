namespace DomeTrain
{
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Point Move(int dx, int dy)
        {
            return new Point(X + dx, Y + dy);
        }
    }
}