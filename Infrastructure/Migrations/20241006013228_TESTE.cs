using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TESTE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    id_agendamento = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    data_agendamento = table.Column<DateTime>(name: "data_agendamento ", type: "TIMESTAMP(7)", nullable: false),
                    data_atendimento = table.Column<DateTime>(name: "data_atendimento ", type: "TIMESTAMP(7)", nullable: false),
                    id_paciente = table.Column<int>(name: "id_paciente ", type: "NUMBER(10)", nullable: false),
                    id_dentista = table.Column<int>(name: "id_dentista  ", type: "NUMBER(10)", nullable: false),
                    id_clinica = table.Column<int>(name: "id_clinica  ", type: "NUMBER(10)", nullable: false),
                    id_tabela_preco = table.Column<int>(name: "id_tabela_preco  ", type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.id_agendamento);
                });

            migrationBuilder.CreateTable(
                name: "Clínica",
                columns: table => new
                {
                    id_clinica = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cnpj = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    endereco = table.Column<string>(name: "endereco ", type: "NVARCHAR2(2000)", nullable: false),
                    id_dentista = table.Column<int>(name: "id_dentista ", type: "NUMBER(10)", nullable: false),
                    nome_clinica = table.Column<string>(name: "nome_clinica ", type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clínica", x => x.id_clinica);
                });

            migrationBuilder.CreateTable(
                name: "ContasPagar",
                columns: table => new
                {
                    id_conta_pagar = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    id_clinica = table.Column<int>(name: "id_clinica ", type: "NUMBER(10)", nullable: false),
                    valor = table.Column<double>(name: "valor ", type: "BINARY_DOUBLE", nullable: false),
                    data_emissao = table.Column<DateTime>(name: "data_emissao ", type: "TIMESTAMP(7)", nullable: false),
                    data_vencimento = table.Column<DateTime>(name: "data_vencimento  ", type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasPagar", x => x.id_conta_pagar);
                });

            migrationBuilder.CreateTable(
                name: "ContasReceber",
                columns: table => new
                {
                    id_conta_receber = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    id_paciente = table.Column<int>(name: "id_paciente ", type: "NUMBER(10)", nullable: false),
                    valor = table.Column<double>(name: "valor ", type: "BINARY_DOUBLE", nullable: false),
                    data_emissao = table.Column<DateTime>(name: "data_emissao ", type: "TIMESTAMP(7)", nullable: false),
                    data_vencimento = table.Column<DateTime>(name: "data_vencimento  ", type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContasReceber", x => x.id_conta_receber);
                });

            migrationBuilder.CreateTable(
                name: "Dentista",
                columns: table => new
                {
                    id_dentista = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cpf_cnpj = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    numero_cro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    telefone = table.Column<string>(name: "telefone ", type: "NVARCHAR2(2000)", nullable: false),
                    email = table.Column<string>(name: "email  ", type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentista", x => x.id_dentista);
                });

            migrationBuilder.CreateTable(
                name: "Fraude",
                columns: table => new
                {
                    id_fraude = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    tipo_fraude = table.Column<string>(name: "tipo_fraude  ", type: "NVARCHAR2(2000)", nullable: false),
                    descricao = table.Column<string>(name: "descricao ", type: "NVARCHAR2(2000)", nullable: false),
                    id_paciente = table.Column<int>(name: "id_paciente ", type: "NUMBER(10)", nullable: false),
                    id_dentista = table.Column<int>(name: "id_dentista  ", type: "NUMBER(10)", nullable: false),
                    id_clinica = table.Column<int>(name: "id_clinica   ", type: "NUMBER(10)", nullable: false),
                    id_agendamento = table.Column<int>(name: "id_agendamento ", type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fraude", x => x.id_fraude);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    id_paciente = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    cpf_cnpj = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    tipo_paciente = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.id_paciente);
                });

            migrationBuilder.CreateTable(
                name: "TabelaPreço",
                columns: table => new
                {
                    id_tabela_preco = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome_procedimento = table.Column<string>(name: "nome_procedimento ", type: "NVARCHAR2(2000)", nullable: false),
                    valor = table.Column<double>(name: "valor ", type: "BINARY_DOUBLE", nullable: false),
                    descricao = table.Column<string>(name: "descricao ", type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaPreço", x => x.id_tabela_preco);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "Clínica");

            migrationBuilder.DropTable(
                name: "ContasPagar");

            migrationBuilder.DropTable(
                name: "ContasReceber");

            migrationBuilder.DropTable(
                name: "Dentista");

            migrationBuilder.DropTable(
                name: "Fraude");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "TabelaPreço");
        }
    }
}
