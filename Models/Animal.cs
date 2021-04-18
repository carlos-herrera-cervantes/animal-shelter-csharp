namespace AnimalShelterConsoleApp.Models
{
    public abstract class Animal
    {
        private int Order;
        public string Name { get; }

        public Animal(string name) => Name = name;

        #region snippet_SetOrder

        /// <summary>Sets the order of the animal</summary>
        /// <param name="order">Integer</param>
        public void SetOrder(int order) => Order = order;

        #endregion

        #region snippet_GetOrder

        /// <summary>Gets the order of the animal</summary>
        /// <returns>Integer</returns>
        public int GetOrder() => Order;

        #endregion

        #region snippet_IsOlderThan

        /// <summary>
        /// Checks if the current animal is older than the parameter
        /// </summary>
        /// <param name="animal">Animal object class (Dog or Cat)</param>
        /// <returns>If the current animal is older than the parameter returns true otherwise false</returns>
        public bool IsOlderThan(Animal animal) => Order < animal.GetOrder();

        #endregion
    }
}