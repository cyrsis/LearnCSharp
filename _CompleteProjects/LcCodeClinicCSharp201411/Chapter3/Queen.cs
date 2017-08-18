
namespace EightQueensProblem
{
	public class Queen
	{
		private int mRow;
		private int mColumn;

		public Queen()
		{
			mRow = 0;
			mColumn = 0;
		}

		public Queen(byte Row, byte Column)
		{
			mRow = Row;
			mColumn = Column;
		}

		public int Row
		{
			get
			{
				return mRow;
			}
			set
			{
				mRow = value;
			}
		}

		public int Column
		{
			get
			{
				return mColumn;
			}
			set
			{
				mColumn = value;
			}
		}
	}
}