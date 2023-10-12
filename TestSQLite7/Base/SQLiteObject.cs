using SQLite;

namespace TestSQLite7.Base;

public class SQLiteObject : IKeyObject
{
	[PrimaryKey]
	public int Id { get; set; }
}

