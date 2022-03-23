using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DataBaseServer_Conection
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Server=LAPTOP-J8NQSAO4;DataBase=PracticeDB;Integrated Security =true");
        }
        public DataSet GetAllEmployess()
        {
            //select query which returns all records
            da = new SqlDataAdapter("select * from Employee", con);
            //MissingSchemaAction is used to set PK to the col which we have added in dataset.
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Emp");//name given to the table which is in the dataset
            return ds;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            try
            {
                //string qry = "select MAX(Id) from Employee";
                //scb = new SqlCommandBuilder();
                //con.Open();
                //object obj = scb.ExecuteScalar();
                //// DBNullis used to check existance of value in the obj
                //if (obj == DBNull.Value)
                //{
                //    txtId.Text = "1";
                //}
                //else

                //{
                //    int id = Convert.ToInt32(obj);//will get the MAX Id from employee
                //    id++;
                //    txtId.Text = id.ToString();

                //}
                //txtId.Enabled = false;//now textbox value cannot 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployess();
                // insert new record
                DataRow row = ds.Tables["Emp"].NewRow();
                row["Id"] = txtId.Text;
                row["Name"] = txtName.Text;
                row["Designation"] = txtDesignation.Text;
                row["Salary"] = txtSalary.Text;
                ds.Tables["Emp"].Rows.Add(row);
                int result = da.Update(ds.Tables["Emp"]); // this will reflect the changes in to the DB
                if (result == 1)
                {
                    MessageBox.Show("Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetAllEmployess();
                // insert new record
                //Id -PK  we can use Find()
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));
                if (row != null)
                {
                    txtId.Text = row["Id"].ToString();
                    txtName.Text = row["Name"].ToString();
                    txtDesignation.Text = row["Designation"].ToString();
                    txtSalary.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployess();
                // insert new record
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));

                row["Name"] = txtName.Text;
                row["Designation"] = txtDesignation.Text;
                row["Salary"] = txtSalary.Text;

                int result = da.Update(ds.Tables["Emp"]); // this will reflect the changes in to the DB
                if (result == 1)
                {
                    MessageBox.Show("updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployess();
                // insert new record
                DataRow row = ds.Tables["Emp"].Rows.Find(Convert.ToInt32(txtId.Text));
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["Emp"]); // this will reflect the changes in to the DB
                    if (result == 1)
                    {
                        MessageBox.Show("deleted");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

