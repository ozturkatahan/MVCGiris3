namespace MVCGiris3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KisilerDegisiklik : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kisiler", "Soyad", c => c.String(maxLength: 30));
            AlterColumn("dbo.Kisiler", "Ad", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kisiler", "Ad", c => c.String(nullable: false));
            DropColumn("dbo.Kisiler", "Soyad");
        }
    }
}
