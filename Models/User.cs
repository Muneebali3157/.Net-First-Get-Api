namespace First_crud_operation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
//this is in memory class not created in the database, so we can use it to store data in memory for testing purposes.
// for database to store data we need to make new cs file applicationdbcontext.cs file
