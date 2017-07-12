using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace Transformation
{
    public static class Transformer
    {
        public static String TransformExternalCalculation()
        {
            return Transform("ExternalCalculation.xslt");
        }

        public static String TransformInlineCalculation()
        {
            return Transform("InlineCalculation.xslt");
        }

        private static String Transform(String stylesheet)
        {
            var transform = new XslCompiledTransform();
            transform.Load(XmlReader.Create(stylesheet));

            using (var writer = new StringWriter())
            {
                var xmlWriter = XmlWriter.Create(writer, new XmlWriterSettings { ConformanceLevel = ConformanceLevel.Auto });

                var xsltArgumentList = new XsltArgumentList();
                xsltArgumentList.XsltMessageEncountered += (a, b) => Console.WriteLine(b.Message);

                transform.Transform(XmlReader.Create("Input.xml"), xsltArgumentList, xmlWriter);
                return writer.ToString().Trim();
            }
        }
    }
}
