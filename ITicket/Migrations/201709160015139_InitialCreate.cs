namespace ITicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        EmpresaID = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Cnpj = c.Int(nullable: false),
                        Telefone = c.String(),
                        Logradouro = c.String(),
                        Endereco = c.String(),
                        Setor = c.String(),
                        Produto = c.String(),
                    })
                .PrimaryKey(t => t.EmpresaID);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        ProdutoID = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Long(nullable: false, identity: true),
                        NomeEmpresa = c.String(),
                        EnderecoEmpresa = c.String(),
                        NomeCliente = c.String(),
                        Produto = c.String(),
                        DataImpressao = c.DateTime(nullable: false),
                        DataFinalizacao = c.DateTime(nullable: false),
                        CodigoTicket = c.Int(nullable: false),
                        Anotacao = c.String(),
                    })
                .PrimaryKey(t => t.TicketID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                        Telefone = c.String(),
                        Ticket = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Tickets");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Empresas");
        }
    }
}
