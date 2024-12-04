namespace DomeTrain
{
    internal class ListExtension<T>
    {
        public static bool ContainsRange(List<T> container, List<T> range)
        {
            return range.All(container.Contains);
        }

        public static async Task<bool> ContainsRangeAsync(List<T> container, List<T> range)
        {
            await Task.Delay(1500);
            var contains = ContainsRange(container, range);
            await Task.Delay(1500);
            return contains;
        }
    }
}
