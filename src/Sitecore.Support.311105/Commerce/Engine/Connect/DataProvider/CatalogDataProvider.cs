namespace Sitecore.Support.Commerce.Engine.Connect.DataProvider
{
    using Sitecore.Collections;
    using Sitecore.Commerce.Engine.Connect.DataProvider.Definitions;
    using Sitecore.Data;
    using Sitecore.Data.DataProviders;
    using System;
    public class CatalogDataProvider : Sitecore.Commerce.Engine.Connect.DataProvider.CatalogDataProvider
    {
        public override VersionUriList GetItemVersions(ItemDefinition item, CallContext context)
        {
            if (item.TemplateID == KnownItemIds.NavigationItemTemplateId)
            {
                return base.GetItemVersions(item, context);
            }
            if (item.Name.Equals("__Standard Values", StringComparison.OrdinalIgnoreCase))
            {
                //The __Standard Values items are managed by Sitecore.
                return null;
            }

            return base.GetItemVersions(item, context);
        }
    }
}