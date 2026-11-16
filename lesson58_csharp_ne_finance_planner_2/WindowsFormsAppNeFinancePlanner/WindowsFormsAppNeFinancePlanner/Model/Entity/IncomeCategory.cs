namespace WindowsFormsAppNeFinancePlanner.Model.Entity
{
    // Элемент справочника источников дохода, например «Зарплата» или «Фриланс».
    public class IncomeCategory
    {
        // Идентификатор назначает репозиторий при добавлении категории.
        public int Id { get; set; }
        public string Name { get; set; }
    }
}