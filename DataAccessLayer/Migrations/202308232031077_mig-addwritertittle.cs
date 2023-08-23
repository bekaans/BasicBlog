﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddwritertittle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTittle", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterTittle");
        }
    }
}
