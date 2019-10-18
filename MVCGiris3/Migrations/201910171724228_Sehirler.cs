namespace MVCGiris3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sehirler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sehirler",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SehirAd = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Kisiler", "DogumYeriId", c => c.Int());
            CreateIndex("dbo.Kisiler", "DogumYeriId");
            AddForeignKey("dbo.Kisiler", "DogumYeriId", "dbo.Sehirler", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kisiler", "DogumYeriId", "dbo.Sehirler");
            DropIndex("dbo.Kisiler", new[] { "DogumYeriId" });
            DropColumn("dbo.Kisiler", "DogumYeriId");
            DropTable("dbo.Sehirler");
        }
    }
}
