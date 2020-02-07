namespace RendueCode.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interventions", "Ouverture_intervention", c => c.DateTime(nullable: false));
            AddColumn("dbo.Interventions", "Fermeture_intervention", c => c.DateTime(nullable: false));
            AlterColumn("dbo.matériel", "Description", c => c.String(maxLength: 500));
            AlterColumn("dbo.matériel", "DateAchat", c => c.DateTime(nullable: false));
            AlterColumn("dbo.véhicule", "Immatriculation", c => c.String(nullable: false));
            DropColumn("dbo.Interventions", "Ouverture");
            DropColumn("dbo.Interventions", "Fermeture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interventions", "Fermeture", c => c.DateTime());
            AddColumn("dbo.Interventions", "Ouverture", c => c.DateTime());
            AlterColumn("dbo.véhicule", "Immatriculation", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.matériel", "DateAchat", c => c.DateTime());
            AlterColumn("dbo.matériel", "Description", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.Interventions", "Fermeture_intervention");
            DropColumn("dbo.Interventions", "Ouverture_intervention");
        }
    }
}
