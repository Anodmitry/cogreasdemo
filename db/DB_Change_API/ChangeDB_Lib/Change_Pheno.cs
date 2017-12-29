using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace ChangeDB_Lib
{
    public class Change_Pheno : Change_DB
    {
        public Change_Pheno()
        {
            this.ConnectToDb(Change_Pheno.connectionString);//для каждого объекта модификации разных сущностей создаём своё соединение
        }
        ~Change_Pheno()//деструктор, закрывающий соединение - хм, а правильное ли это место для закрытия соединения
        {
            //if(this.dbconn)//как проверить, что соединение и так не закрыто и надо ли??
            this.CloseConnection();
        }


        public void AddPheno(string name, string x, string y,
                             string radius, string intensity,
                             string time_from, string time_to)
        {
            try
            {
                //Проверка типов данных
                //
                //
                //Проверка несуществования записи
                this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name + "'");
                if (this.temp_reader.Read()) throw new Exception("Явление уже есть в БД!");
                //Добавление
                else
                {
                    //OleDbDataReader temp_read = this.RunSqlCommand("SELECT ID FROM ActObjTypes WHERE type_name = 'явление'");
                    /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT ID FROM ActObjTypes WHERE type_name = 'явление'");
                    temp_reader.Read();
                    string id_type = temp_reader["ID"].ToString();

                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO Active_objects (ao_name, id_type) VALUES ('" + name + "', '" + id_type + "')");
                    //добавили явление в АО
                    //получить id добавленного явления
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Active_objects WHERE ao_name = '" + name + "'");
                    temp_reader.Read();
                    string id_newactobj = temp_reader["ID"].ToString();
                    //получить id характеристики координат
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Characteristics WHERE char_name = 'координаты центра'");
                    temp_reader.Read();
                    string id_coord = temp_reader["ID"].ToString();
                    //throw new Exception(id_coord);
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO ActObjChar (id_actobj, id_char, char_value, id_unit) VALUES ('" + id_newactobj + "', '" + id_coord + "', '" +
                                       x + ";" + y + "', '1')");
                    //получить id характеристики радиуса
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Characteristics WHERE char_name = 'радиус явления'");
                    temp_reader.Read();
                    string id_radius = temp_reader["ID"].ToString();
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO ActObjChar (id_actobj, id_char, char_value, id_unit) VALUES ('" + id_newactobj + "', '" + id_radius + "', '" +
                                       radius + "', '1')");
                    //получить id характеристики интенсивности
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Characteristics WHERE char_name = 'интенсивность явления'");
                    temp_reader.Read();
                    string id_intens = temp_reader["ID"].ToString();
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO ActObjChar (id_actobj, id_char, char_value, id_unit) VALUES ('" + id_newactobj + "', '" + id_intens + "', '" +
                                       intensity + "', '1')");
                    //получить id характеристик времени
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Characteristics WHERE char_name = 'время начала действия явления'");
                    temp_reader.Read();
                    string id_starttime = temp_reader["ID"].ToString();
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO ActObjChar (id_actobj, id_char, char_value, id_unit) VALUES ('" + id_newactobj + "', '" + id_starttime + "', '" +
                                       time_from + "', '1')");
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Characteristics WHERE char_name = 'время окончания действия явления'");
                    temp_reader.Read();
                    string id_stoptime = temp_reader["ID"].ToString();
                    //ПОЛОЖИТЬ В ТАБЛИЦУ ActObjChar соответствующие значения, единицы измерения везде '1' (null) в id_unit
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("INSERT INTO ActObjChar (id_actobj, id_char, char_value, id_unit) VALUES ('" + id_newactobj + "', '" + id_stoptime + "', '" +
                                       time_to + "', '1')");
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void DeletePheno(string name)
        {
            try
            {
                //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name + "'");
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name + "'");
                //проверка на существование
                if (!temp_reader.Read()) throw new Exception("Явления с указанным именем нет в БД!");
                else
                {
                    string id_pheno = temp_reader["ID"].ToString();//получить id явления по имени
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("DELETE FROM Active_objects WHERE ID = " + id_pheno);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ChangePheno(string name, string name_char, string new_val)
        {
            try
            {
                //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name + "'");
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name + "'");
                //проверка на существование
                if (!temp_reader.Read()) throw new Exception("Явления с указанным именем нет в БД!");
                else
                {
                    string id_pheno = temp_reader["ID"].ToString();//получить id явления по имени
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    /*temp_reader = */this.RunSqlCommand("SELECT ID FROM Characteristics WHERE char_name = '" + name_char + "'");
                    temp_reader.Read();
                    string id_char = temp_reader["ID"].ToString();//получили id характеристики
                    //Изменяем значение
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("UPDATE ActObjChar SET char_value = '" + new_val + "' WHERE id_actobj = " + id_pheno + " AND id_char = " + id_char);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void RenamePheno(string old_name, string new_name)
        {
            try
            {
                //OleDbDataReader temp_reader = this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + old_name + "'");
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + old_name + "'");
                //проверка на существование
                if (!temp_reader.Read()) throw new Exception("Явления с указанным именем нет в БД!");
                else
                {
                    string id_pheno = temp_reader["ID"].ToString();//получить id явления по имени
                    //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                    this.RunSqlCommand("UPDATE Active_objects SET ao_name = '" + new_name + "' WHERE ID = " + id_pheno);//изменить имя
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
