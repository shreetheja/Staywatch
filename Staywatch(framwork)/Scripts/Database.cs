using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Numerics;


namespace Staywatch_framwork_
{
    class Database
    {
        
        //Database Data Handlers and Connection string
        private static string conString = "DATA SOURCE = localhost:1521 / orcl; USER ID = SYSTEM; Password=oracle;";
        private static Dictionary<int, List<string>> _FetchedRecord = new Dictionary<int, List<string>>();
        public static Dictionary<int, List<string>> fetchRecord = new Dictionary<int, List<string>>();
        private static bool PreviousQueryExecute = false;


        public enum LoginStates{undecided,usernameDosnt,credentialWrong };
        public static LoginStates State = LoginStates.undecided;




        #region fetching_helperMethods
        private static bool InsertData(string command)
        {
            bool returnValue = false;
            PreviousQueryExecute = false;
            using (OracleConnection con = new OracleConnection(conString))
            {
                //Here Connection string is  "DATA SOURCE = localhost:1521 / orcl; USER ID = SYSTEM; Password=oracle;"
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        Console.WriteLine("Command Sending : " + command);

                        con.Open();
                        cmd.BindByName = true;
                        cmd.CommandText = command;
                        cmd.ExecuteReader();
                        con.Close();
                        returnValue = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            return returnValue;
        }
        private static bool fetchDataToDictionary(string command)
        {
            bool returnValue = false;
            PreviousQueryExecute = false;
            using (OracleConnection con = new OracleConnection(conString))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        Console.WriteLine("Command Sending : " + command);

                        _FetchedRecord.Clear();
                        con.Open();
                        cmd.BindByName = true;
                        cmd.CommandText = command;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            int _recordNumber = 0;
                            PreviousQueryExecute = true;
                            while (reader.Read())
                            {
                                
                                returnValue = true;
                                List<string> _recordFields = new List<string>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    _recordFields.Add(reader.GetValue(i).ToString());
                                 //   Console.WriteLine(_recordFields[i]);
                                }
                                _FetchedRecord.Add(_recordNumber, _recordFields);
                                _recordNumber++;
                            }
                          //  Console.WriteLine("_fetchRecord Counts:" + _recordNumber);
                        }
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
            return returnValue;
        }
        #endregion

        #region Database data to datatypes helper methods
        public static DataTable fillDatagrid(Dictionary<int,List<string>> _data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Institute", typeof(string));
            table.Columns.Add("Stay Name", typeof(string));
            table.Columns.Add("Distance", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Cost", typeof(string));

            foreach (List<string> row in Database.fetchRecord.Values)
            {
                table.Rows.Add(row[0], row[1], row[2], row[3], row[5],row[4],row[6]);
            }
            return table;
        }
        public static DataTable fillDatagridBooking(Dictionary<int, List<string>> _data)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Booking Id", typeof(string));
            table.Columns.Add("Stay Name", typeof(string));
            table.Columns.Add("Stay Address", typeof(string));
            table.Columns.Add("Stay Phone Number", typeof(string));
            table.Columns.Add("Stay Cost", typeof(string));

            foreach (List<string> row in Database.fetchRecord.Values)
            {
                table.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
            return table;
        }
        #endregion

        #region Database Requests   
        public static bool Login(string _username,string _password,bool isAdmin)
        {
            _FetchedRecord.Clear();
            string _command;
            if (isAdmin)
            {
                 _command = "select username,password from adminlog where username='" + _username + "' and password= '" + _password + "'";
            }
            else
            {
                 _command = "select username,password from users where username='" + _username + "' and password= '" + _password + "'";
            }
           // Console.WriteLine(_command+ "And :");
            if (Database.fetchDataToDictionary(_command))
            {
               
                if ((Database._FetchedRecord[0])[0] == _username)
                {
                    if((Database._FetchedRecord[0])[1] == _password)
                    {
                        DataClass.CurrentUsername = _username;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Credential Not found State Updated");
                        State = LoginStates.credentialWrong;
                        return false;
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("Username Not found State Updated");
                State = LoginStates.usernameDosnt;
            }
            return false;


        }
        public static bool AccountDetails()
        {
            _FetchedRecord.Clear();
            if (!DataClass.isAdmin)
            {
                string _command = "select * from users where username='" + DataClass.CurrentUsername + "'";
                if (Database.fetchDataToDictionary(_command))
                {
                    DataClass.CurrentUsername = _FetchedRecord[0][0];
                    DataClass.Realuser_Name = _FetchedRecord[0][2];
                    DataClass.DOB = _FetchedRecord[0][3];
                    DataClass.CurrentMailId = _FetchedRecord[0][4];
                    DataClass.CurrentPhoneNumber = _FetchedRecord[0][5];
                    DataClass.age = _FetchedRecord[0][6];
                    fetchRecord = _FetchedRecord;
                    return true;
                }
                return false;
            }
            else if(DataClass.isAdmin)
            {
                string _command = "select * from adminlog where username='" + DataClass.CurrentUsername + "'";
                if(Database.fetchDataToDictionary(_command))
                {
                    DataClass.CurrentUsername = _FetchedRecord[0][0];
                    DataClass.CurrentMailId = _FetchedRecord[0][2];
                    DataClass.Realuser_Name = _FetchedRecord[0][4];
                    DataClass.CurrentPhoneNumber = _FetchedRecord[0][3];
                    fetchRecord = _FetchedRecord;
                    return true;
                }
            }
            return false;
        }
        public static bool PasswordChangeCheck(string _username,string _email,string _phone)
        {
            
            string _cmd = "select * from users where username ='" + _username + "' and email='"+_email+"' and phone = '"+_phone+"'";
           // Console.WriteLine(_cmd);
            if(Database.fetchDataToDictionary(_cmd))
            {
                fetchRecord = _FetchedRecord;
                return true;
            }
            return false;
        }
        public static bool SearchResults1(string _institute_Name)
        {
            _FetchedRecord.Clear();
            string _command = "select i1.name,s1.name,xy.distance ,s1.address,s1.borg,s1.phone,s1.roomCost from(select newDistance.id, S.pgid, newDistance.distance from stays S, (select D.id, D.pgid, D.distance from institute I, distance D where I.id = D.id and I.name like '"+_institute_Name+"%') newDistance where newDistance.pgid = S.pgid) xy ,stays s1, institute i1 where s1.pgid = xy.pgid and i1.id = xy.id";
            if (Database.fetchDataToDictionary(_command))
            {
               // Console.WriteLine("Record Fetched From database");
                fetchRecord = _FetchedRecord;
                return true;
            }            
            return false;
        }
        public static bool SignUp(List<string> _listValues)
        {
            _FetchedRecord.Clear();
            string _CheckCommand0 = "select * from users where username='"+_listValues[0]+"'";
            //string _command1 = "insert into users values('" + _listValues[0] + "','" + _listValues[6] + "')";
            string _command2 = "insert into users values('"+_listValues[0]+"','"+ _listValues[6]+"','" + _listValues[1]+ "','"+_listValues[2]+ "','"+_listValues[3]+ "','"+_listValues[4] +"','"+ _listValues[5]+"')";
            Database.fetchDataToDictionary(_CheckCommand0);
            if (PreviousQueryExecute && _FetchedRecord.Count == 0)
            {
                //if (Database.InsertData(_command1))
                {
                    if (Database.InsertData(_command2))
                    {
                        return true;
                    }
                   // Console.WriteLine("Failed in command2");
                }
               // Console.WriteLine("Failed in command1");

            }
            return false;
        }
        public static bool changePassword(string _newPassword)
        {
            string _cmd1 = "Update users set password = '" + _newPassword + "'" + " where username = '" + _FetchedRecord[0][0] + "'";
            if(Database.InsertData(_cmd1))
            {
                return true;
            }

            return false;
        }
        public static bool GetUsersLocation(string _id)
        {
            string _command = "select I.longitude,I.latitude from institute I,studies S where I.id=S.clg_id and S.username ='" + _id + "'";
            //Console.WriteLine(_command);
            if (Database.fetchDataToDictionary(_command))
            {
                fetchRecord = _FetchedRecord;
                return true;
            }
            else
                return false;
        }
        public static bool GetStayLocation(string _id)
        {
            string _command = "select longitude,latitude from stays where name ='" + _id + "'";
           // Console.WriteLine(_command);
            if(Database.fetchDataToDictionary(_command))
            {
                fetchRecord = _FetchedRecord;
                return true;
            }
            return false;
        }
        public static bool BookStay(List<string> _value) 
        {
            //Finding the max Booking id
            int nextBookingId;
            string _cmd1 = "Select max(booking_id) from booking";
            fetchDataToDictionary(_cmd1);
            Console.WriteLine("Database next booking id : " + _FetchedRecord[0][0]);
            nextBookingId = int.Parse(_FetchedRecord[0][0])+1;

            //Finding the Pg id
            int _pgId;
            string _findPgid = "select pgid from stays where phone='" + _value[0] + "'";
            fetchDataToDictionary(_findPgid);
            _pgId = int.Parse(_FetchedRecord[0][0]);

            string _cmd = "insert into booking values('"+nextBookingId+"','" +_pgId+"','" +DataClass.CurrentUsername+"','" +_value[1]+"')";
            if(Database.InsertData(_cmd))
            {
                return true;
            }
            return false;
        }
        public static bool getBookingDetails()
        {
            string _cmd = "select b.Booking_id,s.name,s.address,s.phone,s.roomcost from booking b, stays s,users u where b.username = u.username and b.pgid = s.pgid and u.username = '"+DataClass.CurrentUsername+"'";
            if(Database.fetchDataToDictionary(_cmd))
            {

                _FetchedRecord = fetchRecord;
                return true;
            }
            return false;
        }
        //admin Options
        public static bool InsertStays(List<string> _values)
        {
            int nextPgId;
            _FetchedRecord.Clear();
            //pg name and addresss validation
            string _checkCommand = "select * from stays where phome='"+_values[2]+"'";
            Database.fetchDataToDictionary(_checkCommand);
            if(_FetchedRecord.Count != 0)
            {
                return false;
            }

            //Find The Next Available PgId
            string _cmd1 = "Select max(pgid) from stays";
            fetchDataToDictionary(_cmd1);
            nextPgId = int.Parse(_FetchedRecord[0][0])+1;
            //add to stays
            string _cmdAddStays = "insert into stays values('" + nextPgId + "','" + _values[0] + "','" + _values[2] + "','" + _values[1] + "','" + _values[4] + "','" + _values[3] + "','" + _values[5] + "','" + _values[6] + "','" + _values[7] +"')";
            if(Database.InsertData(_cmdAddStays))
            {
                string _cmd2 = "insert into distance values('" + _values[9] + "'," + nextPgId + "," + _values[8] + ")";
                if (Database.InsertData(_cmd2))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public static bool InsertInstitue(List<string> _values)
        {
            string _CheckCmd = "select * from institute where id='" + _values[0] + "'";
            string _cmdAddInstitute = "insert into institute values('" + _values[0] + "','" + _values[1] + "','" + _values[2] + "','" + _values[3] + "','" + _values[4] + "')";
            Database.fetchDataToDictionary(_CheckCmd);
            if (PreviousQueryExecute && _FetchedRecord.Count == 0)
            {
                if(Database.InsertData(_cmdAddInstitute))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool DeleteStay(string id)
        {
            string _delete = "Delete from stays where pgid = '" + id+"'";
            if(Database.InsertData(_delete))
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}
