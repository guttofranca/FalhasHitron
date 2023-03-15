using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TelaPrincipal.controller;

namespace TelaPrincipal
{
    public partial class FormTelaPrincipal : Form
    {

        //parâmetros globais de consulta sql 
        bool incluirRetestes;

        //receberá a data de ínicio da consulta
        string data_consulta_inicial = "";

        //receberá a data do final da consulta
        string data_consulta_final = "";

        //receberá hora inicial da consulta
        string hora_consulta_inicial = "";

        //receberá hora final da consulta
        string hora_consulta_final = "";

        //receberá o posto selecionado no combo box
        string posto = "";

        //variável usada para o erro no listbox ao efetuar duplo clique
        string codigo_erro = "";

        //para armazenar string com o nome do testador selecionado
        string testador_escolhido = "";        

        //lista que receberá o resultado do retorno da consulta do controller
        List<ConsultaEntidade> lista;


        public FormTelaPrincipal()
        {
            InitializeComponent();

            //iniciar o combo box com o elemento de índice 0 selecionado
            cbPostos.SelectedIndex = 0;                      

        }


        //habilitar e desabilitar campos de acordo com o radio button selecionado
        //para escolher qual tipo de consulta se deseja realizar
        private void rbTurno_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton consultaEscolhida = gbConsulta.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);

            if (consultaEscolhida.Text == "Turno")
            {
                btnConsultarPrimeiro.Enabled = true;
                btnConsultarSegundo.Enabled = true;

                tpDataInicio.Enabled = false;
                tpHoraInicio.Enabled = false;
                tpDataFinal.Enabled = false;
                tpHoraFinal.Enabled = false;
                btnConsultaPersonalizada.Enabled = false;

                btn15.Enabled = false;
                btn30.Enabled = false;
                btn45.Enabled = false;
                btn60.Enabled = false;
            }

            else if (consultaEscolhida.Text == "Período personalizado")
            {
                btnConsultarPrimeiro.Enabled = false;
                btnConsultarSegundo.Enabled = false;

                tpDataInicio.Enabled = true;
                tpHoraInicio.Enabled = true;
                tpDataFinal.Enabled = true;
                tpHoraFinal.Enabled = true;
                btnConsultaPersonalizada.Enabled = true;

                btn15.Enabled = false;
                btn30.Enabled = false;
                btn45.Enabled = false;
                btn60.Enabled = false;
            }
            else
            {
                btnConsultarPrimeiro.Enabled = false;
                btnConsultarSegundo.Enabled = false;

                tpDataInicio.Enabled = false;
                tpHoraInicio.Enabled = false;
                tpDataFinal.Enabled = false;
                tpHoraFinal.Enabled = false;
                btnConsultaPersonalizada.Enabled = false;

                btn15.Enabled = true;
                btn30.Enabled = true;
                btn45.Enabled = true;
                btn60.Enabled = true;

            }
        }


        //evento de click no botão de consulta do primeiro turno
        public void btnConsultarPrimeiro_Click(object sender, EventArgs e)
        {
            //data do dia atual
            var date = DateTime.Now;

            //verificando se o horário atual é do primeiro turno
            //caso não seja, exibe um alerta e encerra a função
            TimeSpan comeco = new TimeSpan(6, 00, 0);
            TimeSpan fim = new TimeSpan(16, 00, 00);
            TimeSpan agora = DateTime.Now.TimeOfDay;

            //se horário não está entre 6h e 16h, exibe um messagebox alertando que está fora do turno
            //para que seja feita uma consulta personalizada. se estiver no horário, realiza um consulta
            if ((agora >= comeco) && (agora <= fim))
            {
                //string com data formatada no formato presente na coluna date_time da tabela no banco de dados
                //data inicial e final é a mesma no primeiro turno
                data_consulta_inicial = date.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                data_consulta_final = date.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");

                //string com nome do posto que será usado na consulta de acordo com seleção do combo box
                posto = definir_posto();

                //intervalo de consulta do primeiro turno
                hora_consulta_inicial = "06:00:00";
                hora_consulta_final = "16:00:00";

                try
                {
                    //verificando status do checkbox
                    incluirRetestes = chkReteste.Checked;

                    //estação definida no combobox
                    posto = definir_posto();

                    lista = new List<ConsultaEntidade>();

                    //primeiro turno, logo data de ínicio da consulta é o mesmo do fim da consulta
                    lista = new ConsultaController().consultar(incluirRetestes, posto, data_consulta_inicial, hora_consulta_inicial, data_consulta_final, hora_consulta_final);

                    preencherQuantitativosDeFalhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Consulta Fora do turno!\nTente uma consulta personalizada!!", "Fora do turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void preencherQuantitativosDeFalhas()
        {

            var consulta =
            from falha in lista
            group falha by falha.Error_code into falhasAgrupadas
            orderby falhasAgrupadas.Count() descending
            select falhasAgrupadas;

            //se forem encontradas falhas
            if (consulta.Count() > 0)
            {
                //setando comportamento dos campos
                lbRelatorio.Items.Clear();
                lbRelDetalhado.Items.Clear();
                lbRelTestador.Items.Clear();
                lbRelDetalhado.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });
                lbRelTestador.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });

                foreach (var item in consulta)
                {

                    string saida = (String.Format("{0, -30} | {1, -35} ", $"Código de erro: {item.Key.Trim()}", $"Total de falhas: {Convert.ToString(item.Count()).Trim()}"));

                    lbRelatorio.Items.Add(saida);

                }

            }
            //caso não sejam encontradas falhas
            else
            {
                MessageBox.Show("Não foram encontradas falhas", "Sem falhas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                voltarCamposEstadoInicial();

            }
        }

        private void voltarCamposEstadoInicial()
        {
            //setando comportamento dos campos
            lbRelatorio.Items.Clear();
            lbRelDetalhado.Items.Clear();
            lbRelTestador.Items.Clear();
            lbRelatorio.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });
            lbRelDetalhado.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });
            lbRelTestador.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });
        }

        //método para definir posto de consulta sql a partir do selecionado no combobox
        public string definir_posto()
        {
            string posto = "";

            switch (cbPostos.SelectedItem.ToString())
            {
                case ("AFI0"):
                    posto = "AFI0";
                    break;
                case ("AFI1"):
                    posto = "AFI1";
                    break;
                case ("WLAN"):
                    posto = "T701";
                    break;
                case ("OTA"):
                    posto = "W2-1 Throughput";
                    break;
                case ("FINAL"):
                    posto = "P1-1";
                    break;
            }

            return posto;
        }

        private void btnConsultarSegundo_Click(object sender, EventArgs e)
        {
            //data do dia atual
            var date = DateTime.Now;

            //usada para verificar dia de consulta
            bool mesmoDia = true;

            //verificando se o horário atual é do primeiro turno
            //caso não seja, exibe um alerta e encerra a função
            TimeSpan comeco = new TimeSpan(16, 00, 00);
            TimeSpan meio_ant = new TimeSpan(23, 59, 59);
            TimeSpan meio_post = new TimeSpan(00, 00, 00);
            TimeSpan fim = new TimeSpan(02, 00, 00);
            TimeSpan agora = DateTime.Now.TimeOfDay;

            //se horário não está entre 6h e 16h, exibe um messagebox alertando que está fora do turno
            //para que seja feita uma consulta personalizada. se estiver no horário, realiza um consulta
            if ((agora >= comeco && agora <= meio_ant) || ((agora >= meio_post && agora <= fim)))
            {
                //definindo se a consulta será feita apenas com uma data ou não
                if ((agora >= comeco && agora <= meio_ant))
                {
                    mesmoDia = true;
                }
                if ((agora >= meio_post && agora <= fim))
                {
                    mesmoDia = false;
                }

                //definindo datas de consulta inicial e final
                if (mesmoDia)
                {
                    data_consulta_inicial = date.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                    data_consulta_final = date.AddDays(1).ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                }
                else
                {
                    data_consulta_inicial = date.AddDays(-1).ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                    data_consulta_final = date.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                }

                //string com nome do posto que será usado na consulta de acordo com seleção do combo box
                posto = definir_posto();

                //intervalo de consulta do primeiro turno
                hora_consulta_inicial = "16:00:00";
                hora_consulta_final = "02:00:00";

                //setando comportamento dos campos
                lbRelatorio.Items.Clear();
                lbRelDetalhado.Items.Clear();
                lbRelTestador.Items.Clear();
                lbRelDetalhado.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });
                lbRelTestador.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });

                try
                {
                    //verificando status do checkbox
                    incluirRetestes = chkReteste.Checked;

                    //estação definida no combobox
                    posto = definir_posto();

                    lista = new List<ConsultaEntidade>();

                    //primeiro turno, logo data de ínicio da consulta é o mesmo do fim da consulta
                    lista = new ConsultaController().consultar(incluirRetestes, posto, data_consulta_inicial, hora_consulta_inicial, data_consulta_final, hora_consulta_final);

                    preencherQuantitativosDeFalhas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Consulta Fora do turno!\nTente uma consulta personalizada!!", "Fora do turno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void preencherRelatorioDetalhado()
        {
            lbRelDetalhado.Items.Clear();

            var consulta =
            from falha in lista
            where falha.Error_code.Trim() == codigo_erro.Trim()
            group falha by falha.Pc_name into falhasAgrupadas
            orderby falhasAgrupadas.Count() descending
            select falhasAgrupadas;

            lbRelDetalhado.Items.Clear();
            lbRelTestador.Items.Clear();
            lbRelTestador.Items.AddRange(new object[] { "AGUARDANDO CONSULTA..." });

            foreach (var item in consulta)
            {

                string saida = (String.Format("{0, -20} | {1, -35} ", $"Testador: {item.Key}", $"Total: {Convert.ToString(item.Count()).Trim()}"));

                lbRelDetalhado.Items.Add(saida);

            }

        }


        private void btnConsultaRapida_Click(object sender, EventArgs e)
        {
            //obtendo nome do botão que disparou o evento
            string nomeBotao = ((Button)sender).Name;

            //data do dia atual
            var date = DateTime.Now;

            //string com data formatada no formato presente na coluna date_time da tabela no banco de dados
            //data inicial e final é a mesma no primeiro turno
            data_consulta_final = date.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
            hora_consulta_final = date.ToString("HH:mm:ss");

            data_consulta_inicial = date.AddMinutes(-1 * Convert.ToDouble(nomeBotao.Replace("btn", ""))).ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
            hora_consulta_inicial = date.AddMinutes(-1 * Convert.ToDouble(nomeBotao.Replace("btn", ""))).ToString("HH:mm:ss");

            //string com nome do posto que será usado na consulta de acordo com seleção do combo box
            posto = definir_posto();

            try
            {
                //verificando status do checkbox
                incluirRetestes = chkReteste.Checked;

                //estação definida no combobox
                posto = definir_posto();

                lista = new List<ConsultaEntidade>();

                //primeiro turno, logo data de ínicio da consulta é o mesmo do fim da consulta
                lista = new ConsultaController().consultar(incluirRetestes, posto, data_consulta_inicial, hora_consulta_inicial, data_consulta_final, hora_consulta_final);

                preencherQuantitativosDeFalhas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultaPersonalizada_Click(object sender, EventArgs e)
        {
            //coletando dateTime dos controles e convertendo para date com apenas a data, para que seja feita
            //comparação no if
            var dataInicio = new DateTime(year: Convert.ToInt32(tpDataInicio.Value.ToString("yyyy")),
                month: Convert.ToInt32(tpDataInicio.Value.ToString("MM")), day: Convert.ToInt32(tpDataInicio.Value.ToString("dd")));

            var dataFinal = new DateTime(year: Convert.ToInt32(tpDataFinal.Value.ToString("yyyy")),
                month: Convert.ToInt32(tpDataFinal.Value.ToString("MM")), day: Convert.ToInt32(tpDataFinal.Value.ToString("dd")));

            var horaInicio = tpHoraInicio.Value;
            var horaFinal = tpHoraFinal.Value;

            TimeSpan horaInicio_ = tpHoraInicio.Value.TimeOfDay;
            TimeSpan horaFinal_ = tpHoraFinal.Value.TimeOfDay;

            //verificação de validade das datas
            //no caso a data inicial da consulta não pode ser uma data superior a data final.
            if (dataInicio > dataFinal)
            {
                MessageBox.Show("A data inicial da consulta não pode ser superior a data final!!", "Datas incorretas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dataInicio == dataFinal && horaInicio_ >= horaFinal_)
                {

                    MessageBox.Show("A data inicial da consulta não pode ser superior a data final!!", "Datas incorretas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                else
                {
                    data_consulta_inicial = dataInicio.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                    hora_consulta_inicial = horaInicio.ToString("HH:mm:ss");

                    data_consulta_final = dataFinal.ToString("yyyy’-‘MM’-‘dd’T’").Replace("‘", "").Replace("’", "");
                    hora_consulta_final = horaFinal.ToString("HH:mm:ss");

                    try
                    {
                        //verificando status do checkbox
                        incluirRetestes = chkReteste.Checked;

                        //estação definida no combobox
                        posto = definir_posto();

                        lista = new List<ConsultaEntidade>();

                        //primeiro turno, logo data de ínicio da consulta é o mesmo do fim da consulta
                        lista = new ConsultaController().consultar(incluirRetestes, posto, data_consulta_inicial, hora_consulta_inicial, data_consulta_final, hora_consulta_final);

                        preencherQuantitativosDeFalhas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        //evento que ocorre ao duplo clique em um item da listbox relativo ao relatorio
        private void lbRelatorio_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            
            //obtendo erro na linha selecionada no listbox
            string item_selecionado = lbRelatorio.SelectedItem.ToString();
            string[] cod_erro = item_selecionado.Split('|');
            codigo_erro = cod_erro[0].Replace("Código de erro: ", "").Trim();

            if(!codigo_erro.Equals("AGUARDANDO CONSULTA..."))
            {
                preencherRelatorioDetalhado();
            }
            
        }

        //evento que ocorre ao duplo clique em um item da listbox relativo ao relatorio detalhado com testadores
        private void lbRelDetalhado_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //obtendo testador na linha selecionada no listbox
            string item_selecionado = lbRelDetalhado.SelectedItem.ToString();
            string[] testador = item_selecionado.Split('|');
            testador_escolhido = testador[0].Replace("Testador: ", "").Trim();

            if(!testador_escolhido.Equals("AGUARDANDO CONSULTA..."))
            {
                preencherRelatorioTestador();
            }
            

        }

        //evento que ocorre ao duplo clique em um item da listbox relativo ao relatorio testador
        //com todos os detalhes das falhas ocorridas em um testador específico
        private void preencherRelatorioTestador()
        {
            lbRelTestador.Items.Clear();

            var consulta =
            lista.Where(l => l.Error_code.Trim() == codigo_erro.Trim()
            && l.Pc_name.Trim() == testador_escolhido.Trim()).ToList().OrderByDescending(l => l.Date_captura).ToList().
            Select(falha => new
            {
                Serial = falha.Serial,
                ErroCode = falha.Error_code,
                Descricao = falha.Description_error,
                Data = falha.Date_captura

            });

            lbRelTestador.Items.Clear();

            foreach (var item in consulta)
            {

                string saida = (String.Format("{0, -22} | {1, -13} | {2, -15} | {3, -100} ", $"Serial: {item.Serial}", $"Erro: {item.ErroCode}", $"Data: {item.Data}", $"Descrição: {item.Descricao}"));

                lbRelTestador.Items.Add(saida);

            }
        }
    }
}