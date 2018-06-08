using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CopyBD
{
    public partial class CopyDBList : Form
    {
        public CopyDBList()
        {
            InitializeComponent();
        }

        private void refreshBDListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxSrvrName.Text.Length!=0)
                { 
                    listBoxBDForCopy.Items.Clear();
                    listBoxBDOnSrvr.Items.Clear();

                    SqlConnection refreshCon = new SqlConnection($@"Data Source = {textBoxSrvrName.Text}; Initial Catalog = master; Integrated Security = true;");
                    SqlCommand refreshCmd = new SqlCommand("SELECT * FROM sysdatabases WHERE name NOT IN ('master','tempdb','model','msdb','ReportServer$MSSQL','ReportServer$MSSQLTempDB') ORDER BY name", refreshCon);
                    refreshCon.Open();

                    SqlDataReader reader = refreshCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listBoxBDOnSrvr.Items.Add(reader[0]);
                    }
                
                    reader.Close();
                    refreshCon.Close();
                }
                else
                {
                MessageBox.Show("Пожалуйста, заполните имя сервера");
            }
        }
            catch (Exception)
            {

                MessageBox.Show("Сервер с таким именем не существует или недоступен!");
            }
        }

        private void ToBtn_Click(object sender, EventArgs e)
        {
            if (listBoxBDOnSrvr.SelectedItem!=null)
            {
                int selectedindex = listBoxBDOnSrvr.SelectedIndex;
                var selected = listBoxBDOnSrvr.SelectedItem;
                listBoxBDForCopy.Items.Add(selected);
                listBoxBDOnSrvr.Items.Remove(selected);
                if (listBoxBDOnSrvr.Items.Count > 0)
                {
                    if (selectedindex != listBoxBDOnSrvr.Items.Count )
                    {
                        listBoxBDOnSrvr.SetSelected(selectedindex, true);

                    }
                    else
                    {
                        listBoxBDOnSrvr.SetSelected(--selectedindex, true);
                    }
                }
            }

        }

        private void listBoxBDOnSrvr_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listBoxBDForCopy.SelectedItem!= null)
            {
                int selectedindex = listBoxBDForCopy.SelectedIndex;

                var selected = listBoxBDForCopy.SelectedItem;
                listBoxBDOnSrvr.Items.Add(selected);
                listBoxBDForCopy.Items.Remove(selected);
                if (listBoxBDForCopy.Items.Count > 0)
                {
                    if (selectedindex != listBoxBDForCopy.Items.Count)
                    {
                        listBoxBDForCopy.SetSelected(selectedindex, true);

                    }
                    else
                    {
                        listBoxBDForCopy.SetSelected(--selectedindex, true);
                    }
                }

            }
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSrvrName.Text.Length != 0)
                {
                    if (postfixTxt.Text.Length !=0 )
                    {
                        foreach (var item in listBoxBDForCopy.Items)
                        {
                            SqlConnection connection = new SqlConnection($"Data Source = {textBoxSrvrName.Text}; Initial Catalog = {item.ToString()}; Integrated Security = true");

                            connection.Open();

                            SqlCommand backup = new SqlCommand(
                                $@"USE master BACKUP DATABASE [{item.ToString()}] TO  DISK = N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\Backup\{item.ToString()}.bak' WITH NOFORMAT, NOINIT,  NAME = N'{item.ToString()}-Полная База данных Резервное копирование', SKIP, NOREWIND, NOUNLOAD,  STATS = 10",
                                connection);
                            backup.ExecuteNonQuery();

                            SqlCommand restore = new SqlCommand(
                                $@"USE master RESTORE DATABASE [{item.ToString() + postfixTxt.Text}] FROM DISK = N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\Backup\{item.ToString()}.bak' WITH  MOVE N'{item.ToString()}' TO N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\DATA\{item.ToString() + postfixTxt.Text}.mdf',  MOVE N'{item.ToString()}_log' TO N'D:\Microsoft SQL Server\MSSQL13.MSSQL\MSSQL\DATA\{item.ToString() + postfixTxt.Text}.ldf',  NOUNLOAD,  STATS = 5",
                                connection);
                            restore.ExecuteNonQuery();

                            connection.Close();
                        }
                        listBoxBDForCopy.Items.Clear();
                        MessageBox.Show("Готово!");
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите постфикс");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, заполните имя сервера");
                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Сервер с таким именем не существует или недоступен!");
            }

        }
    }
}
