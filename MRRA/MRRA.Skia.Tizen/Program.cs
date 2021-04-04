using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MRRA.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new MRRA.App(), args);
            host.Run();
        }
    }
}
