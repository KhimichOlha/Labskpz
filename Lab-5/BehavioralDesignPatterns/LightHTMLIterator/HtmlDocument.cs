﻿using LightHtml;
using System.Collections;

namespace LightHTMLIterator
{
    public class HtmlDocument : IEnumerable<LightNode>
    {
        private LightNode _root;

        public HtmlDocument(LightNode root)
        {
            _root = root;
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            return new HtmlDocumentIterator(_root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
