namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterInfo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterInfo");
        }
    }
}
