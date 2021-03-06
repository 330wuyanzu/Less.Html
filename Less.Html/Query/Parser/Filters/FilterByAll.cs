﻿//bibaoke.com

using System.Collections.Generic;
using System.Linq;

namespace Less.Html
{
    internal class FilterByAll : ElementFilter
    {
        protected override IEnumerable<Element> EvalThis(Document document)
        {
            return document.all;
        }

        protected override IEnumerable<Element> EvalThis(Document document, IEnumerable<Element> source)
        {
            if (document.IsNotNull())
            {
                return source.SelectMany(i => i.EnumerateAllElements());
            }
            else
            {
                return source.GetChildElements();
            }
        }
    }
}
