namespace PokeUI
{
    public interface IMenu
    {
        /// <summary>
        /// Display menu and choices
        /// </summary>
        void Display();

        /// <summary>
        /// Will record user's choice and route your menu beased on choice
        /// </summary>
        /// <returns></returns>
        string UserChoice();


    }
}