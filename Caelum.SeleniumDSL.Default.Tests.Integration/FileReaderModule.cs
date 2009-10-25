using System;
using System.Collections.Generic;
using System.IO;
using HttpServer;
using HttpServer.HttpModules;
using HttpServer.Sessions;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    public class FileReaderModule : HttpModule
    {
        private readonly List<string> _ignoredPaths;

        public FileReaderModule()
        {
            _ignoredPaths = new List<string> {"/favicon.ico", "/"};
        }

        public override bool Process(IHttpRequest request, IHttpResponse response, IHttpSession session)
        {
            if (_ignoredPaths.Contains(request.Uri.AbsolutePath))
                return true;

            TextWriter writer = new StreamWriter(response.Body);
            try
            {
                string fileContents = File.ReadAllText("resources" + request.Uri.AbsolutePath);
                writer.Write(fileContents);
            }
            catch (Exception ex)
            {
                response.ContentType = "text/plain; charset=UTF-8";
                writer.WriteLine(ex.Message);
                writer.WriteLine(ex.StackTrace);
            }
            finally
            {
                writer.Flush();
            }

            return true;
        }
    }
}