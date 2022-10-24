namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TBLDOKTORs", "DOKTORAD", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TBLDOKTORs", "DOKTORAD", c => c.Int(nullable: false));
        }
    }
}
