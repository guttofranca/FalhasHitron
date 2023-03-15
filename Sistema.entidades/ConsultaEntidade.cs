using System.Collections.Generic;

namespace TelaPrincipal
{
    public class ConsultaEntidade
    {
        private uint id;
        private string date_captura;
        private string serial;
        private string status_test;
        private string error_code;
        private string description_error;
        private string mac;
        private string date_time;
        private string work_station;
        private string pc_name;
        private string key_test;

        public uint Id { get => id; set => id = value; }
        public string Date_captura { get => date_captura; set => date_captura = value; }
        public string Serial { get => serial; set => serial = value; }
        public string Status_test { get => status_test; set => status_test = value; }
        public string Error_code { get => error_code; set => error_code = value; }
        public string Description_error { get => description_error; set => description_error = value; }
        public string Mac { get => mac; set => mac = value; }
        public string Date_time { get => date_time; set => date_time = value; }
        public string Work_station { get => work_station; set => work_station = value; }
        public string Pc_name { get => pc_name; set => pc_name = value; }
        public string Key_test { get => key_test; set => key_test = value; }

        public override bool Equals(object obj)
        {
            return obj is ConsultaEntidade consulta &&
                   error_code == consulta.error_code &&
                   mac == consulta.mac;
        }

        public override int GetHashCode()
        {
            int hashCode = -811162169;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(error_code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(mac);
            return hashCode;
        }
    }
}
