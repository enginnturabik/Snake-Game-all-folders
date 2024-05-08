
namespace Snake
{
    public   class Position
    {
        public int Row { get;}
        public int Col { get;}

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;

        }
        public Position Translate(Direction dir)
        {
            return new Position(this.Row+dir.RowOffset, this.Col+dir.ColOffset);

        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Col == position.Col;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }


    }
}
