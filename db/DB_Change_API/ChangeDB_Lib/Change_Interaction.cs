using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ChangeDB_Lib
{
    public class Change_Interaction : Change_DB
    {
        public Change_Interaction()
        {
            this.ConnectToDb(Change_Interaction.connectionString);//для каждого объекта модификации разных сущностей создаём своё соединение
        }
        ~Change_Interaction()//деструктор, закрывающий соединение - хм, а правильное ли это место для закрытия соединения
        {
            //if(this.dbconn)//как проверить, что соединение и так не закрыто и надо ли??
            this.CloseConnection();
        }


        private string ActionExists(string act_name)
        {
            //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Actions WHERE action_name = '" + act_name + "'");
            /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Actions WHERE action_name = '" + act_name + "'");
            if (temp_reader.Read()) return temp_reader["ID"].ToString();
            return "-1";
        }
        public void AddAction(string act_name)
        {
            try
            {
                //проверка, чтобы ещё не было
                if (ActionExists(act_name) != "-1") throw new Exception("Указанное действие уже есть в БД!");
                this.RunSqlCommand("INSERT INTO Actions (action_name) VALUES ('" + act_name + "')");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteAction(string act_name)
        {
            try
            {
                if (ActionExists(act_name) == "-1") throw new Exception("Указанного действия нет в БД!");
                this.RunSqlCommand("DELETE FROM Actions WHERE action_name = '" + act_name + "'");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void RenameAction(string old_name, string new_name)
        {
            try
            {
                string id_action = ActionExists(old_name);
                if (id_action == "-1") throw new Exception("Указанного действия нет в БД!");
                this.RunSqlCommand("UPDATE Actions SET action_name = '" + new_name + "' WHERE ID = " + id_action);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddInterType(string act_name, string act_variation)
        {
            try
            {
                string id_action = ActionExists(act_name);
                if (id_action == "-1") throw new Exception("Указанного действия нет в БД!");
                this.RunSqlCommand("INSERT INTO Interaction_types (id_action, action_variation) VALUES (" + id_action + ", '" + act_variation + "')");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private string InterTypeExists(string id_action, string var)
        {
            //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Interaction_types WHERE id_action = " + id_action + " AND action_variation = '" + var + "'");
            /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Interaction_types WHERE id_action = " + id_action + " AND action_variation = '" + var + "'");
            if (temp_reader.Read()) return temp_reader["ID"].ToString();
            return "-1";
        }
        public void ChangeVariation(string act_name, string old_var, string new_var)
        {
            try
            {
                string id_action = ActionExists(act_name);
                if (id_action == "-1") throw new Exception("Указанного действия нет в БД!");

                string id_inter = InterTypeExists(id_action, old_var);
                if (id_inter == "-1") throw new Exception("Старая вариация указана неверно!");

                this.RunSqlCommand("UPDATE Interaction_types SET action_variation = '" + new_var + "' WHERE ID = " + id_inter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private string RobotParamExists(string par_name)
        {
            //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_name + "'");
            /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_name + "'");
            if (temp_reader.Read()) return temp_reader["ID"].ToString();
            return "-1";
        }
        private string ChangeTypeExists(string type_name)
        {
            //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Change_types WHERE type = '" + type_name + "'");
            /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Change_types WHERE type = '" + type_name + "'");
            if (temp_reader.Read()) return temp_reader["ID"].ToString();
            return "-1";
        }
        private string PotInfExists(string ch_param, string act_name, string act_variation)
        {
            try
            {
                string id_robot_param = RobotParamExists(ch_param);
                if (id_robot_param == "-1") throw new Exception("Робот не имеет указанный параметр!");

                string id_action = ActionExists(act_name);
                if (id_action == "-1") throw new Exception("Указанного действия нет в БД!");

                string id_inter = InterTypeExists(id_action, act_variation);
                if (id_inter == "-1") throw new Exception("Не существует типа взаимодействия с указанной вариацией!");

                //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Potential_influence WHERE id_ch_param = " + id_robot_param +
                //                                                 " AND id_int_type = " + id_inter);
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Potential_influence WHERE id_ch_param = " + id_robot_param +
                                                                 " AND id_int_type = " + id_inter);
                if (temp_reader.Read()) return temp_reader["ID"].ToString();
                return "-1";
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddPotInf(string ch_param, string inf_radius, string max_part, string depend_dist,
                              string change_type, string act_name, string act_variation)
        {
            try
            {
                //проверка данных (bool, int и др.)
                Convert.ToBoolean(depend_dist);
                //
                string id_robot_param = RobotParamExists(ch_param);
                if(id_robot_param == "-1") throw new Exception("Робот не имеет указанный параметр!");

                string id_action = ActionExists(act_name);
                if (id_action == "-1") throw new Exception("Указанного действия нет в БД!");

                string id_inter = InterTypeExists(id_action, act_variation);
                if (id_inter == "-1") throw new Exception("Не существует типа взаимодействия с указанным действием!");

                string id_change_type = ChangeTypeExists(change_type);
                if (id_change_type == "-1") throw new Exception("Не существует указанного типа изменения параметров!");

                if (PotInfExists(ch_param, act_name, act_variation) != "-1") throw new Exception("Запись о потенциальном воздействии уже существует в БД!");
                this.RunSqlCommand("INSERT INTO Potential_influence (id_ch_param, inf_radius, max_part, depend_dist, id_change_type, id_int_type) VALUES (" +
                     id_robot_param + ", " + inf_radius + ", " + max_part + ", " + depend_dist + ", " + id_change_type + ", " + id_inter + ")");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeletePotInf(string ch_param, string act_name, string act_variation)
        {
            try
            {
                string id_pot_inf = PotInfExists(ch_param, act_name, act_variation);
                if (PotInfExists(ch_param, act_name, act_variation) == "-1") throw new Exception("Записи о потенциальном воздействии не существует в БД!");
                this.RunSqlCommand("DELETE FROM Potential_influence WHERE ID = " + id_pot_inf);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}