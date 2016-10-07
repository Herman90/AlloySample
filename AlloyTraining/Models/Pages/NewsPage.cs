using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "a67bc14d-0e28-46d2-8ace-2712c550179b", Description = "")]
    public class NewsPage : StandardPage
    {



        [Display(GroupName = SystemTabNames.Content, Order = 315)]
        public virtual ListingBlock MainListing { get; set; }

    }
}