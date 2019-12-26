using NBL.WebService.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.Webservice.DataAccess.Mapping
{
    public class HospitalMap : EntityTypeConfiguration<Hostpital>
    {
        public HospitalMap()
        {
            HasKey(t => t.HospitalId);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.HospitalName).IsRequired();
            Property(t => t.Address1).IsRequired();
            ToTable("Hospital");
        }
    }
}
