namespace MyMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieUserBound : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Creator_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Movies", "Creator_Id");
            AddForeignKey("dbo.Movies", "Creator_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Creator_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Movies", new[] { "Creator_Id" });
            DropColumn("dbo.Movies", "Creator_Id");
        }
    }
}
