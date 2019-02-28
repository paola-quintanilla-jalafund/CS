using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Vector2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        private const string InvalidArgumentsMessage = "Vector Arguments are not valid, the correct Format is x1,y2 x2,y2";
        string InvalidNumberMessage = "Vector Arguments must supply valid numbers.";
        public Vector2D(string date)
        {
            var point = date.Split(',');

            this.X = ChangeToInteger(point[0]);
            this.Y = ChangeToInteger(point[1]);

        }
        int ChangeToInteger(string date1)
        {
            if (!int.TryParse(date1, out var parsedValue))
            {
                throw new ArgumentException(InvalidNumberMessage);
            }
            return parsedValue;
        }
        public override string ToString()
        {
            return $"[{this.X},{this.Y}]";
        }
        public Vector2D Sum(Vector2D vector)
        {
            vector.X = vector.X + this.X;
            vector.Y = vector.Y + this.Y;
            return vector;
        }
        public int Dot(Vector2D Vector2)
        {
            this.X *= Vector2.X; 
            this.Y *= Vector2.Y;
            return this.X + this.Y;
        }
        public double Length()
        {
            var res = Math.Pow(this.X, 2) + Math.Pow(this.Y, 2);
            return Math.Sqrt(res);
        }
    }
}
