using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Reporting.Base
{
    public abstract class Report
    {
        public abstract string Name { get; }
        // this modifier means protected *or* internal. It means that reports have access to override it and that the ReportGenerator (in this assembly) can call it. But nothing else has access, which means that the ReportGenerator has to be used to make reports. Which guarantees that the Begin and End methods of IReportWriter are called. Otherwise this abstract class could instead be an interface. This wouldn't make a conceptual difference but does mean that each Report could inherit from something else. We are meant to favour composition over inheritance these days though so this shouldn't be an issue.
        protected internal abstract void Generate(IReportWriter write);
    }
}
