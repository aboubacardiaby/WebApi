using Autofac;
using NBL.Webservice.Framework;
using NBL.WebService.Domain;
using NBL.WebService.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBL.Webservice.Tests
{
    [TestFixture]
    public class HospitalTest
    {
        [Test]
        public void AddNewHospital()
        {
            var container = DependencyRegistrar.ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                try
                {
                    var ExpectedResult = "";
                    var originalResult = string.Empty;
                    var app = scope.Resolve<IHospitalService>();
                    app.AddNewHospital(new Hostpital()
                    {
                        Address1 = "1234 Heller Ave S",
                        HospitalId = "Hell214",
                        HospitalName = "Heller Hospital"

                    });
                    originalResult = string.Empty;
                    Assert.AreEqual(ExpectedResult, originalResult);
                }
                catch (Exception)
                {

                    throw;
                }


            }
        }

        [Test]
        public void GetHospital()
        {
            var container = DependencyRegistrar.ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                try
                {
                    var ExpectedResult = "";
                    var originalResult = string.Empty;
                    var app = scope.Resolve<IHospitalService>();
                    app.GetHospital("1");

                    originalResult = string.Empty;
                    Assert.AreEqual(ExpectedResult, originalResult);
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
