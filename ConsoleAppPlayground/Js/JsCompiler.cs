using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppPlayground.Js
{
    public class JsCompiler
    {
        public void Main() 
        {
            var jsCode = File.ReadAllText("./../../../Js/JsMain.js");
            IronJS.Hosting.CSharp.Context ctx = new IronJS.Hosting.CSharp.Context();

            var res = ctx.Execute(jsCode);
            Console.WriteLine(res);
        }
    }
}
