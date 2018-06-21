#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUIModel
{
	[Serializable]
	public partial class DispatchCompleteOrderDocUIModelModel : UIModel
	{
		#region Constructor
		public DispatchCompleteOrderDocUIModelModel() : base("DispatchCompleteOrderDocUIModel")
		{
			InitClass();
			this.SetResourceInfo("7cca486c-2f37-4603-9462-1ab1088e3fb0");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DispatchCompleteOrderDocUIModelModel(bool isInit) : base("DispatchCompleteOrderDocUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DispatchCompleteOrderDocUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private DispatchCompleteOrderDocView viewDispatchCompleteOrderDoc;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public DispatchCompleteOrderDocView DispatchCompleteOrderDoc
		{
			get { return (DispatchCompleteOrderDocView)this["DispatchCompleteOrderDoc"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewDispatchCompleteOrderDoc = new DispatchCompleteOrderDocView(this);
			this.viewDispatchCompleteOrderDoc.SetResourceInfo("88833db1-b13c-4f3a-ad68-9055d40dca3e");
			this.Views.Add(this.viewDispatchCompleteOrderDoc);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class DispatchCompleteOrderDocView : UIView
	{
		#region Constructor
		public DispatchCompleteOrderDocView(IUIModel model) : base(model,"DispatchCompleteOrderDoc","UFIDA.U9.PFM.DispatchCompleteOrderDocBE.DispatchCompleteOrderDoc", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private DispatchCompleteOrderDocView():base(null,"DispatchCompleteOrderDoc","UFIDA.U9.PFM.DispatchCompleteOrderDocBE.DispatchCompleteOrderDoc", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new DispatchCompleteOrderDocView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}
		public IUIField FieldDocNo
		{
			get { return this.Fields["DocNo"]; }
		}
		public IUIField FieldBusinessDate
		{
			get { return this.Fields["BusinessDate"]; }
		}
		public IUIField FieldVersion
		{
			get { return this.Fields["Version"]; }
		}
		public IUIField FieldPrintAmount
		{
			get { return this.Fields["PrintAmount"]; }
		}
		public IUIField FieldLatestPrintedDate
		{
			get { return this.Fields["LatestPrintedDate"]; }
		}
		public IUIField FieldCancel_Canceled
		{
			get { return this.Fields["Cancel_Canceled"]; }
		}
		public IUIField FieldCancel_CancelDate
		{
			get { return this.Fields["Cancel_CancelDate"]; }
		}
		public IUIField FieldCancel_CancelReason
		{
			get { return this.Fields["Cancel_CancelReason"]; }
		}
		public IUIField FieldCancel_CancelUser
		{
			get { return this.Fields["Cancel_CancelUser"]; }
		}
		public IUIField FieldWorkFlowID
		{
			get { return this.Fields["WorkFlowID"]; }
		}
		public IUIField FieldStateMachineID
		{
			get { return this.Fields["StateMachineID"]; }
		}
		public IUIField FieldHoldReason
		{
			get { return this.Fields["HoldReason"]; }
		}
		public IUIField FieldHoldReason_Code
		{
			get { return this.Fields["HoldReason_Code"]; }
		}
		public IUIField FieldHoldReason_Name
		{
			get { return this.Fields["HoldReason_Name"]; }
		}
		public IUIField FieldHoldUser
		{
			get { return this.Fields["HoldUser"]; }
		}
		public IUIField FieldHoldDate
		{
			get { return this.Fields["HoldDate"]; }
		}
		public IUIField FieldReleaseReason
		{
			get { return this.Fields["ReleaseReason"]; }
		}
		public IUIField FieldReleaseReason_Code
		{
			get { return this.Fields["ReleaseReason_Code"]; }
		}
		public IUIField FieldReleaseReason_Name
		{
			get { return this.Fields["ReleaseReason_Name"]; }
		}
		public IUIField FieldReleaseUser
		{
			get { return this.Fields["ReleaseUser"]; }
		}
		public IUIField FieldReleaseDate
		{
			get { return this.Fields["ReleaseDate"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg1
		{
			get { return this.Fields["DescFlexField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg2
		{
			get { return this.Fields["DescFlexField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg3
		{
			get { return this.Fields["DescFlexField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg4
		{
			get { return this.Fields["DescFlexField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg5
		{
			get { return this.Fields["DescFlexField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg6
		{
			get { return this.Fields["DescFlexField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg7
		{
			get { return this.Fields["DescFlexField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg8
		{
			get { return this.Fields["DescFlexField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg9
		{
			get { return this.Fields["DescFlexField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg10
		{
			get { return this.Fields["DescFlexField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg11
		{
			get { return this.Fields["DescFlexField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg12
		{
			get { return this.Fields["DescFlexField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg13
		{
			get { return this.Fields["DescFlexField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg14
		{
			get { return this.Fields["DescFlexField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg15
		{
			get { return this.Fields["DescFlexField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg16
		{
			get { return this.Fields["DescFlexField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg17
		{
			get { return this.Fields["DescFlexField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg18
		{
			get { return this.Fields["DescFlexField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg19
		{
			get { return this.Fields["DescFlexField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg20
		{
			get { return this.Fields["DescFlexField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg21
		{
			get { return this.Fields["DescFlexField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg22
		{
			get { return this.Fields["DescFlexField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg23
		{
			get { return this.Fields["DescFlexField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg24
		{
			get { return this.Fields["DescFlexField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg25
		{
			get { return this.Fields["DescFlexField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg26
		{
			get { return this.Fields["DescFlexField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg27
		{
			get { return this.Fields["DescFlexField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg28
		{
			get { return this.Fields["DescFlexField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg29
		{
			get { return this.Fields["DescFlexField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg30
		{
			get { return this.Fields["DescFlexField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg31
		{
			get { return this.Fields["DescFlexField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg32
		{
			get { return this.Fields["DescFlexField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg33
		{
			get { return this.Fields["DescFlexField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg34
		{
			get { return this.Fields["DescFlexField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg35
		{
			get { return this.Fields["DescFlexField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg36
		{
			get { return this.Fields["DescFlexField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg37
		{
			get { return this.Fields["DescFlexField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg38
		{
			get { return this.Fields["DescFlexField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg39
		{
			get { return this.Fields["DescFlexField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg40
		{
			get { return this.Fields["DescFlexField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg41
		{
			get { return this.Fields["DescFlexField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg42
		{
			get { return this.Fields["DescFlexField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg43
		{
			get { return this.Fields["DescFlexField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg44
		{
			get { return this.Fields["DescFlexField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg45
		{
			get { return this.Fields["DescFlexField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg46
		{
			get { return this.Fields["DescFlexField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg47
		{
			get { return this.Fields["DescFlexField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg48
		{
			get { return this.Fields["DescFlexField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg49
		{
			get { return this.Fields["DescFlexField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFlexField_PubDescSeg50
		{
			get { return this.Fields["DescFlexField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFlexField_ContextValue
		{
			get { return this.Fields["DescFlexField_ContextValue"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg1
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg2
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg3
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg4
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg5
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg6
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg7
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg8
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg9
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg10
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg11
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg12
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg13
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg14
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg15
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg16
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg17
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg18
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg19
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg20
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg21
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg22
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg23
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg24
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg25
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg26
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg27
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg28
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg29
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFlexField_CombineName
		{
			get { return this.Fields["DescFlexField_CombineName"]; }
		}
		public IUIField FieldFlowInstance
		{
			get { return this.Fields["FlowInstance"]; }
		}
		public IUIField FieldDispatchCompleteOrderDocType
		{
			get { return this.Fields["DispatchCompleteOrderDocType"]; }
		}
		public IUIField FieldDispatchCompleteOrderDocType_Code
		{
			get { return this.Fields["DispatchCompleteOrderDocType_Code"]; }
		}
		public IUIField FieldDispatchCompleteOrderDocType_Name
		{
			get { return this.Fields["DispatchCompleteOrderDocType_Name"]; }
		}
		public IUIField FieldProject
		{
			get { return this.Fields["Project"]; }
		}
		public IUIField FieldProject_Code
		{
			get { return this.Fields["Project_Code"]; }
		}
		public IUIField FieldProject_Name
		{
			get { return this.Fields["Project_Name"]; }
		}
		public IUIField FieldTask
		{
			get { return this.Fields["Task"]; }
		}
		public IUIField FieldTask_Code
		{
			get { return this.Fields["Task_Code"]; }
		}
		public IUIField FieldTask_Name
		{
			get { return this.Fields["Task_Name"]; }
		}
		public IUIField FieldDispatchOrderDoc
		{
			get { return this.Fields["DispatchOrderDoc"]; }
		}
		public IUIField FieldDepartment
		{
			get { return this.Fields["Department"]; }
		}
		public IUIField FieldDepartment_Code
		{
			get { return this.Fields["Department_Code"]; }
		}
		public IUIField FieldDepartment_Name
		{
			get { return this.Fields["Department_Name"]; }
		}
		public IUIField FieldShiftGroup
		{
			get { return this.Fields["ShiftGroup"]; }
		}
		public IUIField FieldShiftGroup_Code
		{
			get { return this.Fields["ShiftGroup_Code"]; }
		}
		public IUIField FieldShiftGroup_Name
		{
			get { return this.Fields["ShiftGroup_Name"]; }
		}
		public IUIField FieldPerson
		{
			get { return this.Fields["Person"]; }
		}
		public IUIField FieldPerson_Code
		{
			get { return this.Fields["Person_Code"]; }
		}
		public IUIField FieldPerson_Name
		{
			get { return this.Fields["Person_Name"]; }
		}
		public IUIField FieldStatus
		{
			get { return this.Fields["Status"]; }
		}
		public IUIField FieldCompleteQty
		{
			get { return this.Fields["CompleteQty"]; }
		}
		public IUIField FieldSchedule
		{
			get { return this.Fields["Schedule"]; }
		}
		public IUIField FieldActualStartTime
		{
			get { return this.Fields["ActualStartTime"]; }
		}
		public IUIField FieldActualCompleteTime
		{
			get { return this.Fields["ActualCompleteTime"]; }
		}
		public IUIField FieldWorkHourUOM
		{
			get { return this.Fields["WorkHourUOM"]; }
		}
		public IUIField FieldWorkHourUOM_Code
		{
			get { return this.Fields["WorkHourUOM_Code"]; }
		}
		public IUIField FieldWorkHourUOM_Name
		{
			get { return this.Fields["WorkHourUOM_Name"]; }
		}
		public IUIField FieldActualWorkHours
		{
			get { return this.Fields["ActualWorkHours"]; }
		}
		public IUIField FieldDescFlexFields
		{
			get { return this.Fields["DescFlexFields"]; }
		}
		public IUIField FieldMemo
		{
			get { return this.Fields["Memo"]; }
		}
		public IUIField FieldWorkHourUOM_Round_Precision
		{
			get { return this.Fields["WorkHourUOM_Round_Precision"]; }
		}
		public IUIField FieldWorkHourUOM_Round_RoundType
		{
			get { return this.Fields["WorkHourUOM_Round_RoundType"]; }
		}
		public IUIField FieldWorkHourUOM_Round_RoundValue
		{
			get { return this.Fields["WorkHourUOM_Round_RoundValue"]; }
		}
		public IUIField FieldDispatchOrderDoc_ItemMaster_ID
		{
			get { return this.Fields["DispatchOrderDoc_ItemMaster_ID"]; }
		}
		public IUIField FieldDispatchOrderDoc_ItemMaster_Code
		{
			get { return this.Fields["DispatchOrderDoc_ItemMaster_Code"]; }
		}
		public IUIField FieldDispatchOrderDoc_ItemMaster_Name
		{
			get { return this.Fields["DispatchOrderDoc_ItemMaster_Name"]; }
		}
		public IUIField FieldDispatchOrderDoc_ItemMaster
		{
			get { return this.Fields["DispatchOrderDoc_ItemMaster"]; }
		}
		public IUIField FieldDispatchOrderDoc_OutputUOM
		{
			get { return this.Fields["DispatchOrderDoc_OutputUOM"]; }
		}
		public IUIField FieldDispatchOrderDoc_OutputUOM_Code
		{
			get { return this.Fields["DispatchOrderDoc_OutputUOM_Code"]; }
		}
		public IUIField FieldDispatchOrderDoc_OutputUOM_Name
		{
			get { return this.Fields["DispatchOrderDoc_OutputUOM_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public DispatchCompleteOrderDocDefaultFilterFilter DefaultFilter
		{
			get { return (DispatchCompleteOrderDocDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","57bd23d7-51e4-4dec-ad98-82e64a4019b4");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","bf5dbeb3-1bd9-4f77-845a-d30d66d3d250");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ad3d4d9-740f-48b7-aafb-9398f631f53e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d95ff071-00b6-470b-afe8-7733eb516a5e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd5d24d8-5765-4025-8809-906b9c8d6680");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3d90b52e-6043-491e-8317-d81f7ac48f1f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","a7aec35f-36ea-49a4-826f-88eae8a30973");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9d282f15-fe48-4d2a-9ab9-7dd21f7b5132");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c75ffcd-70ac-4cc4-9b90-bad306872334");
			UIModelRuntimeFactory.AddNewUIField(this,"DocNo", typeof(String), false,"","System.String", "DocNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","202996cc-a277-4664-8c56-176f029477f5");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessDate", typeof(DateTime), false,"","System.Date", "BusinessDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","09be8f5f-e11f-4a57-b86b-63d2cd23d035");
			UIModelRuntimeFactory.AddNewUIField(this,"Version", typeof(Int32), true,"0","System.Int32", "Version", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","31350e7d-3621-4867-acd5-c325227239c4");
			UIModelRuntimeFactory.AddNewUIField(this,"PrintAmount", typeof(Int32), true,"0","System.Int32", "PrintAmount", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","81ca6024-e1f8-4071-a3b7-c919ce0ad9d7");
			UIModelRuntimeFactory.AddNewUIField(this,"LatestPrintedDate", typeof(DateTime), true,"","System.DateTime", "LatestPrintedDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ae2e735b-1b33-491b-8ff0-4ea52fbbdf20");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_Canceled", typeof(Boolean), true,"false","System.Boolean", "Cancel.Canceled", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","b8665ac3-909a-4051-a6e8-7425390a65f0");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelDate", typeof(DateTime), true,"","System.DateTime", "Cancel.CancelDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","cc39fe00-f4b5-4887-9c13-c8965b84f30b");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelReason", typeof(String), true,"","System.String", "Cancel.CancelReason", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5af642a7-3fc0-4e5d-81e5-f673395d0d7a");
			UIModelRuntimeFactory.AddNewUIField(this,"Cancel_CancelUser", typeof(String), true,"","System.String", "Cancel.CancelUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dcd18211-ef60-4812-8711-fb24f90edfef");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkFlowID", typeof(Guid), true,"","System.Guid", "WorkFlowID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","a84632cf-a48c-4d96-9c4b-1a6b7b890b17");
			UIModelRuntimeFactory.AddNewUIField(this,"StateMachineID", typeof(Guid), true,"","System.Guid", "StateMachineID", true,true, false, "",false,(UIFieldType)1,"2b057235-c58e-441e-9477-5e52fcb7f95b","6f3151fb-f0cf-428d-8190-32f273288ff8");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.HoldReason", "HoldReason", true,true, false, "",false,(UIFieldType)4,"aca6401c-cd2c-460c-9883-a704f9ea93a6","558313ed-4c9f-4367-842c-35bfeea22ad1");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Code", typeof(String), false,"","System.String", "HoldReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","451e091d-1b5f-4bc7-a2d1-1d04fca77623");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldReason_Name", typeof(String), true,"","System.String", "HoldReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44d2ea19-a5d3-4bb9-adc1-6c82b5738881");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldUser", typeof(String), true,"","System.String", "HoldUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4c67226-477c-4e68-bd81-5a3eb64a4837");
			UIModelRuntimeFactory.AddNewUIField(this,"HoldDate", typeof(DateTime), true,"","System.DateTime", "HoldDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d03e29c7-f145-4aee-b197-64d8756444f4");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason", typeof(Int64), true,"","UFIDA.U9.Base.HoldRelease.ReleaseReason", "ReleaseReason", true,true, false, "",false,(UIFieldType)4,"8f4c20a0-ea48-4e30-a76a-1f8d38bcc7cc","140bec4a-ca2f-4d62-b5f9-79b2ef191c52");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Code", typeof(String), false,"","System.String", "ReleaseReason.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","17763723-9b71-4ff4-b9ba-4d6d802b502e");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseReason_Name", typeof(String), true,"","System.String", "ReleaseReason.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1b06649a-2032-47b6-bc40-22ba13a7bad9");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseUser", typeof(String), true,"","System.String", "ReleaseUser", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","733860d2-99eb-445a-ab55-0dd20517a104");
			UIModelRuntimeFactory.AddNewUIField(this,"ReleaseDate", typeof(DateTime), true,"","System.DateTime", "ReleaseDate", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ea7a950c-3c4d-4201-9816-f8c235341780");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4aa2a63-b621-489c-9137-0489bf5b61b9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3fec4b22-1956-40a1-a72b-601cbc2bb220");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","391236a1-d274-4ea8-b871-0d94541a4a9a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d85c6b97-fe31-4b73-8ae8-f063f96f4f95");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d14f1e5-fb86-486e-8979-58e465485808");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4415f88d-710e-4cd0-b2f9-a5bd6928f328");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","527df977-5e70-48d9-b8a7-1d3bc8ead4b0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a4cf7f23-f229-47f5-a9ba-b10f681b9b43");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","64c454a1-611e-4c3b-802e-a9b1a4cb55b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd347acc-9790-4882-ae58-d1edde85387b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8467fb7b-13fb-4717-b8bb-5a8ec9dc03ef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b6109ec7-ec7f-46bf-8dd7-5389914e9db0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74ef240c-566e-4ea3-9e1d-86efd1cc1b8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","811e12ed-f49c-4000-bfd0-283450b41f4d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3f2e0223-d0bf-49d5-914c-7cc690633dbb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f08a3f27-e286-4b6b-8865-e0af363f107f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","549f3939-fa65-48c4-8aa6-d46b685b362d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","27d31d23-31fc-4841-bdd8-a07cce8eed8a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bf74df18-c6b4-4a6a-91c5-be935510a901");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b0937521-d178-4569-8615-685ea5405e16");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6571ab66-cd44-4f03-8d4f-0cef9ce2dfc8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20cdb34e-498d-447f-ab86-6c5564252b16");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2f7befe-23c9-477a-8167-5c7217ff4262");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","268d909a-94a8-48f3-8db1-7a228a8a7fa4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f46dd041-8f8b-4fbf-9d15-2bc49da0a787");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","548519d4-c8ae-48b0-8ffc-e05ec8f9629c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","934b54e0-efda-4866-814a-92a7bc92b607");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dd861712-f04c-498c-a88c-80afd882af06");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aeb2614b-3ca6-4ab7-bf46-c6f3094898b0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9d7fe28e-50f4-4602-8110-654dc762e5a7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg31", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91e90c3f-fa2f-4644-b5f1-070608badcf1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg32", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f90e3901-8e2b-4f23-a7a2-387e314ae62b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg33", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bdd57452-ffe4-42c7-8744-f872c435246a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg34", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9d4c89e3-379f-44ea-8981-094990a98a29");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg35", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d94dbfe1-8a20-4ee1-99d5-a67702fec72d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg36", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7943219d-2df5-4a48-b3f8-31d8e08bc512");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg37", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","73bc16c2-caa6-46e8-b98d-7a1cdb3d227d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg38", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89bb5405-7a50-4c57-9dfc-17aa40bc5c04");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg39", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6844e425-499a-4259-9b88-09903907576a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg40", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3bec944-89ad-4c00-abd3-7163e51293ab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg41", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","42551df4-f52d-4728-97f4-cb3333e6233b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg42", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1f94af8-59fe-4a9f-8bb4-40f3ed028b42");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg43", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","83633830-c77c-40d5-89e9-62373bb601d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg44", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","465fabe2-2ef7-403f-9694-6b76ef19ee94");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg45", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","75effb21-71f9-43e7-89ae-b328c02185a0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg46", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cedd045d-2a6d-49a4-9af7-c0a2d3191c03");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg47", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","81d271d8-e789-47fe-b2e3-4158e8028322");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg48", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","13e008d3-85b8-4b95-b8b1-a54744ce1f83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg49", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9f0b3ba3-e673-416c-85ab-04cc7bc2f22b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PubDescSeg50", typeof(String), true,"","System.String", "DescFlexField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dde06435-e786-4d24-af7b-72c9fd05bf2f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_ContextValue", typeof(String), true,"","System.String", "DescFlexField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6e8fd05e-da25-4573-8d7c-c82d20daf91f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fca6714c-2c27-410e-8986-f95c5490ceba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4c7d714b-baf1-4153-997b-e38ca11f8e77");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08799dbe-8a37-40cd-b879-9a655416dfbe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae50cbeb-782a-4483-acc3-fd1151d11372");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a059f29a-aa2f-4640-a7a5-1fe3ad3f471e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","acfdb850-4329-4dff-8fc0-cd9841df2d0c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cebc3d55-0d78-46a9-889c-2474b185f811");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1917ef42-3626-4d9d-8129-af5eed781608");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","815ccb4d-ff12-42bc-a059-3b79e5534423");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f339e399-a650-4b3e-827f-2ab262c24483");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3087febf-c662-4a6c-bf5e-0f987fed923d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59613d23-2001-4642-a79e-3f07889fd3da");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","37178463-b042-40c5-86cc-1b7e82b56f62");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","afb5f7be-5647-4501-8ca2-27cd8e64cc81");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","32178614-1e60-462f-bad8-b84a79d9058b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e352a881-6e4c-4312-8092-39cc06de7b43");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63f44d69-4368-43a2-809a-190a06d4b592");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4abb7689-956d-4176-b441-25d6133bd1d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0014ae0-7244-4428-8119-ed5079e1b0e7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6846ce5-5afb-42b4-9c95-781fb4ab5eca");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","db274ca9-8f6c-4a10-805e-8572b40bbb52");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","491f59e5-18de-4404-83f3-156d0ee7445f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1db1f02a-2ba3-4acd-aac4-7cf8d6a44d87");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b9b8adfd-fa1a-492e-866e-164ebc4b873a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4b76f279-ca4c-45e8-8cf9-1e2d35361f1b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5c667a00-0015-4366-ac49-ce7d6d5339b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0bd928a8-505a-42e0-8139-de35873058a5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1bdc19e-9ba4-4aa9-bc99-f3912485b1aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b60b4d94-19af-4317-ad71-bd9e113f6cc0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f0d7f1cb-51c5-4159-b722-c07ebe864da3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_CombineName", typeof(String), true,"","System.String", "DescFlexField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0d1a2539-0738-4eec-abd3-04d627a8a5f5");
			UIModelRuntimeFactory.AddNewUIField(this,"FlowInstance", typeof(Int64), true,"","UFIDA.U9.CS.Workflow.WorkflowInstanceBE.FlowInstance", "FlowInstance", true,true, false, "",false,(UIFieldType)4,"d87a7006-6643-42f4-98f4-168847a71955","de5cc7e7-9c3b-4144-be8b-6d68d645c783");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchCompleteOrderDocType", typeof(Int64), false,"","UFIDA.U9.PFM.DispatchCompleteOrderDocTypeBE.DispatchCompleteOrderDocType", "DispatchCompleteOrderDocType", true,true, false, "",false,(UIFieldType)4,"f3bf0bcd-2661-4505-9116-b7ec5cec77ce","c141e3c8-7f56-4c0a-963c-2ebbfc1b30c0");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchCompleteOrderDocType_Code", typeof(String), false,"","System.String", "DispatchCompleteOrderDocType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2fbe381e-f6f1-486f-bcdf-42c415c66eea");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchCompleteOrderDocType_Name", typeof(String), true,"","System.String", "DispatchCompleteOrderDocType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","591c6aa6-d9cf-443b-b8ec-4edcc02877f7");
			UIModelRuntimeFactory.AddNewUIField(this,"Project", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.ProjectTask.Project", "Project", true,true, false, "",false,(UIFieldType)4,"7bc6294b-1a35-4e37-acfe-5abc5602f12f","511f47f8-70b9-481a-a7fe-568220f3895f");
			UIModelRuntimeFactory.AddNewUIField(this,"Project_Code", typeof(String), false,"","System.String", "Project.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","853ffe0c-4e4c-4844-9537-9f210f5e5ca0");
			UIModelRuntimeFactory.AddNewUIField(this,"Project_Name", typeof(String), true,"","System.String", "Project.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","96fa9b6c-4dcf-48c2-b4ad-cd2a4be3c7d7");
			UIModelRuntimeFactory.AddNewUIField(this,"Task", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.ProjectTask.Task", "Task", true,true, false, "",false,(UIFieldType)4,"c833b8ac-15da-48f8-872b-fc37ba0005eb","5f79bc37-a6f5-4d79-92d6-270514e606a8");
			UIModelRuntimeFactory.AddNewUIField(this,"Task_Code", typeof(String), false,"","System.String", "Task.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","12276f68-ca6c-4a59-ada9-0b1e8b8f17cb");
			UIModelRuntimeFactory.AddNewUIField(this,"Task_Name", typeof(String), true,"","System.String", "Task.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","336bc53f-cda0-455f-aaeb-54865775cc58");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc", typeof(Int64), false,"","UFIDA.U9.PFM.DispatchOrderDocBE.DispatchOrderDoc", "DispatchOrderDoc", true,true, false, "",false,(UIFieldType)4,"e57c957a-ac18-4290-8577-bb4a8e6f7602","f998570c-7574-407f-bd76-16835d29c347");
			UIModelRuntimeFactory.AddNewUIField(this,"Department", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Department.Department", "Department", true,true, false, "",false,(UIFieldType)4,"3410e657-4f0f-47a9-9cf1-d1c421c116a8","7a2d876f-c866-407d-83c1-4425aba09846");
			UIModelRuntimeFactory.AddNewUIField(this,"Department_Code", typeof(String), false,"","System.String", "Department.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a7c419cc-45d8-49b2-b45e-ac1e37b8f855");
			UIModelRuntimeFactory.AddNewUIField(this,"Department_Name", typeof(String), true,"","System.String", "Department.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d4b9cc32-c647-4c47-b38b-4009a4e99127");
			UIModelRuntimeFactory.AddNewUIField(this,"ShiftGroup", typeof(Int64), true,"","UFIDA.U9.CBO.MFG.ShiftGroupBE.ShiftGroup", "ShiftGroup", true,true, false, "",false,(UIFieldType)4,"06518865-678d-4b4b-bd7b-54133a109a4d","6b752238-8481-4f1a-a875-cf451a581f02");
			UIModelRuntimeFactory.AddNewUIField(this,"ShiftGroup_Code", typeof(String), false,"","System.String", "ShiftGroup.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fc0b1f91-550a-4736-ad69-30009bc67161");
			UIModelRuntimeFactory.AddNewUIField(this,"ShiftGroup_Name", typeof(String), true,"","System.String", "ShiftGroup.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","20d3d3c3-4d92-4b3b-9c00-644071f6e52e");
			UIModelRuntimeFactory.AddNewUIField(this,"Person", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "Person", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","22f6a230-5085-402f-8797-f73b6a3fb715");
			UIModelRuntimeFactory.AddNewUIField(this,"Person_Code", typeof(String), false,"","System.String", "Person.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba892e6a-1bde-4cee-ac75-678fff8d33ee");
			UIModelRuntimeFactory.AddNewUIField(this,"Person_Name", typeof(String), true,"","System.String", "Person.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9e685623-d4fc-4e3c-9a99-c5bd3f412a0a");
			UIModelRuntimeFactory.AddNewUIField(this,"Status", typeof(Int32), false,"0","UFIDA.U9.PFM.DispatchOrderDocBE.DispatchStatusEnum", "Status", true,true, false, "",false,(UIFieldType)2,"a3dbd87d-98c7-43b1-9106-b94f191509da","f2d01947-cd25-43d2-9b8b-ee4d462ff8ed");
			UIModelRuntimeFactory.AddNewUIField(this,"CompleteQty", typeof(Decimal), true,"0","System.Decimal", "CompleteQty", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","2f3c37f4-9fd9-4948-aacc-6b4bd67b8a3b");
			UIModelRuntimeFactory.AddNewUIField(this,"Schedule", typeof(Decimal), true,"0","System.Decimal", "Schedule", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","1cd2a9c9-d452-4fc8-aaf6-0659c017d4ab");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualStartTime", typeof(DateTime), false,"","System.DateTime", "ActualStartTime", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","e34bb9b0-6784-4cfe-b6de-e019231a009d");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualCompleteTime", typeof(DateTime), false,"","System.DateTime", "ActualCompleteTime", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","2ceaf0be-cbee-4bc6-a21d-bf437f5fb1d7");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkHourUOM", typeof(Int64), false,"","UFIDA.U9.Base.UOM.UOM", "WorkHourUOM", true,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","30d4fb52-a72b-4d1c-8ac1-e9e64c3d494c");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkHourUOM_Code", typeof(String), false,"","System.String", "WorkHourUOM.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","34049ea7-8429-404b-8640-cce4fc2b1551");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkHourUOM_Name", typeof(String), true,"","System.String", "WorkHourUOM.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7f5cbc8a-cfa8-4353-9850-e1c4806742c0");
			UIModelRuntimeFactory.AddNewUIField(this,"ActualWorkHours", typeof(Decimal), false,"0","System.Decimal", "ActualWorkHours", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","371dcf7b-8f0f-4954-9123-aa74582e6f63");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexFields", typeof(Int64), true,"","UFIDA.U9.Base.FlexField.DescFlexField.DescFlexFieldDef", "DescFlexFields", true,true, false, "",false,(UIFieldType)4,"7783e578-3f73-41b2-99a9-844eec59c4d1","f01cab96-b679-40aa-b60c-64b9e65a06da");
			UIModelRuntimeFactory.AddNewUIField(this,"Memo", typeof(String), true,"","System.String", "Memo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7481ff91-a842-44ec-a63a-da68a727eb58");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkHourUOM_Round_Precision", typeof(Int32), false,"0","System.Int32", "WorkHourUOM.Round.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","2691de19-70a6-4666-9b26-764e05b703b2");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkHourUOM_Round_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "WorkHourUOM.Round.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","babaaa16-f6fc-43ae-9560-7d752d485c09");
			UIModelRuntimeFactory.AddNewUIField(this,"WorkHourUOM_Round_RoundValue", typeof(Int32), true,"0","System.Int32", "WorkHourUOM.Round.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","427076ed-2614-472d-84ad-46f60c67dfd3");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_ItemMaster_ID", typeof(Int64), false,"","System.Int64", "DispatchOrderDoc.ItemMaster.ID", false,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b186e9d3-90d4-44d4-9d2c-23f76dd02550");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_ItemMaster_Code", typeof(String), false,"","System.String", "DispatchOrderDoc.ItemMaster.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1093efae-c6a4-43f4-9aa4-665513e65213");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_ItemMaster_Name", typeof(String), false,"","System.String", "DispatchOrderDoc.ItemMaster.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d1794cc-f02e-4b56-bfa1-471e00942907");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_ItemMaster", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "DispatchOrderDoc.ItemMaster", false,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","c9c7bcab-42f2-4694-ad83-529c042d5989");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_OutputUOM", typeof(Int64), true,"","UFIDA.U9.Base.UOM.UOM", "DispatchOrderDoc.OutputUOM", false,true, false, "",false,(UIFieldType)4,"ff454e91-0d57-445e-aef2-03cedea46843","970d1634-4367-43a4-8dd4-0d698750ba7a");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_OutputUOM_Code", typeof(String), false,"","System.String", "DispatchOrderDoc.OutputUOM.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","079be88b-278c-4bac-aee5-d06ca2499f52");
			UIModelRuntimeFactory.AddNewUIField(this,"DispatchOrderDoc_OutputUOM_Name", typeof(String), true,"","System.String", "DispatchOrderDoc.OutputUOM.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","00d512a1-f3ad-4092-90b0-1424911d294c");


			this.CurrentFilter = new DispatchCompleteOrderDocDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new DispatchCompleteOrderDocRecord(builder);
		}
		#endregion

		#region new method
		public new DispatchCompleteOrderDocRecord FocusedRecord
		{
			get { return (DispatchCompleteOrderDocRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new DispatchCompleteOrderDocRecord AddNewUIRecord()
		{	
			return (DispatchCompleteOrderDocRecord)base.AddNewUIRecord();
		}
		public new DispatchCompleteOrderDocRecord NewUIRecord()
		{	
			return (DispatchCompleteOrderDocRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class DispatchCompleteOrderDocRecord : UIRecord
	{
		#region Constructor
		public DispatchCompleteOrderDocRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private DispatchCompleteOrderDocView uiviewDispatchCompleteOrderDoc
		{
			get { return (DispatchCompleteOrderDocView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new DispatchCompleteOrderDocRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldID);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDispatchCompleteOrderDoc.FieldCreatedOn);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldCreatedBy);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDispatchCompleteOrderDoc.FieldModifiedOn);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldModifiedBy);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldSysVersion);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldOrg);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldOrg_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldOrg_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldOrg_Name] = value;
			}
		}
		
		
		public  String DocNo
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDocNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDocNo);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDocNo] = value;
			}
		}
		
		
		public  DateTime BusinessDate
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldBusinessDate] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewDispatchCompleteOrderDoc.FieldBusinessDate);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldBusinessDate] = value;
			}
		}
		
		
		public  Int32? Version
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldVersion] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDispatchCompleteOrderDoc.FieldVersion);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldVersion] = value;
			}
		}
		
		
		public  Int32? PrintAmount
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldPrintAmount] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDispatchCompleteOrderDoc.FieldPrintAmount);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldPrintAmount] = value;
			}
		}
		
		
		public  DateTime? LatestPrintedDate
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldLatestPrintedDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDispatchCompleteOrderDoc.FieldLatestPrintedDate);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldLatestPrintedDate] = value;
			}
		}
		
		
		public  Boolean? Cancel_Canceled
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_Canceled] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewDispatchCompleteOrderDoc.FieldCancel_Canceled);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_Canceled] = value;
			}
		}
		
		
		public  DateTime? Cancel_CancelDate
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelDate);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelDate] = value;
			}
		}
		
		
		public  String Cancel_CancelReason
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelReason] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelReason);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelReason] = value;
			}
		}
		
		
		public  String Cancel_CancelUser
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelUser);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCancel_CancelUser] = value;
			}
		}
		
		
		public  Guid WorkFlowID
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkFlowID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewDispatchCompleteOrderDoc.FieldWorkFlowID);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkFlowID] = value;
			}
		}
		
		
		public  Guid StateMachineID
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldStateMachineID] ;
				//return (Guid)value;
				return GetValue<Guid>(this.uiviewDispatchCompleteOrderDoc.FieldStateMachineID);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldStateMachineID] = value;
			}
		}
		
		
		public  Int64? HoldReason
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldHoldReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldHoldReason);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldHoldReason] = value;
			}
		}
		
		
		public  String HoldReason_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldHoldReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldHoldReason_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldHoldReason_Code] = value;
			}
		}
		
		
		public  String HoldReason_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldHoldReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldHoldReason_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldHoldReason_Name] = value;
			}
		}
		
		
		public  String HoldUser
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldHoldUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldHoldUser);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldHoldUser] = value;
			}
		}
		
		
		public  DateTime? HoldDate
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldHoldDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDispatchCompleteOrderDoc.FieldHoldDate);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldHoldDate] = value;
			}
		}
		
		
		public  Int64? ReleaseReason
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason] = value;
			}
		}
		
		
		public  String ReleaseReason_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason_Code] = value;
			}
		}
		
		
		public  String ReleaseReason_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseReason_Name] = value;
			}
		}
		
		
		public  String ReleaseUser
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseUser] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldReleaseUser);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseUser] = value;
			}
		}
		
		
		public  DateTime? ReleaseDate
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDispatchCompleteOrderDoc.FieldReleaseDate);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldReleaseDate] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg1);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg2);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg3);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg4);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg5);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg6);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg7);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg8);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg9);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg10);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg11);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg12);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg13);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg14);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg15);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg16);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg17);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg18);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg19);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg20);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg21);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg22);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg23);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg24);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg25);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg26);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg27);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg28);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg29);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg30);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg31);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg32);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg33);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg34);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg35);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg36);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg37);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg38);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg39);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg40);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg41);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg42);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg43);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg44);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg45);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg46);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg47);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg48);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg49);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFlexField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg50);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFlexField_ContextValue
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_ContextValue);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_ContextValue] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFlexField_CombineName
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_CombineName);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexField_CombineName] = value;
			}
		}
		
		
		public  Int64? FlowInstance
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldFlowInstance] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldFlowInstance);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldFlowInstance] = value;
			}
		}
		
		
		public  Int64 DispatchCompleteOrderDocType
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType] = value;
			}
		}
		
		
		public  String DispatchCompleteOrderDocType_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Code] = value;
			}
		}
		
		
		public  String DispatchCompleteOrderDocType_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Name] = value;
			}
		}
		
		
		public  Int64 Project
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldProject] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldProject);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldProject] = value;
			}
		}
		
		
		public  String Project_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldProject_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldProject_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldProject_Code] = value;
			}
		}
		
		
		public  String Project_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldProject_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldProject_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldProject_Name] = value;
			}
		}
		
		
		public  Int64 Task
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldTask] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldTask);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldTask] = value;
			}
		}
		
		
		public  String Task_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldTask_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldTask_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldTask_Code] = value;
			}
		}
		
		
		public  String Task_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldTask_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldTask_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldTask_Name] = value;
			}
		}
		
		
		public  Int64 DispatchOrderDoc
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc] = value;
			}
		}
		
		
		public  Int64? Department
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDepartment] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldDepartment);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDepartment] = value;
			}
		}
		
		
		public  String Department_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDepartment_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDepartment_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDepartment_Code] = value;
			}
		}
		
		
		public  String Department_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDepartment_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDepartment_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDepartment_Name] = value;
			}
		}
		
		
		public  Int64? ShiftGroup
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup] = value;
			}
		}
		
		
		public  String ShiftGroup_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup_Code] = value;
			}
		}
		
		
		public  String ShiftGroup_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldShiftGroup_Name] = value;
			}
		}
		
		
		public  Int64? Person
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldPerson] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldPerson);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldPerson] = value;
			}
		}
		
		
		public  String Person_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldPerson_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldPerson_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldPerson_Code] = value;
			}
		}
		
		
		public  String Person_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldPerson_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldPerson_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldPerson_Name] = value;
			}
		}
		
		
		public  Int32 Status
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldStatus] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDispatchCompleteOrderDoc.FieldStatus);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldStatus] = value;
			}
		}
		
		
		public  Decimal? CompleteQty
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldCompleteQty] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewDispatchCompleteOrderDoc.FieldCompleteQty);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldCompleteQty] = value;
			}
		}
		
		
		public  Decimal? Schedule
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldSchedule] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewDispatchCompleteOrderDoc.FieldSchedule);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldSchedule] = value;
			}
		}
		
		
		public  DateTime ActualStartTime
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldActualStartTime] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewDispatchCompleteOrderDoc.FieldActualStartTime);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldActualStartTime] = value;
			}
		}
		
		
		public  DateTime ActualCompleteTime
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldActualCompleteTime] ;
				//return (DateTime)value;
				return GetValue<DateTime>(this.uiviewDispatchCompleteOrderDoc.FieldActualCompleteTime);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldActualCompleteTime] = value;
			}
		}
		
		
		public  Int64 WorkHourUOM
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM] = value;
			}
		}
		
		
		public  String WorkHourUOM_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Code] = value;
			}
		}
		
		
		public  String WorkHourUOM_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Name] = value;
			}
		}
		
		
		public  Decimal ActualWorkHours
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldActualWorkHours] ;
				//return (Decimal)value;
				return GetValue<Decimal>(this.uiviewDispatchCompleteOrderDoc.FieldActualWorkHours);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldActualWorkHours] = value;
			}
		}
		
		
		public  Int64? DescFlexFields
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexFields] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldDescFlexFields);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDescFlexFields] = value;
			}
		}
		
		
		public  String Memo
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldMemo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldMemo);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldMemo] = value;
			}
		}
		
		
		public  Int32 WorkHourUOM_Round_Precision
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_Precision);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_Precision] = value;
			}
		}
		
		
		public  Int32 WorkHourUOM_Round_RoundType
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundType);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundType] = value;
			}
		}
		
		
		public  Int32? WorkHourUOM_Round_RoundValue
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundValue);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundValue] = value;
			}
		}
		
		
		public  Int64 DispatchOrderDoc_ItemMaster_ID
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_ID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_ID);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_ID] = value;
			}
		}
		
		
		public  String DispatchOrderDoc_ItemMaster_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Code] = value;
			}
		}
		
		
		public  String DispatchOrderDoc_ItemMaster_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Name] = value;
			}
		}
		
		
		public  Int64? DispatchOrderDoc_ItemMaster
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster] = value;
			}
		}
		
		
		public  Int64? DispatchOrderDoc_OutputUOM
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM] = value;
			}
		}
		
		
		public  String DispatchOrderDoc_OutputUOM_Code
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Code);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Code] = value;
			}
		}
		
		
		public  String DispatchOrderDoc_OutputUOM_Name
		{
			get{
				//object value = this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Name);
			}
			set{
				this[this.uiviewDispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class DispatchCompleteOrderDocDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public DispatchCompleteOrderDocDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private DispatchCompleteOrderDocDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new DispatchCompleteOrderDocDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}