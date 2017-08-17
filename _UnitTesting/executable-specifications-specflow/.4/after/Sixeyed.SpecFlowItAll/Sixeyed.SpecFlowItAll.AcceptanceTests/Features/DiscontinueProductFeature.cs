using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.SpecFlowItAll.AcceptanceTests
{
    [DeploymentItem("02.INSERT-Products.sql")]
    [DeploymentItem("connectionStrings.config")]
    [DeploymentItem("WpfApplication", "WpfApplication")]
    public partial class DiscontinueProductFeature
    {
    }
}
