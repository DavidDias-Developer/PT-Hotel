using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLL
    {

        public class Clientes
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Clientes", null);
            }
            static public DataTable Load2()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Funcionario", null);
            }
            static public DataTable Load4()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Quartos", null);
            }
            static public DataTable Load5()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Reservas", null);
            }

            static public DataTable Load3()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Contas", null);
            }
            static public int insertCliente(string nome, string morada, string contacto, string NIF, string quarto, string DTN, string email, string presença)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@morada", morada),
                new SqlParameter("@contacto", contacto),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@quarto",quarto),
                 new SqlParameter("@DTN",DTN),
                 new SqlParameter("@email",email),
                 new SqlParameter("presença",presença),
              
           };

                return dal.executarNonQuery("INSERT into Clientes (nome,morada,contacto,NIF,quarto,DTN,email,presença) VALUES(@nome,@morada,@contacto,@NIF,@quarto,@DTN,@email,@presença)", sqlParams);
            }
            static public int insertReserva(int Cliente, int Quarto, DateTime DataEntrada, DateTime DataSaida, double PreçoQuarto, double PreçoRestaurante, double PreçoFinal, string Notas, Boolean Ativo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Cliente", Cliente),
                new SqlParameter("@Quarto", Quarto),
                new SqlParameter("@DataEntrada", DataEntrada),
                new SqlParameter("@DataSaida", DataSaida),
                new SqlParameter("@PreçoQuarto",PreçoQuarto),
                new SqlParameter("@PreçoRestaurante",PreçoRestaurante),
                new SqlParameter("@PreçoFinal",PreçoFinal),
                new SqlParameter("@Notas",Notas),
                new SqlParameter("@Ativo",Ativo),
           };

                return dal.executarNonQuery("INSERT into Reservas (Cliente,Quarto,DataEntrada,DataSaida,PreçoQuarto,PreçoRestaurante,PreçoFinal,Notas,Ativo) VALUES(@Cliente,@Quarto,@DataEntrada,@DataSaida,@PreçoQuarto,@PreçoRestaurante,@PreçoFinal,@Notas,@Ativo)", sqlParams);
            }
            static public int deletequarto(string NºQuarto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NºQuarto", NºQuarto),
               
            };
                return dal.executarNonQuery("Delete From [Quartos] WHERE[NºQuarto]=@NºQuarto", sqlParams);
            }

            static public DataTable validarNIF(string NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NIF", NIF),
                };

                return dal.executarReader("select * from Funcionario where Nif=@Nif", sqlParams);
            }
            static public DataTable validarNIFCliente(string NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NIF", NIF),
                };

                return dal.executarReader("select * from Clientes where Nif=@Nif", sqlParams);
            }
            static public DataTable validarConta(string Utilizador)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Utilizador", Utilizador),
                };

                return dal.executarReader("select * from Funcionario where Utilizador=@Utilizador", sqlParams);
            }
            static public DataTable validarNIF2(int Id, string NIF)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id", Id),
                new SqlParameter("@NIF", NIF),
            };
                return dal.executarReader("SELECT * FROM Funcionario WHERE [Id]!=@Id AND [NIF]=@NIF", sqlParams);
            }
            static public DataTable queryCliente(int id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id)
                };
                return dal.executarReader("select * from Clientes where ID=@id", sqlParams);
            }

            static public int updateCliente(string id, string nome, string morada, string contacto, string NIF, string quarto,string email, string presença)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                new SqlParameter("@nome", nome),
               new SqlParameter("@morada", morada),
                new SqlParameter("@contacto", contacto),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@quarto",quarto),
                new SqlParameter("@email",email),
                 new SqlParameter("@presença",presença),
            };
                return dal.executarNonQuery("update [Clientes] set [nome]=@nome, [morada]=@morada, [contacto]=@contacto, [NIF]=@NIF, [quarto]=@quarto,[email]=@email, [presença]=@presença  where [id]=@id", sqlParams);
            }

            static public int updateconc(string IdReservas, double PreçoFinal, Boolean ativo )
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@IdReservas", IdReservas),
               new SqlParameter("@PreçoFinal",PreçoFinal),
                new SqlParameter("@ativo", ativo),
              
            };
                return dal.executarNonQuery("update [Reservas] set [ativo]=@ativo,[PreçoFinal]=@PreçoFinal where [IdReservas]=@IdReservas", sqlParams);
            }
            static public int updateQtAtivo(string NºQuarto, Boolean Vago)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NºQuarto", NºQuarto),
                
                new SqlParameter("@Vago", Vago),

               
            };
                return dal.executarNonQuery("update [Quartos] set  [Vago]=@Vago where [NºQuarto]=@NºQuarto", sqlParams);
            }

            static public int updateVago(string NºQuarto,Boolean vago)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@NºQuarto", NºQuarto),
                new SqlParameter("@vago", vago),
               
            };
                return dal.executarNonQuery("update [Quartos] set [vago]=@vago where [NºQuarto]=@NºQuarto", sqlParams);
            }

             static public int insertFuncionarios(string Nome, string Morada, string Contacto, string NIF, string NIB, string Tipo, string Ativo, string Utilizador, string Password, Boolean Administrador, Boolean Login,string Email, byte[] Imagem )
            {
                DAL dal = new DAL();    
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Contacto", Contacto),
                new SqlParameter("@NIF", NIF),
                new SqlParameter("@NIB",NIB),
                new SqlParameter("@Ativo",Ativo),
                new SqlParameter("@Tipo",Tipo),
                new SqlParameter("@Utilizador",Utilizador),
                new SqlParameter("@Password",Password),
                new SqlParameter("@Administrador",Administrador),
                new SqlParameter("@Login",Login),
                new SqlParameter("@Email",Email),
                new SqlParameter("@Imagem",Imagem),
                  
                  
           };

                return dal.executarNonQuery("INSERT into Funcionario (Nome,Morada,Contacto,NIF,NIB,Ativo,Tipo,Utilizador,Password,Administrador,Login,Email,Imagem) VALUES(@Nome,@Morada,@Contacto,@NIF,@NIB,@Ativo,@Tipo,@Utilizador,@Password,@Administrador,@Login,@Email,@Imagem)", sqlParams);
            }
             static public int updateResQua(string id, string quarto, string presença)
             {
                 DAL dal = new DAL();
                 SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                new SqlParameter("@quarto",quarto),
                new SqlParameter("@presença",presença),
                  
            };
                 return dal.executarNonQuery("update [Clientes] set [quarto]=@quarto, [presença]=@presença where [id]=@id", sqlParams);
             }
           
             static public int updateResCom(string IdReservas, string Produtos, double PreçoRestaurante)
             {
                 DAL dal = new DAL();
                 SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@IdReservas", IdReservas),
                new SqlParameter("@Produtos",Produtos),
                new SqlParameter("@PreçoRestaurante",PreçoRestaurante),
                  
            };
                 return dal.executarNonQuery("update [Reservas] set [Produtos]=@Produtos, [PreçoRestaurante]=@PreçoRestaurante where [IdReservas]=@IdReservas", sqlParams);
             }
            static public int updateLogin(string id, string Password, Boolean Login)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                new SqlParameter("@Password",Password),
                new SqlParameter("@Login",Login),
                  
            };
                return dal.executarNonQuery("update [Funcionario] set [Password]=@Password, [Login]=@Login where [id]=@id", sqlParams);
            }
            static public int updateFuncionario(string id, string Nome, string Morada, string Contacto, string NIB, string NIF, string Tipo, string Ativo, string Utilizador, string Password, Boolean Administrador)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                new SqlParameter("@nome", Nome),
               new SqlParameter("@morada", Morada),
                new SqlParameter("@contacto", Contacto),
                new SqlParameter("@NIB", NIB),
                new SqlParameter("@NIF", NIF),
                 new SqlParameter("@Tipo",Tipo),
                 new SqlParameter("@Ativo",Ativo),
                   new SqlParameter("@Utilizador",Utilizador),
                  new SqlParameter("@Password",Password),
                  new SqlParameter("@Administrador",Administrador),
                  
            };
                return dal.executarNonQuery("update [Funcionario] set [Nome]=@Nome, [Morada]=@Morada, [Contacto]=@Contacto, [NIB]=@NIB, [NIF]=@NIF, [Tipo]=@Tipo, [Ativo]=@Ativo, [Utilizador]=@Utilizador, [Password]=@Password, [Administrador]=@Administrador where [id]=@id", sqlParams);
            }
            static public DataTable LoadNome(String nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter ("@nome", nome+"%") };
                return dal.executarReader("select*from [Clientes] where nome like @nome", sqlparams);
            }

            static public DataTable LoadQuartos(String NºQuarto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter ("@NºQuarto", NºQuarto+"%") };
                return dal.executarReader("select*from [Quartos] where NºQuarto like @NºQuarto", sqlparams);
            }
            static public DataTable LoadQuartosReser(String Quarto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter ("@Quarto", Quarto+"%") };
                return dal.executarReader("select*from [Reservas] where Quarto like @Quarto", sqlparams);
            }
            static public DataTable LoadClienteReser(String Cliente)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter ("@Cliente", Cliente+"%") };
                return dal.executarReader("select*from [Reservas] where Cliente like @Cliente", sqlparams);
            }
            static public DataTable LoadReser(String IdReservas)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter ("@IdReservas", IdReservas+"%") };
                return dal.executarReader("select*from [Reservas] where IdReservas like @IdReservas", sqlparams);
            }
            static public DataTable LoadFunc(String nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[] {
                new SqlParameter ("@nome", nome+"%") };
                return dal.executarReader("select*from [Funcionario] where nome like @nome", sqlparams);
            }
          
            static public int alterarPerfil(string utilizador, String password, string imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@password", password),
                    new SqlParameter("@imagem", imagem)};

                return dal.executarNonQuery("update [utilizadores] set [password]=@password, [imagem]=@imagem where [utilizador]=@utilizador", sqlparams);
            }

            static public int alterarEstado(string utilizador, int estado)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@utilizador", utilizador),
                    new SqlParameter("@estado", estado)};

                return dal.executarNonQuery("update utilizadores set estado=@estado where utilizador=@utilizador", sqlparams);
            }  
            
            static public int insertQuartos(Boolean Vago, string Tipo, string Andar, string Preço)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
               new SqlParameter("@Vago", Vago),
                new SqlParameter("@Tipo", Tipo),
                new SqlParameter("@Andar", Andar),
                new SqlParameter("@Preço",Preço),
           };

                return dal.executarNonQuery("INSERT into Quartos (Vago,Tipo,Andar,Preço) VALUES(@Vago,@Tipo,@Andar,@Preço)", sqlParams);
            }

            static public int insertRestaurante(string Produto, int Quantidade, double Preço)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Produto", Produto),
                new SqlParameter("@Quantidade", Quantidade),
                new SqlParameter("@Preço", Preço),
                
           };

                return dal.executarNonQuery("INSERT into Restaurante (Produto,Quantidade,Preço) VALUES(@Produto,@Quantidade,@Preço)", sqlParams);
            }


            static public int insertImagem(byte [] Imagem)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                  
                  
           };

                return dal.executarNonQuery("INSERT into Funcionario (Imagem) VALUES (@Imagem)", sqlParams);
            }
           

            
            public class Sessao
            {
                static public DataTable login(string Utilizador, string Password)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@Utilizador", Utilizador),
                    new SqlParameter("@Password", Password)
                 };

                    return dal.executarReader("SELECT * FROM Funcionario where Utilizador=@Utilizador AND Password=@Password", sqlparams);

                }

               




            }
        }
    }
}
