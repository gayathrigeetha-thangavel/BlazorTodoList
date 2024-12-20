using System.ComponentModel.DataAnnotations;

namespace BlazorTodoList.TodoList
{
    public class TodoItem
    {
        [Required(ErrorMessage = "Title should not be empty")]
        [StringLength(50)]
        public string? Title { get; set; }
        public bool IsDone { get; set; }
    }
}
