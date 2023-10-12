namespace AdminWeb.Models.Menu
{
    public static class GenericHelpers
    {
        public static IEnumerable<TreeMenuItem<T>> GenerateTreeMenu<T, K>(this IEnumerable<T> collection, Func<T, K> id_selector, Func<T, K> parent_id_selector, Func<T, K> order_selector, K root_id = default(K))
        {
            foreach (T c2 in Enumerable.OrderBy(Enumerable.Where(collection, (T c) => parent_id_selector(c).Equals(root_id)), order_selector))
            {
                yield return new TreeMenuItem<T>
                {
                    Item = c2,
                    Children = collection.GenerateTreeMenu(id_selector, parent_id_selector, order_selector, id_selector(c2))
                };
            }
        }
    }
}

