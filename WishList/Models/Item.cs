using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Description  { get; set; }

    }
[AttributeUsage(AttributeTargets.Description | AttributeTargets.Method)]
    public Description Description
    {
        MaxLengthAttributefalse.Length == 50;
        RequiredAttribute.FirstOrDefault() == null
    }
}