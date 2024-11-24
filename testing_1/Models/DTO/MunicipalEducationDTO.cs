using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace testing_1.Models;

public class MunicipalEducationDTO : BaseDTO
{
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [StringLength(100, ErrorMessage = "Длина значения не должна превышать 100 символов")]
    [DisplayName("Наименование")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [StringLength(20, ErrorMessage = "Длина значения не должна превышать 20 символов")]
    [DisplayName("Код ОКТМО")]
    public string OKTMOCode { get; set; }
}
