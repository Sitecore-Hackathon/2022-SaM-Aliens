using System;
using System.Collections.Generic;
using System.Linq;
using Mvp.Feature.Navigation.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace Mvp.Feature.Navigation.Services
{
  public class TopLinksBuilder : ITopLinksBuilder
  {
    public IList<Link> GetTopLinks(Item contextItem, Rendering rendering)
    {
      var dataSourceItem = contextItem?.Database?.GetItem(rendering.DataSource);
      if (dataSourceItem == null) throw new NullReferenceException();

      return GetValidTopLinkItems(dataSourceItem).Select(c =>
      {
        var linkField = (LinkField) c.Fields[Templates.HasLink.Fields.Link];
        var isMediaLink = linkField.IsMediaLink;
        return new Link
        {
          Title = isMediaLink ? c.DisplayName : linkField.Title,
          Url = isMediaLink ? linkField.GetFriendlyUrl() : linkField.Url
        };
      }).ToList();
    }

    private IEnumerable<Item> GetValidTopLinkItems(Item dataSourceItem)
    {
      return dataSourceItem.Children.Where(x => x.TemplateID == Templates.TopLink.TemplateId
                                                && !string.IsNullOrWhiteSpace(x[Templates.HasLink.Fields.Link]));
    }
  }
}