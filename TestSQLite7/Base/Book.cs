namespace TestSQLite7.Base;

public class Book : SQLiteObject
{
	public int IdBook => Id;

	public string AuthorName { get; set; }

	public string BookName { get; set; }
}