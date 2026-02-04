
namespace DotNetInterviewTDD.Core
{
    public class TestResource : IDisposable
    {
        public TestResource()
        {
        }

        public bool IsDisposed { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}