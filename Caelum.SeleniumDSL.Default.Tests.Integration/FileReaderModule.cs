﻿using System;
using System.Collections.Generic;
using System.IO;
using HttpServer;
using HttpServer.HttpModules;
using HttpServer.Sessions;

namespace Caelum.SeleniumDSL.Default.Tests.Integration
{
    public class FileReaderModule : HttpModule
    {
        private List<string> ignoredPaths;

        public FileReaderModule()
        {
            ignoredPaths = new List<string>();
            ignoredPaths.Add("/favicon.ico");
            ignoredPaths.Add("/");
        }

        public override bool Process(IHttpRequest request, IHttpResponse response, IHttpSession session)
        {
            if (ignoredPaths.Contains(request.Uri.AbsolutePath))
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