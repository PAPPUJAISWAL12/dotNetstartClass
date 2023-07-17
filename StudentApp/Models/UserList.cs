using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models;

public partial class UserList
{
    [Display(Name ="Id")]
   
    public int UserId { get; set; }
	[Required(ErrorMessage = "Please Enter your Name")]
	public string UserName { get; set; } = null!;

    [Display(Name ="Password")]
	[Required(ErrorMessage = "Please Enter your Password")]
	public string UserPassword { get; set; } = null!;

    public string UserAddress { get; set; } = null!;

    public string UserRoleType { get; set; } = null!;

    public string UserPhone { get; set; } = null!;
}
