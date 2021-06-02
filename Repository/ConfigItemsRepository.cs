namespace Repository
{
    public class ConfigItemsRepository : IConfigItemRepository
    {
        /// <summary>
        /// retrieves the config item
        /// </summary>
        /// <param name="aKey">the key</param>
        /// <returns>the value associated with the key</returns>
        public string GetConfigItem(string aKey)
        {
            // TODO: implement this when DB is in place
            return string.Empty;
        }
    }
}
