﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolrNet.Impl
{
    public class MoreLikeThisHandlerResults<T> : AbstractSolrQueryResults<T>, IMoreLikeThisQueryResults<T>
    {
        public MoreLikeThisHandlerResults()
        {
            this.InterestingTerms = new List<KeyValuePair<string, double>>();
        }

        public T Match { get; set; }

        public IList<KeyValuePair<string, double>> InterestingTerms { get; set; }
    }
}
