﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public partial class HRMS_SYS_Program_Function
{
    /// <summary>
    /// 程式代碼
    /// </summary>
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Program_Code { get; set; }

    /// <summary>
    /// 功能代碼
    /// </summary>
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Fuction_Code { get; set; }

    /// <summary>
    /// 異動者
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string Update_By { get; set; }

    /// <summary>
    /// 異動日
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Update_Time { get; set; }
}
