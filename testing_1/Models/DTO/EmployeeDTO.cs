using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace testing_1.Models;


public class EmployeeDTO : BaseDTO
{
    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [StringLength(50, ErrorMessage = "Длина значения не должна превышать 50 символов")]
    [DisplayName("Фамилия Имя Отчество")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [StringLength(200, ErrorMessage = "Длина значения не должна превышать 200 символов")]
    [DisplayName("Должность")]
    public string Post { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [StringLength(50, ErrorMessage = "Длина значения не должна превышать 50 символов")]
    [DisplayName("Адрес электронной почты")]
    public string EMail { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [StringLength(50, ErrorMessage = "Длина значения не должна превышать 50 символов")]
    [DisplayName("Аккаунт WhatsApp")]
    public string WhatsApp { get; set; }

    [Required(ErrorMessage = "Поле обязательно для заполнения")]
    [DisplayName("Фото")]
    public string ImageName { get; set; }

    [DisplayName("Муниципальное образование")]
    public MunicipalEducationDTO MunicipalEducation { get; set; }
}
