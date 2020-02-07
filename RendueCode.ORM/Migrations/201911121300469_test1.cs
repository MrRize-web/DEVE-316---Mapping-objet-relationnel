namespace RendueCode.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Intervenants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Interventions",
                c => new
                    {
                        IdInterventions = c.Int(nullable: false, identity: true),
                        Ouverture = c.DateTime(),
                        Fermeture = c.DateTime(),
                        matériel_IdMateriel = c.Int(),
                        Véhicule_IdVehicule = c.Int(),
                    })
                .PrimaryKey(t => t.IdInterventions)
                .ForeignKey("dbo.matériel", t => t.matériel_IdMateriel)
                .ForeignKey("dbo.véhicule", t => t.Véhicule_IdVehicule)
                .Index(t => t.matériel_IdMateriel)
                .Index(t => t.Véhicule_IdVehicule);
            
            CreateTable(
                "dbo.matériel",
                c => new
                    {
                        IdMateriel = c.Int(nullable: false, identity: true),
                        Désignation = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        DateAchat = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdMateriel);
            
            CreateTable(
                "dbo.véhicule",
                c => new
                    {
                        IdVehicule = c.Int(nullable: false, identity: true),
                        Marque = c.String(nullable: false, maxLength: 20),
                        Immatriculation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Volume = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IdVehicule);
            
            CreateTable(
                "dbo.InterventionsIntervenants",
                c => new
                    {
                        Interventions_IdInterventions = c.Int(nullable: false),
                        Intervenant_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Interventions_IdInterventions, t.Intervenant_Id })
                .ForeignKey("dbo.Interventions", t => t.Interventions_IdInterventions, cascadeDelete: true)
                .ForeignKey("dbo.Intervenants", t => t.Intervenant_Id, cascadeDelete: true)
                .Index(t => t.Interventions_IdInterventions)
                .Index(t => t.Intervenant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interventions", "Véhicule_IdVehicule", "dbo.véhicule");
            DropForeignKey("dbo.Interventions", "matériel_IdMateriel", "dbo.matériel");
            DropForeignKey("dbo.InterventionsIntervenants", "Intervenant_Id", "dbo.Intervenants");
            DropForeignKey("dbo.InterventionsIntervenants", "Interventions_IdInterventions", "dbo.Interventions");
            DropIndex("dbo.InterventionsIntervenants", new[] { "Intervenant_Id" });
            DropIndex("dbo.InterventionsIntervenants", new[] { "Interventions_IdInterventions" });
            DropIndex("dbo.Interventions", new[] { "Véhicule_IdVehicule" });
            DropIndex("dbo.Interventions", new[] { "matériel_IdMateriel" });
            DropTable("dbo.InterventionsIntervenants");
            DropTable("dbo.véhicule");
            DropTable("dbo.matériel");
            DropTable("dbo.Interventions");
            DropTable("dbo.Intervenants");
        }
    }
}
