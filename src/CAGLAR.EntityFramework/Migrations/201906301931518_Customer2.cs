namespace CAGLAR.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Customer2 : DbMigration
    {
        public override void Up()
        {
            AlterTableAnnotations(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Customer_SoftDelete",
                        new AnnotationValues(oldValue: null, newValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition")
                    },
                });
            
            AddColumn("dbo.Customers", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "DeleterUserId", c => c.Long());
            AddColumn("dbo.Customers", "DeletionTime", c => c.DateTime());
            AddColumn("dbo.Customers", "LastModificationTime", c => c.DateTime());
            AddColumn("dbo.Customers", "LastModifierUserId", c => c.Long());
            CreateIndex("dbo.Customers", "IsDeleted");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "IsDeleted" });
            DropColumn("dbo.Customers", "LastModifierUserId");
            DropColumn("dbo.Customers", "LastModificationTime");
            DropColumn("dbo.Customers", "DeletionTime");
            DropColumn("dbo.Customers", "DeleterUserId");
            DropColumn("dbo.Customers", "IsDeleted");
            AlterTableAnnotations(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "DynamicFilter_Customer_SoftDelete",
                        new AnnotationValues(oldValue: "EntityFramework.DynamicFilters.DynamicFilterDefinition", newValue: null)
                    },
                });
            
        }
    }
}
