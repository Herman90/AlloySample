using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace AlloyTraining.Models.Pages
{
    public class PreviewBlock: PageData
    {
        public PreviewBlock(PageData currentContent, IContent previewContent)
            : base(currentContent)
        {
            this.PreviewContent = previewContent;
            this.ContentArea = new ContentArea();
            this.ContentArea.Items.Add(new ContentAreaItem
            {
                ContentLink = this.PreviewContent.ContentLink
            });
        }

        public IContent PreviewContent { get; set; }

        public ContentArea ContentArea { get; set; }
    }
}