using System;
using System.Reflection;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace interfaceIzara.Model
{
    public class DatabaseActionException : Exception
    {
        public DatabaseActionException(string msg) : base(msg) { }
    }

    public class CrudDB
    {
        public int IntNull { get; set; }
        public double DoubleNull { get; set; }
        public float FloatNull { get; set; }

        public List<T> Find<T>(string tableName, T criteria, string afterwhere, MySqlConnection conn)
        {
            List<T> result = new List<T>();
            Type criteriaType = criteria.GetType();
            PropertyInfo[] criteriaProperties = criteriaType.GetProperties();
            string sqlQuery = String.Format("SELECT * FROM {0} WHERE 1 < 2 ", tableName);
            foreach (var prop in criteriaProperties)
            {
                if (!PropertieValueIsNull(prop, criteria))
                {
                    sqlQuery += String.Format(" AND {0} = {1}", prop.Name, GetPropertieValue(prop, criteria));
                }
            }

            Console.WriteLine(sqlQuery);

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            using (MySqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    T element = (T)Activator.CreateInstance(criteriaType);
                    FetchData(element, dataReader);
                    result.Add(element);
                }
            }

            return result;
        }

        private void FetchData(object element, MySqlDataReader dataReader)
        {
            int column = 0;
            Type elementType = element.GetType();
            PropertyInfo[] properties = elementType.GetProperties();
            foreach (var prop in properties)
            {
                column = dataReader.GetOrdinal(prop.Name);
                Console.WriteLine("Objet : {0}", ReadValue(prop, column, dataReader));
                prop.SetValue(element, ReadValue(prop, column, dataReader), null);
            }
        }

        private object ReadValue(PropertyInfo property, int column, MySqlDataReader dataReader)
        {
            Console.WriteLine("Property : {0}", property.PropertyType.Name);
            switch (property.PropertyType.Name)
            {
                case "Int32":
                    try
                    {
                        Console.WriteLine("Data => {0}", dataReader.GetInt32(column));
                        return dataReader.GetInt32(column);
                    } catch(SqlNullValueException e)
                    {
                        return null;
                    }
                case "Single":
                    try
                    {
                        Console.WriteLine("Data => {0}", dataReader.GetFloat(column));
                        return dataReader.GetFloat(column);
                    } catch (SqlNullValueException e)
                    {
                        return null;
                    }
                case "Double":
                    try
                    {
                        Console.WriteLine("Data => {0}", dataReader.GetDouble(column));
                        return dataReader.GetDouble(column);
                    }
                    catch (SqlNullValueException e)
                    {
                        return null;
                    }
                case "DateTime":
                    try
                    {
                        Console.WriteLine("Data => {0}", dataReader.GetDateTime(column));
                        return dataReader.GetDateTime(column);
                    }
                    catch (SqlNullValueException e)
                    {
                        return null;
                    }
                case "Boolean":
                    try
                    {
                        Console.WriteLine("Data => {0}", dataReader.GetBoolean(column));
                        return dataReader.GetBoolean(column);
                    }
                    catch (SqlNullValueException e)
                    {
                        return null;
                    }
                default:
                    try
                    {
                        Console.WriteLine("Data => {0}", dataReader.GetString(column));
                        return dataReader.GetString(column);
                    }
                    catch (SqlNullValueException e)
                    {
                        return null;
                    }
            }
        }

        public int Update(string tableName, object value, object criteria, MySqlConnection conn)
        {
            Type valueType = value.GetType();
            PropertyInfo[] valueProperties = valueType.GetProperties();
            string sqlQuery = String.Format("UPDATE {0} SET ", tableName);
            foreach (var prop in valueProperties)
            {
                if (!PropertieValueIsNull(prop, value))
                {
                    sqlQuery += String.Format("{0} = {1} ", prop.Name, GetPropertieValue(prop, value));
                }
            }
            sqlQuery += " WHERE 1 < 2 ";
            foreach (var prop in valueProperties)
            {
                if (!PropertieValueIsNull(prop, criteria))
                {
                    sqlQuery += String.Format(" AND {0} = {1}", prop.Name, GetPropertieValue(prop, criteria));
                }
            }
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            return cmd.ExecuteNonQuery();
        }

        public void Insert(string tableName, object value, MySqlConnection conn)
        {
            Type valueType = value.GetType();
            PropertyInfo[] valueProperties = valueType.GetProperties();
            string sqlQuery = String.Format("INSERT INTO {0} (", tableName);
            foreach (var property in valueProperties)
            {
                sqlQuery += property.Name + ",";
            }
            sqlQuery = sqlQuery.Remove(sqlQuery.Length - 1);
            sqlQuery += ") VALUES (";
            foreach (var property in valueProperties)
            {
                /*                if (!PropertieValueIsNull(property, value))*/
                sqlQuery += GetPropertieValue(property, value) + ",";
            }
            sqlQuery = sqlQuery.Remove(sqlQuery.Length - 1);
            sqlQuery += ")";
            Console.WriteLine(sqlQuery);
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            if (cmd.ExecuteNonQuery() != 1) throw new DatabaseActionException("Echec de l'insertion");
        }

        private string GetPropertieValue(PropertyInfo property, object obj)
        {
            string result = "";
            switch (property.PropertyType.Name)
            {
                //case "String":
                //    result += String.Format("'{0}'", property.GetValue(obj, null));
                //    break;
                case "Int32":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += (int)property.GetValue(obj, null);
                    }
                    break;
                case "int":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += (int)property.GetValue(obj, null);
                    }
                    break;
                case "Single":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += ((float)property.GetValue(obj, null)).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                    break;
                case "Double":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += ((double)property.GetValue(obj, null)).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                    break;
                case "double":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += ((double)property.GetValue(obj, null)).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                    break;
                case "Boolean":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += ((bool)property.GetValue(obj, null)).ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }

                    break;

                case "DateTime":
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += String.Format("STR_TO_DATE('{0}', '%d/%m/%Y %H:%i:%s')", property.GetValue(obj, null));
                    }
                    break;

                default:
                    if (property.GetValue(obj, null) == null)
                    {
                        result += "NULL";
                    }
                    else
                    {
                        result += String.Format("'{0}'", property.GetValue(obj, null));
                    }
                    break;
            }
            return result;
        }

        private bool PropertieValueIsNull(PropertyInfo property, object obj)
        {
            string propertyType = property.PropertyType.Name;
            switch (propertyType)
            {
                case "Int32":
                    return (int)property.GetValue(obj, null) == this.IntNull;
                case "Single":
                    return (float)property.GetValue(obj, null) == this.FloatNull;
                case "Double":
                    return (double)property.GetValue(obj, null) == this.DoubleNull;
                case "Boolean":
                    return (bool)property.GetValue(obj, null) == false;
                case "DateTime":
                    return (DateTime)property.GetValue(obj, null) == DateTime.Parse("01/01/0001 00:00:00");

                default:
                    return property.GetValue(obj, null) == null;
            }
        }
    }
}