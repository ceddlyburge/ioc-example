using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporting.Base
{
    /*
     In the code review meeting we talked about adding interfaces like this, probably both to be implemented by the same classes as currently, because the ReportWriter wants these things to be called, but the Report's don't want to have any knowledge of them
     

    // this to be passed to Reports and has everything they need
    public interface IReportWriter
    {
        void Heading(string heading);
        void UnorderedList(params string[] unorderedList);
    }

    // this used by the ui to allow user to choose which writer to use and possibly to do some setup with the mimetype (as in the mvc application)
    public interface IReportWriterIdentification // maybe : IReportWriter
    {
        string Name { get; }
        string MimeType { get; }
    }

    // this has things that the ReportWriter's want called
    public interface IReportWriterInternalWorkings  // maybe : IReportWriter or IReportWriterIdentification
    {
        // these are a code smell as they mean that the interface has some knowledge of the class(es) that will implement them. In this case I couldn't really think of another way to do this and it seems that a reasonable proportion of conceivable report writers would want / need these, so I don't think its too bad. If just one implementation needed it then it would be bad.
        // Another option for begin is for the implemention to call this itself the first time a writing method is called. This would only work if the ioc creates a new instance for every request, which is a bit less efficient but not really a big deal.
        void Begin(); 
        void End();
    }
    */
    public interface IReportWriter
    {
        string Name { get; }
        string MimeType { get; }

        void Begin();
        void End();

        // these could have guards to make sure Begin has been called
        void Heading(string heading);
        void UnorderedList(params string [] unorderedList);
        // plus stuff for tables and graphs and all that
    }
}
