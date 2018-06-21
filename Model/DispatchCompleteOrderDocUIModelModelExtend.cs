﻿#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUIModel
{	public partial class DispatchCompleteOrderDocUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            //绑定默认日期.
            this.DispatchCompleteOrderDoc.FieldBusinessDate.DefaultValue=DateTime.Now.ToString("yyyy.MM.dd");
            this.DispatchCompleteOrderDoc.FieldActualCompleteTime.DefaultValue = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
            this.DispatchCompleteOrderDoc.FieldWorkHourUOM_Name.DefaultValue = "小时";

        }
        
        //UIModel提交保存之前的校验操作.
        public override void OnValidate()
        {
        		base.OnValidate() ;
            OnValidate_DefualtImpl();
            //your coustom code ...
        }
	}
}