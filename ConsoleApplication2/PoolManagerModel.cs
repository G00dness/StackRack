namespace StackRanking
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PoolManagerModel : DbContext
    {
        // Your context has been configured to use a 'PoolManagerModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ConsoleApplication2.PoolManagerModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PoolManagerModel' 
        // connection string in the application configuration file.
        public PoolManagerModel()
            : base("name=PoolManagerModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<PoolPlayerAccount> PoolPlayerAccounts { get; set; }
    }

   
}