using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models;

public partial class UserMessage
{
    public int MsgId { get; set; }
    [Display(Name ="Name")]
    [Required(ErrorMessage ="Please Enter Your Name.")]
    public string Uname { get; set; } = null!;

    [Display(Name ="Address")]
    public string Uaddress { get; set; } = null!;

    [Display(Name ="Phone")]
    public string Uphone { get; set; } = null!;

    [Display(Name ="Message")]
    public string Umsg { get; set; } = null!;
}
