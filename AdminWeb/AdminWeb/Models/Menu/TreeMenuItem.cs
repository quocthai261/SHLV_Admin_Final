namespace AdminWeb.Models.Menu
{
    public class TreeMenuItem<T>
    {
        public T Item { get; set; }
        public IEnumerable<TreeMenuItem<T>> Children { get; set; }
        public string CurrentSystemName { get; set; }
        public int Level { get; set; }
    }
}
