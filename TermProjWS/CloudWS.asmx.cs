﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using TermProjectLibrary;

namespace TermProjWS
{
    /// <summary>
    /// Summary description for CloudWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CloudWS : System.Web.Services.WebService
    {
        Serialize mySerialization = new Serialize();
        DBConnect myDB = new DBConnect();
        int verificationToken = 112358;
        SqlCommand myCommand = new SqlCommand();
        DataSet myDS = new DataSet();

        //adds the file's actual data to the database
        [WebMethod]
        public int addDownloadData (int accountID, byte[] data, int verification)
        {
            int returnID = 0;
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPaddDownloadData";
                myCommand.Parameters.AddWithValue("@accountID", accountID);
                myCommand.Parameters.AddWithValue("@data", data);

                myDB.DoUpdateUsingCmdObj(myCommand);

                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPgetMaxFileID";
                myDB.GetDataSetUsingCmdObj(myCommand);

                returnID = Convert.ToInt32(myDB.GetField("maxID", 0));
                return returnID;

            }else
            {
                return returnID;
            }
        }

        [WebMethod]
        public void addPreviousDownloadData(int accountID, byte[] data, int fileID, 
            DateTime timestamp, string title, int length, int verification)
        {
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPaddPreviousData";
                myCommand.Parameters.AddWithValue("@accountID", accountID);
                myCommand.Parameters.AddWithValue("@data", data);
                myCommand.Parameters.AddWithValue("@fileID", fileID);
                myCommand.Parameters.AddWithValue("@timestamp", timestamp);
                myCommand.Parameters.AddWithValue("@title", title);
                myCommand.Parameters.AddWithValue("@length", length);

                myDB.DoUpdateUsingCmdObj(myCommand);

            }
        }

        [WebMethod]
        public DataSet getPreviousFiles(int accountID, int verification)
        {
            myDS = new DataSet();
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPgetPreviousFiles";
                myCommand.Parameters.AddWithValue("@accountID", accountID);
                myDS = myDB.GetDataSetUsingCmdObj(myCommand);
            }

            return myDS;
        }
        [WebMethod]
        public void deletePreviousVersions(int accountID, int verification)
        {
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPdeletePreviousVersions";
                myCommand.Parameters.AddWithValue("@accountID", accountID);
                myDB.DoUpdateUsingCmdObj(myCommand);

            }
        }

        [WebMethod]
        public void updateDownloadData(byte[] newData, int fileID,
             int verification)
        {
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPupdateDownloadData";
                myCommand.Parameters.AddWithValue("@data", newData);
                myCommand.Parameters.AddWithValue("@fileID", fileID);
                myDB.DoUpdateUsingCmdObj(myCommand);

            }
        }

        //returns the max file ID in the database
        [WebMethod]
        public int getMaxFileID(int verification)
        {
            int returnID;
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPgetMaxFileID";
                myDB.GetDataSetUsingCmdObj(myCommand);

                returnID = Convert.ToInt32(myDB.GetField("maxID", 0));
                return returnID;

            }
            else
            {
                return 0;
            }
        }

        [WebMethod]
        public byte[] getPreviousDownloadData(int fileID, Int64 fileLength, string timestamp, int verification)
        {
            byte[] data = new byte[fileLength];

            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPgetPreviousDownloadData";
                myCommand.Parameters.AddWithValue("@fileID", fileID);
                myCommand.Parameters.AddWithValue("@timestamp", timestamp);

                myDB.GetDataSetUsingCmdObj(myCommand);

                data = (byte[])myDB.GetField("fileData", 0);

                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPdeletePreviousData";
                myCommand.Parameters.AddWithValue("@fileID", fileID);
                myCommand.Parameters.AddWithValue("@timestamp", timestamp);
                myDB.DoUpdateUsingCmdObj(myCommand);
            }
            return data;
        }

        //returns the download data from the database
        [WebMethod]
        public byte[] getDownloadData (int fileID, Int64 fileLength, int verification)
        {
            byte[] data = new byte[fileLength];

            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPgetDownloadData";
                myCommand.Parameters.AddWithValue("@fileID", fileID);

                myDB.GetDataSetUsingCmdObj(myCommand);

                data = (byte[])myDB.GetField("fileData", 0);
            }
            return data;
        }

        [WebMethod]
        public int DeleteFile(int fileID, int verification)
        {
            int temp = 0;
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPdeleteFileP3";

                SqlParameter myParameter = new SqlParameter("@ID", fileID);
                myParameter.Direction = ParameterDirection.Input;
                myParameter.SqlDbType = SqlDbType.Int;
                myCommand.Parameters.Add(myParameter);

                temp = myDB.DoUpdateUsingCmdObj(myCommand);
                return temp;
            }
            else
                return temp;

        }

        [WebMethod]
        public int deleteAccount(int ID, int adminID, int verification)
        {
            int flag = 0;
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPdeleteAccountP3";

                SqlParameter myParameter = new SqlParameter("@ID", ID);
                myParameter.Direction = ParameterDirection.Input;
                myParameter.SqlDbType = SqlDbType.Int;
                myCommand.Parameters.Add(myParameter);

                myParameter = new SqlParameter("@adminID", adminID);
                myParameter.Direction = ParameterDirection.Input;
                myParameter.SqlDbType = SqlDbType.Int;
                myCommand.Parameters.Add(myParameter);

                flag = myDB.DoUpdateUsingCmdObj(myCommand);
                return flag;
                //Flag represense number of rows affected,-1 if exception occured, 
            }
            else
                return flag; //return zero
        }

        [WebMethod]
        public int deleteAllFiles(int ID, int verification)
        {
            int flag = 0;
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPdeleteAllFiles";

                SqlParameter myParameter = new SqlParameter("@ID", ID);
                myParameter.Direction = ParameterDirection.Input;
                myParameter.SqlDbType = SqlDbType.Int;
                myCommand.Parameters.Add(myParameter);

                flag = myDB.DoUpdateUsingCmdObj(myCommand);
                return flag;
                //Flag represense number of rows affected,-1 if exception occured, 
            }
            else
                return flag; //return zero
        }

        [WebMethod]
        public int resetStorageUsed(int ID, int verification)
        {
            int flag = 0;
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPresetStorageUsed";

                SqlParameter myParameter = new SqlParameter("@ID", ID);
                myParameter.Direction = ParameterDirection.Input;
                myParameter.SqlDbType = SqlDbType.Int;
                myCommand.Parameters.Add(myParameter);

                flag = myDB.DoUpdateUsingCmdObj(myCommand);
                return flag;
                //Flag represense number of rows affected,-1 if exception occured, 
            }
            else
                return flag; //return zero
        }

        [WebMethod]
        public void logUserTransaction(int accountID, string description, int verification)
        {
            if (verification == verificationToken)
            {
                myCommand.Parameters.Clear();

                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "TPlogUserTransaction";

                myCommand.Parameters.AddWithValue("accountID", accountID);
                myCommand.Parameters.AddWithValue("description", description);

                myDB.DoUpdateUsingCmdObj(myCommand);
                //Flag represense number of rows affected,-1 if exception occured, 
            }
        }

        
    }
}
