namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TBLODEMEs", "ODEMEAD", c => c.String());
            AlterColumn("dbo.TBLHASTAs", "HASTAAD", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TBLHASTAs", "HASTAAD", c => c.Int(nullable: false));
            AlterColumn("dbo.TBLODEMEs", "ODEMEAD", c => c.Int(nullable: false));
        }
    }
}
