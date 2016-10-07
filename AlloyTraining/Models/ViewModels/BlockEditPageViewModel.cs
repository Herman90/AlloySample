using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlloyTraining.Models.Pages;
using EPiServer.Core;

namespace AlloyTraining.Models.ViewModels
{
    public class BlockEditPageViewModel: IPageViewModel<SitePageData>
    {
        public BlockEditPageViewModel(PageData page, IContent content)
        {
            PreviewBlock = new PreviewBlock(page, content);
            CurrentPage = page as SitePageData;
        }

        public SitePageData CurrentPage { get; }

        public PreviewBlock PreviewBlock { get; set; }
    }
}