using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace ClassicAsynch_NewAsynch
{
    public partial class Form1 : Form
    {
        public string? connectionString;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = null;
        SqlConnection connection = null;
        DataTable dataTable = null;

        public Form1()
        {
            InitializeComponent();

            Configure();
        }

        private void Configure()
        {
            var configuration= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            connectionString = configuration.GetConnectionString("SqlServerLibrary");
            connection = new SqlConnection(connectionString);
        }


        private void Btn_Fill_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection(connectionString);
            using SqlCommand command = connection.CreateCommand();

            var commandText = "SELECT * FROM Books;";
            command.CommandText = commandText;
            command.CommandType = CommandType.Text;

            command.CommandTimeout = 30;

            try
            {
                connection.Open();
                AsyncCallback callback = new AsyncCallback(GetDataCallBack);

                command.BeginExecuteReader(callback, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void GetDataCallBack(IAsyncResult result)
        {
            SqlDataReader? dataReader = null;
            try
            {
                using SqlCommand? command = result.AsyncState as SqlCommand;
                dataReader = command?.EndExecuteReader(result);
                dataTable = new DataTable();

                int line = 0;
                do
                {
                    while (dataReader?.Read() ?? false)
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                dataTable.Columns.Add(dataReader.GetName(i));
                            }
                            line++;
                        }

                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            row[i] = dataReader[i];
                        }
                        dataTable.Rows.Add(row);
                    }

                } while (dataReader?.NextResult() ?? false);

                gridView.Invoke(() => gridView.DataSource = dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (dataReader is not null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }
//------------------------------------------------------------------------------------------------------------------------------------


        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dataSet is not null)
                dataAdapter.Update(dataSet);
        }

        

        private void cmbBox_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_Authors.Items is null)
                return;
            try
            {
                var connection = new SqlConnection(connectionString);
                connection?.Open();

                var id = cmbBox_Categories.ToString()?.Split(' ')[0];
                var name = cmbBox_Authors.SelectedItem.ToString();
                using SqlCommand command = new SqlCommand($"SELECT * FROM Books JOIN Categories ON Categories.Id = Id_Category JOIN Authors ON Authors.Id = Id_Author WHERE Categories.Name = @name AND Id_Author = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                AsyncCallback callback = new AsyncCallback(CallBackCategories);

                command.BeginExecuteReader(callback, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CallBackCategories(IAsyncResult result)
        {
            if (result.AsyncState is SqlCommand command)
            {
                SqlDataReader? reader = null;

                try
                {
                    reader = command.EndExecuteReader(result);

                    while (reader.Read())
                    {
                        var row = dataTable?.NewRow();

                        if (row != null)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader[i];
                            }

                            dataTable?.Rows.Add(row);
                        }
                    }

                    gridView.Invoke(() => gridView.DataSource = dataTable?.AsDataView());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader?.Close();
                }
            }
        }



        private void cmbBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_Categories.Items is null)
                return;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cmbBox_Authors.Items is null)
                return;
            try
            {
                var connection = new SqlConnection(connectionString);
                connection?.Open();

                using SqlCommand command = new SqlCommand($"SELECT [Name] FROM Categories", connection);
                AsyncCallback callback = new AsyncCallback(CallBackCategories);
                IAsyncResult iar = command.BeginExecuteReader();

                GetData(command,iar);
                var reader = command.BeginExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GetData(SqlCommand command, IAsyncResult ia)
        {
            SqlDataReader? dataReader = null;

            try
            {
                dataReader = command.EndExecuteReader(ia);
                while (dataReader.Read())
                {
                    cmbBox_Categories.Items.Add(dataReader["Name"]);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader is not null && !dataReader.IsClosed)
                    dataReader.Close();
            }
        }

    }
}