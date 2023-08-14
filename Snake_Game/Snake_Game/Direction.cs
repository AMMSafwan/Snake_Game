﻿using System.Collections.Generic;

namespace Snake_Game
{
    public class Direction
    {
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);

        public int RowOffset { get; }
        public int ColOffset { get; }

        private Direction(int rowOffset, int colOffset)
        {
            RowOffset = rowOffset;
            ColOffset = colOffset;
        }

        public Direction Opposite()
        {
            return new Direction(-RowOffset, -ColOffset);
        }

        public override bool Equals(object obj)
        {
            var direction = obj as Direction;
            return direction != null &&
                   RowOffset == direction.RowOffset &&
                   ColOffset == direction.ColOffset;
        }

        public override int GetHashCode()
        {
            var hashCode = -1482510490;
            hashCode = hashCode * -1521134295 + RowOffset.GetHashCode();
            hashCode = hashCode * -1521134295 + ColOffset.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}