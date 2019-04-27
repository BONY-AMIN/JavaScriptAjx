namespace JavaScriptAjx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ajax : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        Dept = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Sums",
                c => new
                    {
                        SumId = c.Int(nullable: false, identity: true),
                        Firstnumber = c.Double(nullable: false),
                        Secondnumber = c.Double(nullable: false),
                        Result = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SumId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sums");
            DropTable("dbo.Students");
        }
    }
}
