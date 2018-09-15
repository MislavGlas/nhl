namespace NHL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDataToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Perica', 'Peric', 'Forward', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Domagoj', 'Ivic', 'Left Wing', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Ivan', 'Horvat', 'Left Wing', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Tomislav', 'Kovacevic', 'Right Wing', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Mario', 'Kovac', 'Right Wing', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Jura', 'Juric', 'Defense', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Stjepan', 'Novak', 'Forward', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Luka', 'Maric', 'Right Wing', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Josip', 'Vukovic', 'Defense', 'Croatia'); ");
            Sql("INSERT INTO Players (FirstName, LastName, Position, Country) VALUES('Milan', 'Vuk', 'Defense', 'Croatia'); ");
        }
        
        public override void Down()
        {
        }
    }
}
