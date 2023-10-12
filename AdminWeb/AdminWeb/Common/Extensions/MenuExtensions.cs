using AdminWeb.Models.Menu;

namespace AdminWeb.Common.Extensions
{
    public static class MenuExtensions
    {
        public static bool ContainsSystemName(this TreeMenuItem<SiteMapNode> node, string systemName)
        {
            if (!string.IsNullOrEmpty(systemName))
            {
                if (node.Item.SYSTEMNAME != null)
                {
                    return node.Item.SYSTEMNAME.Equals(systemName);
                }
            }
            
            return false;
        }

        public static bool ContainsParentSystemName(this TreeMenuItem<SiteMapNode> node, string parentSystemName)
        {
            if (!string.IsNullOrEmpty(parentSystemName))
            {
                if (node.Item.SYSTEMNAME != null)
                {
                    return node.Item.SYSTEMNAME.Equals(parentSystemName);
                }
            }

            return false;
        }
    }
}
