using System.IO;
using HttpServer.HttpModules;
using HttpServer;
using HttpServer.Sessions;
using System.Collections.Generic;
namespace Integration.Caelum.SeleniumDSL
{
    public class FileReaderModule : HttpModule
    {
        private List<string> ignoredPaths;
        public FileReaderModule()
        {
            ignoredPaths = new List<string>();
            ignoredPaths.Add("/favicon.ico");
        }

        public override bool Process(IHttpRequest request, IHttpResponse response, IHttpSession session)
        {
            if (ignoredPaths.Contains(request.Uri.AbsolutePath))
                return true;

            string fileContents = File.ReadAllText("../../../Integration Tests/resources" + request.Uri.AbsolutePath);
            TextWriter writer = new StreamWriter(response.Body);
            writer.Write(fileContents);
            writer.Close();

            return true;
        }
    }
}