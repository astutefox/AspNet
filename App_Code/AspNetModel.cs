﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class pomdept2
{
    public pomdept2()
    {
        this.pompersn1 = new HashSet<pompersn1>();
    }

    public string dept_no { get; set; }
    public string dept_nm { get; set; }
    public string creator { get; set; }
    public string createdate { get; set; }
    public string upduser { get; set; }
    public string upddate { get; set; }

    public virtual ICollection<pompersn1> pompersn1 { get; set; }
}

public partial class pomflow1
{
    public pomflow1()
    {
        this.pomflow2 = new HashSet<pomflow2>();
    }

    public string flow_no { get; set; }
    public string flow_typ { get; set; }
    public string bill_no { get; set; }
    public string creator { get; set; }
    public string createdate { get; set; }
    public string upduser { get; set; }
    public string upddate { get; set; }

    public virtual ICollection<pomflow2> pomflow2 { get; set; }
}

public partial class pomflow2
{
    public string flow_no { get; set; }
    public string flow_seq { get; set; }
    public string dept_no { get; set; }
    public string emp_no { get; set; }
    public string f_status { get; set; }
    public string creator { get; set; }
    public string createdate { get; set; }
    public string upduser { get; set; }
    public string upddate { get; set; }

    public virtual pomflow1 pomflow1 { get; set; }
}

public partial class pompersn1
{
    public string emp_no { get; set; }
    public string emp_nm { get; set; }
    public string dept_no { get; set; }
    public string posi_no { get; set; }
    public string creator { get; set; }
    public string createdate { get; set; }
    public string upduser { get; set; }
    public string upddate { get; set; }

    public virtual pomdept2 pomdept2 { get; set; }
}
