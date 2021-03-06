﻿using System;

namespace StrategyLibrary.Transport
{
    class RoadStrategy : IRouteStrategy
    {
        public string Message(Point A, Point B)
        {
            return $"Road route between points {(A.X, A.Y)} and {(B.X, B.Y)} is build sucessfully.";
        }

        public int Range(Point A, Point B)
        {
            return (int)Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
    }
}
