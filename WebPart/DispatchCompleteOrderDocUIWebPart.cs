


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:258226fd-e312-4612-8c07-29c0499be6e8 
 * Form Name:DispatchCompleteOrderDocUI
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUIModel
{
	[FormRegister("UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI","UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUIModel.DispatchCompleteOrderDocUIWebPart", "UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI.WebPart", "258226fd-e312-4612-8c07-29c0499be6e8","WebPart", "True", 992, 488)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI', 'UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUIModel.DispatchCompleteOrderDocUIWebPart', 'UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI.WebPart', '258226fd-e312-4612-8c07-29c0499be6e8')
	///<siteMapNode url="~/erp/simple.aspx?lnk=258226fd-e312-4612-8c07-29c0499be6e8" title="DispatchCompleteOrderDocUI"/>
    public partial class DispatchCompleteOrderDocUIWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DispatchCompleteOrderDocUIWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new DispatchCompleteOrderDocUIModelAction Action
		{
			get { return (DispatchCompleteOrderDocUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		DispatchCompleteOrderDocUIModelModel _uimodel=null;
		public new DispatchCompleteOrderDocUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new DispatchCompleteOrderDocUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as DispatchCompleteOrderDocUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnAdd;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnCopy;
        IUFSeparator Separator1;
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFButton QuickPrint;
        IUFCard Card0;
        IUFDropDownButton DDBtnQuery;
        IUFMenu WorkTimeData;
        IUFCard Card3;
        IUFTabControl TabControl0;
        IUFTabPage TabPage0;
        IUFLine BasicInfo;
        IUFLabel lblDocNo143;
        IUFFldTextBox DocNo143;
        IUFLabel lblDispatchCompleteOrderDocType230;
        IUFFldReference DispatchCompleteOrderDocType230;
        IUFLabel lblBusinessDate116;
        IUFFldDatePicker BusinessDate116;
        IUFLabel lblProject89;
        IUFFldReference Project89;
        IUFLabel lblTask80;
        IUFFldReference Task80;
        IUFLabel lblDispatchOrderDoc131;
        IUFFldReference DispatchOrderDoc131;
        IUFLabel lblDepartment113;
        IUFFldReference Department113;
        IUFLabel lblShiftGroup158;
        IUFFldReference ShiftGroup158;
        IUFLabel lblPerson150;
        IUFFldReference Person150;
        IUFLabel lblStatus137;
        IUFFldDropDownList Status137;
        IUFLabel lblActualStartTime189;
        IUFFldDatePicker ActualStartTime189;
        IUFLabel lblActualCompleteTime137;
        IUFFldDatePicker ActualCompleteTime137;
        IUFLabel lblWorkHourUOM140;
        IUFFldReference WorkHourUOM140;
        IUFLabel lblActualWorkHours167;
        IUFFldNumberControl ActualWorkHours167;
        IUFLine Line2;
        IUFLabel lblCompleteQty155;
        IUFFldNumberControl CompleteQty155;
        IUFLabel lblSchedule190;
        IUFFldNumberControl Schedule190;
        IUFLabel lblDispatchOrderDoc_ItemMaster118;
        IUFFldReference DispatchOrderDoc_ItemMaster118;
        IUFLabel lblDispatchOrderDoc_OutputUOM158;
        IUFFldReference DispatchOrderDoc_OutputUOM158;
        IUFTabPage Remark;
        IUFFldTextBox RemarkText;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public DispatchCompleteOrderDocUIWebPart()
        {
            FormID = "258226fd-e312-4612-8c07-29c0499be6e8";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnCancel.Click += new EventHandler(BtnCancel_Click);		
						
				//Button控件事件
			this.BtnAdd.Click += new EventHandler(BtnAdd_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.QuickPrint.Click += new EventHandler(QuickPrint_Click);		
						
				//DropDownButton下面的MenuModel控件事件
			this.WorkTimeData.ItemClick += new MenuItemHandle(WorkTimeData_Click);
			((PopMenuItem)this.WorkTimeData).MethodName = "WorkTimeData_Click";				
				

	
            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new DispatchCompleteOrderDocUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (DispatchCompleteOrderDocUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new DispatchCompleteOrderDocUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"DispatchCompleteOrderDocUI",true,992,488);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(419,bool.Parse("False")),new GridRowDef(29,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card3(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card3, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","3fb57dee-36ee-4bbd-8905-88dd2fa6c0b8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","1dceba8e-a273-4dda-b22c-64ede83ebeb4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","37ebebae-fbd5-49a2-aa01-acc35bd30c6f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","27320ea9-847d-42e3-b62b-d8abd095e6d1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","7ae698f7-e88f-4d82-b377-7c78a1fa7450");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","38c1c699-2e16-4860-86ac-d426cb88acd4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","0a92c08d-1db9-471a-bdaa-90b2ce08b4e7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","14fc3ac5-b16a-4e7c-9f8d-85f76d2243d0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","62f160c0-e6ed-4e25-a519-9d15e6dbf5f3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","0f3f674a-9072-4f0b-b3a1-1b8a47716e23");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","39c8a13e-f909-485e-9fb0-ec974b776266");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", "",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","62cb3e13-9359-49fc-a2ed-64b15fa4324c");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", "",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","51e03b72-3eb6-4cc7-827f-11784665f740");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","3721f1e7-f652-4b9c-b8cd-0f5e3ad3ec69");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","cb3aa2e4-3417-40d1-9c12-a642711033a3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","b3774157-fd17-462d-8cbb-22234007ba8e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","0165c921-a509-49ba-aee1-673ecaaeab4f");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","81239166-50be-416c-86bb-2d4634ed17b4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	                            this.QuickPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "QuickPrint", "True", "True", 35, 28,"25", "",true,false,"3a28c8d9-58b1-4932-bd22-a227b4d389b1","9d04a4cf-ebe6-4114-b29d-d7e57a7eca47","3a28c8d9-58b1-4932-bd22-a227b4d389b1");
		
            UIControlBuilder.SetButtonAccessKey(this.QuickPrint);
            this.QuickPrint.UIModel = this.Model.ElementID;
            this.QuickPrint.Action = "QuickPrint";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","3ad54f50-7f4b-4b6b-88fa-cb75f3f1ec17");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 29, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(22,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DDBtnQuery(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DDBtnQuery, "3");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				       
        private void _BuilderControl_DDBtnQuery(IUFContainer container)
        {
            IUFDropDownButton _dropDownButton = UIControlBuilder.BuildDropDownButton(container,"DDBtnQuery",true, true,"3"
            , 80, 22, 0, 0, 1, 1, "100","61a151e6-462e-4392-b264-c988ddd844b8","83342c58-cf3e-4de2-820e-252d97a92900");
            this.DDBtnQuery = _dropDownButton;
            
            ///foreach DropDownButton下的所有控件，增加到此容器
	                 this.WorkTimeData = UIControlBuilder.BuildDropDownButtonMenu(container,_dropDownButton,0,"WorkTimeData","", true, true,true,false,"WorkTimeData","01f43f88-c55f-47f7-a7d3-32a5512f8995","64d88cbd-225c-46d7-ae4a-4dee9d537f40","01f43f88-c55f-47f7-a7d3-32a5512f8995") ;
		 			
        }

	                   
        private IUFCard _BuilderControl_Card3(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card3",false,"none", true, true, "2","","8e43bb7b-2711-43b2-8194-4e5597ba95a3");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 419, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 2, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(417,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card3 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_TabControl0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.TabControl0, "1");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	         private void _BuilderControl_TabControl0(IUFContainer container)
        {
            IUFTabControl _UFTabControl = UIControlBuilder.BuildTabControl(container,"TabControl0",true, true, "1",EventResponseType.Client,971, 428, 0, 0, 1, 2, "100");
            ///foreach UFTabbedPane下的所有控件，增加到此容器
            _UFTabControl.TabPages.Add(_BuilderControl_TabPage0(_UFTabControl));
            _UFTabControl.TabPages.Add(_BuilderControl_Remark(_UFTabControl));
            this.TabControl0 = _UFTabControl;
        }

	        private IUFTabPage _BuilderControl_TabPage0(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"TabPage0",true, true, "1","ad16c26a-0bfe-4b1c-91a5-b0c6bf17491a","729de2dd-0ce8-47f7-b1f5-19ed2aff2b41");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 12, 16, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  this.Model.DispatchCompleteOrderDoc, "DispatchCompleteOrderDoc", "", null, 1, "现场派工申报单");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(149,bool.Parse("True")),new GridColumnDef(1,bool.Parse("True")),new GridColumnDef(4,bool.Parse("True")),new GridColumnDef(1,bool.Parse("True")),new GridColumnDef(1,bool.Parse("True")),new GridColumnDef(317,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(17,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(15,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.BasicInfo = UIControlBuilder.BuilderUFLine(_UFTabPage, "BasicInfo", 150, "Horizontal", "True", 150, 17, 0, 0, 1, 1, "100","00000000-0000-0000-0000-000000000000","0d0d1f94-4ffb-4183-84f3-bc97ca0a064a");
	

		
			UIControlBuilder.BuilderUFControl(this.BasicInfo, "0");		


				this.lblDocNo143 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDocNo143", "", "True", "True", "Right", 150, 20, 0, 2, 1, 1, "100","202996cc-a277-4664-8c56-176f029477f5","8cc97829-fea1-417b-b0fb-265e8ee5ab40");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocNo143, "1");		


				this.DocNo143 = UIControlBuilder.BuilderTextBox(_UFTabPage, "DocNo143", "False", "True", "True", "False", "Left", 0, 60, 0, 150, 20, 2, 2, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblDocNo143","","50","202996cc-a277-4664-8c56-176f029477f5","8be8e5ab-8970-40c1-bf72-c98be66a560c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocNo143, "False", "DocNo", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldDocNo, "DispatchCompleteOrderDoc");


		
			UIControlBuilder.BuilderUFControl(this.DocNo143, "2");		
		 

				this.lblDispatchCompleteOrderDocType230 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDispatchCompleteOrderDocType230", "", "True", "True", "Right", 150, 20, 0, 1, 1, 1, "100","c141e3c8-7f56-4c0a-963c-2ebbfc1b30c0","c70ddd9e-5813-4d08-947f-8d9594c184ff");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDispatchCompleteOrderDocType230, "3");		


				this.DispatchCompleteOrderDocType230 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"DispatchCompleteOrderDocType230",false,true, true,150, 20, 2, 1, 1, 1, "100","4",false,false,true,"lblDispatchCompleteOrderDocType230","c141e3c8-7f56-4c0a-963c-2ebbfc1b30c0","02d734b5-0663-43d7-a33f-dc3712542414");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DispatchCompleteOrderDocType230, "False", "DispatchCompleteOrderDocType", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.DispatchCompleteOrderDocType230,"edcb4511-0423-42dd-b9e9-db0b16b21094", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Code,this.Model.DispatchCompleteOrderDoc.FieldDispatchCompleteOrderDocType_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DispatchCompleteOrderDocType230,"DispatchCompleteOrderDocType230",new ReferenceOutputParam[]{new ReferenceOutputParam("DispatchCompleteOrderDocType230","ID","Key"),new ReferenceOutputParam("DispatchCompleteOrderDocType230","Code","Value"),new ReferenceOutputParam("DispatchCompleteOrderDocType230","Name","Text"),new ReferenceOutputParam("DispatchCompleteOrderDocType230","BusinessType","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.DispatchCompleteOrderDocType230, "4");		
		 

				this.lblBusinessDate116 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblBusinessDate116", "", "True", "True", "Right", 150, 20, 0, 3, 1, 1, "100","09be8f5f-e11f-4a57-b86b-63d2cd23d035","1bf71f3c-9ea4-4766-8418-f0e106960fa4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBusinessDate116, "5");		


				this.BusinessDate116 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "BusinessDate116", false, true, true, "Date","Left", 3, 60, 0, 150, 20, 2, 3, 1, 1, "100",true,false,"lblBusinessDate116","09be8f5f-e11f-4a57-b86b-63d2cd23d035","58a3b94f-0b6f-4de1-b038-822a77ea9500");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BusinessDate116, "False", "BusinessDate", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldBusinessDate, "DispatchCompleteOrderDoc");


		
			UIControlBuilder.BuilderUFControl(this.BusinessDate116, "6");		
		 

				this.lblProject89 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblProject89", "", "True", "True", "Right", 150, 20, 0, 4, 1, 1, "100","511f47f8-70b9-481a-a7fe-568220f3895f","d6d9d1e2-f2a4-402a-8980-9f9f1f464a4a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblProject89, "7");		


				this.Project89 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"Project89",false,true, true,150, 20, 2, 4, 1, 1, "100","8",false,false,true,"lblProject89","511f47f8-70b9-481a-a7fe-568220f3895f","b706920d-191e-4ddf-9d53-2008158e7f4c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Project89, "False", "Project", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldProject, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.Project89,"a790ec54-e159-4db9-a86c-3f50cb61adf3", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldProject_Code,this.Model.DispatchCompleteOrderDoc.FieldProject_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Project89,"Project89",new ReferenceInputParam[]{new ReferenceInputParam("Task","","Key","Task80",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("Project89", "Task", "Task80", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Project89,"Project89",new ReferenceOutputParam[]{new ReferenceOutputParam("Project89","ID","Key"),new ReferenceOutputParam("Project89","Code","Value"),new ReferenceOutputParam("Project89","Name","Text"),new ReferenceOutputParam("Project89","Description","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Project89, "8");		
		 

				this.lblTask80 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblTask80", "", "True", "True", "Right", 150, 20, 0, 5, 1, 1, "100","5f79bc37-a6f5-4d79-92d6-270514e606a8","901d9d28-2e98-40f4-a7f2-6ecd892eaab4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblTask80, "9");		


				this.Task80 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"Task80",false,true, true,150, 20, 2, 5, 1, 1, "100","10",false,false,true,"lblTask80","5f79bc37-a6f5-4d79-92d6-270514e606a8","dafa31f0-cbd6-41f7-956b-6ac37dc13c80");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Task80, "False", "Task", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldTask, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.Task80,"a4adfdc4-9d59-488e-9f8a-e51e6d8800f9", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldTask_Code,this.Model.DispatchCompleteOrderDoc.FieldTask_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Task80,"Task80",new ReferenceInputParam[]{new ReferenceInputParam("ProjectID","","Key","Project89",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("Task80", "ProjectID", "Project89", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Task80,"Task80",new ReferenceOutputParam[]{new ReferenceOutputParam("Task80","ID","Key"),new ReferenceOutputParam("Task80","Code","Value"),new ReferenceOutputParam("Task80","Name","Text"),new ReferenceOutputParam("Task80","Description","Text"),new ReferenceOutputParam("Project89","Project_ID","Key"),new ReferenceOutputParam("Project89","Project_Code","Value"),new ReferenceOutputParam("Project89","Project_Name","Text"),new ReferenceOutputParam("Project89","Project_Description","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Task80, "10");		
		 

				this.lblDispatchOrderDoc131 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDispatchOrderDoc131", "", "True", "True", "Right", 150, 20, 0, 6, 1, 1, "100","f998570c-7574-407f-bd76-16835d29c347","cad7a03e-ef93-48c9-845c-d43bd21cd5ab");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDispatchOrderDoc131, "11");		


				this.DispatchOrderDoc131 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"DispatchOrderDoc131",false,true, true,150, 20, 2, 6, 1, 1, "100","12",false,false,true,"lblDispatchOrderDoc131","f998570c-7574-407f-bd76-16835d29c347","c06564c8-b7a6-41e2-801f-c682b8c72147");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DispatchOrderDoc131, "False", "DispatchOrderDoc", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.DispatchOrderDoc131,"a68fc4b2-469c-4dcd-8cb3-d11b7ade2b8e", 580,408, "Status","DocNo","ID", null,null);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.DispatchOrderDoc131,"DispatchOrderDoc131",new ReferenceInputParam[]{new ReferenceInputParam("Task","","Key","Task80",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("DispatchOrderDoc131", "Task", "Task80", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DispatchOrderDoc131,"DispatchOrderDoc131",new ReferenceOutputParam[]{new ReferenceOutputParam("DispatchOrderDoc131","ID","Key"),new ReferenceOutputParam("DispatchOrderDoc131","DocNo","Value"),new ReferenceOutputParam("DispatchOrderDoc131","Status","Text"),new ReferenceOutputParam("DispatchOrderDoc131","Task_Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.DispatchOrderDoc131, "12");		
		 

				this.lblDepartment113 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDepartment113", "", "True", "True", "Right", 150, 20, 0, 7, 1, 1, "100","7a2d876f-c866-407d-83c1-4425aba09846","089fa62d-42c4-479a-b1da-770efb4f67b2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDepartment113, "13");		


				this.Department113 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"Department113",true,true, false,150, 20, 2, 7, 1, 1, "100","14",false,false,true,"lblDepartment113","7a2d876f-c866-407d-83c1-4425aba09846","b2189c6f-39e4-4ffe-956f-1b478033bbb8");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Department113, "False", "Department", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldDepartment, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.Department113,"8ef2b987-b257-4873-a30e-e8194fef7e25", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldDepartment_Code,this.Model.DispatchCompleteOrderDoc.FieldDepartment_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Department113,"Department113",new ReferenceOutputParam[]{new ReferenceOutputParam("Department113","ID","Key"),new ReferenceOutputParam("Department113","Code","Value"),new ReferenceOutputParam("Department113","Name","Text"),new ReferenceOutputParam("Department113","MasterOrg_Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Department113, "14");		
		 

				this.lblShiftGroup158 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblShiftGroup158", "", "True", "True", "Right", 150, 20, 0, 8, 1, 1, "100","6b752238-8481-4f1a-a875-cf451a581f02","4af2e207-2d28-4623-9471-d76eed8ba143");


								

		
			UIControlBuilder.BuilderUFControl(this.lblShiftGroup158, "15");		


				this.ShiftGroup158 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"ShiftGroup158",true,true, false,150, 20, 2, 8, 1, 1, "100","16",false,false,true,"lblShiftGroup158","6b752238-8481-4f1a-a875-cf451a581f02","0262c262-bd07-4e6a-a1de-7bf21c1534f4");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ShiftGroup158, "False", "ShiftGroup", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldShiftGroup, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.ShiftGroup158,"bc8f8c6b-5bb9-4841-99fa-ab9df4b0adc6", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldShiftGroup_Code,this.Model.DispatchCompleteOrderDoc.FieldShiftGroup_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.ShiftGroup158,"ShiftGroup158",new ReferenceInputParam[]{new ReferenceInputParam("Dept","","Key","Department113",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("ShiftGroup158", "Dept", "Department113", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ShiftGroup158,"ShiftGroup158",new ReferenceOutputParam[]{new ReferenceOutputParam("ShiftGroup158","ID","Key"),new ReferenceOutputParam("ShiftGroup158","Code","Value"),new ReferenceOutputParam("ShiftGroup158","Name","Text"),new ReferenceOutputParam("ShiftGroup158","Description","Text"),new ReferenceOutputParam("Department113","Department_Code","Value"),new ReferenceOutputParam("Department113","Department_Name","Text"),new ReferenceOutputParam("Department113","Department_ID","Key"),});
				

		
			UIControlBuilder.BuilderUFControl(this.ShiftGroup158, "16");		
		 

				this.lblPerson150 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblPerson150", "", "True", "True", "Right", 150, 20, 0, 9, 1, 1, "100","22f6a230-5085-402f-8797-f73b6a3fb715","3f7d639b-8a16-4a43-a383-801706f43ab8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPerson150, "17");		


				this.Person150 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"Person150",true,true, false,150, 20, 2, 9, 1, 1, "100","18",false,false,true,"lblPerson150","22f6a230-5085-402f-8797-f73b6a3fb715","e92bdb10-bfa6-402a-a764-9599149f1d61");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Person150, "False", "Person", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldPerson, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.Person150,"ed7b196c-06c3-4261-a4ac-be69874a06ff", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldPerson_Code,this.Model.DispatchCompleteOrderDoc.FieldPerson_Name);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Person150,"Person150",new ReferenceInputParam[]{new ReferenceInputParam("Dept","","Key","Department113",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("Person150", "Dept", "Department113", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Person150,"Person150",new ReferenceOutputParam[]{new ReferenceOutputParam("Person150","ID","Key"),new ReferenceOutputParam("Person150","Code","Value"),new ReferenceOutputParam("Person150","Name","Text"),new ReferenceOutputParam("Person150","Description","Text"),new ReferenceOutputParam("Department113","Dept_Name","Text"),new ReferenceOutputParam("Department113","Dept_ID","Key"),new ReferenceOutputParam("Department113","Dept_Code","Value"),new ReferenceOutputParam("Department113","Dept_Description","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.Person150, "18");		
		 

				this.lblStatus137 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblStatus137", "", "True", "True", "Right", 150, 20, 0, 10, 1, 1, "100","f2d01947-cd25-43d2-9b8b-ee4d462ff8ed","fb7184bf-f419-4d2e-b125-13a237d5f2c5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblStatus137, "19");		


		        this.Status137 = UIControlBuilder.BuilderDropDownList(_UFTabPage, "Status137", "UFIDA.U9.PFM.DispatchOrderDocBE.DispatchStatusEnum", false,  true, false, "Left", 2, 60, 0, 150, 20, 2, 10, 1, 1, "100",true,false,"lblStatus137","f2d01947-cd25-43d2-9b8b-ee4d462ff8ed","b7908986-621c-4b5b-80ba-853d6e2d0958");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Status137, "False", "Status", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldStatus, "DispatchCompleteOrderDoc");
			EnumTypeList.Add("UFIDA.U9.PFM.DispatchOrderDocBE.DispatchStatusEnum");
			EnumControlsMap.Add(this.Status137, _UFTabPage);
		

		
			UIControlBuilder.BuilderUFControl(this.Status137, "20");		
		 

				this.lblActualStartTime189 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblActualStartTime189", "", "True", "True", "Right", 150, 20, 4, 1, 1, 1, "100","e34bb9b0-6784-4cfe-b6de-e019231a009d","c52761bb-2cec-4582-9eb3-0efc38467abf");


								

		
			UIControlBuilder.BuilderUFControl(this.lblActualStartTime189, "21");		


				this.ActualStartTime189 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "ActualStartTime189", false, true, true, "DateTime","Left", 5, 60, 0, 149, 20, 6, 1, 1, 1, "100",true,false,"lblActualStartTime189","e34bb9b0-6784-4cfe-b6de-e019231a009d","4de4b832-f7f8-462d-8698-cd2cfa95feb9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ActualStartTime189, "False", "ActualStartTime", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldActualStartTime, "DispatchCompleteOrderDoc");


		
			UIControlBuilder.BuilderUFControl(this.ActualStartTime189, "22");		
		 

				this.lblActualCompleteTime137 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblActualCompleteTime137", "", "True", "True", "Right", 150, 20, 4, 2, 1, 1, "100","2ceaf0be-cbee-4bc6-a21d-bf437f5fb1d7","119552ef-d948-4c2c-901f-b8ff6e7768a1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblActualCompleteTime137, "23");		


				this.ActualCompleteTime137 = UIControlBuilder.BuilderDatePicker(_UFTabPage, "ActualCompleteTime137", false, true, true, "DateTime","Left", 5, 60, 0, 149, 20, 6, 2, 1, 1, "100",true,false,"lblActualCompleteTime137","2ceaf0be-cbee-4bc6-a21d-bf437f5fb1d7","c091f77a-9ed9-44ab-8120-138ac005bd23");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ActualCompleteTime137, "False", "ActualCompleteTime", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldActualCompleteTime, "DispatchCompleteOrderDoc");


		
			UIControlBuilder.BuilderUFControl(this.ActualCompleteTime137, "24");		
		 

				this.lblWorkHourUOM140 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblWorkHourUOM140", "", "True", "True", "Right", 150, 20, 4, 3, 1, 1, "100","30d4fb52-a72b-4d1c-8ac1-e9e64c3d494c","7089f07e-df93-4d1d-a516-7c6212d55b2e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblWorkHourUOM140, "25");		


				this.WorkHourUOM140 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"WorkHourUOM140",false,true, true,149, 20, 6, 3, 1, 1, "100","26",false,false,true,"lblWorkHourUOM140","30d4fb52-a72b-4d1c-8ac1-e9e64c3d494c","f14cc932-a4e3-42c3-b82e-b0f9af9dc426");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.WorkHourUOM140, "False", "WorkHourUOM", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldWorkHourUOM, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.WorkHourUOM140,"f60347ca-0114-4396-891f-efd65b825db1", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldWorkHourUOM_Code,this.Model.DispatchCompleteOrderDoc.FieldWorkHourUOM_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.WorkHourUOM140,"WorkHourUOM140",new ReferenceOutputParam[]{new ReferenceOutputParam("WorkHourUOM140","ID","Key"),new ReferenceOutputParam("WorkHourUOM140","Code","Value"),new ReferenceOutputParam("WorkHourUOM140","Name","Text"),new ReferenceOutputParam("WorkHourUOM140","UOMClass","Text"),new ReferenceOutputParam("WorkHourUOM140","Effective_IsEffective","Text"),new ReferenceOutputParam("WorkHourUOM140","Description","Text"),new ReferenceOutputParam("WorkHourUOM140","Round_Precision","Text"),new ReferenceOutputParam("WorkHourUOM140","Round_RoundType","Text"),new ReferenceOutputParam("WorkHourUOM140","Round_RoundValue","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.WorkHourUOM140, "26");		
		 

				this.lblActualWorkHours167 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblActualWorkHours167", "", "True", "True", "Right", 150, 20, 4, 4, 1, 1, "100","371dcf7b-8f0f-4954-9123-aa74582e6f63","77475173-8eb0-4ae8-9a05-add505337815");


								

		
			UIControlBuilder.BuilderUFControl(this.lblActualWorkHours167, "27");		


				this.ActualWorkHours167 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "ActualWorkHours167", "False", "True", "True", "Left", 8, 60, 0, 149, 20, 6, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblActualWorkHours167","24.9","371dcf7b-8f0f-4954-9123-aa74582e6f63","b3a55573-81cd-4155-ac38-ed43d60c278a",this.Model.DispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundValue,this.Model.DispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundType,this.Model.DispatchCompleteOrderDoc.FieldWorkHourUOM_Round_RoundValue, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ActualWorkHours167, "False", "ActualWorkHours", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldActualWorkHours, "DispatchCompleteOrderDoc");
	
		
			UIControlBuilder.BuilderUFControl(this.ActualWorkHours167, "28");		
		 

				this.Line2 = UIControlBuilder.BuilderUFLine(_UFTabPage, "Line2", 150, "Horizontal", "True", 150, 20, 0, 11, 1, 1, "100","00000000-0000-0000-0000-000000000000","5e520b37-d878-4aa4-8d12-abdf28c4c750");
	

		
			UIControlBuilder.BuilderUFControl(this.Line2, "29");		


				this.lblCompleteQty155 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblCompleteQty155", "", "True", "True", "Right", 150, 20, 0, 14, 1, 1, "100","2f3c37f4-9fd9-4948-aacc-6b4bd67b8a3b","713c684d-221d-4b62-85de-a9202b906db4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCompleteQty155, "30");		


				this.CompleteQty155 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "CompleteQty155", "True", "True", "True", "Left", 8, 60, 0, 150, 20, 2, 14, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblCompleteQty155","24.9","2f3c37f4-9fd9-4948-aacc-6b4bd67b8a3b","a7faa6b8-c4db-486e-a89e-12f6f7a8e1eb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CompleteQty155, "False", "CompleteQty", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldCompleteQty, "DispatchCompleteOrderDoc");
	
		
			UIControlBuilder.BuilderUFControl(this.CompleteQty155, "31");		
		 

				this.lblSchedule190 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblSchedule190", "", "True", "True", "Right", 150, 15, 0, 15, 1, 1, "100","1cd2a9c9-d452-4fc8-aaf6-0659c017d4ab","c6a06ac7-3b84-494a-985b-0cd387d992d4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSchedule190, "32");		


				this.Schedule190 = UIControlBuilder.BuilderNumberControl(_UFTabPage, "Schedule190", "True", "True", "True", "Left", 8, 60, 0, 150, 15, 2, 15, 1, 1, NumbericType.Percent, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblSchedule190","24.9","1cd2a9c9-d452-4fc8-aaf6-0659c017d4ab","20fd3e37-6d08-43e2-92d3-5d5d3aa41d75",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Schedule190, "False", "Schedule", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldSchedule, "DispatchCompleteOrderDoc");
	
		
			UIControlBuilder.BuilderUFControl(this.Schedule190, "33");		
		 

				this.lblDispatchOrderDoc_ItemMaster118 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDispatchOrderDoc_ItemMaster118", "", "True", "True", "Right", 150, 20, 0, 12, 1, 1, "100","c9c7bcab-42f2-4694-ad83-529c042d5989","7610b656-89e8-4ddc-a4d3-1aff43122efd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDispatchOrderDoc_ItemMaster118, "38");		


				this.DispatchOrderDoc_ItemMaster118 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"DispatchOrderDoc_ItemMaster118",true,true, false,150, 20, 2, 12, 1, 1, "100","39",false,false,true,"lblDispatchOrderDoc_ItemMaster118","c9c7bcab-42f2-4694-ad83-529c042d5989","e0509d67-8f5f-4471-b0d8-ae3105b16dd5");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DispatchOrderDoc_ItemMaster118, "False", "DispatchOrderDoc_ItemMaster", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.DispatchOrderDoc_ItemMaster118,"beedebc3-5398-46b5-a237-5a3a4d13ad4f", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Code,this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc_ItemMaster_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DispatchOrderDoc_ItemMaster118,"DispatchOrderDoc_ItemMaster118",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","AliasName",""),new ReferenceOutputParam("","Version",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","InventoryUOM_ID",""),new ReferenceOutputParam("","InventoryUOM_Code",""),new ReferenceOutputParam("","InventoryUOM_Name",""),new ReferenceOutputParam("","ItemForm",""),new ReferenceOutputParam("","VersionID",""),new ReferenceOutputParam("","TradeMark_ID",""),new ReferenceOutputParam("","TradeMark_Code",""),new ReferenceOutputParam("","TradeMark_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.DispatchOrderDoc_ItemMaster118, "39");		
		 

				this.lblDispatchOrderDoc_OutputUOM158 = UIControlBuilder.BuilderUFLabel(_UFTabPage, "lblDispatchOrderDoc_OutputUOM158", "", "True", "True", "Right", 150, 20, 0, 13, 1, 1, "100","970d1634-4367-43a4-8dd4-0d698750ba7a","d544ebcd-be98-471b-98c5-666d36fcd3e7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDispatchOrderDoc_OutputUOM158, "40");		


				this.DispatchOrderDoc_OutputUOM158 = UIControlBuilder.BuilderRefrenceControl(_UFTabPage,"DispatchOrderDoc_OutputUOM158",true,true, false,150, 20, 2, 13, 1, 1, "100","41",false,false,true,"lblDispatchOrderDoc_OutputUOM158","970d1634-4367-43a4-8dd4-0d698750ba7a","0485136c-cfd6-4202-a7f0-49a57a01f57c");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DispatchOrderDoc_OutputUOM158, "False", "DispatchOrderDoc_OutputUOM", this.Model.DispatchCompleteOrderDoc, this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM, "DispatchCompleteOrderDoc");
			UIControlBuilder.SetReferenceControlRefInfo(this.DispatchOrderDoc_OutputUOM158,"f60347ca-0114-4396-891f-efd65b825db1", 580,408, "Name","Code","ID", this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Code,this.Model.DispatchCompleteOrderDoc.FieldDispatchOrderDoc_OutputUOM_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DispatchOrderDoc_OutputUOM158,"DispatchOrderDoc_OutputUOM158",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","UOMClass",""),new ReferenceOutputParam("","Effective_IsEffective",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","Round_Precision",""),new ReferenceOutputParam("","Round_RoundType",""),new ReferenceOutputParam("","Round_RoundValue",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.DispatchOrderDoc_OutputUOM158, "41");		
		 


					
			this.DispatchCompleteOrderDocType230.IsMultiOrg  = false ;
			this.lblDispatchCompleteOrderDocType230.SetMultiOrgInfo(this.DispatchCompleteOrderDocType230,false);
			
				
			this.Project89.IsMultiOrg  = false ;
			this.lblProject89.SetMultiOrgInfo(this.Project89,false);
			
		
			this.Task80.IsMultiOrg  = false ;
			this.lblTask80.SetMultiOrgInfo(this.Task80,false);
			
		
			this.DispatchOrderDoc131.IsMultiOrg  = false ;
			this.lblDispatchOrderDoc131.SetMultiOrgInfo(this.DispatchOrderDoc131,false);
			
		
			this.Department113.IsMultiOrg  = false ;
			this.lblDepartment113.SetMultiOrgInfo(this.Department113,false);
			
		
			this.ShiftGroup158.IsMultiOrg  = false ;
			this.lblShiftGroup158.SetMultiOrgInfo(this.ShiftGroup158,false);
			
		
			this.Person150.IsMultiOrg  = false ;
			this.lblPerson150.SetMultiOrgInfo(this.Person150,false);
			
								
			this.WorkHourUOM140.IsMultiOrg  = false ;
			this.lblWorkHourUOM140.SetMultiOrgInfo(this.WorkHourUOM140,false);
			
									
			this.DispatchOrderDoc_ItemMaster118.IsMultiOrg  = false ;
			this.lblDispatchOrderDoc_ItemMaster118.SetMultiOrgInfo(this.DispatchOrderDoc_ItemMaster118,false);
			
		
			this.DispatchOrderDoc_OutputUOM158.IsMultiOrg  = false ;
			this.lblDispatchOrderDoc_OutputUOM158.SetMultiOrgInfo(this.DispatchOrderDoc_OutputUOM158,false);
			


            this.TabPage0 = _UFTabPage;
            return _UFTabPage;
        }

				

				

				

				

				

				

				

				

				

				

	        private IUFTabPage _BuilderControl_Remark(IUFTabControl container)
        {
            IUFTabPage _UFTabPage = UIControlBuilder.BuildTabPageControl(container,"Remark",true, true, "2","00000000-0000-0000-0000-000000000000","30a8f8b4-ad8b-44fc-8f05-72697e6ff656");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFTabPage, 12, 16, 0, 5, 5, 5, 5, 5);
			InitViewBindingContainer(this, _UFTabPage,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFTabPage, 5,new GridColumnDef[]{new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(150,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(149,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(149,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(149,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(11,bool.Parse("False")),});
            ///foreach UFTab下的所有控件，增加到此容器





				this.RemarkText = UIControlBuilder.BuilderTextBox(_UFTabPage, "RemarkText", "True", "True", "True", "True", "Left", 0, 60, 0, 480, 170, 0, 0, 6, 7, "False", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"","","","","97cecc8d-6c49-40fe-b4a5-385b7bd46223");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.RemarkText, "False", "", null, null, "");


		
			UIControlBuilder.BuilderUFControl(this.RemarkText, "0");		
		 


	

            this.Remark = _UFTabPage;
            return _UFTabPage;
        }





		#endregion
		

	}
}
