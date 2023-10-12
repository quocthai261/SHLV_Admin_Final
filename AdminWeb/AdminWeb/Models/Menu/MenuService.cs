using System.Linq;

namespace AdminWeb.Models.Menu
{
    public static class MenuService
    {
        public static List<SiteMapNode> _menuItemList;

        public static IEnumerable<TreeMenuItem<SiteMapNode>> GenerateTreeMenu(List<SiteMapNode> menuItemList)
        {
            List<TreeMenuItem<SiteMapNode>> threeMenuItemList = new List<TreeMenuItem<SiteMapNode>>();

            foreach (var item in menuItemList)
            {
                TreeMenuItem<SiteMapNode> threeMenuItem = new TreeMenuItem<SiteMapNode>()
                {
                    Item = item,
                };

                //threeMenuItem.Children = new List<TreeMenuItem<SiteMapNode>>();
                //var childrens = LoadChildrens(menuItemList, item.ID);
                //threeMenuItem.Children = childrens;

                //if (childrens.ToList().Count > 0)
                //{
                //    foreach (var child in childrens)
                //    {

                //    }
                //}

                threeMenuItemList.Add(threeMenuItem);
            }

            return threeMenuItemList;
        }

        private static void CreateThreeMenuItem(SiteMapNode node, int level)
        {
            TreeMenuItem<SiteMapNode> treeMenuItem = new TreeMenuItem<SiteMapNode>();
            treeMenuItem.Level = level + 1;
            treeMenuItem.Item = node;
            treeMenuItem.Children = new List<TreeMenuItem<SiteMapNode>>();

            var children = _menuItemList.Where(item => item.PARENTID == node.ID);

            //if (children.Count > 0)
            //{
            //    foreach (var child in children)
            //    {
            //        TreeMenuItem<SiteMapNode> treeMenuItemChild = new TreeMenuItem<SiteMapNode>();
            //        treeMenuItemChild.Level = treeMenuItem.Level + 1;
            //        treeMenuItemChild.Item = child;
            //        treeMenuItem.Children.ToList().Add(treeMenuItemChild);
            //    }
            //}                        
        }
    }
}

