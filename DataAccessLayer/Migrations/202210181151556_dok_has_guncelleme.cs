namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dok_has_guncelleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TBLDOKTORs", "DOKTORPASIF", c => c.Boolean(nullable: false));
            AddColumn("dbo.TBLDOKTORs", "DOKTORADRESBILGI", c => c.String());
            AddColumn("dbo.TBLHASTAs", "HASTAPASIF", c => c.Boolean(nullable: false));
            AddColumn("dbo.TBLHASTAs", "HASTAADRESBILGI", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TBLHASTAs", "HASTAADRESBILGI");
            DropColumn("dbo.TBLHASTAs", "HASTAPASIF");
            DropColumn("dbo.TBLDOKTORs", "DOKTORADRESBILGI");
            DropColumn("dbo.TBLDOKTORs", "DOKTORPASIF");
        }
    }
}
