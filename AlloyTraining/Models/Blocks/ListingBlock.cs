using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "6b0b9cc0-1e4b-4030-a9a6-55e4952a9288", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 100)]
        public virtual string Heading { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}