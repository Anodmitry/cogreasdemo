using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace ChangeDB_Lib
{
    public class Change_Robot : Change_DB 
    {
        //не уверен, что правильный способ избежать проблем с открытыми datareader
        //???когда закрывать соединение???оставить на совести клиента???или в деструктор запихнуть, а есть ли они в шарпе?
        public Change_Robot()
        {
            this.ConnectToDb(Change_Robot.connectionString);//для каждого объекта модификации разных сущностей создаём своё соединение
        }
        ~Change_Robot()//деструктор, закрывающий соединение - хм, а правильное ли это место для закрытия соединения
        {
            //if(this.dbconn)//как проверить, что соединение и так не закрыто и надо ли??
            this.CloseConnection();
        }

        public void AddParameter(string par_name, string par_val)
        {
            try
            {
                //Проверка типов данных
                //
                //
                //Проверка несуществования записи
                this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_name + "'");
                if (this.temp_reader.Read()) throw new Exception("Параметр робота уже есть в БД!");
                else
                {
                    this.RunSqlCommand("INSERT INTO Robot_parameters (par_name, par_value) VALUES ('" + par_name + "', '" + par_val + "')");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteParameter(string par_name)
        {
            try
            {
                //Проверка существования записи
                this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_name + "'");
                if (!this.temp_reader.Read()) throw new Exception("Указанный параметр робота не существует в БД!");
                else
                {
                    this.RunSqlCommand("DELETE FROM Robot_parameters WHERE par_name = '" + par_name + "'");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ChangeParameter(string par_name, string new_val)
        {
            try
            {
                //Проверка типов данных
                //
                //
                //Проверка существования записи
                this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_name + "'");
                if (!this.temp_reader.Read()) throw new Exception("Указанный параметр робота не существует в БД!");
                else
                {
                    this.RunSqlCommand("UPDATE Robot_parameters SET par_value = " + new_val + " WHERE par_name = '" + par_name + "'");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddDefenceAction(string def_act_name, string energy_sp)
        {
            try
            {
                //Проверка типов данных
                //
                //
                //Проверка несуществования записи
                this.RunSqlCommand("SELECT * FROM Defence_actions WHERE def_act_name = '" + def_act_name + "'");
                if (this.temp_reader.Read()) throw new Exception("Действие защиты уже есть в БД!");
                else
                {
                    this.RunSqlCommand("INSERT INTO Defence_actions (def_act_name, energy_spending) VALUES ('" + def_act_name + "', " + energy_sp + ")");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteDefenceAction(string def_act_name)
        {
            try
            {
                //Проверка существования записи
                this.RunSqlCommand("SELECT * FROM Defence_actions WHERE def_act_name = '" + def_act_name + "'");
                if (!this.temp_reader.Read()) throw new Exception("Указанное действие защиты не существует в БД!");
                else
                {
                    this.RunSqlCommand("DELETE FROM Defence_actions WHERE def_act_name = '" + def_act_name + "'");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ChangeDefenceAction(string def_act_name, string new_name, string new_energy_sp)
        {
            try
            {
                //Проверка типов данных
                //
                //
                //Проверка существования записи
                //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Defence_actions WHERE def_act_name = '" + def_act_name + "'");
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Defence_actions WHERE def_act_name = '" + def_act_name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанное действие защиты не существует в БД!");
                else
                {
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    if (new_name == "")
                    {
                        this.RunSqlCommand("UPDATE Defence_actions SET energy_spending = " + new_energy_sp + " WHERE def_act_name = '" + def_act_name + "'");
                    }
                    if (new_energy_sp == "")
                    {
                        this.RunSqlCommand("UPDATE Defence_actions SET def_act_name = '" + new_name + "' WHERE def_act_name = '" + def_act_name + "'");
                    }
                    if (new_name != "" && new_energy_sp != "")
                    {
                        this.RunSqlCommand("UPDATE Defence_actions SET def_act_name = '" + new_name + "', energy_spending = "
                                       + new_energy_sp + " WHERE def_act_name = '" + def_act_name + "'");
                    }                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void SetParameterProtection(string def_act_name, string par_for_protect_name, string coef_weak_attack)
        {
            try
            {
                //Проверка типов данных
                //
                //
                //Проверка существования параметра робота
                //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_for_protect_name + "'");
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Robot_parameters WHERE par_name = '" + par_for_protect_name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный параметр робота не существует в БД!");
                string id_par = temp_reader["ID"].ToString();//получили ID параметра

                //Проверка существования действия защиты
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM Defence_actions WHERE def_act_name = '" + def_act_name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанное действие защиты не существует в БД!");
                string id_def_act = temp_reader["ID"].ToString();//получили ID действия защиты

                //Проверка существования указанной защиты указанного параметра
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM ParameterProtection WHERE id_def_act = " + id_def_act + " AND id_paramfordef = " +
                                                 id_par);
                if (temp_reader.Read())
                {
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("UPDATE ParameterProtection SET coef_weak_attack = " + coef_weak_attack +
                                                           " WHERE id_def_act = " + id_def_act + " AND id_paramfordef = " + id_par);
                }
                else {
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO ParameterProtection (id_def_act, id_paramfordef, coef_weak_attack) VALUES (" +
                                        id_def_act + ", " + id_par + ", " + coef_weak_attack + ")");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
