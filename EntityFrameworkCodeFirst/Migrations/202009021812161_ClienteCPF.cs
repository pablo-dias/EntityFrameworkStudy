namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteCPF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clientes", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "CPF");
            DropTable("dbo.Produtoes");
        }
    }
}
