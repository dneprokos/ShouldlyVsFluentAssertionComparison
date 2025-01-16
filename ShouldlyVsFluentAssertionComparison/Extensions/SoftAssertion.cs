namespace ShouldlyVsFluentAssertionComparison.Extensions
{
    public class SoftAssertion : IDisposable
    {
        private readonly List<string> _failures = new();

        public void Assert(Action assertion)
        {
            try
            {
                assertion();
            }
            catch (Exception ex)
            {
                _failures.Add(ex.Message);
            }
        }

        public void Dispose()
        {
            if (_failures.Count > 0)
            {
                throw new Exception("The following assertions failed:\n" + string.Join("\n", _failures));
            }
        }
    }
}
