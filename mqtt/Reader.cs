using System;
using System.Windows.Forms;
using System.Xml;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;


namespace mqtt
{
    internal class Reader
    {


        public void MqttClient_MqttMsgPublish(string Dipadd, string Ddeviceid, string Dtype, int Dvalue, string Dstate, MySqlConnection DBCon, ClassGeneralFunctions cGF)
        {

            int index = 0;

            string cmdText = "INSERT INTO iot_input_process(device_id_in_iot_input, parameter_id_in_iot_input,value_input) " +
                                      "VALUES (@DID, @DTYP, @DVAL)";
            MySqlCommand cmd = new MySqlCommand(cmdText, DBCon);

            if (Dstate == "running")
            {
                cmd.Parameters.AddWithValue("@DID", "10000015");
                cmd.Parameters.AddWithValue("@DTYP", "LNTH");

            }
            else
            {

                cmd.Parameters.AddWithValue("@DID", Ddeviceid);
                cmd.Parameters.AddWithValue("@DTYP", Dtype);

            }

            cmd.Parameters.AddWithValue("@DVAL", Dvalue);

            cmd.ExecuteNonQuery();

            int ProducID = 0;
            int HisID = 0;
            string Hisdate = null;
            MySqlCommand cmdW = new MySqlCommand("SELECT iot_input_process_id, iot_input_his_id, time_date_in_iot_input_his  FROM iot_input_history order by iot_input_his_id desc LIMIT 1;", DBCon);
            MySqlDataReader rW = cmdW.ExecuteReader();

            if (rW.Read())
            {
                if (!rW.IsDBNull(rW.GetOrdinal("iot_input_process_id")))
                {
                    ProducID = (int)rW.GetInt64("iot_input_process_id");
                    HisID = (int)rW.GetInt64("iot_input_his_id");
                    Hisdate = (string)rW.GetString("time_date_in_iot_input_his");
                }
                else
                {
                    ProducID = 0;
                    HisID = 0;
                    Hisdate = null;
                }
                rW.Close();
            }
            rW.Close();


            if ((Dtype == "bobbin1" || Dtype == "bobbin2" || Dtype == "bobbin0" || Dtype == "bobbin12") && Dstate != "done" && Dvalue == 0)
            {

                MySqlCommand cmdM = new MySqlCommand("select * from accual_weight where process_id=@ProID  order by number_of_rolls  desc limit 1 ", DBCon);
                cmdM.Parameters.AddWithValue("@ProID", ProducID);
                MySqlDataReader dM = cmdM.ExecuteReader();

                if (dM.Read())
                {
                    string lastBoB;
                    string enddate;
                    int LENTHTOT = 0;
                    int WNUMBER = 0;

                    lastBoB = dM.GetString("BobbinID");

                    LENTHTOT = (int)dM.GetInt64(dM.GetOrdinal("number_of_rolls"));
                    WNUMBER = (int)dM.GetInt64(dM.GetOrdinal("weight_id"));

                    if (!dM.IsDBNull(dM.GetOrdinal("roll_EndDateTime")))
                    {

                        LENTHTOT = LENTHTOT + 1;
                        dM.Close();
                        //MySqlCommand cmd = new MySqlCommand("insert into <iot_input_process>values(Ddeviceid,'null',Dtype,'null',Dvalue);", conn);
                        string cmdText1 = "INSERT INTO accual_weight(process_id,system_length,number_of_rolls,accual_weightcol,roll_StartDateTime,BobbinID) " +
                                          "VALUES (@PROD, @DSYSL,@LTOT,@DAW,@DCDATE,@DBOB)";
                        MySqlCommand cmd3 = new MySqlCommand(cmdText1, DBCon);
                        cmd3.Parameters.AddWithValue("@PROD", ProducID);
                        cmd3.Parameters.AddWithValue("@DBOB", Dtype);
                        cmd3.Parameters.AddWithValue("@DSYSL", 0);
                        cmd3.Parameters.AddWithValue("@DAW", 0);
                        cmd3.Parameters.AddWithValue("@EDATE", "NULL");
                        cmd3.Parameters.AddWithValue("@DCDATE", cGF.getCurrentDateTimeIST(true, false, false));
                        cmd3.Parameters.AddWithValue("@LTOT", LENTHTOT);
                        cmd3.ExecuteNonQuery();

                    }
                    else
                    {

                        dM.Close();

                        string cmdText4 = "UPDATE accual_weight SET roll_StartDateTime = @DCDATE WHERE weight_id=@WID";
                        MySqlCommand cmd5 = new MySqlCommand(cmdText4, DBCon);
                        cmd5.Parameters.AddWithValue("@DCDATE", cGF.getCurrentDateTimeIST(true, false, false));
                        cmd5.Parameters.AddWithValue("@WID", WNUMBER);
                        cmd5.ExecuteNonQuery();
                    }

                }

                else
                {
                    dM.Close();
                    string cmdText7 = "INSERT INTO accual_weight(process_id,system_length,number_of_rolls,accual_weightcol,roll_StartDateTime,BobbinID) " +
                                        "VALUES (@PROD, @DSYSL,@LTOT,@DAW,@DCDATE,@DBOB)";
                    MySqlCommand cmd7 = new MySqlCommand(cmdText7, DBCon);
                    cmd7.Parameters.AddWithValue("@PROD", ProducID);
                    cmd7.Parameters.AddWithValue("@DBOB", Dtype);
                    cmd7.Parameters.AddWithValue("@DSYSL", 0);
                    cmd7.Parameters.AddWithValue("@DAW", 0);
                    cmd7.Parameters.AddWithValue("@EDATE", "NULL");
                    cmd7.Parameters.AddWithValue("@DCDATE", cGF.getCurrentDateTimeIST(true, false, false));
                    cmd7.Parameters.AddWithValue("@LTOT", 1);
                    cmd7.ExecuteNonQuery();

                }


            }


            if ((Dtype == "bobbin1" || Dtype == "bobbin2" || Dtype == "waste") && Dstate != "running")
            {


                if (ProducID > 0)
                {
                    if (Dtype == "waste" && Dstate == "done")
                    {

                        string cmdText7 = "INSERT INTO wastage(admin_id,system_wastage,actual_wastage,iot_input_his_id, time_date_in_iot_input_his) " +
                                            "VALUES (@PROD,@SyatemWaste,@Awaste,@HisId, @Hisd)";
                        MySqlCommand cmd7 = new MySqlCommand(cmdText7, DBCon);
                        cmd7.Parameters.AddWithValue("@PROD", ProducID);
                        cmd7.Parameters.AddWithValue("@SyatemWaste", Dvalue);
                        cmd7.Parameters.AddWithValue("@Awaste", 0);
                        cmd7.Parameters.AddWithValue("@HisId", HisID);
                        cmd7.Parameters.AddWithValue("@Hisd", Hisdate);
                        cmd7.ExecuteNonQuery();

                    }
                    if (Dtype != "waste" && Dstate == "done")
                    {
                        int Num = 0;
                        MySqlCommand cmdN = new MySqlCommand("select weight_id from accual_weight where process_id=@ProID  and roll_EndDateTime is null order by weight_id  desc limit 1 ", DBCon);
                        cmdN.Parameters.AddWithValue("@ProID", ProducID);
                        MySqlDataReader dN = cmdN.ExecuteReader();

                        if (dN.Read())
                        {

                            Num = (int)dN.GetInt64(dN.GetOrdinal("weight_id"));
                            dN.Close();
                            string cmdText2 = "UPDATE accual_weight SET system_length = @Value, roll_EndDateTime=@DCDATE, BobbinID=@DBOB, ID_Process=@HisId WHERE weight_id=@WID";
                            MySqlCommand cmd4 = new MySqlCommand(cmdText2, DBCon);
                            // string updatedTime = cGF.getCurrentDateTimeIST(true, false, false);
                            cmd4.Parameters.AddWithValue("@WID", Num);
                            cmd4.Parameters.AddWithValue("@Value", Dvalue);
                            cmd4.Parameters.AddWithValue("@DCDATE", cGF.getCurrentDateTimeIST(true, false, false));
                            cmd4.Parameters.AddWithValue("@DBOB", Dtype);
                            cmd4.Parameters.AddWithValue("@HisId", HisID);
                            cmd4.ExecuteNonQuery();

                        }
                        else
                        {
                            dN.Close();
                            string cmdText8 = "INSERT INTO accual_weight(process_id,system_length,number_of_rolls,accual_weightcol,roll_StartDateTime,roll_EndDateTime,BobbinID,ID_Process) " +
                                        "VALUES (@PROD, @DSYSL,@LTOT,@DAW,@DCDATE,@EDATE,@DBOB, @HisId)";
                            MySqlCommand cmd8 = new MySqlCommand(cmdText8, DBCon);
                            cmd8.Parameters.AddWithValue("@PROD", ProducID);
                            cmd8.Parameters.AddWithValue("@DSYSL", Dvalue);
                            cmd8.Parameters.AddWithValue("@LTOT", 1);
                            cmd8.Parameters.AddWithValue("@DAW", 0);
                            cmd8.Parameters.AddWithValue("@EDATE", cGF.getCurrentDateTimeIST(true, false, false));
                            cmd8.Parameters.AddWithValue("@DCDATE", cGF.getCurrentDateTimeIST(true, false, false));
                            cmd8.Parameters.AddWithValue("@DBOB", Dtype);
                            cmd8.Parameters.AddWithValue("@HisId", HisID);
                            cmd8.ExecuteNonQuery();
                        }

                    }

                }


                Console.WriteLine("Inserting Data Successfully");
            }


        }

    }
}



