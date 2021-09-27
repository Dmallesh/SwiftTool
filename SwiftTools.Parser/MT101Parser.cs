using SwiftTools.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SwiftTools.MT101Parser
{
    public class MT101Parser
    {
        private CultureInfo SWIFTCultureInfo { get; set; }

        public MT101Parser()
        {
            SWIFTCultureInfo = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            SWIFTCultureInfo.NumberFormat.NumberDecimalSeparator = ",";
            SWIFTCultureInfo.NumberFormat.NumberGroupSeparator = "";
            SWIFTCultureInfo.NumberFormat.NumberDecimalDigits = 2;
            SWIFTCultureInfo.DateTimeFormat.ShortDatePattern = "yyMMdd";
        }

        /// <summary>
        /// TODO: should validate content
        /// </summary>
        /// <param name="content"></param>
        public void ValidateFormat(Stream content)
        {
            if(content == null)
                throw new NoDataException();

            if (content.Length == 0)
                throw new NoDataException();

            StreamReader reader = new StreamReader(content);
            int i = 1;
            var emptExp = new List<int>();
            var incorrExp = new List<int>();
            var icorreChar = new List<IncorrectChar>();
            bool block = false;
            while (reader.Peek() >= 0)
            {
                var line = reader.ReadLine();
                if (line.IndexOf("\r\n\r\n") > 0)
                {
                    emptExp.Add(i);
                    if (line.StartsWith("-"))
                    {
                        if (line.StartsWith("-}"))
                        {
                            continue;
                        }
                        else
                        {
                            incorrExp.Add(i);
                        }
                    }
                }


                if (line.StartsWith("{4:"))
                    block = true;

                var temp = line.Replace("-}", "");
                temp = temp.Replace("{4:", "");
                if (temp.Contains("{") || temp.Contains("}"))
                {
                    throw new MTFormatException();
                }

           

                var match = Regex.Match(line, @"^[a-z0-9A-Z/-?:().,'+{}]*$");

                if (!match.Success)
                {
                    var c = line.Substring(match.Index);
                    icorreChar.Add(new IncorrectChar {Index = i,IncorrectCharacter = c.ToCharArray()[0]});
                }
            }

            if (emptExp.Count > 0)
                throw new EmptyLinesException(emptExp.ToArray());

            if (incorrExp.Count > 0)
                throw new IncorrectLinesException(incorrExp.ToArray());

            if (!block)
                throw new MTFormatException();

            if (icorreChar.Count > 0)
                throw new NotAllowedCharactersException(icorreChar.ToArray());


        }

        /// <summary>
        /// TODO: should parse content
        /// </summary>
        /// <param name="content"></param>
        public MT101Message[] Parse(Stream content)
        {
            throw new NotImplementedException();
        }
    }
}
