using CodeGenerate.EngineHost;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string templateFileName = "test.tt";
            TextTemplatingEngineHost host = new TextTemplatingEngineHost();
            Engine engine = new Engine();
            //引入本地dll
            // host.LocalDlls = new List<string>() { AppDomain.CurrentDomain.BaseDirectory.ToString() + "Params.dll" };
            //引入命名空间
            // host.Namespaces = new List<string>() { "Params" };
            //模板文件
            host.TemplateFile = templateFileName;
            //设置输出文件的编码格式
            host.SetOutputEncoding(System.Text.Encoding.UTF8, false);
            //通过Session将参数传递到模板
            // CodeGenerate.EngineHost.TextTemplatingSession keyValuePairs = new CodeGenerate.EngineHost.TextTemplatingSession();
            //testType t = new testType() { Name = "666666666666" };
            //keyValuePairs.Add("test", t);
            // host.Session = keyValuePairs;
            //模板
            string input = File.ReadAllText(templateFileName);
            //执行代码生成
            string output = engine.ProcessTemplate(input, host);
            //设置文件的输出路径和文件扩展名 ，，根据模板中的设置定义
            string outputFileName = string.Concat(
                AppDomain.CurrentDomain.BaseDirectory.ToString(),
                Path.GetFileNameWithoutExtension(templateFileName),
                host.FileExtension);
            //将生成的文件写入到新位置
            File.WriteAllText(outputFileName, output, host.FileEncoding);
            if (host.Errors.HasErrors)
            {
                foreach (CompilerError error in host.Errors)
                {
                    Console.WriteLine(error.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
