using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Contact
    {
        [Required]
        //[BindRequired] //áp dụng cho một thuộc tính của lớp phức tạp,
        //nó sẽ phát sinh trạng thái lỗi nếu không thực hiện binding cho thuộc tính này
        public string Name { get; set; }

        [Phone]
        //[BindNever] //không thực hiện binding
        [Required]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(10)]
        public string Message { get; set; }
    }
}