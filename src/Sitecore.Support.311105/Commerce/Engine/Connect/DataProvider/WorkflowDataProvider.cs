namespace Sitecore.Support.Commerce.Engine.Connect.DataProvider
{
    using Sitecore.Collections;
    using Sitecore.Data;
    using Sitecore.Data.DataProviders;
    public class WorkflowDataProvider : Sitecore.Commerce.Engine.Connect.DataProvider.WorkflowDataProvider
    {
        public override VersionUriList GetItemVersions(ItemDefinition itemDefinition, CallContext context)
        {
            //The Workflows items are managed by Sitecore
            return null;            
        }
    }
}