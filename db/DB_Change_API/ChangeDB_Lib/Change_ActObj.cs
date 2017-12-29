using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OleDb;
using System.Data.SqlClient;

namespace ChangeDB_Lib
{
    public class Change_ActObj : Change_DB
    {
        //не уверен, что правильный способ избежать проблем с открытыми datareader
        //???когда закрывать соединение???оставить на совести клиента???или в деструктор запихнуть, а есть ли они в шарпе?
        public Change_ActObj()
        {
            this.ConnectToDb(Change_ActObj.connectionString);//для каждого объекта модификации разных сущностей создаём своё соединение
        }
        ~Change_ActObj()//деструктор, закрывающий соединение - хм, а правильное ли это место для закрытия соединения
        {
            //if(this.dbconn)//как проверить, что соединение и так не закрыто и надо ли??
            this.CloseConnection();
        }


        
        public void AddActObj(string name_ao, string type)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name_ao + "'");
                if (temp_reader.Read()) throw new Exception("Активный объект уже есть в БД!");
                //temp_reader.Close();//без этого выдаёт ошибку
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM ActObjTypes WHERE type_name = '" + type + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный тип не существует в БД!");                
                string id_type = temp_reader["ID"].ToString();
                
                /*temp_reader = */this.RunSqlCommand("INSERT INTO Active_objects (ao_name, id_type) VALUES ('" + name_ao + "', " + id_type + ")");
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteActObj(string name_ao)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name_ao + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный активный объект не существует в БД!");
                
                this.RunSqlCommand("DELETE FROM Active_objects WHERE ao_name = '" + name_ao + "'");
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddAOType(string name)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM ActObjTypes WHERE type_name = '" + name + "'");
                if (temp_reader.Read()) throw new Exception("Указанный тип активных объектов уже есть в БД!");
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("INSERT INTO ActObjTypes (type_name) VALUES ('" + name + "')");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteAOType(string name)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM ActObjTypes WHERE type_name = '" + name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанного типа активных объектов не существует в БД!");
                this.RunSqlCommand("DELETE FROM ActObjTypes WHERE type_name = '" + name + "'");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ChangeAOType(string old_name, string new_name)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM ActObjTypes WHERE type_name = '" + old_name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанного типа активных объектов не существует в БД!");
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("UPDATE ActObjTypes SET type_name = '" + new_name + "' WHERE type_name = '" + old_name + "'");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void AddCharacteristic(string name_char)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + name_char + "'");
                if (temp_reader.Read()) throw new Exception("Указанная характеристика активных объектов уже есть в БД!");
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("INSERT INTO Characteristics (char_name) VALUES ('" + name_char + "')");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteCharacteristic(string name_char)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + name_char + "'");
                if (!temp_reader.Read()) throw new Exception("Указанной характеристики активных объектов не существует в БД!");
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("DELETE FROM Characteristics WHERE char_name = '" + name_char + "'");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ChangeCharacteristic(string old_name, string new_name)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + old_name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанной характеристики активных объектов не существует в БД!");
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("UPDATE Characteristics SET char_name = '" + new_name + "' WHERE char_name = '" + old_name + "'");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private string UnitExists(string unit_name)
        {
            /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Units WHERE unit_name = '" + unit_name + "'");
            if (temp_reader.Read()) return temp_reader["ID"].ToString();
            return "-1";
        }
        private string TypeCanHaveChar(string id_type, string id_char)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM AOTypeCanHaveChar WHERE id_char = " + id_char + " AND id_aotype = " + id_type);
                if (temp_reader.Read()) return temp_reader["ID"].ToString();
                return "-1";
            }
            catch(Exception e)
            {
                throw e;
            }         
        }
        public void AddActObjChar(string name_ao, string name_char, string val, string unit_name)
        {
            try
            {
                //Проверка наличия ао в БД
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name_ao + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный активный объект не существует в БД!");
                string id_actobj = temp_reader["ID"].ToString();
                string id_type = temp_reader["id_type"].ToString();
                //Проверка на наличие в бд единиц измерения
                string id_unit = UnitExists(unit_name);
                if (id_unit == "-1") throw new Exception("Указанных единиц измерения не существует в БД!");
                //Проверка существования характеристики
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + name_char + "'");
                if (!temp_reader.Read()) throw new Exception("Указанная характеристика не существует в БД!");
                string id_char = temp_reader["ID"].ToString();
                //Проверка, чтобы типу указанного ао было разрешено иметь указанную характеристику
                if (TypeCanHaveChar(id_type, id_char) == "-1") throw new Exception("Тип указанного объекта не может иметь указанную характеристику!");
                //Проверка типов данных
                //
                //Добавление
                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("INSERT INTO ActObjChar (id_actobj, id_char, char_value, id_unit) VALUES (" + id_actobj + ", " + id_char + ", '" +
                                   val + "', " + id_unit + ")");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteActObjChar(string name_ao, string name_char)
        {
            try
            {
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name_ao + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный активный объект не существует в БД!");
                string id_actobj = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + name_char + "'");
                if (!temp_reader.Read()) throw new Exception("Указанная характеристика не существует в БД!");
                string id_char = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM ActObjChar WHERE id_actobj = " + id_actobj + " AND id_char = " + id_char);
                if (!temp_reader.Read()) throw new Exception("Записи не существует в таблице ActObjChar!");
                string id_del = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("DELETE FROM ActObjChar WHERE ID = " + id_del);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ChangeActObjChar(string name_ao, string name_char, string new_val, string new_unit_name)
        {
            try
            {
                //ошибка, если нет записи
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + name_ao + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный активный объект не существует в БД!");
                string id_actobj = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + name_char + "'");
                if (!temp_reader.Read()) throw new Exception("Указанная характеристика не существует в БД!");
                string id_char = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM ActObjChar WHERE id_actobj = " + id_actobj + " AND id_char = " + id_char);
                if (!temp_reader.Read()) throw new Exception("Записи не существует в таблице ActObjChar!");
                string id_change = temp_reader["ID"].ToString();

                string id_unit = UnitExists(new_unit_name);
                if (id_unit == "-1") throw new Exception("Указанных единиц измерения не существует в БД!");

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("UPDATE ActObjChar SET char_value = '" + new_val + "', id_unit = " + id_unit + " WHERE ID = " + id_change);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void SetAOTypeCanHaveChar(string type_ao, string name_char, bool let)//true - разрешить (добавить в таблицу AOTypeCanHaveChar), false - запретить
        {
            try
            {
                //ошибка, если нет характеристики или типа
                this.RunSqlCommand("SELECT * FROM ActObjTypes WHERE type_name = '" + type_ao + "'");
                if (!temp_reader.Read()) throw new Exception("Указанного типа активных объектов не существует в БД!");
                string id_aotype = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                /*temp_reader = */this.RunSqlCommand("SELECT * FROM Characteristics WHERE char_name = '" + name_char + "'");
                if (!temp_reader.Read()) throw new Exception("Указанная характеристика не существует в БД!");
                string id_char = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                string id_record = TypeCanHaveChar(id_aotype, id_char);//-1, если не существует записи
                if (let && id_record == "-1") this.RunSqlCommand("INSERT INTO AOTypeCanHaveChar (id_char, id_aotype) VALUES (" + id_char + ", " + id_aotype + ")");
                if (!let && id_record != "-1") this.RunSqlCommand("DELETE FROM AOTypeCanHaveChar WHERE ID = " + id_record);
                if (let && id_record != "-1" || !let && id_record == "-1") throw new Exception("Характеристика уже разрешена (запрещена) для данного типа активных объектов!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void RenameActObj(string old_name, string new_name)
        {
            try
            {
                //форма rename
                /*SqlDataReader temp_reader = */this.RunSqlCommand("SELECT * FROM Active_objects WHERE ao_name = '" + old_name + "'");
                if (!temp_reader.Read()) throw new Exception("Указанный активный объект не существует в БД!");
                string id_actobj = temp_reader["ID"].ToString();

                //temp_reader.Close();//без этого выдаёт ошибку незакрытого SqlDataReader
                this.RunSqlCommand("UPDATE Active_objects SET ao_name = '" + new_name + "' WHERE ID = " + id_actobj);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
