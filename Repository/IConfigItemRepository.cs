namespace Repository
{
    public interface IConfigItemRepository
    {
        /// <summary>
        /// retrieves the config item
        /// </summary>
        /// <param name="aKey">the key</param>
        /// <returns>the value associated with the key</returns>
        string GetConfigItem(string aKey);
    }
}
