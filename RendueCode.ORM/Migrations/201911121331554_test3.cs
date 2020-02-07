namespace RendueCode.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.véhicule", "Immatriculation", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.véhicule", "Immatriculation", c => c.String(nullable: false));
        }
    }
}
