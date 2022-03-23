using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADONetDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Server=LAPTOP-J8NQSAO4;DataBase=PracticeDB;Integrated Security =true");
        }
        private void ClearData()
        {
            txtId.Clear();
            txtName.Clear();
            txtDesignation.Clear();
            txtSalary.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //To pas values into the insert query we will use parameters (parametric query)
                string qry = "insert into Employee Values(@id,@name,@designation,@salary)";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@designation", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully saved the record");
                    ClearData();
                }
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
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select MAX(Id) from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                // DBNullis used to check existance of value in the obj
                if (obj == DBNull.Value)
                {
                    txtId.Text = "1";
                }
                else

                {
                    int id = Convert.ToInt32(obj);//will get the MAX Id from employee
                    id++;
                    txtId.Text = id.ToString();

                }
                txtId.Enabled = false;//now textbox value cannot 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearData();
            }
            finally
            {
                con.Close();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //To pas values into the insert query we will use parameters (parametric query)
                string qry = "update Employee set Name=@name,Designation=@designation,Salary=@salary where Id=@id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@designation", txtDesignation.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtSalary.Text));
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully Update the record");
                    ClearData();
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select*from Employee where Id = @id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                dr = cmd.ExecuteReader();
                //first will check that record is present
                if (dr.HasRows)
                {
                    //read the record from dr obj
                    if (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtDesignation.Text = dr["Designation"].ToString();
                        txtSalary.Text = dr["Salary"].ToString();

                    }
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
            finally
            {
                con.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //To pas values into the insert query we will use parameters (parametric query)
                string qry = "delete from Employee where Id=@id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully delete the record");
                    ClearData();
                }
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

    }
}
