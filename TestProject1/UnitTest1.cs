namespace TestProject1
{
    using Xunit;
    using System.Data.OleDb;

    public class DataAccessLayer
    {
        private OleDbConnection conn;

        public DataAccessLayer(string connectionString)
        {
            this.conn = new OleDbConnection(connectionString);
        }

        public bool Connect()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (OleDbException ex)
            {
                throw new Exception($"Ошибка подключения: {ex.Message}", ex); // Переходим на выброс исключения
            }
        }

        public void Close()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
        }
    }

    public class IntegrationTests
    {
        [Fact]
        public void Test_DatabaseConnection_ShouldBeSuccessful()
        {
            // Arrange
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb"; 
            DataAccessLayer dal = new DataAccessLayer(connectionString);

            // Act & Assert
            Assert.True(dal.Connect(), "Не удалось подключить базу данных");

            // Clean up
            dal.Close();
        }
    }
}