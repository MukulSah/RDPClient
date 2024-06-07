using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RDPClientApplication
{
    class DatabaseConnection
    {
        public static SqlConnection conn;

        public static bool connect()
        {
            try
            {
                string connectionString;
                connectionString = @"Data Source=103.171.44.124,1533;Initial Catalog=aananda_macotest;User ID=sa;Password=maco@123;MultipleActiveResultSets=true;";
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static List<Software> ReadSoftwareList()
        {
            List<Software> softwares = new List<Software>();
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("read_software_details", conn);
                sql_cmnd.Parameters.AddWithValue("@processorid", StartUp.client.processorId);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Software sft = new Software();
                        sft.name = (string)((dr["name"] == DBNull.Value) ? "" : dr["name"].ToString());
                        softwares.Add(sft);
                    }
                    
                    
                }
                else
                {
                    //read software details and save it to database
                }
                
                return softwares;
            }
            catch(Exception ex)
            {
                return softwares;
            }
        }

        internal static void SaveBiosDetails(BIOSInfo info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_bios_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@buildnumber", info.BuildNumber);
                cmd.Parameters.AddWithValue("@caption", info.Caption);
                cmd.Parameters.AddWithValue("@codeset", info.CodeSet);
                cmd.Parameters.AddWithValue("@currentlanguage", info.CurrentLanguage);
                cmd.Parameters.AddWithValue("@description", info.Description);
                cmd.Parameters.AddWithValue("@embeddedcontrolmajorversion", info.EmbeddedControllerMajorVersion);
                cmd.Parameters.AddWithValue("@embeddedcontrolminorversion", info.EmbeddedControllerMinorVersion);
                cmd.Parameters.AddWithValue("@identificationcode", info.IdentificationCode);
                cmd.Parameters.AddWithValue("@installablelanguages", info.InstallableLanguages);
                cmd.Parameters.AddWithValue("@installdate", info.InstallDate);
                cmd.Parameters.AddWithValue("@languageedition", info.LanguageEdition);
                cmd.Parameters.AddWithValue("@manufacturer", info.Manufacturer);
                cmd.Parameters.AddWithValue("@name", info.Name);
                cmd.Parameters.AddWithValue("@primarybios", info.PrimaryBIOS);
                cmd.Parameters.AddWithValue("@serialnumber", info.SerialNumber);
                cmd.Parameters.AddWithValue("@smbiosmajorversion", info.SMBIOSMajorVersion);
                cmd.Parameters.AddWithValue("@smbiosminorversion", info.SMBIOSMinorVersion);
                cmd.Parameters.AddWithValue("@smbiospresent", info.SMBIOSPresent);
                cmd.Parameters.AddWithValue("@status", info.Status);
                cmd.Parameters.AddWithValue("@systembiosmajorversion", info.SystemBiosMajorVersion);
                cmd.Parameters.AddWithValue("@systembiosminorversion", info.SystemBiosMinorVersion);
                cmd.Parameters.AddWithValue("@targetoperatingsystem", info.TargetOperatingSystem);
                cmd.Parameters.AddWithValue("@processorid", StartUp.client.processorId); cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }

        internal static List<Software> ReadServerSoftware()
        {
            SqlCommand sql_cmnd = new SqlCommand("read_server_software", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
            da.Fill(dt);
            List<Software> list = new List<Software>();
            foreach (DataRow dr in dt.Rows)
            {
             
                Software sft = new Software();
                sft.downloadLink = (dr["downloadlink"] == DBNull.Value) ? "" : (string)dr["downloadlink"].ToString();
                
                sft.licenseId = (int)((dr["licenseid"] == DBNull.Value) ? 0 : dr["licenseid"]);
                sft.licenseVersion = (dr["licenseversion"] == DBNull.Value) ? "" : (string)dr["licenseversion"].ToString();
                sft.serverProcessorId = (dr["serverprocessorid"] == DBNull.Value) ? "" : (string)dr["serverprocessorid"].ToString();
                sft.targetMachine = (dr["targetmachine"] == DBNull.Value) ? "" : (string)dr["targetmachine"].ToString();
                sft.name = (dr["softwarename"] == DBNull.Value) ? "" : (string)dr["softwarename"].ToString();
                sft.licenseKey = (dr["licensekey"] == DBNull.Value) ? "" : (string)dr["licensekey"].ToString();
                sft.softwareVersion = (dr["version"] == DBNull.Value) ? "" : (string)dr["version"].ToString();
                sft.usersleft = (int)((dr["usersleft"] == DBNull.Value) ? 0 : dr["usersleft"]);
                sft.licenseValidatedFor = (int)((dr["timeactivated"] == DBNull.Value) ? 0 : dr["timeactivated"]);
                sft.totalusers = (int)((dr["totalusers"] == DBNull.Value) ? 0 : dr["totalusers"]);
                sft.usersleft = (int)((dr["usersleft"] == DBNull.Value) ? 0 : dr["usersleft"]);
                sft.licenseExpireDate = (DateTime)((dr["expiredate"] == DBNull.Value) ? 0 : dr["expiredate"]);
                sft.softwareId = (int)((dr["softwareid"] == DBNull.Value) ? 0 : dr["softwareid"]);

                list.Add(sft);
                

            }
            return list;
        }

        internal static bool UpdateLicenseDetails(License updatedDetails)
        {
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("update_license_details", conn);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = updatedDetails.processorid;
                sql_cmnd.Parameters.AddWithValue("@licensekey", SqlDbType.NVarChar).Value = updatedDetails.key;
                sql_cmnd.Parameters.AddWithValue("@softwarename", SqlDbType.NVarChar).Value = updatedDetails.softwareName;
                sql_cmnd.Parameters.AddWithValue("@totaluser", SqlDbType.NVarChar).Value = updatedDetails.totalUsers;
                sql_cmnd.Parameters.AddWithValue("@usersassigned", SqlDbType.NVarChar).Value = updatedDetails.usersAssigned;

                sql_cmnd.Parameters.AddWithValue("@expiredate ", SqlDbType.DateTime
                    ).Value = updatedDetails.expireDate;
                sql_cmnd.Parameters.AddWithValue("@version ", SqlDbType.NVarChar
                    ).Value = updatedDetails.version;
                sql_cmnd.Parameters.AddWithValue("@timeactivated ", SqlDbType.NVarChar
                   ).Value = updatedDetails.timeActivated;
                sql_cmnd.Parameters.AddWithValue("@installdate ", SqlDbType.DateTime
                   ).Value = updatedDetails.installDate;
                sql_cmnd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        internal static Dictionary<string, int> ReadUsbPortsStatus(string processorId)
        {
            SqlCommand sql_cmnd = new SqlCommand("read_client_all_status", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("clientprocessorid", processorId);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
            da.Fill(dt);
            Dictionary<string, int> clientStatus = new Dictionary<string, int>();
            foreach (DataRow dr in dt.Rows)
            {
                int usbportsstatus = (int)((dr["usbports"] == DBNull.Value) ? 0 : dr["usbports"]);


                clientStatus.Add("usb", usbportsstatus);


            }
            return clientStatus;
        }

        internal static void SaveProcessorDetails(ProcessorInfo info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_processor_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@addresswidth", info.AddressWidth);
                cmd.Parameters.AddWithValue("@architecture", info.Architechure);
                cmd.Parameters.AddWithValue("@assettag", info.AssetTag);
                cmd.Parameters.AddWithValue("@availaibility", info.Availability);
                cmd.Parameters.AddWithValue("@caption", info.Caption);
                cmd.Parameters.AddWithValue("@cpustatus", info.CPUStatus);
                cmd.Parameters.AddWithValue("@currentclockspeed", info.CurrentClockSpeed);
                cmd.Parameters.AddWithValue("@deviceid", info.DeviceID);
                cmd.Parameters.AddWithValue("@currentvoltage", info.CurrentVoltage);
                cmd.Parameters.AddWithValue("@installdate", info.InstallDate);
                cmd.Parameters.AddWithValue("@l2cachesize", info.L2CacheSize);
                cmd.Parameters.AddWithValue("@l2cachespeed", info.L2CacheSpeed);
                cmd.Parameters.AddWithValue("@l3cachesize", info.L3CacheSize);
                cmd.Parameters.AddWithValue("@l3cachespeed", info.L3CacheSpeed);
                cmd.Parameters.AddWithValue("@manufacturer", info.Manufacturer);
                cmd.Parameters.AddWithValue("@maxclockspeed", info.MaxClockSpeed);
                cmd.Parameters.AddWithValue("@processorname", info.Name);
                cmd.Parameters.AddWithValue("@noofcores", info.NumberOfCores);
                cmd.Parameters.AddWithValue("@noofenabledcored", info.NumberOfEnabledCore);
                cmd.Parameters.AddWithValue("@nooflogicalprocessors", info.NumberOfLogicalProcessors);
                cmd.Parameters.AddWithValue("@processorid", info.ProcessorId);
                cmd.Parameters.AddWithValue("@type", info.ProcessorType); cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
               
            }
        }

        internal static bool InsertHardwareDetails(HardwareInfo info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_hardware_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@processd", info.processorid);
                cmd.Parameters.AddWithValue("@hdd", info.hddSerialNo);
                cmd.Parameters.AddWithValue("@boardmaker", info.boardMaker);
                cmd.Parameters.AddWithValue("@physicalmemory", info.physicalMemory);
                cmd.Parameters.AddWithValue("@biosmaker", info.biosMaker);
                cmd.Parameters.AddWithValue("@cpuspeed", info.cpuSpeed);
                cmd.Parameters.AddWithValue("@cpumaker", info.cpuMaker);
                cmd.Parameters.AddWithValue("@newmac", info.macId);
                cmd.Parameters.AddWithValue("@newdes", info.desktopName);
                cmd.Parameters.AddWithValue("@RamMemory", info.ramMemory);
                cmd.Parameters.AddWithValue("@curdt", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        internal static void SaveSoftwareDetails(Software sft)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_software_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", sft.name);
                cmd.Parameters.AddWithValue("@desc", sft.installationSource);
                cmd.Parameters.AddWithValue("@instloc", sft.installationLocation);
                cmd.Parameters.AddWithValue("@date", sft.installationDate);
                cmd.Parameters.AddWithValue("@productid", sft.softwareSize);
                cmd.Parameters.AddWithValue("@vendor", sft.language);
                cmd.Parameters.AddWithValue("@version", sft.softwareVersion);
                cmd.Parameters.AddWithValue("@processorid", sft.processorId);
                cmd.Parameters.AddWithValue("@desktop", sft.desktopName);
                cmd.Parameters.AddWithValue("@expirydate", sft.expiryDate);
                cmd.Parameters.AddWithValue("@curdt", DateTime.Now.ToString());

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                
            }
        }

        internal static void SaveMotherboardDetails(MotherboardInfo info)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_motherboard_details", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@avaialability", info.Availability);
                cmd.Parameters.AddWithValue("@caption", info.Caption);
                cmd.Parameters.AddWithValue("@configmanagererrorcode", info.ConfigManagerErrorCode);
                cmd.Parameters.AddWithValue("@configmanageruserconfig", info.ConfigManagerUserConfig);
                cmd.Parameters.AddWithValue("@description", info.Description);
                cmd.Parameters.AddWithValue("@deviceid", info.DeviceID);
                cmd.Parameters.AddWithValue("@installdate", info.InstallDate);
                cmd.Parameters.AddWithValue("@name", info.Name);
                cmd.Parameters.AddWithValue("@powermanagementcapabilities", info.PowerManagementCapabilities);
                cmd.Parameters.AddWithValue("@powermanagementsupported", info.PowerManagementSupported);
                cmd.Parameters.AddWithValue("@primarybustype", info.PrimaryBusType);
                cmd.Parameters.AddWithValue("@revisionnumber", info.RevisionNumber);
                cmd.Parameters.AddWithValue("@secondarybustype", info.SecondaryBusType);
                cmd.Parameters.AddWithValue("@status", info.Status);
                cmd.Parameters.AddWithValue("@depth", info.Depth);
                cmd.Parameters.AddWithValue("@height", info.Height);
                cmd.Parameters.AddWithValue("@hostingboard", info.HostingBoard);
                cmd.Parameters.AddWithValue("@hotswappable", info.HotSwappable);
                cmd.Parameters.AddWithValue("@manufacturer", info.Manufacturer);
                cmd.Parameters.AddWithValue("@model", info.Model);
                cmd.Parameters.AddWithValue("@partnumber", info.PartNumber); 
                cmd.Parameters.AddWithValue("@poweredon", info.PoweredOn); 
                cmd.Parameters.AddWithValue("@product", info.Product); 
                cmd.Parameters.AddWithValue("@removable", info.Removable); 
                cmd.Parameters.AddWithValue("@requirementsdescription", info.RequirementsDescription); 
                cmd.Parameters.AddWithValue("@requiresdaugterboard", info.RequiresDaughterBoard);
                cmd.Parameters.AddWithValue("@serialnumber", info.SerialNumber); 
                cmd.Parameters.AddWithValue("@sku", info.SKU); 
                cmd.Parameters.AddWithValue("@slotlayout", info.SlotLayout); 
                cmd.Parameters.AddWithValue("@tag", info.Tag);
                cmd.Parameters.AddWithValue("@weight", info.Weight); 
                cmd.Parameters.AddWithValue("@width", info.Width); 
                cmd.Parameters.AddWithValue("@processorid", StartUp.client.processorId); cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }

        internal static void DeleteClipboardData(string serverprocessorid, string clientprocessorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("delete_clipboard_copy_file", conn);
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = clientprocessorid;
            sql_cmnd.Parameters.AddWithValue("@serverprocessorid", SqlDbType.NVarChar).Value = serverprocessorid;
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.ExecuteNonQuery();
        }

        internal static bool SaveUnauthorizedSoftwareInstallCount(string processorId, string fileDescription)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert_unauthorized_software_install_Count", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clientprocessorid", processorId);
                cmd.Parameters.AddWithValue("@filedescription", fileDescription);
               
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal static List<string> ReadUnauthorizedInstallSoftware()
        {
            List<string> list = new List<string>();
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("read_unauthorized_software_install", conn);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    string desc = (dr["softwaredescription"] == DBNull.Value) ? "" : (string)dr["softwaredescription"].ToString();
                    
                    list.Add(desc);
                }
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }

        public static void disconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static ClientUpdates InsertOrUpdateClient(string processorid,string devicename, string ipadress) 
        {
            SqlCommand sql_cmnd = new SqlCommand("client_timer_updates", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = processorid;
            sql_cmnd.Parameters.AddWithValue("@devicename", SqlDbType.NVarChar).Value = devicename;
            sql_cmnd.Parameters.AddWithValue("@ipaddress", SqlDbType.NVarChar).Value = ipadress;
            SqlDataAdapter sda = new SqlDataAdapter(sql_cmnd);
            DataSet ds = new DataSet();       
            sda.Fill(ds);  
            ClientUpdates clientUpdates = new ClientUpdates();
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                clientUpdates.client.clientId  = (dr["clientid"] == DBNull.Value) ? "" : (string)dr["clientid"].ToString();
                clientUpdates.client.processorId = (dr["processorid"] == DBNull.Value) ? "" : (string)dr["processorid"].ToString();
                clientUpdates.client.name = (dr["devicename"] == DBNull.Value) ? "" : (string)dr["devicename"].ToString();
                clientUpdates.client.agentStatus = (dr["agentstatus"] == DBNull.Value) ? "" : (string)dr["agentstatus"].ToString();
                clientUpdates.client.ipaddress = (dr["ipaddress"] == DBNull.Value) ? "" : (string)dr["ipaddress"].ToString();
                
            }
           
            foreach (DataRow dr in ds.Tables[1].Rows)
            {

                Software sft = new Software();
                sft.downloadLink = (dr["downloadlink"] == DBNull.Value) ? "" : (string)dr["downloadlink"].ToString();

                sft.licenseId = (int)((dr["licenseid"] == DBNull.Value) ? 0 : dr["licenseid"]);
                sft.licenseVersion = (dr["licenseversion"] == DBNull.Value) ? "" : (string)dr["licenseversion"].ToString();
                sft.serverProcessorId = (dr["serverprocessorid"] == DBNull.Value) ? "" : (string)dr["serverprocessorid"].ToString();
                sft.targetMachine = (dr["targetmachine"] == DBNull.Value) ? "" : (string)dr["targetmachine"].ToString();
                sft.name = (dr["softwarename"] == DBNull.Value) ? "" : (string)dr["softwarename"].ToString();
                sft.licenseKey = (dr["licensekey"] == DBNull.Value) ? "" : (string)dr["licensekey"].ToString();
                sft.softwareVersion = (dr["version"] == DBNull.Value) ? "" : (string)dr["version"].ToString();
                sft.usersleft = (int)((dr["usersleft"] == DBNull.Value) ? 0 : dr["usersleft"]);
                sft.licenseValidatedFor = (int)((dr["timeactivated"] == DBNull.Value) ? 0 : dr["timeactivated"]);
                sft.totalusers = (int)((dr["totalusers"] == DBNull.Value) ? 0 : dr["totalusers"]);
                sft.usersleft = (int)((dr["usersleft"] == DBNull.Value) ? 0 : dr["usersleft"]);
                sft.licenseExpireDate = (DateTime)((dr["expiredate"] == DBNull.Value) ? 0 : dr["expiredate"]);
                sft.softwareId = (int)((dr["softwareid"] == DBNull.Value) ? 0 : dr["softwareid"]);

                clientUpdates.insatllationRequestSoftwares.Add(sft);


            }

            
            foreach (DataRow dr in ds.Tables[2].Rows)
            {
                Software sft = new Software();
                sft.name = (dr["softwarename"] == DBNull.Value) ? "" : (string)dr["softwarename"].ToString();
                sft.softwareVersion = (dr["softwareversion"] == DBNull.Value) ? "" : (string)dr["softwareversion"].ToString();
                sft.softwareExe = (dr["softwareexe"] == DBNull.Value) ? "" : (string)dr["softwareexe"].ToString();
                clientUpdates.unauthorizedSoftwares.Add(sft);
            }
            return clientUpdates;
        }

        internal static void MinimizeScreen(string serverprocessorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("insert_minimize_for_server", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@serverprocessorid", SqlDbType.NVarChar).Value = serverprocessorid;
            sql_cmnd.Parameters.AddWithValue("@operation", SqlDbType.NVarChar).Value = "minimize";
            sql_cmnd.Parameters.AddWithValue("@value", SqlDbType.NVarChar).Value = "Yes";
            sql_cmnd.ExecuteNonQuery();
        }

        internal static bool CheckSystemLock(string processorId)
        {
            SqlCommand sql_cmnd = new SqlCommand("check_client_lock_status", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("clientprocessorid", SqlDbType.NVarChar).Value = processorId;
            sql_cmnd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            sql_cmnd.ExecuteNonQuery();
            int retval = (int)sql_cmnd.Parameters["@retValue"].Value;
            return Convert.ToBoolean(retval);
        }

        public static void SaveScreenToDatabase(string base64String, string processorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("insert_image", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("image", SqlDbType.NVarChar).Value = base64String;
            sql_cmnd.Parameters.AddWithValue("@processorid", SqlDbType.NVarChar).Value = processorid;
            sql_cmnd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            sql_cmnd.ExecuteNonQuery();
            int retval = (int)sql_cmnd.Parameters["@retValue"].Value;
            //Console.WriteLine(processorid + " - " + retval);

        }

        public static List<string> IsAnyServerRequestAvailable(string processorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("check_any_server_request", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("processorid", SqlDbType.NVarChar).Value = processorid;
            sql_cmnd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            sql_cmnd.ExecuteNonQuery();
            int retval = (int)sql_cmnd.Parameters["@retValue"].Value;
            List<string> serverDetails = null;

            if (retval == 1)
            {
                serverDetails = new List<string>();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    serverDetails.Add((dr["devicename"] == DBNull.Value) ? "" : (string)dr["devicename"].ToString());
                    serverDetails.Add((dr["processorid"] == DBNull.Value) ? "" : (string)dr["processorid"].ToString());
                    return serverDetails;
                }

            }
            return serverDetails;
        }

        internal static void StopClient(string processorId, string serverprocessorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("stop_client", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = processorId;
            if(serverprocessorid == null)
            {
                sql_cmnd.Parameters.AddWithValue("@serverprocessorid", System.Data.SqlDbType.NVarChar).Value = DBNull.Value;
            }
            else
            {

                sql_cmnd.Parameters.AddWithValue("@serverprocessorid", System.Data.SqlDbType.NVarChar).Value = serverprocessorid;
            }
          
            
            sql_cmnd.ExecuteNonQuery();
        }

        internal static void SoftwareInstallationRequestSuccessful(string status)
        {
            SqlCommand sql_cmnd = new SqlCommand("update_software_installation_request", conn);
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", StartUp.client.processorId);
            sql_cmnd.Parameters.AddWithValue("@status", status);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.ExecuteNonQuery();
        }

        internal static List<Software> ReadSoftwareInstallationRequest()
        {
            SqlCommand sql_cmnd = new SqlCommand("read_software_installation_request", conn);
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", StartUp.client.processorId);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
            da.Fill(dt);
            List<Software> list = new List<Software>();
            foreach (DataRow dr in dt.Rows)
            {

                Software sft = new Software();
                sft.downloadLink = (dr["downloadlink"] == DBNull.Value) ? "" : (string)dr["downloadlink"].ToString();

                sft.licenseId = (int)((dr["licenseid"] == DBNull.Value) ? 0 : dr["licenseid"]);
                sft.licenseVersion = (dr["licenseversion"] == DBNull.Value) ? "" : (string)dr["licenseversion"].ToString();
                sft.serverProcessorId = (dr["serverprocessorid"] == DBNull.Value) ? "" : (string)dr["serverprocessorid"].ToString();
                sft.targetMachine = (dr["targetmachine"] == DBNull.Value) ? "" : (string)dr["targetmachine"].ToString();
                sft.name = (dr["softwarename"] == DBNull.Value) ? "" : (string)dr["softwarename"].ToString();
                sft.licenseKey = (dr["licensekey"] == DBNull.Value) ? "" : (string)dr["licensekey"].ToString();
                sft.softwareVersion = (dr["version"] == DBNull.Value) ? "" : (string)dr["version"].ToString();
                sft.usersleft = (int)((dr["usersleft"] == DBNull.Value) ? 0 : dr["usersleft"]);
                sft.licenseValidatedFor = (int)((dr["timeactivated"] == DBNull.Value) ? 0 : dr["timeactivated"]);
                sft.totalusers = (int)((dr["totalusers"] == DBNull.Value) ? 0 : dr["totalusers"]);
                sft.usersleft = (int)((dr["usersleft"] == DBNull.Value) ? 0 : dr["usersleft"]);
                sft.licenseExpireDate = (DateTime)((dr["expiredate"] == DBNull.Value) ? 0 : dr["expiredate"]);
                sft.softwareId = (int)((dr["softwareid"] == DBNull.Value) ? 0 : dr["softwareid"]);

                list.Add(sft);


            }
            return list;
        }

        internal static void InsertOrUpadteSoftwareDownloadFromServer(Software sft, string status)
        {

            SqlCommand sql_cmnd = new SqlCommand("insert_software_download_status_on_client", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@softwareid", SqlDbType.Int).Value = sft.softwareId;
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = StartUp.client.processorId;
            sql_cmnd.Parameters.Add("@serverprocessorid", System.Data.SqlDbType.NVarChar).Value = sft.serverProcessorId;
            sql_cmnd.Parameters.Add("@downloadstatus", System.Data.SqlDbType.NVarChar).Value = status;
            sql_cmnd.ExecuteNonQuery();
            
        }

        internal static void SaveUSBStatus(int usbStatus, string clientprocessorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("save_usb_status", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@status", SqlDbType.Int).Value = usbStatus;
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = clientprocessorid;
            sql_cmnd.ExecuteNonQuery();
        }

        internal static void InsertOrUpadteSoftwareInstallFromServer(Software sft, string status)
        {

            SqlCommand sql_cmnd = new SqlCommand("insert_software_install_status_on_client", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("@softwareid", SqlDbType.Int).Value = sft.softwareId;
            sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = StartUp.client.processorId;
            sql_cmnd.Parameters.Add("@installstatus", System.Data.SqlDbType.NVarChar).Value = status;
            sql_cmnd.ExecuteNonQuery();

        }

        internal static List<Software> ReadUnauthorizedSoftwares()
        {
            List<Software> list = new List<Software>();
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("read_unauthorized_software", conn);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Software sft = new Software();
                    sft.name = (dr["softwarename"] == DBNull.Value) ? "" : (string)dr["softwarename"].ToString();
                    sft.softwareVersion = (dr["softwareversion"] == DBNull.Value) ? "" : (string)dr["softwareversion"].ToString();
                    sft.softwareExe = (dr["softwareexe"] == DBNull.Value) ? "" : (string)dr["softwareexe"].ToString();
                    list.Add(sft);
                }
                return list;
            }
            catch (Exception ex)
            {
                return list;
            }
        }

        internal static List<string> ReadClipboardData(string serverprocessorid, string clientprocessorid)
        {
            List<string> copyData = new List<string>();
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("read_clipboard_copy_file", conn);
                sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = clientprocessorid;
                sql_cmnd.Parameters.AddWithValue("@serverprocessorid", SqlDbType.NVarChar).Value = serverprocessorid;
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    copyData.Add((dr["typecopy"] == DBNull.Value) ? "" : (string)dr["typecopy"].ToString());
                   
                    copyData.Add((dr["downloadlink"] == DBNull.Value) ? "" : (string)dr["downloadlink"].ToString());
                    
                    copyData.Add((dr["copytext"] == DBNull.Value) ? "" : (string)dr["copytext"].ToString());
                    copyData.Add((dr["filename"] == DBNull.Value) ? "" : (string)dr["filename"].ToString());
                }
                return copyData;
                
            }
            catch(Exception ex)
            {
                return copyData;
            }
        }

        internal static void SaveClipboardFile(string text, string serverprocessorid, string typecopy, string clientprocessorid)
        {
            try
            {
                SqlCommand sql_cmnd = new SqlCommand("save_clipboard_copy_file", conn);
                sql_cmnd.CommandType = CommandType.StoredProcedure;
                sql_cmnd.Parameters.AddWithValue("@downloadlink", SqlDbType.NVarChar).Value = text;
                sql_cmnd.Parameters.AddWithValue("@serverprocessorid", SqlDbType.NVarChar).Value = serverprocessorid;
                sql_cmnd.Parameters.AddWithValue("@typecopy", SqlDbType.NVarChar).Value = typecopy;
                sql_cmnd.Parameters.AddWithValue("@clientprocessorid", SqlDbType.NVarChar).Value = clientprocessorid;
                sql_cmnd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
        }
        internal static License ReadLicenseDetails(string softwareName, string clientprocessorid)
        {
            SqlCommand sql_cmnd = new SqlCommand("read_license_details", conn);
            sql_cmnd.CommandType = CommandType.StoredProcedure;
            sql_cmnd.Parameters.AddWithValue("clientprocessorid", SqlDbType.NVarChar).Value = clientprocessorid;
            sql_cmnd.Parameters.AddWithValue("softwarename", SqlDbType.NVarChar).Value = softwareName;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_cmnd);
            da.Fill(dt);
            License details = null;
            foreach (DataRow dr in dt.Rows)
            {
                details = new License();
                details.softwareName = (dr["softwarename"] == DBNull.Value) ? "" : (string)dr["softwarename"].ToString();
                details.key = (dr["licensekey"] == DBNull.Value) ? "" : (string)dr["licensekey"].ToString();
                details.version = (dr["version"] == DBNull.Value) ? "" : (string)dr["version"].ToString();
                details.installDate = (DateTime)dr["installdate"];
                details.timeActivated = (dr["timeactivated"] == DBNull.Value) ? "" : (string)dr["timeactivated"].ToString();
                details.totalUsers = (dr["totalusers"] == DBNull.Value) ? "" : (string)dr["totalusers"].ToString();
                details.usersAssigned = (dr["usersassigned"] == DBNull.Value) ? "" : (string)dr["usersassigned"].ToString();
                details.usersLeft = (dr["usersleft"] == DBNull.Value) ? "" : (string)dr["usersleft"].ToString();
                details.expireDate = (DateTime)dr["expiredate"];
                details.processorid = (dr["processorid"] == DBNull.Value) ? "" : (string)dr["processorid"].ToString();
                details.timeActivated = (dr["timeactivated"] == DBNull.Value) ? "" : (string)dr["timeactivated"].ToString();
                details.installDate =
                    (DateTime)dr["installdate"];
            }
            return details;
        }
    }
}
