using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TelaPrincipal.controller
{
    public class ConsultaController
    {
        //string de conexão com o banco de dados
        const string connectionString = "Data Source=ENGENHARIA_HITR;Initial Catalog=pilotohitron;" +
                                  "User ID=consulta;PWD=Engenhari@123";

        //nome da tabela com as falhas da hitron
        const string tabela = "ft_hitron_test";

        string sql = "";
        
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        //lista que será retornada em caso de consulta com reteste
        List<ConsultaEntidade> listaComRepeticao;

        //lista que será retornada em caso de consulta sem reteste
        List<ConsultaEntidade> listaSemRepeticaoTratada;
        
        //para armazenar apenas objetos diferentes na consulta.
        HashSet<ConsultaEntidade> listaSemRepeticao;


        public List<ConsultaEntidade> consultar(bool incluirReteste, string posto,string dataInicial, string horaInicial, string dataFinal,string horaFinal)
        {

            sql = $"SELECT * FROM {tabela} " +
                  $"WHERE status_test = 'FAIL' AND work_station = '{posto}' " +
                  $"AND date_captura BETWEEN '{dataInicial}{horaInicial}' " +
                  $"AND '{dataFinal}{horaFinal}'";
            
            Console.WriteLine(sql);

            listaComRepeticao = new List<ConsultaEntidade>();
            listaSemRepeticao = new HashSet<ConsultaEntidade>();
            listaSemRepeticaoTratada = new List<ConsultaEntidade>();

            if (incluirReteste)//incluindo retestes
            {

                using (con = new SqlConnection())
                {
                    con = new SqlConnection(connectionString);
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ConsultaEntidade dado = new ConsultaEntidade();

                            dado.Id = Convert.ToUInt32(reader["id"]);
                            dado.Date_captura = Convert.ToString(reader["date_captura"]);
                            dado.Serial = Convert.ToString(reader["serial"]);
                            dado.Status_test = Convert.ToString(reader["status_test"]);
                            dado.Error_code = Convert.ToString(reader["error_code"]);
                            dado.Description_error = Convert.ToString(reader["description_error"]);
                            dado.Mac = Convert.ToString(reader["mac"]);
                            dado.Date_time = Convert.ToString(reader["date_time"]);
                            dado.Work_station = Convert.ToString(reader["work_station"]);
                            dado.Pc_name = Convert.ToString(reader["pc_name"]);
                            dado.Key_test = Convert.ToString(reader["key_test"]);

                            listaComRepeticao.Add(dado);

                        }

                    }

                }
                             

                return listaComRepeticao;


            }
            else //excluindo reteste
            {

                using (con = new SqlConnection())
                {
                    con = new SqlConnection(connectionString);
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ConsultaEntidade dado = new ConsultaEntidade();

                            dado.Id = Convert.ToUInt32(reader["id"]);
                            dado.Date_captura = Convert.ToString(reader["date_captura"]);
                            dado.Serial = Convert.ToString(reader["serial"]);
                            dado.Status_test = Convert.ToString(reader["status_test"]);
                            dado.Error_code = Convert.ToString(reader["error_code"]);
                            dado.Description_error = Convert.ToString(reader["description_error"]);
                            dado.Mac = Convert.ToString(reader["mac"]);
                            dado.Date_time = Convert.ToString(reader["date_time"]);
                            dado.Work_station = Convert.ToString(reader["work_station"]);
                            dado.Pc_name = Convert.ToString(reader["pc_name"]);
                            dado.Key_test = Convert.ToString(reader["key_test"]);

                            listaSemRepeticao.Add(dado);

                        }

                        foreach (var item in listaSemRepeticao){
                            listaSemRepeticaoTratada.Add(item);
                        }

                    }
                    
                }
                 

                return listaSemRepeticaoTratada;
            }

        }
    }
}