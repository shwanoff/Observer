using System;

namespace Observer
{
    /// <summary>
    /// Наблюдатель.
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Создать экземпляр наблюдателя.
        /// </summary>
        /// <param name="title">Название наблюдателя.</param>
        /// <param name="subject">Наблюдаемый объект.</param>
        public Observer(string title, Subject subject)
        {
            Title = title;
            subject.OnSaved += Subject_OnSaved;
        }

        /// <summary>
        /// Обработчик события сохранения наблюдаемого объекта.
        /// </summary>
        /// <param name="sender">Наблюдаемый объект.</param>
        /// <param name="e">Аргументы события.</param>
        private void Subject_OnSaved(object sender, EventArgs e)
        {
            string format = "dd.MM.yyyy hh:mm:ss";
            Console.WriteLine($"[{DateTime.Now.ToString(format)}] Наблюдатель '{this}': Выполнено сохранение наблюдаемого объекта '{sender}'");
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
