
using SparkPlug.WebForm.Core.Model;

namespace SparkPlug.WebForm.Core.FormService
{
    public interface IFormServices
    {
        bool FormAction(FormSubmissionRequest req);
    }
}