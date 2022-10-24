namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isler_ekle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBLISLERs",
                c => new
                    {
                        ISID = c.Int(nullable: false, identity: true),
                        ISACIKLAMA = c.String(),
                        ISTARIH = c.DateTime(nullable: false),
                        DOKTORID = c.Int(),
                        HASTAID = c.Int(),
                    })
                .PrimaryKey(t => t.ISID)
                .ForeignKey("dbo.TBLDOKTORs", t => t.DOKTORID)
                .ForeignKey("dbo.TBLHASTAs", t => t.HASTAID)
                .Index(t => t.DOKTORID)
                .Index(t => t.HASTAID);
            
            AddColumn("dbo.TBLODEMEs", "ODEMEMIKTAR", c => c.Single(nullable: false));
            AddColumn("dbo.TBLODEMEs", "ODEMETARIH", c => c.DateTime(nullable: false));
            DropColumn("dbo.TBLODEMEs", "ODEMEAD");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TBLODEMEs", "ODEMEAD", c => c.String());
            DropForeignKey("dbo.TBLISLERs", "HASTAID", "dbo.TBLHASTAs");
            DropForeignKey("dbo.TBLISLERs", "DOKTORID", "dbo.TBLDOKTORs");
            DropIndex("dbo.TBLISLERs", new[] { "HASTAID" });
            DropIndex("dbo.TBLISLERs", new[] { "DOKTORID" });
            DropColumn("dbo.TBLODEMEs", "ODEMETARIH");
            DropColumn("dbo.TBLODEMEs", "ODEMEMIKTAR");
            DropTable("dbo.TBLISLERs");
        }
    }
}
