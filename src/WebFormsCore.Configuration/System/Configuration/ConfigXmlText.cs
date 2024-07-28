﻿
using System.Configuration.Internal;
using System.Xml;

#nullable disable
namespace System.Configuration
{
  internal sealed class ConfigXmlText : XmlText, IConfigErrorInfo
  {
    private int _line;
    private string _filename;

    public ConfigXmlText(string filename, int line, string strData, XmlDocument doc)
      : base(strData, doc)
    {
      this._line = line;
      this._filename = filename;
    }

    int IConfigErrorInfo.LineNumber => this._line;

    string IConfigErrorInfo.Filename => this._filename;

    public override XmlNode CloneNode(bool deep)
    {
      XmlNode xmlNode = base.CloneNode(deep);
      if (xmlNode is ConfigXmlText configXmlText)
      {
        configXmlText._line = this._line;
        configXmlText._filename = this._filename;
      }
      return xmlNode;
    }
  }
}
