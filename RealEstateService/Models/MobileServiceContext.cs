using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using RealEstateService.DataObjects;

namespace RealEstateService.Models
{

    public class MobileServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        //
        // To enable Entity Framework migrations in the cloud, please ensure that the 
        // service name, set by the 'MS_MobileServiceName' AppSettings in the local 
        // Web.config, is the same as the service name when hosted in Azure.

        private const string connectionStringName = "Name=MS_TableConnectionString";

        public MobileServiceContext() : base(connectionStringName)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            string schema = ServiceSettingsDictionary.GetSchemaName();
            if (!string.IsNullOrEmpty(schema))
            {
                modelBuilder.HasDefaultSchema(schema);
            }

            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }

        public System.Data.Entity.DbSet<RealEstateService.DataObjects.Person> People { get; set; }

        public System.Data.Entity.DbSet<RealEstateService.DataObjects.Social> Socials { get; set; }

        public System.Data.Entity.DbSet<RealEstateService.DataObjects.Image> Images { get; set; }

        public System.Data.Entity.DbSet<RealEstateService.DataObjects.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<RealEstateService.DataObjects.Apartment> Apartments { get; set; }

        public System.Data.Entity.DbSet<RealEstateService.DataObjects.Address> Addresses { get; set; }
    }

}
