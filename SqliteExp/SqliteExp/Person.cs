﻿using SQLite;

namespace SqliteExp
{
    
    public class Person
    {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Subscribe { get; set; }
        
    }
}
