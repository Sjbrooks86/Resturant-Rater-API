﻿namespace ResturantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Resturants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Style = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Rating = c.Double(nullable: false),
                        DollarSigns = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resturants");
        }
    }
}
