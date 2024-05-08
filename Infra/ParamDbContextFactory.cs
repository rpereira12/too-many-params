using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace too_many_params.Infra
{
    public class ParamDbContextFactory : IDesignTimeDbContextFactory<ParamsDbContext>
    {
        public ParamsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParamsDbContext>();
            optionsBuilder.UseMySql(
                "Server=localhost;Port=3309;Database=mydatabase;Uid=myuser;Pwd=mypassword;",
                new MySqlServerVersion(new Version(8, 0, 21)));
            return new ParamsDbContext(optionsBuilder.Options);
        }
    }
}
