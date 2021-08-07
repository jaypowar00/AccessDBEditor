using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace AccessDBEditor
{
    public partial class AccessDBEditor : Form
    {
        OleDbConnection con = new OleDbConnection();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        bool connected = false;
        string TableName = "";
        string OpenedTableName = "";
        public AccessDBEditor()
        {
            InitializeComponent();
            col_type_listview.Items.Add("Text").Selected = true;
            col_type_listview.Items.Add("Number");
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select .mdb Access File";
            openFileDialog.Filter = "Access mdb Files (*.mdb)|*.mdb";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                filepath_tb.Text = openFileDialog.FileName;
                open_btn.Enabled = true;
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+filepath_tb.Text;
            try
            {
                con.Open();
                connected = true;
                open_btn.Enabled = false;
                close_btn.Enabled = true;
                button1.Enabled = true;
                col_type_listview.Enabled = true;
                open_table_btn.Enabled = true;
                create_table_btn.Enabled = true;
                add_col_btn.Enabled = true;
                del_col_btn.Enabled = true;
                tablegridview_refresh_btn.Enabled = true;
                del_table_btn.Enabled = true;
                table_listview.Enabled = true;
                column_name_tb.Enabled = true;
                table_name_tb.Enabled = true;
                table_gridview.Enabled = true;
                string[] restrictions = new string[4];
                restrictions[3] = "Table";
                DataTable userTables = con.GetSchema("Tables", restrictions);
                foreach( DataRow row in userTables.Rows)
                    table_listview.Items.Add(row["TABLE_NAME"].ToString());
            }
            catch (OleDbException ex)
            {
                connected = false;
                MessageBox.Show(this, "DB not connected!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
            }catch(OleDbException)
            {
                MessageBox.Show(this, "Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            close_btn.Enabled = false;
            open_btn.Enabled = true;
            button1.Enabled = false;
            col_type_listview.Enabled = false;
            open_table_btn.Enabled = false;
            create_table_btn.Enabled = false;
            add_col_btn.Enabled = false;
            del_col_btn.Enabled = false;
            tablegridview_refresh_btn.Enabled = false;
            del_table_btn.Enabled = false;
            table_listview.Enabled = false;
            column_name_tb.Enabled = false;
            table_name_tb.Enabled = false;
            table_gridview.Enabled = false;
            table_listview.SelectedItems.Clear();
            table_listview.Clear();
        }

        private void create_table_btn_Click(object sender, EventArgs e)
        {
            if (table_name_tb.Text != "")
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "CREATE TABLE "+table_name_tb.Text+" ([ID] Number);";
                    cmd.ExecuteNonQuery();
                    table_listview.Clear();
                    string[] restrictions = new string[4];
                    restrictions[3] = "Table";
                    DataTable userTables = con.GetSchema("Tables", restrictions);
                    foreach (DataRow row in userTables.Rows)
                        table_listview.Items.Add(row["TABLE_NAME"].ToString());
                }
                catch(OleDbException ex)
                {
                    MessageBox.Show(this, "Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_listview.Clear();
            string[] restrictions = new string[4];
            restrictions[3] = "Table";
            DataTable userTables = con.GetSchema("Tables", restrictions);
            foreach (DataRow row in userTables.Rows)
                table_listview.Items.Add(row["TABLE_NAME"].ToString());
        }

        private void open_table_btn_Click(object sender, EventArgs e)
        {
            int c = table_listview.SelectedItems.Count;
            if (c > 1 || c==0)
            {
                MessageBox.Show(this, "Please (only) select one Table from Tables list!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    TableName = table_listview.SelectedItems[0].Text;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM "+TableName+";";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    table_gridview.DataSource = dt;
                    OpenedTableName = TableName;
                }catch(OleDbException ex)
                {
                    string msg = ex.Message;
                    if (msg == "Query must have at least one destination field.")
                    {
                        msg = "The Table is successfully Opened but it is Empty!\nPlease add atleast one column before using this table in your program!";
                        table_gridview.DataSource = null;
                    }
                    MessageBox.Show(this, "Error!\n" + msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_col_btn_Click(object sender, EventArgs e)
        {
            if (OpenedTableName != "")
            {
                if (column_name_tb.Text != "")
                {
                    if(col_type_listview.SelectedItems.Count>1 || col_type_listview.SelectedItems.Count == 0)
                    {
                        MessageBox.Show(this, "Please select a Column Type!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            string colname = column_name_tb.Text;
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "ALTER TABLE "+TableName+" ADD COLUMN "+colname+" "+col_type_listview.SelectedItems[0].Text+";";
                            cmd.ExecuteNonQuery();
                            tablegridview_refresh_btn_Click(sender, e);
                        }catch(Exception ex)
                        {
                            MessageBox.Show(this, "Error!\n"+ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please Enter Column Name!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Please open a table first!");
            }
        }

        private void tablegridview_refresh_btn_Click(object sender, EventArgs e)
        {
            if (connected && OpenedTableName!="")
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM "+TableName+";";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    table_gridview.DataSource = dt;
                }catch(OleDbException ex)
                {
                    string msg = ex.Message;
                    if(msg=="Query must have at least one destination field.")
                    {
                        msg = "The Table is successfully Opened but it is Empty\nPlease add atleast one column before using this table in your program!";
                        table_gridview.DataSource = null;
                    }
                    MessageBox.Show(this, "Error!\n"+msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void del_col_btn_Click(object sender, EventArgs e)
        {
            if (OpenedTableName!="")
            {
                if (column_name_tb.Text != "")
                {
                    try
                    {
                        string colname = column_name_tb.Text;
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "ALTER TABLE " + TableName + " DROP COLUMN " + colname + ";";
                        cmd.ExecuteNonQuery();
                        tablegridview_refresh_btn_Click(sender, e);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(this, "Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Column Name!");
                }
            }
            else
            {
                MessageBox.Show("Please open a table first!");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "This software is made by Jay Powar (RedRanger).\n\n" +
                            "This software is used to open .mdb Access Database Files and CREATE/DELETE User Defined Tables and ADD/DELETE COLUMNS\n" +
                            "This software might not work in all Windows Machine!\n\n" +
                            "Thank You For using AccessDBEditor software!";
            MessageBox.Show(this, about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void del_table_btn_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                if(table_listview.SelectedItems.Count > 1 || table_listview.SelectedItems.Count == 0)
                {
                    MessageBox.Show(this,"Please select (only one) Table from Table list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        TableName = table_listview.SelectedItems[0].Text;
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "DROP TABLE "+TableName+";";
                        cmd.ExecuteNonQuery();
                        button1_Click(sender, e);
                        if (TableName.Equals(OpenedTableName))
                        {
                            OpenedTableName = TableName = "";
                            table_gridview.DataSource = null;
                        }
                    }catch(OleDbException ex)
                    {
                        MessageBox.Show(this, "Error!\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void createNewmdbFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Stream reader = asm.GetManifestResourceStream("DBWinFormDemo1.File.dbfilename.mdb");
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".mdb";
            saveFile.AddExtension = true;
            saveFile.Filter = "MS Access mdb File (*.mdb)|*.mdb";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                Stream file = saveFile.OpenFile();
                reader.CopyTo(file);
                reader.Close();
                file.Close();
                filepath_tb.Text = saveFile.FileName;
                open_btn.Enabled = true;
            }

        }
    }
}
