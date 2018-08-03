using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Process_Model
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.dataGridButton = new DevExpress.XtraEditors.SimpleButton();
            this.skinComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.systemNameTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.systemNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.q1memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q1Label = new DevExpress.XtraEditors.LabelControl();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.q2memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q2Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage3 = new DevExpress.XtraWizard.WizardPage();
            this.q3PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BillingCheckEdit10 = new DevExpress.XtraEditors.CheckEdit();
            this.DistributionCheckEdit9 = new DevExpress.XtraEditors.CheckEdit();
            this.MarketingCheckEdit8 = new DevExpress.XtraEditors.CheckEdit();
            this.ManagementDecisionCheckEdit7 = new DevExpress.XtraEditors.CheckEdit();
            this.InformationSecurityCheckEdit6 = new DevExpress.XtraEditors.CheckEdit();
            this.CRMcheckEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.GeneralITCheckEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.LogisticsCheckEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.ManagementCheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.HRCheckEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.q3Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage4 = new DevExpress.XtraWizard.WizardPage();
            this.q4BMemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q4BLabel = new DevExpress.XtraEditors.LabelControl();
            this.q4aRadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.q4ALabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage5 = new DevExpress.XtraWizard.WizardPage();
            this.q5RadioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.q5Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage6 = new DevExpress.XtraWizard.WizardPage();
            this.q6MemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q6Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage7 = new DevExpress.XtraWizard.WizardPage();
            this.q7PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.q7BillingCheckEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.q7DistributionCheckEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.q7MarketingCheckEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.q7ManagDecsCheckEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.q7InformationSecCheckEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.q7CRMCheckEdit6 = new DevExpress.XtraEditors.CheckEdit();
            this.q7GeneralITCheckEdit7 = new DevExpress.XtraEditors.CheckEdit();
            this.q7LogisticsCheckEdit8 = new DevExpress.XtraEditors.CheckEdit();
            this.q7ManagementCheckEdit9 = new DevExpress.XtraEditors.CheckEdit();
            this.q7HRCheckEdit10 = new DevExpress.XtraEditors.CheckEdit();
            this.q7Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage8 = new DevExpress.XtraWizard.WizardPage();
            this.q8bJobTextEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.q8bJobLabel = new DevExpress.XtraEditors.LabelControl();
            this.q8aNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.q8aNameTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.q8Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage9 = new DevExpress.XtraWizard.WizardPage();
            this.q9TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.q9Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage10 = new DevExpress.XtraWizard.WizardPage();
            this.q10TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.q10Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage11 = new DevExpress.XtraWizard.WizardPage();
            this.q11MemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q11Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage12 = new DevExpress.XtraWizard.WizardPage();
            this.q12PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.q12BillingCheckEdit11 = new DevExpress.XtraEditors.CheckEdit();
            this.q12DistributionCheckEdit12 = new DevExpress.XtraEditors.CheckEdit();
            this.q12MarketingCheckEdit13 = new DevExpress.XtraEditors.CheckEdit();
            this.q12MangDecsCheckEdit14 = new DevExpress.XtraEditors.CheckEdit();
            this.q12InformationSecCheckEdit15 = new DevExpress.XtraEditors.CheckEdit();
            this.q12CRMCheckEdit16 = new DevExpress.XtraEditors.CheckEdit();
            this.q12GeneralITCheckEdit17 = new DevExpress.XtraEditors.CheckEdit();
            this.q12LogisticsCheckEdit18 = new DevExpress.XtraEditors.CheckEdit();
            this.q12ManagementCheckEdit19 = new DevExpress.XtraEditors.CheckEdit();
            this.q12HRCheckEdit20 = new DevExpress.XtraEditors.CheckEdit();
            this.q12Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage13 = new DevExpress.XtraWizard.WizardPage();
            this.q13SystemHoldComboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.q13SystemHoldComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.q13SystemHoldRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.q13Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage14 = new DevExpress.XtraWizard.WizardPage();
            this.q14RadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.q14Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage15 = new DevExpress.XtraWizard.WizardPage();
            this.q15PanelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.q15CyclicCheckEdit24 = new DevExpress.XtraEditors.CheckEdit();
            this.q15IntegrationTechniquesCheckEdit23 = new DevExpress.XtraEditors.CheckEdit();
            this.q15SDLCCheckEdit22 = new DevExpress.XtraEditors.CheckEdit();
            this.q15BestPracticesCheckEdit21 = new DevExpress.XtraEditors.CheckEdit();
            this.q15Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage16 = new DevExpress.XtraWizard.WizardPage();
            this.q16PanelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.q16OrganizationalSearchCheckEdit22 = new DevExpress.XtraEditors.CheckEdit();
            this.q16APIMCheckEdit21 = new DevExpress.XtraEditors.CheckEdit();
            this.q16Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage17 = new DevExpress.XtraWizard.WizardPage();
            this.q17RadioGroup4 = new DevExpress.XtraEditors.RadioGroup();
            this.q17Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage18 = new DevExpress.XtraWizard.WizardPage();
            this.q25MemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q25Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage19 = new DevExpress.XtraWizard.WizardPage();
            this.q26MemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q26Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage20 = new DevExpress.XtraWizard.WizardPage();
            this.q27MemoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q27Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage21 = new DevExpress.XtraWizard.WizardPage();
            this.q28panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.q28ESXcheckEdit25 = new DevExpress.XtraEditors.CheckEdit();
            this.q28AS400checkEdit24 = new DevExpress.XtraEditors.CheckEdit();
            this.q28LinuxCheckEdit23 = new DevExpress.XtraEditors.CheckEdit();
            this.q28UnixCheckEdit22 = new DevExpress.XtraEditors.CheckEdit();
            this.q28WinCheckEdit21 = new DevExpress.XtraEditors.CheckEdit();
            this.q28Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage22 = new DevExpress.XtraWizard.WizardPage();
            this.q29memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q29Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage23 = new DevExpress.XtraWizard.WizardPage();
            this.q30memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q30Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage24 = new DevExpress.XtraWizard.WizardPage();
            this.q31memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q31Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage25 = new DevExpress.XtraWizard.WizardPage();
            this.q32memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q32Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage26 = new DevExpress.XtraWizard.WizardPage();
            this.q33memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q33Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage27 = new DevExpress.XtraWizard.WizardPage();
            this.q34memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q34Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage28 = new DevExpress.XtraWizard.WizardPage();
            this.q35MVCcomboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.q35Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage29 = new DevExpress.XtraWizard.WizardPage();
            this.q36ControlTypeComboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.q36ControlTypeComboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.q36ControlTypeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.q36Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage30 = new DevExpress.XtraWizard.WizardPage();
            this.q44memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q44Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage31 = new DevExpress.XtraWizard.WizardPage();
            this.q45memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.q45Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage32 = new DevExpress.XtraWizard.WizardPage();
            this.q46memoEdit3 = new DevExpress.XtraEditors.MemoEdit();
            this.q46Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage33 = new DevExpress.XtraWizard.WizardPage();
            this.q47memoEdit4 = new DevExpress.XtraEditors.MemoEdit();
            this.q47Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage34 = new DevExpress.XtraWizard.WizardPage();
            this.q48memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q48Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage35 = new DevExpress.XtraWizard.WizardPage();
            this.q49memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q49Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage36 = new DevExpress.XtraWizard.WizardPage();
            this.q50memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q50Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage37 = new DevExpress.XtraWizard.WizardPage();
            this.q51memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q51Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage38 = new DevExpress.XtraWizard.WizardPage();
            this.q52memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q52Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage39 = new DevExpress.XtraWizard.WizardPage();
            this.q53HyperLink = new DevExpress.XtraEditors.HyperLinkEdit();
            this.q53AttachButton = new DevExpress.XtraEditors.SimpleButton();
            this.q53Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage40 = new DevExpress.XtraWizard.WizardPage();
            this.q54HyperLink = new DevExpress.XtraEditors.HyperLinkEdit();
            this.q54AttachButton = new DevExpress.XtraEditors.SimpleButton();
            this.q54Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage41 = new DevExpress.XtraWizard.WizardPage();
            this.q55memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q55Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage42 = new DevExpress.XtraWizard.WizardPage();
            this.q56memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q56Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage43 = new DevExpress.XtraWizard.WizardPage();
            this.q57HyperLink = new DevExpress.XtraEditors.HyperLinkEdit();
            this.q57AttachButton = new DevExpress.XtraEditors.SimpleButton();
            this.q57Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage44 = new DevExpress.XtraWizard.WizardPage();
            this.q58memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q58Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage45 = new DevExpress.XtraWizard.WizardPage();
            this.q59memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q59Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage46 = new DevExpress.XtraWizard.WizardPage();
            this.q60memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q60Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage47 = new DevExpress.XtraWizard.WizardPage();
            this.q61memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q61Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage48 = new DevExpress.XtraWizard.WizardPage();
            this.q62memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q62Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage49 = new DevExpress.XtraWizard.WizardPage();
            this.q63memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q63Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage50 = new DevExpress.XtraWizard.WizardPage();
            this.q64Label = new DevExpress.XtraEditors.LabelControl();
            this.q64memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.wizardPage51 = new DevExpress.XtraWizard.WizardPage();
            this.q65memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q65Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage52 = new DevExpress.XtraWizard.WizardPage();
            this.q66memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.q66Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage53 = new DevExpress.XtraWizard.WizardPage();
            this.q18aHyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.q18aAttachDiagramButton = new DevExpress.XtraEditors.SimpleButton();
            this.q18b3IntegratorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.q18b3IntegratorLabel = new DevExpress.XtraEditors.LabelControl();
            this.q18b2DistributorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.q18b2DistributorLabel = new DevExpress.XtraEditors.LabelControl();
            this.q18b1VendorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.q18b1VendorLabel = new DevExpress.XtraEditors.LabelControl();
            this.q18aDiagramLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage55 = new DevExpress.XtraWizard.WizardPage();
            this.q24CustomSolutionsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.q24CustomSolutionsLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage56 = new DevExpress.XtraWizard.WizardPage();
            this.q23SiteLicenseRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.q23SiteLicenseLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage57 = new DevExpress.XtraWizard.WizardPage();
            this.q22CashBackRadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.q22CashBackLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage58 = new DevExpress.XtraWizard.WizardPage();
            this.q21CurrencyRadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.q21CurrencyLabel = new DevExpress.XtraEditors.LabelControl();
            this.q21TextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.q21OrganizationalCostLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage59 = new DevExpress.XtraWizard.WizardPage();
            this.q19SolutionTypeRadioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.q19SolutionTypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage62 = new DevExpress.XtraWizard.WizardPage();
            this.q20ControlResolutionRadioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.q20ControlResolutionLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage54 = new DevExpress.XtraWizard.WizardPage();
            this.q40ControlTagMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.q40ControlTagLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage60 = new DevExpress.XtraWizard.WizardPage();
            this.q39ControlMandatoryRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.q39ControlMandatoryLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage61 = new DevExpress.XtraWizard.WizardPage();
            this.q38ControlValidityRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.q38ControlValidityLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage63 = new DevExpress.XtraWizard.WizardPage();
            this.q37ControlDescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.q37ControlDescriptionLabel = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage64 = new DevExpress.XtraWizard.WizardPage();
            this.q43MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.q43Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage65 = new DevExpress.XtraWizard.WizardPage();
            this.q42MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.q42Label = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage66 = new DevExpress.XtraWizard.WizardPage();
            this.q41MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.q41Label = new DevExpress.XtraEditors.LabelControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.generateReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.systemComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.submitButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinComboBox.Properties)).BeginInit();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemNameTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).BeginInit();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q1memoEdit1.Properties)).BeginInit();
            this.completionWizardPage1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q2memoEdit1.Properties)).BeginInit();
            this.wizardPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q3PanelControl1)).BeginInit();
            this.q3PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillingCheckEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistributionCheckEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketingCheckEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagementDecisionCheckEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationSecurityCheckEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMcheckEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralITCheckEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogisticsCheckEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagementCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRCheckEdit2.Properties)).BeginInit();
            this.wizardPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q4BMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q4aRadioGroup1.Properties)).BeginInit();
            this.wizardPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q5RadioGroup2.Properties)).BeginInit();
            this.wizardPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q6MemoEdit1.Properties)).BeginInit();
            this.wizardPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q7PanelControl2)).BeginInit();
            this.q7PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q7BillingCheckEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7DistributionCheckEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7MarketingCheckEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7ManagDecsCheckEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7InformationSecCheckEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7CRMCheckEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7GeneralITCheckEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7LogisticsCheckEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7ManagementCheckEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7HRCheckEdit10.Properties)).BeginInit();
            this.wizardPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q8bJobTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q8aNameTextEdit1.Properties)).BeginInit();
            this.wizardPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q9TextEdit1.Properties)).BeginInit();
            this.wizardPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q10TextEdit1.Properties)).BeginInit();
            this.wizardPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q11MemoEdit1.Properties)).BeginInit();
            this.wizardPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q12PanelControl3)).BeginInit();
            this.q12PanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q12BillingCheckEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12DistributionCheckEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12MarketingCheckEdit13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12MangDecsCheckEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12InformationSecCheckEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12CRMCheckEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12GeneralITCheckEdit17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12LogisticsCheckEdit18.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12ManagementCheckEdit19.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12HRCheckEdit20.Properties)).BeginInit();
            this.wizardPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q13SystemHoldComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q13SystemHoldComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q13SystemHoldRadioGroup.Properties)).BeginInit();
            this.wizardPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q14RadioGroup.Properties)).BeginInit();
            this.wizardPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q15PanelControl4)).BeginInit();
            this.q15PanelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q15CyclicCheckEdit24.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q15IntegrationTechniquesCheckEdit23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q15SDLCCheckEdit22.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q15BestPracticesCheckEdit21.Properties)).BeginInit();
            this.wizardPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q16PanelControl5)).BeginInit();
            this.q16PanelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q16OrganizationalSearchCheckEdit22.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q16APIMCheckEdit21.Properties)).BeginInit();
            this.wizardPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q17RadioGroup4.Properties)).BeginInit();
            this.wizardPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q25MemoEdit1.Properties)).BeginInit();
            this.wizardPage19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q26MemoEdit1.Properties)).BeginInit();
            this.wizardPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q27MemoEdit1.Properties)).BeginInit();
            this.wizardPage21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q28panelControl6)).BeginInit();
            this.q28panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q28ESXcheckEdit25.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28AS400checkEdit24.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28LinuxCheckEdit23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28UnixCheckEdit22.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28WinCheckEdit21.Properties)).BeginInit();
            this.wizardPage22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q29memoEdit1.Properties)).BeginInit();
            this.wizardPage23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q30memoEdit1.Properties)).BeginInit();
            this.wizardPage24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q31memoEdit1.Properties)).BeginInit();
            this.wizardPage25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q32memoEdit1.Properties)).BeginInit();
            this.wizardPage26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q33memoEdit1.Properties)).BeginInit();
            this.wizardPage27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q34memoEdit1.Properties)).BeginInit();
            this.wizardPage28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q35MVCcomboBoxEdit.Properties)).BeginInit();
            this.wizardPage29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q36ControlTypeComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q36ControlTypeComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q36ControlTypeRadioGroup.Properties)).BeginInit();
            this.wizardPage30.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q44memoEdit1.Properties)).BeginInit();
            this.wizardPage31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q45memoEdit2.Properties)).BeginInit();
            this.wizardPage32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q46memoEdit3.Properties)).BeginInit();
            this.wizardPage33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q47memoEdit4.Properties)).BeginInit();
            this.wizardPage34.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q48memoEdit1.Properties)).BeginInit();
            this.wizardPage35.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q49memoEdit1.Properties)).BeginInit();
            this.wizardPage36.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q50memoEdit1.Properties)).BeginInit();
            this.wizardPage37.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q51memoEdit1.Properties)).BeginInit();
            this.wizardPage38.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q52memoEdit1.Properties)).BeginInit();
            this.wizardPage39.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q53HyperLink.Properties)).BeginInit();
            this.wizardPage40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q54HyperLink.Properties)).BeginInit();
            this.wizardPage41.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q55memoEdit1.Properties)).BeginInit();
            this.wizardPage42.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q56memoEdit1.Properties)).BeginInit();
            this.wizardPage43.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q57HyperLink.Properties)).BeginInit();
            this.wizardPage44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q58memoEdit1.Properties)).BeginInit();
            this.wizardPage45.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q59memoEdit1.Properties)).BeginInit();
            this.wizardPage46.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q60memoEdit1.Properties)).BeginInit();
            this.wizardPage47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q61memoEdit1.Properties)).BeginInit();
            this.wizardPage48.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q62memoEdit1.Properties)).BeginInit();
            this.wizardPage49.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q63memoEdit1.Properties)).BeginInit();
            this.wizardPage50.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q64memoEdit1.Properties)).BeginInit();
            this.wizardPage51.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q65memoEdit1.Properties)).BeginInit();
            this.wizardPage52.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q66memoEdit1.Properties)).BeginInit();
            this.wizardPage53.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q18aHyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q18b3IntegratorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q18b2DistributorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q18b1VendorTextEdit.Properties)).BeginInit();
            this.wizardPage55.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q24CustomSolutionsMemoEdit.Properties)).BeginInit();
            this.wizardPage56.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q23SiteLicenseRadioGroup.Properties)).BeginInit();
            this.wizardPage57.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q22CashBackRadioGroup1.Properties)).BeginInit();
            this.wizardPage58.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q21CurrencyRadioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q21TextEdit1.Properties)).BeginInit();
            this.wizardPage59.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q19SolutionTypeRadioGroup1.Properties)).BeginInit();
            this.wizardPage62.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q20ControlResolutionRadioGroup2.Properties)).BeginInit();
            this.wizardPage54.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q40ControlTagMemoEdit.Properties)).BeginInit();
            this.wizardPage60.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q39ControlMandatoryRadioGroup.Properties)).BeginInit();
            this.wizardPage61.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q38ControlValidityRadioGroup.Properties)).BeginInit();
            this.wizardPage63.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q37ControlDescriptionMemoEdit.Properties)).BeginInit();
            this.wizardPage64.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q43MemoEdit.Properties)).BeginInit();
            this.wizardPage65.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q42MemoEdit.Properties)).BeginInit();
            this.wizardPage66.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q41MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.dataGridButton);
            this.wizardControl1.Controls.Add(this.skinComboBox);
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Controls.Add(this.wizardPage3);
            this.wizardControl1.Controls.Add(this.wizardPage4);
            this.wizardControl1.Controls.Add(this.wizardPage5);
            this.wizardControl1.Controls.Add(this.wizardPage6);
            this.wizardControl1.Controls.Add(this.wizardPage7);
            this.wizardControl1.Controls.Add(this.wizardPage8);
            this.wizardControl1.Controls.Add(this.wizardPage9);
            this.wizardControl1.Controls.Add(this.wizardPage10);
            this.wizardControl1.Controls.Add(this.wizardPage11);
            this.wizardControl1.Controls.Add(this.wizardPage12);
            this.wizardControl1.Controls.Add(this.wizardPage13);
            this.wizardControl1.Controls.Add(this.wizardPage14);
            this.wizardControl1.Controls.Add(this.wizardPage15);
            this.wizardControl1.Controls.Add(this.wizardPage16);
            this.wizardControl1.Controls.Add(this.wizardPage17);
            this.wizardControl1.Controls.Add(this.wizardPage18);
            this.wizardControl1.Controls.Add(this.wizardPage19);
            this.wizardControl1.Controls.Add(this.wizardPage20);
            this.wizardControl1.Controls.Add(this.wizardPage21);
            this.wizardControl1.Controls.Add(this.wizardPage22);
            this.wizardControl1.Controls.Add(this.wizardPage23);
            this.wizardControl1.Controls.Add(this.wizardPage24);
            this.wizardControl1.Controls.Add(this.wizardPage25);
            this.wizardControl1.Controls.Add(this.wizardPage26);
            this.wizardControl1.Controls.Add(this.wizardPage27);
            this.wizardControl1.Controls.Add(this.wizardPage28);
            this.wizardControl1.Controls.Add(this.wizardPage29);
            this.wizardControl1.Controls.Add(this.wizardPage30);
            this.wizardControl1.Controls.Add(this.wizardPage31);
            this.wizardControl1.Controls.Add(this.wizardPage32);
            this.wizardControl1.Controls.Add(this.wizardPage33);
            this.wizardControl1.Controls.Add(this.wizardPage34);
            this.wizardControl1.Controls.Add(this.wizardPage35);
            this.wizardControl1.Controls.Add(this.wizardPage36);
            this.wizardControl1.Controls.Add(this.wizardPage37);
            this.wizardControl1.Controls.Add(this.wizardPage38);
            this.wizardControl1.Controls.Add(this.wizardPage39);
            this.wizardControl1.Controls.Add(this.wizardPage40);
            this.wizardControl1.Controls.Add(this.wizardPage41);
            this.wizardControl1.Controls.Add(this.wizardPage42);
            this.wizardControl1.Controls.Add(this.wizardPage43);
            this.wizardControl1.Controls.Add(this.wizardPage44);
            this.wizardControl1.Controls.Add(this.wizardPage45);
            this.wizardControl1.Controls.Add(this.wizardPage46);
            this.wizardControl1.Controls.Add(this.wizardPage47);
            this.wizardControl1.Controls.Add(this.wizardPage48);
            this.wizardControl1.Controls.Add(this.wizardPage49);
            this.wizardControl1.Controls.Add(this.wizardPage50);
            this.wizardControl1.Controls.Add(this.wizardPage51);
            this.wizardControl1.Controls.Add(this.wizardPage52);
            this.wizardControl1.Controls.Add(this.wizardPage53);
            this.wizardControl1.Controls.Add(this.wizardPage55);
            this.wizardControl1.Controls.Add(this.wizardPage56);
            this.wizardControl1.Controls.Add(this.wizardPage57);
            this.wizardControl1.Controls.Add(this.wizardPage58);
            this.wizardControl1.Controls.Add(this.wizardPage59);
            this.wizardControl1.Controls.Add(this.wizardPage62);
            this.wizardControl1.Controls.Add(this.wizardPage54);
            this.wizardControl1.Controls.Add(this.wizardPage60);
            this.wizardControl1.Controls.Add(this.wizardPage61);
            this.wizardControl1.Controls.Add(this.wizardPage63);
            this.wizardControl1.Controls.Add(this.wizardPage64);
            this.wizardControl1.Controls.Add(this.wizardPage65);
            this.wizardControl1.Controls.Add(this.wizardPage66);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.wizardPage4,
            this.wizardPage5,
            this.wizardPage6,
            this.wizardPage7,
            this.wizardPage8,
            this.wizardPage9,
            this.wizardPage10,
            this.wizardPage11,
            this.wizardPage12,
            this.wizardPage13,
            this.wizardPage14,
            this.wizardPage15,
            this.wizardPage16,
            this.wizardPage17,
            this.wizardPage53,
            this.wizardPage59,
            this.wizardPage62,
            this.wizardPage58,
            this.wizardPage57,
            this.wizardPage56,
            this.wizardPage55,
            this.wizardPage18,
            this.wizardPage19,
            this.wizardPage20,
            this.wizardPage21,
            this.wizardPage22,
            this.wizardPage23,
            this.wizardPage24,
            this.wizardPage25,
            this.wizardPage26,
            this.wizardPage27,
            this.wizardPage28,
            this.wizardPage29,
            this.wizardPage63,
            this.wizardPage61,
            this.wizardPage60,
            this.wizardPage54,
            this.wizardPage66,
            this.wizardPage65,
            this.wizardPage64,
            this.wizardPage30,
            this.wizardPage31,
            this.wizardPage32,
            this.wizardPage33,
            this.wizardPage34,
            this.wizardPage35,
            this.wizardPage36,
            this.wizardPage37,
            this.wizardPage38,
            this.wizardPage39,
            this.wizardPage40,
            this.wizardPage41,
            this.wizardPage42,
            this.wizardPage43,
            this.wizardPage44,
            this.wizardPage45,
            this.wizardPage46,
            this.wizardPage47,
            this.wizardPage48,
            this.wizardPage49,
            this.wizardPage50,
            this.wizardPage51,
            this.wizardPage52,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(632, 437);
            this.wizardControl1.Text = "1 / 68";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            this.wizardControl1.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_PrevClick);
            this.wizardControl1.Click += new System.EventHandler(this.wizardControl1_Click);
            this.wizardControl1.Validated += new System.EventHandler(this.wizardControl1_Validated);
            // 
            // dataGridButton
            // 
            this.dataGridButton.Location = new System.Drawing.Point(540, 13);
            this.dataGridButton.Name = "dataGridButton";
            this.dataGridButton.Size = new System.Drawing.Size(75, 23);
            this.dataGridButton.TabIndex = 147;
            this.dataGridButton.Text = "Data Grid";
            this.dataGridButton.Click += new System.EventHandler(this.gridButton_Click);
            // 
            // skinComboBox
            // 
            this.skinComboBox.EditValue = "Select Skin";
            this.skinComboBox.Location = new System.Drawing.Point(391, 13);
            this.skinComboBox.Name = "skinComboBox";
            this.skinComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.skinComboBox.Size = new System.Drawing.Size(131, 20);
            this.skinComboBox.TabIndex = 76;
            this.skinComboBox.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_SelectedIndexChanged);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.systemNameTextEdit1);
            this.welcomeWizardPage1.Controls.Add(this.systemNameLabel);
            this.welcomeWizardPage1.Controls.Add(this.userNameTextEdit);
            this.welcomeWizardPage1.Controls.Add(this.userNameLabel);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(572, 269);
            this.welcomeWizardPage1.Text = "Welcome to the New IT project wizard";
            this.welcomeWizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage67_PageValidating);
            // 
            // systemNameTextEdit1
            // 
            this.systemNameTextEdit1.Location = new System.Drawing.Point(181, 127);
            this.systemNameTextEdit1.Name = "systemNameTextEdit1";
            this.systemNameTextEdit1.Properties.Leave += new System.EventHandler(this.systemNameTextEdit1_Properties_Leave);
            this.systemNameTextEdit1.Size = new System.Drawing.Size(169, 20);
            this.systemNameTextEdit1.TabIndex = 9;
            // 
            // systemNameLabel
            // 
            this.systemNameLabel.Location = new System.Drawing.Point(181, 108);
            this.systemNameLabel.Name = "systemNameLabel";
            this.systemNameLabel.Size = new System.Drawing.Size(69, 13);
            this.systemNameLabel.TabIndex = 8;
            this.systemNameLabel.Text = "System Name:";
            // 
            // userNameTextEdit
            // 
            this.userNameTextEdit.Location = new System.Drawing.Point(181, 59);
            this.userNameTextEdit.Name = "userNameTextEdit";
            this.userNameTextEdit.Properties.Mask.BeepOnError = true;
            this.userNameTextEdit.Properties.Mask.EditMask = "[A-Za-z0-9.\'_,/]+";
            this.userNameTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.userNameTextEdit.Size = new System.Drawing.Size(169, 20);
            this.userNameTextEdit.TabIndex = 7;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Location = new System.Drawing.Point(181, 40);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(52, 13);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "Username:";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.q1memoEdit1);
            this.wizardPage1.Controls.Add(this.q1Label);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(572, 269);
            this.wizardPage1.Text = "The need –";
            // 
            // q1memoEdit1
            // 
            this.q1memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q1memoEdit1.Name = "q1memoEdit1";
            this.q1memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q1memoEdit1.TabIndex = 1;
            // 
            // q1Label
            // 
            this.q1Label.Location = new System.Drawing.Point(24, 14);
            this.q1Label.Name = "q1Label";
            this.q1Label.Size = new System.Drawing.Size(244, 13);
            this.q1Label.TabIndex = 0;
            this.q1Label.Text = "What is the incentive for implementing the system?";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Controls.Add(this.generateReportButton);
            this.completionWizardPage1.Controls.Add(this.systemComboBox);
            this.completionWizardPage1.Controls.Add(this.submitButton1);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(572, 269);
            this.completionWizardPage1.Text = "Submission";
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.q2memoEdit1);
            this.wizardPage2.Controls.Add(this.q2Label);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(572, 269);
            this.wizardPage2.Text = "The need –";
            // 
            // q2memoEdit1
            // 
            this.q2memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q2memoEdit1.Name = "q2memoEdit1";
            this.q2memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q2memoEdit1.TabIndex = 1;
            // 
            // q2Label
            // 
            this.q2Label.Location = new System.Drawing.Point(24, 14);
            this.q2Label.Name = "q2Label";
            this.q2Label.Size = new System.Drawing.Size(148, 13);
            this.q2Label.TabIndex = 0;
            this.q2Label.Text = "What the system meant to do?";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.q3PanelControl1);
            this.wizardPage3.Controls.Add(this.q3Label);
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(572, 269);
            this.wizardPage3.Text = "The need –";
            this.wizardPage3.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage3_PageValidating);
            // 
            // q3PanelControl1
            // 
            this.q3PanelControl1.Controls.Add(this.BillingCheckEdit10);
            this.q3PanelControl1.Controls.Add(this.DistributionCheckEdit9);
            this.q3PanelControl1.Controls.Add(this.MarketingCheckEdit8);
            this.q3PanelControl1.Controls.Add(this.ManagementDecisionCheckEdit7);
            this.q3PanelControl1.Controls.Add(this.InformationSecurityCheckEdit6);
            this.q3PanelControl1.Controls.Add(this.CRMcheckEdit5);
            this.q3PanelControl1.Controls.Add(this.GeneralITCheckEdit4);
            this.q3PanelControl1.Controls.Add(this.LogisticsCheckEdit3);
            this.q3PanelControl1.Controls.Add(this.ManagementCheckEdit1);
            this.q3PanelControl1.Controls.Add(this.HRCheckEdit2);
            this.q3PanelControl1.Location = new System.Drawing.Point(87, 33);
            this.q3PanelControl1.Name = "q3PanelControl1";
            this.q3PanelControl1.Size = new System.Drawing.Size(410, 154);
            this.q3PanelControl1.TabIndex = 4;
            // 
            // BillingCheckEdit10
            // 
            this.BillingCheckEdit10.Location = new System.Drawing.Point(183, 117);
            this.BillingCheckEdit10.Name = "BillingCheckEdit10";
            this.BillingCheckEdit10.Properties.Caption = "Billing";
            this.BillingCheckEdit10.Size = new System.Drawing.Size(75, 19);
            this.BillingCheckEdit10.TabIndex = 11;
            // 
            // DistributionCheckEdit9
            // 
            this.DistributionCheckEdit9.Location = new System.Drawing.Point(183, 92);
            this.DistributionCheckEdit9.Name = "DistributionCheckEdit9";
            this.DistributionCheckEdit9.Properties.Caption = "Distribution channels (Digital)";
            this.DistributionCheckEdit9.Size = new System.Drawing.Size(169, 19);
            this.DistributionCheckEdit9.TabIndex = 10;
            // 
            // MarketingCheckEdit8
            // 
            this.MarketingCheckEdit8.Location = new System.Drawing.Point(183, 67);
            this.MarketingCheckEdit8.Name = "MarketingCheckEdit8";
            this.MarketingCheckEdit8.Properties.Caption = "Marketing";
            this.MarketingCheckEdit8.Size = new System.Drawing.Size(75, 19);
            this.MarketingCheckEdit8.TabIndex = 9;
            // 
            // ManagementDecisionCheckEdit7
            // 
            this.ManagementDecisionCheckEdit7.Location = new System.Drawing.Point(183, 42);
            this.ManagementDecisionCheckEdit7.Name = "ManagementDecisionCheckEdit7";
            this.ManagementDecisionCheckEdit7.Properties.Caption = "Management decision supporting system";
            this.ManagementDecisionCheckEdit7.Size = new System.Drawing.Size(219, 19);
            this.ManagementDecisionCheckEdit7.TabIndex = 8;
            // 
            // InformationSecurityCheckEdit6
            // 
            this.InformationSecurityCheckEdit6.Location = new System.Drawing.Point(183, 18);
            this.InformationSecurityCheckEdit6.Name = "InformationSecurityCheckEdit6";
            this.InformationSecurityCheckEdit6.Properties.Caption = "Information security";
            this.InformationSecurityCheckEdit6.Size = new System.Drawing.Size(135, 19);
            this.InformationSecurityCheckEdit6.TabIndex = 7;
            // 
            // CRMcheckEdit5
            // 
            this.CRMcheckEdit5.Location = new System.Drawing.Point(21, 117);
            this.CRMcheckEdit5.Name = "CRMcheckEdit5";
            this.CRMcheckEdit5.Properties.Caption = "CRM";
            this.CRMcheckEdit5.Size = new System.Drawing.Size(75, 19);
            this.CRMcheckEdit5.TabIndex = 6;
            // 
            // GeneralITCheckEdit4
            // 
            this.GeneralITCheckEdit4.Location = new System.Drawing.Point(21, 92);
            this.GeneralITCheckEdit4.Name = "GeneralITCheckEdit4";
            this.GeneralITCheckEdit4.Properties.Caption = "General IT";
            this.GeneralITCheckEdit4.Size = new System.Drawing.Size(75, 19);
            this.GeneralITCheckEdit4.TabIndex = 5;
            // 
            // LogisticsCheckEdit3
            // 
            this.LogisticsCheckEdit3.Location = new System.Drawing.Point(21, 67);
            this.LogisticsCheckEdit3.Name = "LogisticsCheckEdit3";
            this.LogisticsCheckEdit3.Properties.Caption = "Logistics";
            this.LogisticsCheckEdit3.Size = new System.Drawing.Size(75, 19);
            this.LogisticsCheckEdit3.TabIndex = 4;
            // 
            // ManagementCheckEdit1
            // 
            this.ManagementCheckEdit1.Location = new System.Drawing.Point(21, 17);
            this.ManagementCheckEdit1.Name = "ManagementCheckEdit1";
            this.ManagementCheckEdit1.Properties.Caption = "Management";
            this.ManagementCheckEdit1.Size = new System.Drawing.Size(89, 19);
            this.ManagementCheckEdit1.TabIndex = 2;
            // 
            // HRCheckEdit2
            // 
            this.HRCheckEdit2.Location = new System.Drawing.Point(21, 42);
            this.HRCheckEdit2.Name = "HRCheckEdit2";
            this.HRCheckEdit2.Properties.Caption = "HR";
            this.HRCheckEdit2.Size = new System.Drawing.Size(75, 19);
            this.HRCheckEdit2.TabIndex = 3;
            // 
            // q3Label
            // 
            this.q3Label.Location = new System.Drawing.Point(24, 14);
            this.q3Label.Name = "q3Label";
            this.q3Label.Size = new System.Drawing.Size(200, 13);
            this.q3Label.TabIndex = 0;
            this.q3Label.Text = "Who will use this system, daily and often?";
            // 
            // wizardPage4
            // 
            this.wizardPage4.Controls.Add(this.q4BMemoEdit1);
            this.wizardPage4.Controls.Add(this.q4BLabel);
            this.wizardPage4.Controls.Add(this.q4aRadioGroup1);
            this.wizardPage4.Controls.Add(this.q4ALabel);
            this.wizardPage4.Name = "wizardPage4";
            this.wizardPage4.Size = new System.Drawing.Size(572, 269);
            this.wizardPage4.Text = "The need –";
            this.wizardPage4.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage4_PageValidating);
            // 
            // q4BMemoEdit1
            // 
            this.q4BMemoEdit1.Location = new System.Drawing.Point(78, 92);
            this.q4BMemoEdit1.Name = "q4BMemoEdit1";
            this.q4BMemoEdit1.Size = new System.Drawing.Size(422, 55);
            this.q4BMemoEdit1.TabIndex = 3;
            // 
            // q4BLabel
            // 
            this.q4BLabel.Location = new System.Drawing.Point(22, 72);
            this.q4BLabel.Name = "q4BLabel";
            this.q4BLabel.Size = new System.Drawing.Size(95, 13);
            this.q4BLabel.TabIndex = 2;
            this.q4BLabel.Text = "Please explain why.";
            // 
            // q4aRadioGroup1
            // 
            this.q4aRadioGroup1.Location = new System.Drawing.Point(78, 33);
            this.q4aRadioGroup1.Name = "q4aRadioGroup1";
            this.q4aRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "No")});
            this.q4aRadioGroup1.Size = new System.Drawing.Size(148, 24);
            this.q4aRadioGroup1.TabIndex = 1;
            // 
            // q4ALabel
            // 
            this.q4ALabel.Location = new System.Drawing.Point(22, 14);
            this.q4ALabel.Name = "q4ALabel";
            this.q4ALabel.Size = new System.Drawing.Size(104, 13);
            this.q4ALabel.TabIndex = 0;
            this.q4ALabel.Text = "Is this system critical?";
            // 
            // wizardPage5
            // 
            this.wizardPage5.Controls.Add(this.q5RadioGroup2);
            this.wizardPage5.Controls.Add(this.q5Label);
            this.wizardPage5.Name = "wizardPage5";
            this.wizardPage5.Size = new System.Drawing.Size(572, 269);
            this.wizardPage5.Text = "Process";
            // 
            // q5RadioGroup2
            // 
            this.q5RadioGroup2.Location = new System.Drawing.Point(65, 33);
            this.q5RadioGroup2.Name = "q5RadioGroup2";
            this.q5RadioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Management"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "HR"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Logistics"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "General IT"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "CRM"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Information security"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Management decision supporting system"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Marketing"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Distribution channels (Digital)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Billing")});
            this.q5RadioGroup2.Size = new System.Drawing.Size(436, 154);
            this.q5RadioGroup2.TabIndex = 1;
            // 
            // q5Label
            // 
            this.q5Label.Location = new System.Drawing.Point(24, 14);
            this.q5Label.Name = "q5Label";
            this.q5Label.Size = new System.Drawing.Size(156, 13);
            this.q5Label.TabIndex = 0;
            this.q5Label.Text = "What is the field of this process?";
            // 
            // wizardPage6
            // 
            this.wizardPage6.Controls.Add(this.q6MemoEdit1);
            this.wizardPage6.Controls.Add(this.q6Label);
            this.wizardPage6.Name = "wizardPage6";
            this.wizardPage6.Size = new System.Drawing.Size(572, 269);
            this.wizardPage6.Text = "Process";
            // 
            // q6MemoEdit1
            // 
            this.q6MemoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q6MemoEdit1.Name = "q6MemoEdit1";
            this.q6MemoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q6MemoEdit1.TabIndex = 1;
            // 
            // q6Label
            // 
            this.q6Label.Location = new System.Drawing.Point(24, 14);
            this.q6Label.Name = "q6Label";
            this.q6Label.Size = new System.Drawing.Size(183, 13);
            this.q6Label.TabIndex = 0;
            this.q6Label.Text = "What is the incentive for this process?";
            // 
            // wizardPage7
            // 
            this.wizardPage7.Controls.Add(this.q7PanelControl2);
            this.wizardPage7.Controls.Add(this.q7Label);
            this.wizardPage7.Name = "wizardPage7";
            this.wizardPage7.Size = new System.Drawing.Size(572, 269);
            this.wizardPage7.Text = "Process";
            this.wizardPage7.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage7_PageValidating);
            // 
            // q7PanelControl2
            // 
            this.q7PanelControl2.Controls.Add(this.q7BillingCheckEdit1);
            this.q7PanelControl2.Controls.Add(this.q7DistributionCheckEdit2);
            this.q7PanelControl2.Controls.Add(this.q7MarketingCheckEdit3);
            this.q7PanelControl2.Controls.Add(this.q7ManagDecsCheckEdit4);
            this.q7PanelControl2.Controls.Add(this.q7InformationSecCheckEdit5);
            this.q7PanelControl2.Controls.Add(this.q7CRMCheckEdit6);
            this.q7PanelControl2.Controls.Add(this.q7GeneralITCheckEdit7);
            this.q7PanelControl2.Controls.Add(this.q7LogisticsCheckEdit8);
            this.q7PanelControl2.Controls.Add(this.q7ManagementCheckEdit9);
            this.q7PanelControl2.Controls.Add(this.q7HRCheckEdit10);
            this.q7PanelControl2.Location = new System.Drawing.Point(87, 33);
            this.q7PanelControl2.Name = "q7PanelControl2";
            this.q7PanelControl2.Size = new System.Drawing.Size(410, 154);
            this.q7PanelControl2.TabIndex = 5;
            // 
            // q7BillingCheckEdit1
            // 
            this.q7BillingCheckEdit1.Location = new System.Drawing.Point(183, 117);
            this.q7BillingCheckEdit1.Name = "q7BillingCheckEdit1";
            this.q7BillingCheckEdit1.Properties.Caption = "Billing";
            this.q7BillingCheckEdit1.Size = new System.Drawing.Size(75, 19);
            this.q7BillingCheckEdit1.TabIndex = 11;
            // 
            // q7DistributionCheckEdit2
            // 
            this.q7DistributionCheckEdit2.Location = new System.Drawing.Point(183, 92);
            this.q7DistributionCheckEdit2.Name = "q7DistributionCheckEdit2";
            this.q7DistributionCheckEdit2.Properties.Caption = "Distribution channels (Digital)";
            this.q7DistributionCheckEdit2.Size = new System.Drawing.Size(161, 19);
            this.q7DistributionCheckEdit2.TabIndex = 10;
            // 
            // q7MarketingCheckEdit3
            // 
            this.q7MarketingCheckEdit3.Location = new System.Drawing.Point(183, 67);
            this.q7MarketingCheckEdit3.Name = "q7MarketingCheckEdit3";
            this.q7MarketingCheckEdit3.Properties.Caption = "Marketing";
            this.q7MarketingCheckEdit3.Size = new System.Drawing.Size(75, 19);
            this.q7MarketingCheckEdit3.TabIndex = 9;
            // 
            // q7ManagDecsCheckEdit4
            // 
            this.q7ManagDecsCheckEdit4.Location = new System.Drawing.Point(183, 43);
            this.q7ManagDecsCheckEdit4.Name = "q7ManagDecsCheckEdit4";
            this.q7ManagDecsCheckEdit4.Properties.Caption = "Management decision supporting system";
            this.q7ManagDecsCheckEdit4.Size = new System.Drawing.Size(222, 19);
            this.q7ManagDecsCheckEdit4.TabIndex = 8;
            // 
            // q7InformationSecCheckEdit5
            // 
            this.q7InformationSecCheckEdit5.Location = new System.Drawing.Point(183, 18);
            this.q7InformationSecCheckEdit5.Name = "q7InformationSecCheckEdit5";
            this.q7InformationSecCheckEdit5.Properties.Caption = "Information security";
            this.q7InformationSecCheckEdit5.Size = new System.Drawing.Size(135, 19);
            this.q7InformationSecCheckEdit5.TabIndex = 7;
            // 
            // q7CRMCheckEdit6
            // 
            this.q7CRMCheckEdit6.Location = new System.Drawing.Point(21, 117);
            this.q7CRMCheckEdit6.Name = "q7CRMCheckEdit6";
            this.q7CRMCheckEdit6.Properties.Caption = "CRM";
            this.q7CRMCheckEdit6.Size = new System.Drawing.Size(75, 19);
            this.q7CRMCheckEdit6.TabIndex = 6;
            // 
            // q7GeneralITCheckEdit7
            // 
            this.q7GeneralITCheckEdit7.Location = new System.Drawing.Point(21, 92);
            this.q7GeneralITCheckEdit7.Name = "q7GeneralITCheckEdit7";
            this.q7GeneralITCheckEdit7.Properties.Caption = "General IT";
            this.q7GeneralITCheckEdit7.Size = new System.Drawing.Size(75, 19);
            this.q7GeneralITCheckEdit7.TabIndex = 5;
            // 
            // q7LogisticsCheckEdit8
            // 
            this.q7LogisticsCheckEdit8.Location = new System.Drawing.Point(21, 67);
            this.q7LogisticsCheckEdit8.Name = "q7LogisticsCheckEdit8";
            this.q7LogisticsCheckEdit8.Properties.Caption = "Logistics";
            this.q7LogisticsCheckEdit8.Size = new System.Drawing.Size(75, 19);
            this.q7LogisticsCheckEdit8.TabIndex = 4;
            // 
            // q7ManagementCheckEdit9
            // 
            this.q7ManagementCheckEdit9.Location = new System.Drawing.Point(21, 17);
            this.q7ManagementCheckEdit9.Name = "q7ManagementCheckEdit9";
            this.q7ManagementCheckEdit9.Properties.Caption = "Management";
            this.q7ManagementCheckEdit9.Size = new System.Drawing.Size(94, 19);
            this.q7ManagementCheckEdit9.TabIndex = 2;
            // 
            // q7HRCheckEdit10
            // 
            this.q7HRCheckEdit10.Location = new System.Drawing.Point(21, 42);
            this.q7HRCheckEdit10.Name = "q7HRCheckEdit10";
            this.q7HRCheckEdit10.Properties.Caption = "HR";
            this.q7HRCheckEdit10.Size = new System.Drawing.Size(75, 19);
            this.q7HRCheckEdit10.TabIndex = 3;
            // 
            // q7Label
            // 
            this.q7Label.Location = new System.Drawing.Point(24, 14);
            this.q7Label.Name = "q7Label";
            this.q7Label.Size = new System.Drawing.Size(217, 13);
            this.q7Label.TabIndex = 0;
            this.q7Label.Text = "Who are the main consumers of this process?";
            // 
            // wizardPage8
            // 
            this.wizardPage8.Controls.Add(this.q8bJobTextEdit2);
            this.wizardPage8.Controls.Add(this.q8bJobLabel);
            this.wizardPage8.Controls.Add(this.q8aNameLabel);
            this.wizardPage8.Controls.Add(this.q8aNameTextEdit1);
            this.wizardPage8.Controls.Add(this.q8Label);
            this.wizardPage8.Name = "wizardPage8";
            this.wizardPage8.Size = new System.Drawing.Size(572, 269);
            this.wizardPage8.Text = "Process";
            // 
            // q8bJobTextEdit2
            // 
            this.q8bJobTextEdit2.Location = new System.Drawing.Point(77, 125);
            this.q8bJobTextEdit2.Name = "q8bJobTextEdit2";
            this.q8bJobTextEdit2.Size = new System.Drawing.Size(169, 20);
            this.q8bJobTextEdit2.TabIndex = 4;
            // 
            // q8bJobLabel
            // 
            this.q8bJobLabel.Location = new System.Drawing.Point(77, 106);
            this.q8bJobLabel.Name = "q8bJobLabel";
            this.q8bJobLabel.Size = new System.Drawing.Size(40, 13);
            this.q8bJobLabel.TabIndex = 3;
            this.q8bJobLabel.Text = "Job Title";
            // 
            // q8aNameLabel
            // 
            this.q8aNameLabel.Location = new System.Drawing.Point(77, 45);
            this.q8aNameLabel.Name = "q8aNameLabel";
            this.q8aNameLabel.Size = new System.Drawing.Size(27, 13);
            this.q8aNameLabel.TabIndex = 2;
            this.q8aNameLabel.Text = "Name";
            // 
            // q8aNameTextEdit1
            // 
            this.q8aNameTextEdit1.Location = new System.Drawing.Point(77, 64);
            this.q8aNameTextEdit1.Name = "q8aNameTextEdit1";
            this.q8aNameTextEdit1.Size = new System.Drawing.Size(169, 20);
            this.q8aNameTextEdit1.TabIndex = 1;
            // 
            // q8Label
            // 
            this.q8Label.Location = new System.Drawing.Point(24, 14);
            this.q8Label.Name = "q8Label";
            this.q8Label.Size = new System.Drawing.Size(162, 13);
            this.q8Label.TabIndex = 0;
            this.q8Label.Text = "Who is the owner of this process?";
            // 
            // wizardPage9
            // 
            this.wizardPage9.Controls.Add(this.q9TextEdit1);
            this.wizardPage9.Controls.Add(this.q9Label);
            this.wizardPage9.Name = "wizardPage9";
            this.wizardPage9.Size = new System.Drawing.Size(572, 269);
            this.wizardPage9.Text = "System title";
            // 
            // q9TextEdit1
            // 
            this.q9TextEdit1.EditValue = "";
            this.q9TextEdit1.Enabled = false;
            this.q9TextEdit1.Location = new System.Drawing.Point(24, 33);
            this.q9TextEdit1.Name = "q9TextEdit1";
            this.q9TextEdit1.Size = new System.Drawing.Size(169, 20);
            this.q9TextEdit1.TabIndex = 1;
            // 
            // q9Label
            // 
            this.q9Label.Location = new System.Drawing.Point(24, 14);
            this.q9Label.Name = "q9Label";
            this.q9Label.Size = new System.Drawing.Size(115, 13);
            this.q9Label.TabIndex = 0;
            this.q9Label.Text = "Give the system a name";
            // 
            // wizardPage10
            // 
            this.wizardPage10.Controls.Add(this.q10TextEdit1);
            this.wizardPage10.Controls.Add(this.q10Label);
            this.wizardPage10.Name = "wizardPage10";
            this.wizardPage10.Size = new System.Drawing.Size(572, 269);
            this.wizardPage10.Text = "System title";
            // 
            // q10TextEdit1
            // 
            this.q10TextEdit1.Location = new System.Drawing.Point(24, 33);
            this.q10TextEdit1.Name = "q10TextEdit1";
            this.q10TextEdit1.Size = new System.Drawing.Size(514, 20);
            this.q10TextEdit1.TabIndex = 1;
            // 
            // q10Label
            // 
            this.q10Label.Location = new System.Drawing.Point(24, 14);
            this.q10Label.Name = "q10Label";
            this.q10Label.Size = new System.Drawing.Size(250, 13);
            this.q10Label.TabIndex = 0;
            this.q10Label.Text = "What is the propose of the system in one sentence?";
            // 
            // wizardPage11
            // 
            this.wizardPage11.Controls.Add(this.q11MemoEdit1);
            this.wizardPage11.Controls.Add(this.q11Label);
            this.wizardPage11.Name = "wizardPage11";
            this.wizardPage11.Size = new System.Drawing.Size(572, 269);
            this.wizardPage11.Text = "System title";
            // 
            // q11MemoEdit1
            // 
            this.q11MemoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q11MemoEdit1.Name = "q11MemoEdit1";
            this.q11MemoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q11MemoEdit1.TabIndex = 1;
            // 
            // q11Label
            // 
            this.q11Label.Location = new System.Drawing.Point(24, 14);
            this.q11Label.Name = "q11Label";
            this.q11Label.Size = new System.Drawing.Size(137, 13);
            this.q11Label.TabIndex = 0;
            this.q11Label.Text = "Describe the system process";
            // 
            // wizardPage12
            // 
            this.wizardPage12.Controls.Add(this.q12PanelControl3);
            this.wizardPage12.Controls.Add(this.q12Label);
            this.wizardPage12.Name = "wizardPage12";
            this.wizardPage12.Size = new System.Drawing.Size(572, 269);
            this.wizardPage12.Text = "System Classification";
            this.wizardPage12.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage12_PageValidating);
            // 
            // q12PanelControl3
            // 
            this.q12PanelControl3.Controls.Add(this.q12BillingCheckEdit11);
            this.q12PanelControl3.Controls.Add(this.q12DistributionCheckEdit12);
            this.q12PanelControl3.Controls.Add(this.q12MarketingCheckEdit13);
            this.q12PanelControl3.Controls.Add(this.q12MangDecsCheckEdit14);
            this.q12PanelControl3.Controls.Add(this.q12InformationSecCheckEdit15);
            this.q12PanelControl3.Controls.Add(this.q12CRMCheckEdit16);
            this.q12PanelControl3.Controls.Add(this.q12GeneralITCheckEdit17);
            this.q12PanelControl3.Controls.Add(this.q12LogisticsCheckEdit18);
            this.q12PanelControl3.Controls.Add(this.q12ManagementCheckEdit19);
            this.q12PanelControl3.Controls.Add(this.q12HRCheckEdit20);
            this.q12PanelControl3.Location = new System.Drawing.Point(87, 33);
            this.q12PanelControl3.Name = "q12PanelControl3";
            this.q12PanelControl3.Size = new System.Drawing.Size(410, 154);
            this.q12PanelControl3.TabIndex = 6;
            // 
            // q12BillingCheckEdit11
            // 
            this.q12BillingCheckEdit11.Location = new System.Drawing.Point(183, 117);
            this.q12BillingCheckEdit11.Name = "q12BillingCheckEdit11";
            this.q12BillingCheckEdit11.Properties.Caption = "Billing";
            this.q12BillingCheckEdit11.Size = new System.Drawing.Size(75, 19);
            this.q12BillingCheckEdit11.TabIndex = 11;
            // 
            // q12DistributionCheckEdit12
            // 
            this.q12DistributionCheckEdit12.Location = new System.Drawing.Point(183, 92);
            this.q12DistributionCheckEdit12.Name = "q12DistributionCheckEdit12";
            this.q12DistributionCheckEdit12.Properties.Caption = "Distribution channels (Digital)";
            this.q12DistributionCheckEdit12.Size = new System.Drawing.Size(169, 19);
            this.q12DistributionCheckEdit12.TabIndex = 10;
            // 
            // q12MarketingCheckEdit13
            // 
            this.q12MarketingCheckEdit13.Location = new System.Drawing.Point(183, 67);
            this.q12MarketingCheckEdit13.Name = "q12MarketingCheckEdit13";
            this.q12MarketingCheckEdit13.Properties.Caption = "Marketing";
            this.q12MarketingCheckEdit13.Size = new System.Drawing.Size(75, 19);
            this.q12MarketingCheckEdit13.TabIndex = 9;
            // 
            // q12MangDecsCheckEdit14
            // 
            this.q12MangDecsCheckEdit14.Location = new System.Drawing.Point(183, 42);
            this.q12MangDecsCheckEdit14.Name = "q12MangDecsCheckEdit14";
            this.q12MangDecsCheckEdit14.Properties.Caption = "Management decision supporting system";
            this.q12MangDecsCheckEdit14.Size = new System.Drawing.Size(222, 19);
            this.q12MangDecsCheckEdit14.TabIndex = 8;
            // 
            // q12InformationSecCheckEdit15
            // 
            this.q12InformationSecCheckEdit15.Location = new System.Drawing.Point(183, 18);
            this.q12InformationSecCheckEdit15.Name = "q12InformationSecCheckEdit15";
            this.q12InformationSecCheckEdit15.Properties.Caption = "Information security";
            this.q12InformationSecCheckEdit15.Size = new System.Drawing.Size(135, 19);
            this.q12InformationSecCheckEdit15.TabIndex = 7;
            // 
            // q12CRMCheckEdit16
            // 
            this.q12CRMCheckEdit16.Location = new System.Drawing.Point(21, 117);
            this.q12CRMCheckEdit16.Name = "q12CRMCheckEdit16";
            this.q12CRMCheckEdit16.Properties.Caption = "CRM";
            this.q12CRMCheckEdit16.Size = new System.Drawing.Size(75, 19);
            this.q12CRMCheckEdit16.TabIndex = 6;
            // 
            // q12GeneralITCheckEdit17
            // 
            this.q12GeneralITCheckEdit17.Location = new System.Drawing.Point(21, 92);
            this.q12GeneralITCheckEdit17.Name = "q12GeneralITCheckEdit17";
            this.q12GeneralITCheckEdit17.Properties.Caption = "General IT";
            this.q12GeneralITCheckEdit17.Size = new System.Drawing.Size(75, 19);
            this.q12GeneralITCheckEdit17.TabIndex = 5;
            // 
            // q12LogisticsCheckEdit18
            // 
            this.q12LogisticsCheckEdit18.Location = new System.Drawing.Point(21, 67);
            this.q12LogisticsCheckEdit18.Name = "q12LogisticsCheckEdit18";
            this.q12LogisticsCheckEdit18.Properties.Caption = "Logistics";
            this.q12LogisticsCheckEdit18.Size = new System.Drawing.Size(75, 19);
            this.q12LogisticsCheckEdit18.TabIndex = 4;
            // 
            // q12ManagementCheckEdit19
            // 
            this.q12ManagementCheckEdit19.Location = new System.Drawing.Point(21, 17);
            this.q12ManagementCheckEdit19.Name = "q12ManagementCheckEdit19";
            this.q12ManagementCheckEdit19.Properties.Caption = "Management";
            this.q12ManagementCheckEdit19.Size = new System.Drawing.Size(94, 19);
            this.q12ManagementCheckEdit19.TabIndex = 2;
            // 
            // q12HRCheckEdit20
            // 
            this.q12HRCheckEdit20.Location = new System.Drawing.Point(21, 42);
            this.q12HRCheckEdit20.Name = "q12HRCheckEdit20";
            this.q12HRCheckEdit20.Properties.Caption = "HR";
            this.q12HRCheckEdit20.Size = new System.Drawing.Size(75, 19);
            this.q12HRCheckEdit20.TabIndex = 3;
            // 
            // q12Label
            // 
            this.q12Label.Location = new System.Drawing.Point(24, 14);
            this.q12Label.Name = "q12Label";
            this.q12Label.Size = new System.Drawing.Size(100, 13);
            this.q12Label.TabIndex = 0;
            this.q12Label.Text = "System Classification";
            // 
            // wizardPage13
            // 
            this.wizardPage13.Controls.Add(this.q13SystemHoldComboBoxEdit2);
            this.wizardPage13.Controls.Add(this.q13SystemHoldComboBoxEdit1);
            this.wizardPage13.Controls.Add(this.q13SystemHoldRadioGroup);
            this.wizardPage13.Controls.Add(this.q13Label);
            this.wizardPage13.Name = "wizardPage13";
            this.wizardPage13.Size = new System.Drawing.Size(572, 269);
            this.wizardPage13.Text = "System hold";
            this.wizardPage13.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage13_PageValidating);
            // 
            // q13SystemHoldComboBoxEdit2
            // 
            this.q13SystemHoldComboBoxEdit2.Location = new System.Drawing.Point(137, 115);
            this.q13SystemHoldComboBoxEdit2.Name = "q13SystemHoldComboBoxEdit2";
            this.q13SystemHoldComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.q13SystemHoldComboBoxEdit2.Properties.Items.AddRange(new object[] {
            "AWS",
            "Azure"});
            this.q13SystemHoldComboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.q13SystemHoldComboBoxEdit2.TabIndex = 3;
            this.q13SystemHoldComboBoxEdit2.Visible = false;
            this.q13SystemHoldComboBoxEdit2.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // q13SystemHoldComboBoxEdit1
            // 
            this.q13SystemHoldComboBoxEdit1.Location = new System.Drawing.Point(103, 80);
            this.q13SystemHoldComboBoxEdit1.Name = "q13SystemHoldComboBoxEdit1";
            this.q13SystemHoldComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.q13SystemHoldComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "External",
            "Internal",
            "Development",
            "Production"});
            this.q13SystemHoldComboBoxEdit1.Size = new System.Drawing.Size(134, 20);
            this.q13SystemHoldComboBoxEdit1.TabIndex = 2;
            this.q13SystemHoldComboBoxEdit1.SelectedValueChanged += new System.EventHandler(this.comboBoxEdit1_SelectedValueChanged);
            // 
            // q13SystemHoldRadioGroup
            // 
            this.q13SystemHoldRadioGroup.Location = new System.Drawing.Point(61, 39);
            this.q13SystemHoldRadioGroup.Name = "q13SystemHoldRadioGroup";
            this.q13SystemHoldRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "On premise"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cloud")});
            this.q13SystemHoldRadioGroup.Size = new System.Drawing.Size(176, 24);
            this.q13SystemHoldRadioGroup.TabIndex = 1;
            this.q13SystemHoldRadioGroup.SelectedIndexChanged += new System.EventHandler(this.radioGroup3_SelectedIndexChanged);
            // 
            // q13Label
            // 
            this.q13Label.Location = new System.Drawing.Point(24, 14);
            this.q13Label.Name = "q13Label";
            this.q13Label.Size = new System.Drawing.Size(58, 13);
            this.q13Label.TabIndex = 0;
            this.q13Label.Text = "System hold";
            // 
            // wizardPage14
            // 
            this.wizardPage14.Controls.Add(this.q14RadioGroup);
            this.wizardPage14.Controls.Add(this.q14Label);
            this.wizardPage14.Name = "wizardPage14";
            this.wizardPage14.Size = new System.Drawing.Size(572, 269);
            this.wizardPage14.Text = "System type";
            // 
            // q14RadioGroup
            // 
            this.q14RadioGroup.Location = new System.Drawing.Point(63, 33);
            this.q14RadioGroup.Name = "q14RadioGroup";
            this.q14RadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Virtual"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Physical")});
            this.q14RadioGroup.Size = new System.Drawing.Size(442, 29);
            this.q14RadioGroup.TabIndex = 3;
            // 
            // q14Label
            // 
            this.q14Label.Location = new System.Drawing.Point(24, 14);
            this.q14Label.Name = "q14Label";
            this.q14Label.Size = new System.Drawing.Size(60, 13);
            this.q14Label.TabIndex = 0;
            this.q14Label.Text = "System type";
            // 
            // wizardPage15
            // 
            this.wizardPage15.Controls.Add(this.q15PanelControl4);
            this.wizardPage15.Controls.Add(this.q15Label);
            this.wizardPage15.Name = "wizardPage15";
            this.wizardPage15.Size = new System.Drawing.Size(572, 269);
            this.wizardPage15.Text = "Methodology";
            this.wizardPage15.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage15_PageValidating);
            // 
            // q15PanelControl4
            // 
            this.q15PanelControl4.Controls.Add(this.q15CyclicCheckEdit24);
            this.q15PanelControl4.Controls.Add(this.q15IntegrationTechniquesCheckEdit23);
            this.q15PanelControl4.Controls.Add(this.q15SDLCCheckEdit22);
            this.q15PanelControl4.Controls.Add(this.q15BestPracticesCheckEdit21);
            this.q15PanelControl4.Location = new System.Drawing.Point(67, 33);
            this.q15PanelControl4.Name = "q15PanelControl4";
            this.q15PanelControl4.Size = new System.Drawing.Size(419, 100);
            this.q15PanelControl4.TabIndex = 2;
            // 
            // q15CyclicCheckEdit24
            // 
            this.q15CyclicCheckEdit24.Location = new System.Drawing.Point(257, 60);
            this.q15CyclicCheckEdit24.Name = "q15CyclicCheckEdit24";
            this.q15CyclicCheckEdit24.Properties.Caption = "Cyclic revision integration";
            this.q15CyclicCheckEdit24.Size = new System.Drawing.Size(145, 19);
            this.q15CyclicCheckEdit24.TabIndex = 3;
            // 
            // q15IntegrationTechniquesCheckEdit23
            // 
            this.q15IntegrationTechniquesCheckEdit23.Location = new System.Drawing.Point(5, 60);
            this.q15IntegrationTechniquesCheckEdit23.Name = "q15IntegrationTechniquesCheckEdit23";
            this.q15IntegrationTechniquesCheckEdit23.Properties.Caption = "Integration Techniques";
            this.q15IntegrationTechniquesCheckEdit23.Size = new System.Drawing.Size(132, 19);
            this.q15IntegrationTechniquesCheckEdit23.TabIndex = 2;
            // 
            // q15SDLCCheckEdit22
            // 
            this.q15SDLCCheckEdit22.Location = new System.Drawing.Point(257, 17);
            this.q15SDLCCheckEdit22.Name = "q15SDLCCheckEdit22";
            this.q15SDLCCheckEdit22.Properties.Caption = "SDLC";
            this.q15SDLCCheckEdit22.Size = new System.Drawing.Size(75, 19);
            this.q15SDLCCheckEdit22.TabIndex = 1;
            // 
            // q15BestPracticesCheckEdit21
            // 
            this.q15BestPracticesCheckEdit21.Location = new System.Drawing.Point(5, 17);
            this.q15BestPracticesCheckEdit21.Name = "q15BestPracticesCheckEdit21";
            this.q15BestPracticesCheckEdit21.Properties.Caption = "Best Practices";
            this.q15BestPracticesCheckEdit21.Size = new System.Drawing.Size(106, 19);
            this.q15BestPracticesCheckEdit21.TabIndex = 0;
            // 
            // q15Label
            // 
            this.q15Label.Location = new System.Drawing.Point(24, 14);
            this.q15Label.Name = "q15Label";
            this.q15Label.Size = new System.Drawing.Size(62, 13);
            this.q15Label.TabIndex = 0;
            this.q15Label.Text = "Methodology";
            // 
            // wizardPage16
            // 
            this.wizardPage16.Controls.Add(this.q16PanelControl5);
            this.wizardPage16.Controls.Add(this.q16Label);
            this.wizardPage16.Name = "wizardPage16";
            this.wizardPage16.Size = new System.Drawing.Size(572, 269);
            this.wizardPage16.Text = "Knowledge Management";
            this.wizardPage16.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage16_PageValidating);
            // 
            // q16PanelControl5
            // 
            this.q16PanelControl5.Controls.Add(this.q16OrganizationalSearchCheckEdit22);
            this.q16PanelControl5.Controls.Add(this.q16APIMCheckEdit21);
            this.q16PanelControl5.Location = new System.Drawing.Point(67, 33);
            this.q16PanelControl5.Name = "q16PanelControl5";
            this.q16PanelControl5.Size = new System.Drawing.Size(419, 30);
            this.q16PanelControl5.TabIndex = 1;
            // 
            // q16OrganizationalSearchCheckEdit22
            // 
            this.q16OrganizationalSearchCheckEdit22.Location = new System.Drawing.Point(268, 6);
            this.q16OrganizationalSearchCheckEdit22.Name = "q16OrganizationalSearchCheckEdit22";
            this.q16OrganizationalSearchCheckEdit22.Properties.Caption = "Organizational Search";
            this.q16OrganizationalSearchCheckEdit22.Size = new System.Drawing.Size(132, 19);
            this.q16OrganizationalSearchCheckEdit22.TabIndex = 1;
            // 
            // q16APIMCheckEdit21
            // 
            this.q16APIMCheckEdit21.Location = new System.Drawing.Point(19, 5);
            this.q16APIMCheckEdit21.Name = "q16APIMCheckEdit21";
            this.q16APIMCheckEdit21.Properties.Caption = "APIM";
            this.q16APIMCheckEdit21.Size = new System.Drawing.Size(75, 19);
            this.q16APIMCheckEdit21.TabIndex = 0;
            // 
            // q16Label
            // 
            this.q16Label.Location = new System.Drawing.Point(24, 14);
            this.q16Label.Name = "q16Label";
            this.q16Label.Size = new System.Drawing.Size(117, 13);
            this.q16Label.TabIndex = 0;
            this.q16Label.Text = "Knowledge Management";
            // 
            // wizardPage17
            // 
            this.wizardPage17.Controls.Add(this.q17RadioGroup4);
            this.wizardPage17.Controls.Add(this.q17Label);
            this.wizardPage17.Name = "wizardPage17";
            this.wizardPage17.Size = new System.Drawing.Size(572, 269);
            this.wizardPage17.Text = "Technology";
            // 
            // q17RadioGroup4
            // 
            this.q17RadioGroup4.Location = new System.Drawing.Point(76, 33);
            this.q17RadioGroup4.Name = "q17RadioGroup4";
            this.q17RadioGroup4.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "In house proprietary solution"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "On shelf solution")});
            this.q17RadioGroup4.Size = new System.Drawing.Size(420, 30);
            this.q17RadioGroup4.TabIndex = 3;
            this.q17RadioGroup4.SelectedIndexChanged += new System.EventHandler(this.radioGroup4_SelectedIndexChanged);
            // 
            // q17Label
            // 
            this.q17Label.Location = new System.Drawing.Point(24, 14);
            this.q17Label.Name = "q17Label";
            this.q17Label.Size = new System.Drawing.Size(55, 13);
            this.q17Label.TabIndex = 0;
            this.q17Label.Text = "Technology";
            // 
            // wizardPage18
            // 
            this.wizardPage18.Controls.Add(this.q25MemoEdit1);
            this.wizardPage18.Controls.Add(this.q25Label);
            this.wizardPage18.Name = "wizardPage18";
            this.wizardPage18.Size = new System.Drawing.Size(572, 269);
            this.wizardPage18.Text = "System Data";
            // 
            // q25MemoEdit1
            // 
            this.q25MemoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q25MemoEdit1.Name = "q25MemoEdit1";
            this.q25MemoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q25MemoEdit1.TabIndex = 1;
            // 
            // q25Label
            // 
            this.q25Label.Location = new System.Drawing.Point(24, 14);
            this.q25Label.Name = "q25Label";
            this.q25Label.Size = new System.Drawing.Size(164, 13);
            this.q25Label.TabIndex = 0;
            this.q25Label.Text = "What data the system will handle?";
            // 
            // wizardPage19
            // 
            this.wizardPage19.Controls.Add(this.q26MemoEdit1);
            this.wizardPage19.Controls.Add(this.q26Label);
            this.wizardPage19.Name = "wizardPage19";
            this.wizardPage19.Size = new System.Drawing.Size(572, 269);
            this.wizardPage19.Text = "System Data";
            // 
            // q26MemoEdit1
            // 
            this.q26MemoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q26MemoEdit1.Name = "q26MemoEdit1";
            this.q26MemoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q26MemoEdit1.TabIndex = 1;
            // 
            // q26Label
            // 
            this.q26Label.Location = new System.Drawing.Point(24, 14);
            this.q26Label.Name = "q26Label";
            this.q26Label.Size = new System.Drawing.Size(126, 13);
            this.q26Label.TabIndex = 0;
            this.q26Label.Text = "Where is this data stored?";
            // 
            // wizardPage20
            // 
            this.wizardPage20.Controls.Add(this.q27MemoEdit1);
            this.wizardPage20.Controls.Add(this.q27Label);
            this.wizardPage20.Name = "wizardPage20";
            this.wizardPage20.Size = new System.Drawing.Size(572, 269);
            this.wizardPage20.Text = "System Data";
            // 
            // q27MemoEdit1
            // 
            this.q27MemoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q27MemoEdit1.Name = "q27MemoEdit1";
            this.q27MemoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q27MemoEdit1.TabIndex = 1;
            // 
            // q27Label
            // 
            this.q27Label.Location = new System.Drawing.Point(24, 14);
            this.q27Label.Name = "q27Label";
            this.q27Label.Size = new System.Drawing.Size(127, 13);
            this.q27Label.TabIndex = 0;
            this.q27Label.Text = "Who can access this data?";
            // 
            // wizardPage21
            // 
            this.wizardPage21.Controls.Add(this.q28panelControl6);
            this.wizardPage21.Controls.Add(this.q28Label);
            this.wizardPage21.Name = "wizardPage21";
            this.wizardPage21.Size = new System.Drawing.Size(572, 269);
            this.wizardPage21.Text = "System Platform";
            this.wizardPage21.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage21_PageValidating);
            // 
            // q28panelControl6
            // 
            this.q28panelControl6.Controls.Add(this.q28ESXcheckEdit25);
            this.q28panelControl6.Controls.Add(this.q28AS400checkEdit24);
            this.q28panelControl6.Controls.Add(this.q28LinuxCheckEdit23);
            this.q28panelControl6.Controls.Add(this.q28UnixCheckEdit22);
            this.q28panelControl6.Controls.Add(this.q28WinCheckEdit21);
            this.q28panelControl6.Location = new System.Drawing.Point(62, 33);
            this.q28panelControl6.Name = "q28panelControl6";
            this.q28panelControl6.Size = new System.Drawing.Size(433, 85);
            this.q28panelControl6.TabIndex = 1;
            // 
            // q28ESXcheckEdit25
            // 
            this.q28ESXcheckEdit25.Location = new System.Drawing.Point(260, 6);
            this.q28ESXcheckEdit25.Name = "q28ESXcheckEdit25";
            this.q28ESXcheckEdit25.Properties.Caption = "ESX";
            this.q28ESXcheckEdit25.Size = new System.Drawing.Size(75, 19);
            this.q28ESXcheckEdit25.TabIndex = 4;
            // 
            // q28AS400checkEdit24
            // 
            this.q28AS400checkEdit24.Location = new System.Drawing.Point(260, 32);
            this.q28AS400checkEdit24.Name = "q28AS400checkEdit24";
            this.q28AS400checkEdit24.Properties.Caption = "AS400";
            this.q28AS400checkEdit24.Size = new System.Drawing.Size(75, 19);
            this.q28AS400checkEdit24.TabIndex = 3;
            // 
            // q28LinuxCheckEdit23
            // 
            this.q28LinuxCheckEdit23.Location = new System.Drawing.Point(6, 32);
            this.q28LinuxCheckEdit23.Name = "q28LinuxCheckEdit23";
            this.q28LinuxCheckEdit23.Properties.Caption = "Linux";
            this.q28LinuxCheckEdit23.Size = new System.Drawing.Size(75, 19);
            this.q28LinuxCheckEdit23.TabIndex = 2;
            // 
            // q28UnixCheckEdit22
            // 
            this.q28UnixCheckEdit22.Location = new System.Drawing.Point(6, 57);
            this.q28UnixCheckEdit22.Name = "q28UnixCheckEdit22";
            this.q28UnixCheckEdit22.Properties.Caption = "Unix";
            this.q28UnixCheckEdit22.Size = new System.Drawing.Size(75, 19);
            this.q28UnixCheckEdit22.TabIndex = 1;
            // 
            // q28WinCheckEdit21
            // 
            this.q28WinCheckEdit21.Location = new System.Drawing.Point(6, 6);
            this.q28WinCheckEdit21.Name = "q28WinCheckEdit21";
            this.q28WinCheckEdit21.Properties.Caption = "Win";
            this.q28WinCheckEdit21.Size = new System.Drawing.Size(75, 19);
            this.q28WinCheckEdit21.TabIndex = 0;
            // 
            // q28Label
            // 
            this.q28Label.Location = new System.Drawing.Point(24, 14);
            this.q28Label.Name = "q28Label";
            this.q28Label.Size = new System.Drawing.Size(78, 13);
            this.q28Label.TabIndex = 0;
            this.q28Label.Text = "System Platform";
            // 
            // wizardPage22
            // 
            this.wizardPage22.Controls.Add(this.q29memoEdit1);
            this.wizardPage22.Controls.Add(this.q29Label);
            this.wizardPage22.Name = "wizardPage22";
            this.wizardPage22.Size = new System.Drawing.Size(572, 269);
            this.wizardPage22.Text = "Access controls";
            // 
            // q29memoEdit1
            // 
            this.q29memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q29memoEdit1.Name = "q29memoEdit1";
            this.q29memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q29memoEdit1.TabIndex = 1;
            // 
            // q29Label
            // 
            this.q29Label.Location = new System.Drawing.Point(24, 14);
            this.q29Label.Name = "q29Label";
            this.q29Label.Size = new System.Drawing.Size(123, 13);
            this.q29Label.TabIndex = 0;
            this.q29Label.Text = "How is the system admin?";
            // 
            // wizardPage23
            // 
            this.wizardPage23.Controls.Add(this.q30memoEdit1);
            this.wizardPage23.Controls.Add(this.q30Label);
            this.wizardPage23.Name = "wizardPage23";
            this.wizardPage23.Size = new System.Drawing.Size(572, 269);
            this.wizardPage23.Text = "Access controls";
            // 
            // q30memoEdit1
            // 
            this.q30memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q30memoEdit1.Name = "q30memoEdit1";
            this.q30memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q30memoEdit1.TabIndex = 2;
            // 
            // q30Label
            // 
            this.q30Label.Location = new System.Drawing.Point(24, 14);
            this.q30Label.Name = "q30Label";
            this.q30Label.Size = new System.Drawing.Size(195, 13);
            this.q30Label.TabIndex = 1;
            this.q30Label.Text = "How is authorized to access this system?";
            // 
            // wizardPage24
            // 
            this.wizardPage24.Controls.Add(this.q31memoEdit1);
            this.wizardPage24.Controls.Add(this.q31Label);
            this.wizardPage24.Name = "wizardPage24";
            this.wizardPage24.Size = new System.Drawing.Size(572, 269);
            this.wizardPage24.Text = "Access controls";
            // 
            // q31memoEdit1
            // 
            this.q31memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q31memoEdit1.Name = "q31memoEdit1";
            this.q31memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q31memoEdit1.TabIndex = 2;
            // 
            // q31Label
            // 
            this.q31Label.Location = new System.Drawing.Point(24, 14);
            this.q31Label.Name = "q31Label";
            this.q31Label.Size = new System.Drawing.Size(181, 13);
            this.q31Label.TabIndex = 1;
            this.q31Label.Text = "What rolls configured for this system?";
            // 
            // wizardPage25
            // 
            this.wizardPage25.Controls.Add(this.q32memoEdit1);
            this.wizardPage25.Controls.Add(this.q32Label);
            this.wizardPage25.Name = "wizardPage25";
            this.wizardPage25.Size = new System.Drawing.Size(572, 269);
            this.wizardPage25.Text = "Access controls";
            // 
            // q32memoEdit1
            // 
            this.q32memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q32memoEdit1.Name = "q32memoEdit1";
            this.q32memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q32memoEdit1.TabIndex = 2;
            // 
            // q32Label
            // 
            this.q32Label.Location = new System.Drawing.Point(24, 14);
            this.q32Label.Name = "q32Label";
            this.q32Label.Size = new System.Drawing.Size(193, 13);
            this.q32Label.TabIndex = 1;
            this.q32Label.Text = "When revising system authorized users?";
            // 
            // wizardPage26
            // 
            this.wizardPage26.Controls.Add(this.q33memoEdit1);
            this.wizardPage26.Controls.Add(this.q33Label);
            this.wizardPage26.Name = "wizardPage26";
            this.wizardPage26.Size = new System.Drawing.Size(572, 269);
            this.wizardPage26.Text = "System services and processes";
            // 
            // q33memoEdit1
            // 
            this.q33memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q33memoEdit1.Name = "q33memoEdit1";
            this.q33memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q33memoEdit1.TabIndex = 1;
            // 
            // q33Label
            // 
            this.q33Label.Location = new System.Drawing.Point(24, 14);
            this.q33Label.Name = "q33Label";
            this.q33Label.Size = new System.Drawing.Size(233, 13);
            this.q33Label.TabIndex = 0;
            this.q33Label.Text = "Describe the services of the system functionality";
            // 
            // wizardPage27
            // 
            this.wizardPage27.Controls.Add(this.q34memoEdit1);
            this.wizardPage27.Controls.Add(this.q34Label);
            this.wizardPage27.Name = "wizardPage27";
            this.wizardPage27.Size = new System.Drawing.Size(572, 269);
            this.wizardPage27.Text = "System services and processes";
            // 
            // q34memoEdit1
            // 
            this.q34memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q34memoEdit1.Name = "q34memoEdit1";
            this.q34memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q34memoEdit1.TabIndex = 1;
            // 
            // q34Label
            // 
            this.q34Label.Location = new System.Drawing.Point(24, 14);
            this.q34Label.Name = "q34Label";
            this.q34Label.Size = new System.Drawing.Size(147, 13);
            this.q34Label.TabIndex = 0;
            this.q34Label.Text = "What are the control domains?";
            // 
            // wizardPage28
            // 
            this.wizardPage28.Controls.Add(this.q35MVCcomboBoxEdit);
            this.wizardPage28.Controls.Add(this.q35Label);
            this.wizardPage28.Name = "wizardPage28";
            this.wizardPage28.Size = new System.Drawing.Size(572, 269);
            this.wizardPage28.Text = "System services and processes";
            // 
            // q35MVCcomboBoxEdit
            // 
            this.q35MVCcomboBoxEdit.Location = new System.Drawing.Point(154, 33);
            this.q35MVCcomboBoxEdit.Name = "q35MVCcomboBoxEdit";
            this.q35MVCcomboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.q35MVCcomboBoxEdit.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.q35MVCcomboBoxEdit.Size = new System.Drawing.Size(137, 20);
            this.q35MVCcomboBoxEdit.TabIndex = 2;
            // 
            // q35Label
            // 
            this.q35Label.Location = new System.Drawing.Point(24, 14);
            this.q35Label.Name = "q35Label";
            this.q35Label.Size = new System.Drawing.Size(267, 13);
            this.q35Label.TabIndex = 0;
            this.q35Label.Text = "What are the minimum valuable controls (MVC) needed?";
            // 
            // wizardPage29
            // 
            this.wizardPage29.Controls.Add(this.q36ControlTypeComboBoxEdit2);
            this.wizardPage29.Controls.Add(this.q36ControlTypeComboBoxEdit1);
            this.wizardPage29.Controls.Add(this.q36ControlTypeRadioGroup);
            this.wizardPage29.Controls.Add(this.q36Label);
            this.wizardPage29.Name = "wizardPage29";
            this.wizardPage29.Size = new System.Drawing.Size(572, 269);
            this.wizardPage29.Text = "System services and processes";
            this.wizardPage29.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage29_PageValidating);
            // 
            // q36ControlTypeComboBoxEdit2
            // 
            this.q36ControlTypeComboBoxEdit2.Location = new System.Drawing.Point(137, 119);
            this.q36ControlTypeComboBoxEdit2.Name = "q36ControlTypeComboBoxEdit2";
            this.q36ControlTypeComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.q36ControlTypeComboBoxEdit2.Properties.Items.AddRange(new object[] {
            "AWS",
            "Azure"});
            this.q36ControlTypeComboBoxEdit2.Size = new System.Drawing.Size(100, 20);
            this.q36ControlTypeComboBoxEdit2.TabIndex = 6;
            this.q36ControlTypeComboBoxEdit2.Visible = false;
            // 
            // q36ControlTypeComboBoxEdit1
            // 
            this.q36ControlTypeComboBoxEdit1.Location = new System.Drawing.Point(103, 80);
            this.q36ControlTypeComboBoxEdit1.Name = "q36ControlTypeComboBoxEdit1";
            this.q36ControlTypeComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.q36ControlTypeComboBoxEdit1.Properties.Items.AddRange(new object[] {
            "External",
            "Internal",
            "Development",
            "Production"});
            this.q36ControlTypeComboBoxEdit1.Size = new System.Drawing.Size(134, 20);
            this.q36ControlTypeComboBoxEdit1.TabIndex = 5;
            this.q36ControlTypeComboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.ControlTypeComboBoxEdit1_SelectedIndexChanged);
            // 
            // q36ControlTypeRadioGroup
            // 
            this.q36ControlTypeRadioGroup.Location = new System.Drawing.Point(61, 39);
            this.q36ControlTypeRadioGroup.Name = "q36ControlTypeRadioGroup";
            this.q36ControlTypeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "On premise"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cloud")});
            this.q36ControlTypeRadioGroup.Size = new System.Drawing.Size(176, 24);
            this.q36ControlTypeRadioGroup.TabIndex = 4;
            this.q36ControlTypeRadioGroup.SelectedIndexChanged += new System.EventHandler(this.ControlTypeRadioGroup_SelectedIndexChanged);
            // 
            // q36Label
            // 
            this.q36Label.Location = new System.Drawing.Point(24, 14);
            this.q36Label.Name = "q36Label";
            this.q36Label.Size = new System.Drawing.Size(62, 13);
            this.q36Label.TabIndex = 0;
            this.q36Label.Text = "Control Type";
            // 
            // wizardPage30
            // 
            this.wizardPage30.Controls.Add(this.q44memoEdit1);
            this.wizardPage30.Controls.Add(this.q44Label);
            this.wizardPage30.DescriptionText = "Describe for all decision junctions in the process:";
            this.wizardPage30.Name = "wizardPage30";
            this.wizardPage30.Size = new System.Drawing.Size(572, 269);
            this.wizardPage30.Text = "Decision matrix";
            // 
            // q44memoEdit1
            // 
            this.q44memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q44memoEdit1.Name = "q44memoEdit1";
            this.q44memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q44memoEdit1.TabIndex = 3;
            // 
            // q44Label
            // 
            this.q44Label.Location = new System.Drawing.Point(24, 14);
            this.q44Label.Name = "q44Label";
            this.q44Label.Size = new System.Drawing.Size(231, 13);
            this.q44Label.TabIndex = 2;
            this.q44Label.Text = "Who can make a decision regarding this system?";
            // 
            // wizardPage31
            // 
            this.wizardPage31.Controls.Add(this.q45memoEdit2);
            this.wizardPage31.Controls.Add(this.q45Label);
            this.wizardPage31.DescriptionText = "Describe for all decision junctions in the process:";
            this.wizardPage31.Name = "wizardPage31";
            this.wizardPage31.Size = new System.Drawing.Size(572, 269);
            this.wizardPage31.Text = "Decision matrix";
            // 
            // q45memoEdit2
            // 
            this.q45memoEdit2.Location = new System.Drawing.Point(24, 33);
            this.q45memoEdit2.Name = "q45memoEdit2";
            this.q45memoEdit2.Size = new System.Drawing.Size(514, 55);
            this.q45memoEdit2.TabIndex = 3;
            // 
            // q45Label
            // 
            this.q45Label.Location = new System.Drawing.Point(24, 14);
            this.q45Label.Name = "q45Label";
            this.q45Label.Size = new System.Drawing.Size(143, 13);
            this.q45Label.TabIndex = 2;
            this.q45Label.Text = "Who can revise that decision?";
            // 
            // wizardPage32
            // 
            this.wizardPage32.Controls.Add(this.q46memoEdit3);
            this.wizardPage32.Controls.Add(this.q46Label);
            this.wizardPage32.DescriptionText = "Describe for all decision junctions in the process:";
            this.wizardPage32.Name = "wizardPage32";
            this.wizardPage32.Size = new System.Drawing.Size(572, 269);
            this.wizardPage32.Text = "Decision matrix";
            // 
            // q46memoEdit3
            // 
            this.q46memoEdit3.Location = new System.Drawing.Point(24, 33);
            this.q46memoEdit3.Name = "q46memoEdit3";
            this.q46memoEdit3.Size = new System.Drawing.Size(514, 55);
            this.q46memoEdit3.TabIndex = 3;
            // 
            // q46Label
            // 
            this.q46Label.Location = new System.Drawing.Point(24, 14);
            this.q46Label.Name = "q46Label";
            this.q46Label.Size = new System.Drawing.Size(167, 13);
            this.q46Label.TabIndex = 2;
            this.q46Label.Text = "What is the impact of the decision?";
            // 
            // wizardPage33
            // 
            this.wizardPage33.Controls.Add(this.q47memoEdit4);
            this.wizardPage33.Controls.Add(this.q47Label);
            this.wizardPage33.DescriptionText = "Describe for all decision junctions in the process:";
            this.wizardPage33.Name = "wizardPage33";
            this.wizardPage33.Size = new System.Drawing.Size(572, 269);
            this.wizardPage33.Text = "Decision matrix";
            // 
            // q47memoEdit4
            // 
            this.q47memoEdit4.Location = new System.Drawing.Point(24, 33);
            this.q47memoEdit4.Name = "q47memoEdit4";
            this.q47memoEdit4.Size = new System.Drawing.Size(514, 55);
            this.q47memoEdit4.TabIndex = 3;
            // 
            // q47Label
            // 
            this.q47Label.Location = new System.Drawing.Point(24, 14);
            this.q47Label.Name = "q47Label";
            this.q47Label.Size = new System.Drawing.Size(262, 13);
            this.q47Label.TabIndex = 2;
            this.q47Label.Text = "What is the acid test for this decision to be successful?";
            // 
            // wizardPage34
            // 
            this.wizardPage34.Controls.Add(this.q48memoEdit1);
            this.wizardPage34.Controls.Add(this.q48Label);
            this.wizardPage34.Name = "wizardPage34";
            this.wizardPage34.Size = new System.Drawing.Size(572, 269);
            this.wizardPage34.Text = "Responsibility share";
            // 
            // q48memoEdit1
            // 
            this.q48memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q48memoEdit1.Name = "q48memoEdit1";
            this.q48memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q48memoEdit1.TabIndex = 1;
            // 
            // q48Label
            // 
            this.q48Label.Location = new System.Drawing.Point(24, 14);
            this.q48Label.Name = "q48Label";
            this.q48Label.Size = new System.Drawing.Size(165, 13);
            this.q48Label.TabIndex = 0;
            this.q48Label.Text = "Who will build the system process?";
            // 
            // wizardPage35
            // 
            this.wizardPage35.Controls.Add(this.q49memoEdit1);
            this.wizardPage35.Controls.Add(this.q49Label);
            this.wizardPage35.Name = "wizardPage35";
            this.wizardPage35.Size = new System.Drawing.Size(572, 269);
            this.wizardPage35.Text = "Responsibility share";
            // 
            // q49memoEdit1
            // 
            this.q49memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q49memoEdit1.Name = "q49memoEdit1";
            this.q49memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q49memoEdit1.TabIndex = 1;
            // 
            // q49Label
            // 
            this.q49Label.Location = new System.Drawing.Point(24, 14);
            this.q49Label.Name = "q49Label";
            this.q49Label.Size = new System.Drawing.Size(217, 13);
            this.q49Label.TabIndex = 0;
            this.q49Label.Text = "Who will execute the implementation project?";
            // 
            // wizardPage36
            // 
            this.wizardPage36.Controls.Add(this.q50memoEdit1);
            this.wizardPage36.Controls.Add(this.q50Label);
            this.wizardPage36.Name = "wizardPage36";
            this.wizardPage36.Size = new System.Drawing.Size(572, 269);
            this.wizardPage36.Text = "Responsibility share";
            // 
            // q50memoEdit1
            // 
            this.q50memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q50memoEdit1.Name = "q50memoEdit1";
            this.q50memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q50memoEdit1.TabIndex = 1;
            // 
            // q50Label
            // 
            this.q50Label.Location = new System.Drawing.Point(24, 14);
            this.q50Label.Name = "q50Label";
            this.q50Label.Size = new System.Drawing.Size(141, 13);
            this.q50Label.TabIndex = 0;
            this.q50Label.Text = "Who will operate the system?";
            // 
            // wizardPage37
            // 
            this.wizardPage37.Controls.Add(this.q51memoEdit1);
            this.wizardPage37.Controls.Add(this.q51Label);
            this.wizardPage37.Name = "wizardPage37";
            this.wizardPage37.Size = new System.Drawing.Size(572, 269);
            this.wizardPage37.Text = "Responsibility share";
            // 
            // q51memoEdit1
            // 
            this.q51memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q51memoEdit1.Name = "q51memoEdit1";
            this.q51memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q51memoEdit1.TabIndex = 1;
            // 
            // q51Label
            // 
            this.q51Label.Location = new System.Drawing.Point(24, 14);
            this.q51Label.Name = "q51Label";
            this.q51Label.Size = new System.Drawing.Size(140, 13);
            this.q51Label.TabIndex = 0;
            this.q51Label.Text = "Who will support the system?";
            // 
            // wizardPage38
            // 
            this.wizardPage38.Controls.Add(this.q52memoEdit1);
            this.wizardPage38.Controls.Add(this.q52Label);
            this.wizardPage38.Name = "wizardPage38";
            this.wizardPage38.Size = new System.Drawing.Size(572, 269);
            this.wizardPage38.Text = "Operations";
            // 
            // q52memoEdit1
            // 
            this.q52memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q52memoEdit1.Name = "q52memoEdit1";
            this.q52memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q52memoEdit1.TabIndex = 1;
            // 
            // q52Label
            // 
            this.q52Label.Location = new System.Drawing.Point(24, 14);
            this.q52Label.Name = "q52Label";
            this.q52Label.Size = new System.Drawing.Size(84, 13);
            this.q52Label.TabIndex = 0;
            this.q52Label.Text = "Process definition";
            // 
            // wizardPage39
            // 
            this.wizardPage39.Controls.Add(this.q53HyperLink);
            this.wizardPage39.Controls.Add(this.q53AttachButton);
            this.wizardPage39.Controls.Add(this.q53Label);
            this.wizardPage39.Name = "wizardPage39";
            this.wizardPage39.Size = new System.Drawing.Size(572, 269);
            this.wizardPage39.Text = "Operations";
            // 
            // q53HyperLink
            // 
            this.q53HyperLink.Location = new System.Drawing.Point(24, 68);
            this.q53HyperLink.Name = "q53HyperLink";
            this.q53HyperLink.Size = new System.Drawing.Size(508, 20);
            this.q53HyperLink.TabIndex = 13;
            // 
            // q53AttachButton
            // 
            this.q53AttachButton.Location = new System.Drawing.Point(24, 39);
            this.q53AttachButton.Name = "q53AttachButton";
            this.q53AttachButton.Size = new System.Drawing.Size(113, 23);
            this.q53AttachButton.TabIndex = 12;
            this.q53AttachButton.Text = "Attach File";
            this.q53AttachButton.Click += new System.EventHandler(this.ProcessFlowChartAttachButton_Click);
            // 
            // q53Label
            // 
            this.q53Label.Location = new System.Drawing.Point(24, 14);
            this.q53Label.Name = "q53Label";
            this.q53Label.Size = new System.Drawing.Size(88, 13);
            this.q53Label.TabIndex = 0;
            this.q53Label.Text = "Process flow chart";
            // 
            // wizardPage40
            // 
            this.wizardPage40.Controls.Add(this.q54HyperLink);
            this.wizardPage40.Controls.Add(this.q54AttachButton);
            this.wizardPage40.Controls.Add(this.q54Label);
            this.wizardPage40.Name = "wizardPage40";
            this.wizardPage40.Size = new System.Drawing.Size(572, 269);
            this.wizardPage40.Text = "Operations";
            // 
            // q54HyperLink
            // 
            this.q54HyperLink.Location = new System.Drawing.Point(24, 68);
            this.q54HyperLink.Name = "q54HyperLink";
            this.q54HyperLink.Size = new System.Drawing.Size(508, 20);
            this.q54HyperLink.TabIndex = 15;
            // 
            // q54AttachButton
            // 
            this.q54AttachButton.Location = new System.Drawing.Point(24, 39);
            this.q54AttachButton.Name = "q54AttachButton";
            this.q54AttachButton.Size = new System.Drawing.Size(113, 23);
            this.q54AttachButton.TabIndex = 14;
            this.q54AttachButton.Text = "Attach File";
            this.q54AttachButton.Click += new System.EventHandler(this.ProcessDiagramAttachButton_Click);
            // 
            // q54Label
            // 
            this.q54Label.Location = new System.Drawing.Point(24, 14);
            this.q54Label.Name = "q54Label";
            this.q54Label.Size = new System.Drawing.Size(78, 13);
            this.q54Label.TabIndex = 0;
            this.q54Label.Text = "Process diagram";
            // 
            // wizardPage41
            // 
            this.wizardPage41.Controls.Add(this.q55memoEdit1);
            this.wizardPage41.Controls.Add(this.q55Label);
            this.wizardPage41.Name = "wizardPage41";
            this.wizardPage41.Size = new System.Drawing.Size(572, 269);
            this.wizardPage41.Text = "Operations";
            // 
            // q55memoEdit1
            // 
            this.q55memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q55memoEdit1.Name = "q55memoEdit1";
            this.q55memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q55memoEdit1.TabIndex = 1;
            // 
            // q55Label
            // 
            this.q55Label.Location = new System.Drawing.Point(24, 14);
            this.q55Label.Name = "q55Label";
            this.q55Label.Size = new System.Drawing.Size(46, 13);
            this.q55Label.TabIndex = 0;
            this.q55Label.Text = "Main risks";
            // 
            // wizardPage42
            // 
            this.wizardPage42.Controls.Add(this.q56memoEdit1);
            this.wizardPage42.Controls.Add(this.q56Label);
            this.wizardPage42.Name = "wizardPage42";
            this.wizardPage42.Size = new System.Drawing.Size(572, 269);
            this.wizardPage42.Text = "Operations";
            // 
            // q56memoEdit1
            // 
            this.q56memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q56memoEdit1.Name = "q56memoEdit1";
            this.q56memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q56memoEdit1.TabIndex = 1;
            // 
            // q56Label
            // 
            this.q56Label.Location = new System.Drawing.Point(24, 14);
            this.q56Label.Name = "q56Label";
            this.q56Label.Size = new System.Drawing.Size(230, 13);
            this.q56Label.TabIndex = 0;
            this.q56Label.Text = "Most important decision junctions in this process";
            // 
            // wizardPage43
            // 
            this.wizardPage43.Controls.Add(this.q57HyperLink);
            this.wizardPage43.Controls.Add(this.q57AttachButton);
            this.wizardPage43.Controls.Add(this.q57Label);
            this.wizardPage43.Name = "wizardPage43";
            this.wizardPage43.Size = new System.Drawing.Size(572, 269);
            this.wizardPage43.Text = "Operations";
            // 
            // q57HyperLink
            // 
            this.q57HyperLink.Location = new System.Drawing.Point(24, 68);
            this.q57HyperLink.Name = "q57HyperLink";
            this.q57HyperLink.Size = new System.Drawing.Size(508, 20);
            this.q57HyperLink.TabIndex = 17;
            // 
            // q57AttachButton
            // 
            this.q57AttachButton.Location = new System.Drawing.Point(24, 39);
            this.q57AttachButton.Name = "q57AttachButton";
            this.q57AttachButton.Size = new System.Drawing.Size(113, 23);
            this.q57AttachButton.TabIndex = 16;
            this.q57AttachButton.Text = "Attach File";
            this.q57AttachButton.Click += new System.EventHandler(this.MainMilestonesAttachButton_Click);
            // 
            // q57Label
            // 
            this.q57Label.Location = new System.Drawing.Point(24, 14);
            this.q57Label.Name = "q57Label";
            this.q57Label.Size = new System.Drawing.Size(75, 13);
            this.q57Label.TabIndex = 0;
            this.q57Label.Text = "Main milestones";
            // 
            // wizardPage44
            // 
            this.wizardPage44.Controls.Add(this.q58memoEdit1);
            this.wizardPage44.Controls.Add(this.q58Label);
            this.wizardPage44.Name = "wizardPage44";
            this.wizardPage44.Size = new System.Drawing.Size(572, 269);
            this.wizardPage44.Text = "Remediation";
            // 
            // q58memoEdit1
            // 
            this.q58memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q58memoEdit1.Name = "q58memoEdit1";
            this.q58memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q58memoEdit1.TabIndex = 1;
            // 
            // q58Label
            // 
            this.q58Label.Location = new System.Drawing.Point(24, 14);
            this.q58Label.Name = "q58Label";
            this.q58Label.Size = new System.Drawing.Size(82, 13);
            this.q58Label.TabIndex = 0;
            this.q58Label.Text = "Help and support";
            // 
            // wizardPage45
            // 
            this.wizardPage45.Controls.Add(this.q59memoEdit1);
            this.wizardPage45.Controls.Add(this.q59Label);
            this.wizardPage45.Name = "wizardPage45";
            this.wizardPage45.Size = new System.Drawing.Size(572, 269);
            this.wizardPage45.Text = "Remediation";
            // 
            // q59memoEdit1
            // 
            this.q59memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q59memoEdit1.Name = "q59memoEdit1";
            this.q59memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q59memoEdit1.TabIndex = 1;
            // 
            // q59Label
            // 
            this.q59Label.Location = new System.Drawing.Point(24, 14);
            this.q59Label.Name = "q59Label";
            this.q59Label.Size = new System.Drawing.Size(33, 13);
            this.q59Label.TabIndex = 0;
            this.q59Label.Text = "Bug fix";
            // 
            // wizardPage46
            // 
            this.wizardPage46.Controls.Add(this.q60memoEdit1);
            this.wizardPage46.Controls.Add(this.q60Label);
            this.wizardPage46.Name = "wizardPage46";
            this.wizardPage46.Size = new System.Drawing.Size(572, 269);
            this.wizardPage46.Text = "Remediation";
            // 
            // q60memoEdit1
            // 
            this.q60memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q60memoEdit1.Name = "q60memoEdit1";
            this.q60memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q60memoEdit1.TabIndex = 1;
            // 
            // q60Label
            // 
            this.q60Label.Location = new System.Drawing.Point(24, 14);
            this.q60Label.Name = "q60Label";
            this.q60Label.Size = new System.Drawing.Size(97, 13);
            this.q60Label.TabIndex = 0;
            this.q60Label.Text = "Real time assistance";
            // 
            // wizardPage47
            // 
            this.wizardPage47.Controls.Add(this.q61memoEdit1);
            this.wizardPage47.Controls.Add(this.q61Label);
            this.wizardPage47.Name = "wizardPage47";
            this.wizardPage47.Size = new System.Drawing.Size(572, 269);
            this.wizardPage47.Text = "Remediation";
            // 
            // q61memoEdit1
            // 
            this.q61memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q61memoEdit1.Name = "q61memoEdit1";
            this.q61memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q61memoEdit1.TabIndex = 1;
            // 
            // q61Label
            // 
            this.q61Label.Location = new System.Drawing.Point(24, 14);
            this.q61Label.Name = "q61Label";
            this.q61Label.Size = new System.Drawing.Size(146, 13);
            this.q61Label.TabIndex = 0;
            this.q61Label.Text = "Organization Support & Solution";
            // 
            // wizardPage48
            // 
            this.wizardPage48.Controls.Add(this.q62memoEdit1);
            this.wizardPage48.Controls.Add(this.q62Label);
            this.wizardPage48.Name = "wizardPage48";
            this.wizardPage48.Size = new System.Drawing.Size(572, 269);
            this.wizardPage48.Text = "Remediation";
            // 
            // q62memoEdit1
            // 
            this.q62memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q62memoEdit1.Name = "q62memoEdit1";
            this.q62memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q62memoEdit1.TabIndex = 1;
            // 
            // q62Label
            // 
            this.q62Label.Location = new System.Drawing.Point(24, 14);
            this.q62Label.Name = "q62Label";
            this.q62Label.Size = new System.Drawing.Size(157, 13);
            this.q62Label.TabIndex = 0;
            this.q62Label.Text = "Organizational Methods & Support";
            // 
            // wizardPage49
            // 
            this.wizardPage49.Controls.Add(this.q63memoEdit1);
            this.wizardPage49.Controls.Add(this.q63Label);
            this.wizardPage49.Name = "wizardPage49";
            this.wizardPage49.Size = new System.Drawing.Size(572, 269);
            this.wizardPage49.Text = "Prologue";
            // 
            // q63memoEdit1
            // 
            this.q63memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q63memoEdit1.Name = "q63memoEdit1";
            this.q63memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q63memoEdit1.TabIndex = 1;
            // 
            // q63Label
            // 
            this.q63Label.Location = new System.Drawing.Point(24, 14);
            this.q63Label.Name = "q63Label";
            this.q63Label.Size = new System.Drawing.Size(317, 13);
            this.q63Label.TabIndex = 0;
            this.q63Label.Text = "Who can decide of ending the system life or replacing the system?";
            // 
            // wizardPage50
            // 
            this.wizardPage50.Controls.Add(this.q64Label);
            this.wizardPage50.Controls.Add(this.q64memoEdit1);
            this.wizardPage50.Name = "wizardPage50";
            this.wizardPage50.Size = new System.Drawing.Size(572, 269);
            this.wizardPage50.Text = "Prologue";
            // 
            // q64Label
            // 
            this.q64Label.Location = new System.Drawing.Point(24, 14);
            this.q64Label.Name = "q64Label";
            this.q64Label.Size = new System.Drawing.Size(290, 13);
            this.q64Label.TabIndex = 1;
            this.q64Label.Text = "What do we need for the system to run daily and flawlessly?";
            // 
            // q64memoEdit1
            // 
            this.q64memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q64memoEdit1.Name = "q64memoEdit1";
            this.q64memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q64memoEdit1.TabIndex = 0;
            // 
            // wizardPage51
            // 
            this.wizardPage51.Controls.Add(this.q65memoEdit1);
            this.wizardPage51.Controls.Add(this.q65Label);
            this.wizardPage51.Name = "wizardPage51";
            this.wizardPage51.Size = new System.Drawing.Size(572, 269);
            this.wizardPage51.Text = "Prologue";
            // 
            // q65memoEdit1
            // 
            this.q65memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q65memoEdit1.Name = "q65memoEdit1";
            this.q65memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q65memoEdit1.TabIndex = 1;
            // 
            // q65Label
            // 
            this.q65Label.Location = new System.Drawing.Point(24, 14);
            this.q65Label.Name = "q65Label";
            this.q65Label.Size = new System.Drawing.Size(221, 13);
            this.q65Label.TabIndex = 0;
            this.q65Label.Text = "How can we extend the usage of this system?";
            // 
            // wizardPage52
            // 
            this.wizardPage52.Controls.Add(this.q66memoEdit1);
            this.wizardPage52.Controls.Add(this.q66Label);
            this.wizardPage52.Name = "wizardPage52";
            this.wizardPage52.Size = new System.Drawing.Size(572, 269);
            this.wizardPage52.Text = "Prologue";
            // 
            // q66memoEdit1
            // 
            this.q66memoEdit1.Location = new System.Drawing.Point(24, 33);
            this.q66memoEdit1.Name = "q66memoEdit1";
            this.q66memoEdit1.Size = new System.Drawing.Size(514, 55);
            this.q66memoEdit1.TabIndex = 1;
            // 
            // q66Label
            // 
            this.q66Label.Location = new System.Drawing.Point(24, 14);
            this.q66Label.Name = "q66Label";
            this.q66Label.Size = new System.Drawing.Size(288, 13);
            this.q66Label.TabIndex = 0;
            this.q66Label.Text = "How can we spare resources using or not using this system?";
            // 
            // wizardPage53
            // 
            this.wizardPage53.Controls.Add(this.q18aHyperLinkEdit1);
            this.wizardPage53.Controls.Add(this.q18aAttachDiagramButton);
            this.wizardPage53.Controls.Add(this.q18b3IntegratorTextEdit);
            this.wizardPage53.Controls.Add(this.q18b3IntegratorLabel);
            this.wizardPage53.Controls.Add(this.q18b2DistributorTextEdit);
            this.wizardPage53.Controls.Add(this.q18b2DistributorLabel);
            this.wizardPage53.Controls.Add(this.q18b1VendorTextEdit);
            this.wizardPage53.Controls.Add(this.q18b1VendorLabel);
            this.wizardPage53.Controls.Add(this.q18aDiagramLabel);
            this.wizardPage53.Name = "wizardPage53";
            this.wizardPage53.Size = new System.Drawing.Size(572, 269);
            this.wizardPage53.Text = "Technology – In house proprietary solution";
            // 
            // q18aHyperLinkEdit1
            // 
            this.q18aHyperLinkEdit1.Location = new System.Drawing.Point(24, 68);
            this.q18aHyperLinkEdit1.Name = "q18aHyperLinkEdit1";
            this.q18aHyperLinkEdit1.Size = new System.Drawing.Size(508, 20);
            this.q18aHyperLinkEdit1.TabIndex = 11;
            // 
            // q18aAttachDiagramButton
            // 
            this.q18aAttachDiagramButton.Location = new System.Drawing.Point(24, 39);
            this.q18aAttachDiagramButton.Name = "q18aAttachDiagramButton";
            this.q18aAttachDiagramButton.Size = new System.Drawing.Size(113, 23);
            this.q18aAttachDiagramButton.TabIndex = 10;
            this.q18aAttachDiagramButton.Text = "Attach File";
            this.q18aAttachDiagramButton.Click += new System.EventHandler(this.attachDiagramButton_Click);
            // 
            // q18b3IntegratorTextEdit
            // 
            this.q18b3IntegratorTextEdit.Location = new System.Drawing.Point(24, 142);
            this.q18b3IntegratorTextEdit.Name = "q18b3IntegratorTextEdit";
            this.q18b3IntegratorTextEdit.Size = new System.Drawing.Size(182, 20);
            this.q18b3IntegratorTextEdit.TabIndex = 9;
            this.q18b3IntegratorTextEdit.Visible = false;
            // 
            // q18b3IntegratorLabel
            // 
            this.q18b3IntegratorLabel.Location = new System.Drawing.Point(24, 122);
            this.q18b3IntegratorLabel.Name = "q18b3IntegratorLabel";
            this.q18b3IntegratorLabel.Size = new System.Drawing.Size(50, 13);
            this.q18b3IntegratorLabel.TabIndex = 8;
            this.q18b3IntegratorLabel.Text = "Integrator";
            this.q18b3IntegratorLabel.Visible = false;
            // 
            // q18b2DistributorTextEdit
            // 
            this.q18b2DistributorTextEdit.Location = new System.Drawing.Point(24, 86);
            this.q18b2DistributorTextEdit.Name = "q18b2DistributorTextEdit";
            this.q18b2DistributorTextEdit.Size = new System.Drawing.Size(182, 20);
            this.q18b2DistributorTextEdit.TabIndex = 7;
            this.q18b2DistributorTextEdit.Visible = false;
            // 
            // q18b2DistributorLabel
            // 
            this.q18b2DistributorLabel.Location = new System.Drawing.Point(24, 67);
            this.q18b2DistributorLabel.Name = "q18b2DistributorLabel";
            this.q18b2DistributorLabel.Size = new System.Drawing.Size(50, 13);
            this.q18b2DistributorLabel.TabIndex = 6;
            this.q18b2DistributorLabel.Text = "Distributor";
            this.q18b2DistributorLabel.Visible = false;
            // 
            // q18b1VendorTextEdit
            // 
            this.q18b1VendorTextEdit.Location = new System.Drawing.Point(24, 35);
            this.q18b1VendorTextEdit.Name = "q18b1VendorTextEdit";
            this.q18b1VendorTextEdit.Size = new System.Drawing.Size(182, 20);
            this.q18b1VendorTextEdit.TabIndex = 2;
            this.q18b1VendorTextEdit.Visible = false;
            // 
            // q18b1VendorLabel
            // 
            this.q18b1VendorLabel.Location = new System.Drawing.Point(24, 16);
            this.q18b1VendorLabel.Name = "q18b1VendorLabel";
            this.q18b1VendorLabel.Size = new System.Drawing.Size(34, 13);
            this.q18b1VendorLabel.TabIndex = 1;
            this.q18b1VendorLabel.Text = "Vendor";
            this.q18b1VendorLabel.Visible = false;
            // 
            // q18aDiagramLabel
            // 
            this.q18aDiagramLabel.Location = new System.Drawing.Point(24, 14);
            this.q18aDiagramLabel.Name = "q18aDiagramLabel";
            this.q18aDiagramLabel.Size = new System.Drawing.Size(39, 13);
            this.q18aDiagramLabel.TabIndex = 0;
            this.q18aDiagramLabel.Text = "Diagram";
            // 
            // wizardPage55
            // 
            this.wizardPage55.Controls.Add(this.q24CustomSolutionsMemoEdit);
            this.wizardPage55.Controls.Add(this.q24CustomSolutionsLabel);
            this.wizardPage55.Name = "wizardPage55";
            this.wizardPage55.Size = new System.Drawing.Size(572, 269);
            this.wizardPage55.Text = "Technology – In house proprietary solution";
            // 
            // q24CustomSolutionsMemoEdit
            // 
            this.q24CustomSolutionsMemoEdit.Location = new System.Drawing.Point(24, 33);
            this.q24CustomSolutionsMemoEdit.Name = "q24CustomSolutionsMemoEdit";
            this.q24CustomSolutionsMemoEdit.Size = new System.Drawing.Size(514, 55);
            this.q24CustomSolutionsMemoEdit.TabIndex = 1;
            // 
            // q24CustomSolutionsLabel
            // 
            this.q24CustomSolutionsLabel.Location = new System.Drawing.Point(24, 14);
            this.q24CustomSolutionsLabel.Name = "q24CustomSolutionsLabel";
            this.q24CustomSolutionsLabel.Size = new System.Drawing.Size(82, 13);
            this.q24CustomSolutionsLabel.TabIndex = 0;
            this.q24CustomSolutionsLabel.Text = "Custom Solutions";
            // 
            // wizardPage56
            // 
            this.wizardPage56.Controls.Add(this.q23SiteLicenseRadioGroup);
            this.wizardPage56.Controls.Add(this.q23SiteLicenseLabel);
            this.wizardPage56.Name = "wizardPage56";
            this.wizardPage56.Size = new System.Drawing.Size(572, 269);
            this.wizardPage56.Text = "Technology – In house proprietary solution";
            // 
            // q23SiteLicenseRadioGroup
            // 
            this.q23SiteLicenseRadioGroup.Location = new System.Drawing.Point(79, 33);
            this.q23SiteLicenseRadioGroup.Name = "q23SiteLicenseRadioGroup";
            this.q23SiteLicenseRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "No")});
            this.q23SiteLicenseRadioGroup.Size = new System.Drawing.Size(405, 34);
            this.q23SiteLicenseRadioGroup.TabIndex = 1;
            // 
            // q23SiteLicenseLabel
            // 
            this.q23SiteLicenseLabel.Location = new System.Drawing.Point(24, 14);
            this.q23SiteLicenseLabel.Name = "q23SiteLicenseLabel";
            this.q23SiteLicenseLabel.Size = new System.Drawing.Size(56, 13);
            this.q23SiteLicenseLabel.TabIndex = 0;
            this.q23SiteLicenseLabel.Text = "Site License";
            // 
            // wizardPage57
            // 
            this.wizardPage57.Controls.Add(this.q22CashBackRadioGroup1);
            this.wizardPage57.Controls.Add(this.q22CashBackLabel);
            this.wizardPage57.Name = "wizardPage57";
            this.wizardPage57.Size = new System.Drawing.Size(572, 269);
            this.wizardPage57.Text = "Technology – In house proprietary solution";
            // 
            // q22CashBackRadioGroup1
            // 
            this.q22CashBackRadioGroup1.Location = new System.Drawing.Point(65, 32);
            this.q22CashBackRadioGroup1.Name = "q22CashBackRadioGroup1";
            this.q22CashBackRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SROI"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Kill on premise"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "New service"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Spare resources")});
            this.q22CashBackRadioGroup1.Size = new System.Drawing.Size(436, 64);
            this.q22CashBackRadioGroup1.TabIndex = 1;
            // 
            // q22CashBackLabel
            // 
            this.q22CashBackLabel.Location = new System.Drawing.Point(24, 14);
            this.q22CashBackLabel.Name = "q22CashBackLabel";
            this.q22CashBackLabel.Size = new System.Drawing.Size(78, 13);
            this.q22CashBackLabel.TabIndex = 0;
            this.q22CashBackLabel.Text = "Cash back Mode";
            // 
            // wizardPage58
            // 
            this.wizardPage58.Controls.Add(this.q21CurrencyRadioGroup1);
            this.wizardPage58.Controls.Add(this.q21CurrencyLabel);
            this.wizardPage58.Controls.Add(this.q21TextEdit1);
            this.wizardPage58.Controls.Add(this.q21OrganizationalCostLabel);
            this.wizardPage58.Name = "wizardPage58";
            this.wizardPage58.Size = new System.Drawing.Size(572, 269);
            this.wizardPage58.Text = "Technology – In house proprietary solution";
            // 
            // q21CurrencyRadioGroup1
            // 
            this.q21CurrencyRadioGroup1.Location = new System.Drawing.Point(96, 55);
            this.q21CurrencyRadioGroup1.Name = "q21CurrencyRadioGroup1";
            this.q21CurrencyRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "NIS"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Dollar")});
            this.q21CurrencyRadioGroup1.Size = new System.Drawing.Size(160, 26);
            this.q21CurrencyRadioGroup1.TabIndex = 3;
            this.q21CurrencyRadioGroup1.SelectedIndexChanged += new System.EventHandler(this.q21CurrencyRadioGroup1_SelectedIndexChanged);
            // 
            // q21CurrencyLabel
            // 
            this.q21CurrencyLabel.Location = new System.Drawing.Point(96, 36);
            this.q21CurrencyLabel.Name = "q21CurrencyLabel";
            this.q21CurrencyLabel.Size = new System.Drawing.Size(48, 13);
            this.q21CurrencyLabel.TabIndex = 2;
            this.q21CurrencyLabel.Text = "Currency:";
            // 
            // q21TextEdit1
            // 
            this.q21TextEdit1.Location = new System.Drawing.Point(96, 87);
            this.q21TextEdit1.Name = "q21TextEdit1";
            this.q21TextEdit1.Properties.Mask.EditMask = "n0";
            this.q21TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.q21TextEdit1.Properties.NullValuePrompt = "₪";
            this.q21TextEdit1.Size = new System.Drawing.Size(160, 20);
            this.q21TextEdit1.TabIndex = 1;
            // 
            // q21OrganizationalCostLabel
            // 
            this.q21OrganizationalCostLabel.Location = new System.Drawing.Point(24, 14);
            this.q21OrganizationalCostLabel.Name = "q21OrganizationalCostLabel";
            this.q21OrganizationalCostLabel.Size = new System.Drawing.Size(94, 13);
            this.q21OrganizationalCostLabel.TabIndex = 0;
            this.q21OrganizationalCostLabel.Text = "Organizational Cost";
            // 
            // wizardPage59
            // 
            this.wizardPage59.Controls.Add(this.q19SolutionTypeRadioGroup1);
            this.wizardPage59.Controls.Add(this.q19SolutionTypeLabel);
            this.wizardPage59.Name = "wizardPage59";
            this.wizardPage59.Size = new System.Drawing.Size(572, 269);
            this.wizardPage59.Text = "Technology – In house proprietary solution";
            // 
            // q19SolutionTypeRadioGroup1
            // 
            this.q19SolutionTypeRadioGroup1.Location = new System.Drawing.Point(65, 32);
            this.q19SolutionTypeRadioGroup1.Name = "q19SolutionTypeRadioGroup1";
            this.q19SolutionTypeRadioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Application"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Infrastructure"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Appliance"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Server")});
            this.q19SolutionTypeRadioGroup1.Size = new System.Drawing.Size(436, 64);
            this.q19SolutionTypeRadioGroup1.TabIndex = 1;
            // 
            // q19SolutionTypeLabel
            // 
            this.q19SolutionTypeLabel.Location = new System.Drawing.Point(24, 14);
            this.q19SolutionTypeLabel.Name = "q19SolutionTypeLabel";
            this.q19SolutionTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.q19SolutionTypeLabel.TabIndex = 0;
            this.q19SolutionTypeLabel.Text = "Solution Type";
            // 
            // wizardPage62
            // 
            this.wizardPage62.Controls.Add(this.q20ControlResolutionRadioGroup2);
            this.wizardPage62.Controls.Add(this.q20ControlResolutionLabel);
            this.wizardPage62.Name = "wizardPage62";
            this.wizardPage62.Size = new System.Drawing.Size(572, 269);
            this.wizardPage62.Text = "Technology – In house proprietary solution";
            // 
            // q20ControlResolutionRadioGroup2
            // 
            this.q20ControlResolutionRadioGroup2.Location = new System.Drawing.Point(65, 32);
            this.q20ControlResolutionRadioGroup2.Name = "q20ControlResolutionRadioGroup2";
            this.q20ControlResolutionRadioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SCCM"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SIEM SOC"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Help desk"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "NOC")});
            this.q20ControlResolutionRadioGroup2.Size = new System.Drawing.Size(436, 64);
            this.q20ControlResolutionRadioGroup2.TabIndex = 5;
            // 
            // q20ControlResolutionLabel
            // 
            this.q20ControlResolutionLabel.Location = new System.Drawing.Point(24, 14);
            this.q20ControlResolutionLabel.Name = "q20ControlResolutionLabel";
            this.q20ControlResolutionLabel.Size = new System.Drawing.Size(88, 13);
            this.q20ControlResolutionLabel.TabIndex = 4;
            this.q20ControlResolutionLabel.Text = "Control Resolution";
            // 
            // wizardPage54
            // 
            this.wizardPage54.Controls.Add(this.q40ControlTagMemoEdit);
            this.wizardPage54.Controls.Add(this.q40ControlTagLabel);
            this.wizardPage54.Name = "wizardPage54";
            this.wizardPage54.Size = new System.Drawing.Size(572, 269);
            this.wizardPage54.Text = "System services and processes";
            // 
            // q40ControlTagMemoEdit
            // 
            this.q40ControlTagMemoEdit.Location = new System.Drawing.Point(24, 33);
            this.q40ControlTagMemoEdit.Name = "q40ControlTagMemoEdit";
            this.q40ControlTagMemoEdit.Size = new System.Drawing.Size(514, 55);
            this.q40ControlTagMemoEdit.TabIndex = 5;
            // 
            // q40ControlTagLabel
            // 
            this.q40ControlTagLabel.Location = new System.Drawing.Point(24, 14);
            this.q40ControlTagLabel.Name = "q40ControlTagLabel";
            this.q40ControlTagLabel.Size = new System.Drawing.Size(56, 13);
            this.q40ControlTagLabel.TabIndex = 4;
            this.q40ControlTagLabel.Text = "Control Tag";
            // 
            // wizardPage60
            // 
            this.wizardPage60.Controls.Add(this.q39ControlMandatoryRadioGroup);
            this.wizardPage60.Controls.Add(this.q39ControlMandatoryLabel);
            this.wizardPage60.Name = "wizardPage60";
            this.wizardPage60.Size = new System.Drawing.Size(572, 269);
            this.wizardPage60.Text = "System services and processes";
            // 
            // q39ControlMandatoryRadioGroup
            // 
            this.q39ControlMandatoryRadioGroup.Location = new System.Drawing.Point(79, 33);
            this.q39ControlMandatoryRadioGroup.Name = "q39ControlMandatoryRadioGroup";
            this.q39ControlMandatoryRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "No")});
            this.q39ControlMandatoryRadioGroup.Size = new System.Drawing.Size(405, 34);
            this.q39ControlMandatoryRadioGroup.TabIndex = 3;
            // 
            // q39ControlMandatoryLabel
            // 
            this.q39ControlMandatoryLabel.Location = new System.Drawing.Point(24, 14);
            this.q39ControlMandatoryLabel.Name = "q39ControlMandatoryLabel";
            this.q39ControlMandatoryLabel.Size = new System.Drawing.Size(90, 13);
            this.q39ControlMandatoryLabel.TabIndex = 2;
            this.q39ControlMandatoryLabel.Text = "Control Mandatory";
            // 
            // wizardPage61
            // 
            this.wizardPage61.Controls.Add(this.q38ControlValidityRadioGroup);
            this.wizardPage61.Controls.Add(this.q38ControlValidityLabel);
            this.wizardPage61.Name = "wizardPage61";
            this.wizardPage61.Size = new System.Drawing.Size(572, 269);
            this.wizardPage61.Text = "System services and processes";
            // 
            // q38ControlValidityRadioGroup
            // 
            this.q38ControlValidityRadioGroup.Location = new System.Drawing.Point(79, 33);
            this.q38ControlValidityRadioGroup.Name = "q38ControlValidityRadioGroup";
            this.q38ControlValidityRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Yes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "No")});
            this.q38ControlValidityRadioGroup.Size = new System.Drawing.Size(405, 34);
            this.q38ControlValidityRadioGroup.TabIndex = 1;
            // 
            // q38ControlValidityLabel
            // 
            this.q38ControlValidityLabel.Location = new System.Drawing.Point(24, 14);
            this.q38ControlValidityLabel.Name = "q38ControlValidityLabel";
            this.q38ControlValidityLabel.Size = new System.Drawing.Size(72, 13);
            this.q38ControlValidityLabel.TabIndex = 0;
            this.q38ControlValidityLabel.Text = "Control Validity";
            // 
            // wizardPage63
            // 
            this.wizardPage63.Controls.Add(this.q37ControlDescriptionMemoEdit);
            this.wizardPage63.Controls.Add(this.q37ControlDescriptionLabel);
            this.wizardPage63.Name = "wizardPage63";
            this.wizardPage63.Size = new System.Drawing.Size(572, 269);
            this.wizardPage63.Text = "System services and processes";
            // 
            // q37ControlDescriptionMemoEdit
            // 
            this.q37ControlDescriptionMemoEdit.Location = new System.Drawing.Point(24, 33);
            this.q37ControlDescriptionMemoEdit.Name = "q37ControlDescriptionMemoEdit";
            this.q37ControlDescriptionMemoEdit.Size = new System.Drawing.Size(514, 55);
            this.q37ControlDescriptionMemoEdit.TabIndex = 1;
            // 
            // q37ControlDescriptionLabel
            // 
            this.q37ControlDescriptionLabel.Location = new System.Drawing.Point(24, 14);
            this.q37ControlDescriptionLabel.Name = "q37ControlDescriptionLabel";
            this.q37ControlDescriptionLabel.Size = new System.Drawing.Size(91, 13);
            this.q37ControlDescriptionLabel.TabIndex = 0;
            this.q37ControlDescriptionLabel.Text = "Control Description";
            // 
            // wizardPage64
            // 
            this.wizardPage64.Controls.Add(this.q43MemoEdit);
            this.wizardPage64.Controls.Add(this.q43Label);
            this.wizardPage64.Name = "wizardPage64";
            this.wizardPage64.Size = new System.Drawing.Size(572, 269);
            this.wizardPage64.Text = "System services and processes";
            // 
            // q43MemoEdit
            // 
            this.q43MemoEdit.Location = new System.Drawing.Point(24, 33);
            this.q43MemoEdit.Name = "q43MemoEdit";
            this.q43MemoEdit.Size = new System.Drawing.Size(514, 55);
            this.q43MemoEdit.TabIndex = 11;
            // 
            // q43Label
            // 
            this.q43Label.Location = new System.Drawing.Point(24, 14);
            this.q43Label.Name = "q43Label";
            this.q43Label.Size = new System.Drawing.Size(319, 13);
            this.q43Label.TabIndex = 10;
            this.q43Label.Text = "What are the Categorization Techniques required for this process?";
            // 
            // wizardPage65
            // 
            this.wizardPage65.Controls.Add(this.q42MemoEdit);
            this.wizardPage65.Controls.Add(this.q42Label);
            this.wizardPage65.Name = "wizardPage65";
            this.wizardPage65.Size = new System.Drawing.Size(572, 269);
            this.wizardPage65.Text = "System services and processes";
            // 
            // q42MemoEdit
            // 
            this.q42MemoEdit.Location = new System.Drawing.Point(24, 33);
            this.q42MemoEdit.Name = "q42MemoEdit";
            this.q42MemoEdit.Size = new System.Drawing.Size(514, 55);
            this.q42MemoEdit.TabIndex = 9;
            // 
            // q42Label
            // 
            this.q42Label.Location = new System.Drawing.Point(24, 14);
            this.q42Label.Name = "q42Label";
            this.q42Label.Size = new System.Drawing.Size(254, 13);
            this.q42Label.TabIndex = 8;
            this.q42Label.Text = "Describe Per Platform Controls (PPC) if there are any";
            // 
            // wizardPage66
            // 
            this.wizardPage66.Controls.Add(this.q41MemoEdit);
            this.wizardPage66.Controls.Add(this.q41Label);
            this.wizardPage66.Name = "wizardPage66";
            this.wizardPage66.Size = new System.Drawing.Size(572, 269);
            this.wizardPage66.Text = "System services and processes";
            // 
            // q41MemoEdit
            // 
            this.q41MemoEdit.Location = new System.Drawing.Point(24, 33);
            this.q41MemoEdit.Name = "q41MemoEdit";
            this.q41MemoEdit.Size = new System.Drawing.Size(514, 55);
            this.q41MemoEdit.TabIndex = 7;
            // 
            // q41Label
            // 
            this.q41Label.Location = new System.Drawing.Point(24, 14);
            this.q41Label.Name = "q41Label";
            this.q41Label.Size = new System.Drawing.Size(277, 13);
            this.q41Label.TabIndex = 6;
            this.q41Label.Text = "Count and describe Per Risk Controls (PRC) of the system";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(243, 146);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(94, 23);
            this.generateReportButton.TabIndex = 12;
            this.generateReportButton.Text = "Generate Report";
            // 
            // systemComboBox
            // 
            this.systemComboBox.EditValue = " Select System";
            this.systemComboBox.Location = new System.Drawing.Point(189, 120);
            this.systemComboBox.Name = "systemComboBox";
            this.systemComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.systemComboBox.Size = new System.Drawing.Size(148, 20);
            this.systemComboBox.TabIndex = 11;
            // 
            // submitButton1
            // 
            this.submitButton1.Location = new System.Drawing.Point(186, 45);
            this.submitButton1.Name = "submitButton1";
            this.submitButton1.Size = new System.Drawing.Size(151, 36);
            this.submitButton1.TabIndex = 10;
            this.submitButton1.Text = "Submit Answers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 437);
            this.Controls.Add(this.wizardControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Model";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinComboBox.Properties)).EndInit();
            this.welcomeWizardPage1.ResumeLayout(false);
            this.welcomeWizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemNameTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q1memoEdit1.Properties)).EndInit();
            this.completionWizardPage1.ResumeLayout(false);
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q2memoEdit1.Properties)).EndInit();
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q3PanelControl1)).EndInit();
            this.q3PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BillingCheckEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistributionCheckEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarketingCheckEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagementDecisionCheckEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformationSecurityCheckEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRMcheckEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralITCheckEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogisticsCheckEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagementCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRCheckEdit2.Properties)).EndInit();
            this.wizardPage4.ResumeLayout(false);
            this.wizardPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q4BMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q4aRadioGroup1.Properties)).EndInit();
            this.wizardPage5.ResumeLayout(false);
            this.wizardPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q5RadioGroup2.Properties)).EndInit();
            this.wizardPage6.ResumeLayout(false);
            this.wizardPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q6MemoEdit1.Properties)).EndInit();
            this.wizardPage7.ResumeLayout(false);
            this.wizardPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q7PanelControl2)).EndInit();
            this.q7PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.q7BillingCheckEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7DistributionCheckEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7MarketingCheckEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7ManagDecsCheckEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7InformationSecCheckEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7CRMCheckEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7GeneralITCheckEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7LogisticsCheckEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7ManagementCheckEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q7HRCheckEdit10.Properties)).EndInit();
            this.wizardPage8.ResumeLayout(false);
            this.wizardPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q8bJobTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q8aNameTextEdit1.Properties)).EndInit();
            this.wizardPage9.ResumeLayout(false);
            this.wizardPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q9TextEdit1.Properties)).EndInit();
            this.wizardPage10.ResumeLayout(false);
            this.wizardPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q10TextEdit1.Properties)).EndInit();
            this.wizardPage11.ResumeLayout(false);
            this.wizardPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q11MemoEdit1.Properties)).EndInit();
            this.wizardPage12.ResumeLayout(false);
            this.wizardPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q12PanelControl3)).EndInit();
            this.q12PanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.q12BillingCheckEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12DistributionCheckEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12MarketingCheckEdit13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12MangDecsCheckEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12InformationSecCheckEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12CRMCheckEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12GeneralITCheckEdit17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12LogisticsCheckEdit18.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12ManagementCheckEdit19.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q12HRCheckEdit20.Properties)).EndInit();
            this.wizardPage13.ResumeLayout(false);
            this.wizardPage13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q13SystemHoldComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q13SystemHoldComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q13SystemHoldRadioGroup.Properties)).EndInit();
            this.wizardPage14.ResumeLayout(false);
            this.wizardPage14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q14RadioGroup.Properties)).EndInit();
            this.wizardPage15.ResumeLayout(false);
            this.wizardPage15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q15PanelControl4)).EndInit();
            this.q15PanelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.q15CyclicCheckEdit24.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q15IntegrationTechniquesCheckEdit23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q15SDLCCheckEdit22.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q15BestPracticesCheckEdit21.Properties)).EndInit();
            this.wizardPage16.ResumeLayout(false);
            this.wizardPage16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q16PanelControl5)).EndInit();
            this.q16PanelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.q16OrganizationalSearchCheckEdit22.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q16APIMCheckEdit21.Properties)).EndInit();
            this.wizardPage17.ResumeLayout(false);
            this.wizardPage17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q17RadioGroup4.Properties)).EndInit();
            this.wizardPage18.ResumeLayout(false);
            this.wizardPage18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q25MemoEdit1.Properties)).EndInit();
            this.wizardPage19.ResumeLayout(false);
            this.wizardPage19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q26MemoEdit1.Properties)).EndInit();
            this.wizardPage20.ResumeLayout(false);
            this.wizardPage20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q27MemoEdit1.Properties)).EndInit();
            this.wizardPage21.ResumeLayout(false);
            this.wizardPage21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q28panelControl6)).EndInit();
            this.q28panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.q28ESXcheckEdit25.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28AS400checkEdit24.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28LinuxCheckEdit23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28UnixCheckEdit22.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q28WinCheckEdit21.Properties)).EndInit();
            this.wizardPage22.ResumeLayout(false);
            this.wizardPage22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q29memoEdit1.Properties)).EndInit();
            this.wizardPage23.ResumeLayout(false);
            this.wizardPage23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q30memoEdit1.Properties)).EndInit();
            this.wizardPage24.ResumeLayout(false);
            this.wizardPage24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q31memoEdit1.Properties)).EndInit();
            this.wizardPage25.ResumeLayout(false);
            this.wizardPage25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q32memoEdit1.Properties)).EndInit();
            this.wizardPage26.ResumeLayout(false);
            this.wizardPage26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q33memoEdit1.Properties)).EndInit();
            this.wizardPage27.ResumeLayout(false);
            this.wizardPage27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q34memoEdit1.Properties)).EndInit();
            this.wizardPage28.ResumeLayout(false);
            this.wizardPage28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q35MVCcomboBoxEdit.Properties)).EndInit();
            this.wizardPage29.ResumeLayout(false);
            this.wizardPage29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q36ControlTypeComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q36ControlTypeComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q36ControlTypeRadioGroup.Properties)).EndInit();
            this.wizardPage30.ResumeLayout(false);
            this.wizardPage30.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q44memoEdit1.Properties)).EndInit();
            this.wizardPage31.ResumeLayout(false);
            this.wizardPage31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q45memoEdit2.Properties)).EndInit();
            this.wizardPage32.ResumeLayout(false);
            this.wizardPage32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q46memoEdit3.Properties)).EndInit();
            this.wizardPage33.ResumeLayout(false);
            this.wizardPage33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q47memoEdit4.Properties)).EndInit();
            this.wizardPage34.ResumeLayout(false);
            this.wizardPage34.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q48memoEdit1.Properties)).EndInit();
            this.wizardPage35.ResumeLayout(false);
            this.wizardPage35.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q49memoEdit1.Properties)).EndInit();
            this.wizardPage36.ResumeLayout(false);
            this.wizardPage36.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q50memoEdit1.Properties)).EndInit();
            this.wizardPage37.ResumeLayout(false);
            this.wizardPage37.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q51memoEdit1.Properties)).EndInit();
            this.wizardPage38.ResumeLayout(false);
            this.wizardPage38.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q52memoEdit1.Properties)).EndInit();
            this.wizardPage39.ResumeLayout(false);
            this.wizardPage39.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q53HyperLink.Properties)).EndInit();
            this.wizardPage40.ResumeLayout(false);
            this.wizardPage40.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q54HyperLink.Properties)).EndInit();
            this.wizardPage41.ResumeLayout(false);
            this.wizardPage41.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q55memoEdit1.Properties)).EndInit();
            this.wizardPage42.ResumeLayout(false);
            this.wizardPage42.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q56memoEdit1.Properties)).EndInit();
            this.wizardPage43.ResumeLayout(false);
            this.wizardPage43.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q57HyperLink.Properties)).EndInit();
            this.wizardPage44.ResumeLayout(false);
            this.wizardPage44.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q58memoEdit1.Properties)).EndInit();
            this.wizardPage45.ResumeLayout(false);
            this.wizardPage45.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q59memoEdit1.Properties)).EndInit();
            this.wizardPage46.ResumeLayout(false);
            this.wizardPage46.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q60memoEdit1.Properties)).EndInit();
            this.wizardPage47.ResumeLayout(false);
            this.wizardPage47.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q61memoEdit1.Properties)).EndInit();
            this.wizardPage48.ResumeLayout(false);
            this.wizardPage48.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q62memoEdit1.Properties)).EndInit();
            this.wizardPage49.ResumeLayout(false);
            this.wizardPage49.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q63memoEdit1.Properties)).EndInit();
            this.wizardPage50.ResumeLayout(false);
            this.wizardPage50.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q64memoEdit1.Properties)).EndInit();
            this.wizardPage51.ResumeLayout(false);
            this.wizardPage51.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q65memoEdit1.Properties)).EndInit();
            this.wizardPage52.ResumeLayout(false);
            this.wizardPage52.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q66memoEdit1.Properties)).EndInit();
            this.wizardPage53.ResumeLayout(false);
            this.wizardPage53.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q18aHyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q18b3IntegratorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q18b2DistributorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q18b1VendorTextEdit.Properties)).EndInit();
            this.wizardPage55.ResumeLayout(false);
            this.wizardPage55.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q24CustomSolutionsMemoEdit.Properties)).EndInit();
            this.wizardPage56.ResumeLayout(false);
            this.wizardPage56.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q23SiteLicenseRadioGroup.Properties)).EndInit();
            this.wizardPage57.ResumeLayout(false);
            this.wizardPage57.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q22CashBackRadioGroup1.Properties)).EndInit();
            this.wizardPage58.ResumeLayout(false);
            this.wizardPage58.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q21CurrencyRadioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q21TextEdit1.Properties)).EndInit();
            this.wizardPage59.ResumeLayout(false);
            this.wizardPage59.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q19SolutionTypeRadioGroup1.Properties)).EndInit();
            this.wizardPage62.ResumeLayout(false);
            this.wizardPage62.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q20ControlResolutionRadioGroup2.Properties)).EndInit();
            this.wizardPage54.ResumeLayout(false);
            this.wizardPage54.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q40ControlTagMemoEdit.Properties)).EndInit();
            this.wizardPage60.ResumeLayout(false);
            this.wizardPage60.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q39ControlMandatoryRadioGroup.Properties)).EndInit();
            this.wizardPage61.ResumeLayout(false);
            this.wizardPage61.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q38ControlValidityRadioGroup.Properties)).EndInit();
            this.wizardPage63.ResumeLayout(false);
            this.wizardPage63.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q37ControlDescriptionMemoEdit.Properties)).EndInit();
            this.wizardPage64.ResumeLayout(false);
            this.wizardPage64.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q43MemoEdit.Properties)).EndInit();
            this.wizardPage65.ResumeLayout(false);
            this.wizardPage65.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q42MemoEdit.Properties)).EndInit();
            this.wizardPage66.ResumeLayout(false);
            this.wizardPage66.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q41MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.MemoEdit q1memoEdit1;
        private DevExpress.XtraEditors.LabelControl q1Label;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraEditors.MemoEdit q2memoEdit1;
        private DevExpress.XtraEditors.LabelControl q2Label;
        private DevExpress.XtraWizard.WizardPage wizardPage3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl q3Label;
        private DevExpress.XtraWizard.WizardPage wizardPage4;
        private DevExpress.XtraEditors.MemoEdit q4BMemoEdit1;
        private DevExpress.XtraEditors.LabelControl q4BLabel;
        private DevExpress.XtraEditors.RadioGroup q4aRadioGroup1;
        private DevExpress.XtraEditors.LabelControl q4ALabel;
        private DevExpress.XtraWizard.WizardPage wizardPage5;
        private DevExpress.XtraEditors.RadioGroup q5RadioGroup2;
        private DevExpress.XtraEditors.LabelControl q5Label;
        private DevExpress.XtraWizard.WizardPage wizardPage6;
        private DevExpress.XtraEditors.MemoEdit q6MemoEdit1;
        private DevExpress.XtraEditors.LabelControl q6Label;
        private DevExpress.XtraWizard.WizardPage wizardPage7;
        private DevExpress.XtraEditors.PanelControl q7PanelControl2;
        private DevExpress.XtraEditors.CheckEdit q7BillingCheckEdit1;
        private DevExpress.XtraEditors.CheckEdit q7DistributionCheckEdit2;
        private DevExpress.XtraEditors.CheckEdit q7MarketingCheckEdit3;
        private DevExpress.XtraEditors.CheckEdit q7ManagDecsCheckEdit4;
        private DevExpress.XtraEditors.CheckEdit q7InformationSecCheckEdit5;
        private DevExpress.XtraEditors.CheckEdit q7CRMCheckEdit6;
        private DevExpress.XtraEditors.CheckEdit q7GeneralITCheckEdit7;
        private DevExpress.XtraEditors.CheckEdit q7LogisticsCheckEdit8;
        private DevExpress.XtraEditors.CheckEdit q7ManagementCheckEdit9;
        private DevExpress.XtraEditors.CheckEdit q7HRCheckEdit10;
        private DevExpress.XtraEditors.LabelControl q7Label;
        private DevExpress.XtraWizard.WizardPage wizardPage8;
        private DevExpress.XtraEditors.TextEdit q8bJobTextEdit2;
        private DevExpress.XtraEditors.LabelControl q8bJobLabel;
        private DevExpress.XtraEditors.LabelControl q8aNameLabel;
        private DevExpress.XtraEditors.TextEdit q8aNameTextEdit1;
        private DevExpress.XtraEditors.LabelControl q8Label;
        private DevExpress.XtraWizard.WizardPage wizardPage9;
        private DevExpress.XtraEditors.TextEdit q9TextEdit1;
        private DevExpress.XtraEditors.LabelControl q9Label;
        private DevExpress.XtraWizard.WizardPage wizardPage10;
        private DevExpress.XtraEditors.TextEdit q10TextEdit1;
        private DevExpress.XtraEditors.LabelControl q10Label;
        private DevExpress.XtraWizard.WizardPage wizardPage11;
        private DevExpress.XtraEditors.MemoEdit q11MemoEdit1;
        private DevExpress.XtraEditors.LabelControl q11Label;
        private DevExpress.XtraWizard.WizardPage wizardPage12;
        private DevExpress.XtraEditors.PanelControl q12PanelControl3;
        private DevExpress.XtraEditors.CheckEdit q12BillingCheckEdit11;
        private DevExpress.XtraEditors.CheckEdit q12DistributionCheckEdit12;
        private DevExpress.XtraEditors.CheckEdit q12MarketingCheckEdit13;
        private DevExpress.XtraEditors.CheckEdit q12MangDecsCheckEdit14;
        private DevExpress.XtraEditors.CheckEdit q12InformationSecCheckEdit15;
        private DevExpress.XtraEditors.CheckEdit q12CRMCheckEdit16;
        private DevExpress.XtraEditors.CheckEdit q12GeneralITCheckEdit17;
        private DevExpress.XtraEditors.CheckEdit q12LogisticsCheckEdit18;
        private DevExpress.XtraEditors.CheckEdit q12ManagementCheckEdit19;
        private DevExpress.XtraEditors.CheckEdit q12HRCheckEdit20;
        private DevExpress.XtraEditors.LabelControl q12Label;
        private DevExpress.XtraWizard.WizardPage wizardPage13;
        private DevExpress.XtraEditors.ComboBoxEdit q13SystemHoldComboBoxEdit1;
        private DevExpress.XtraEditors.RadioGroup q13SystemHoldRadioGroup;
        private DevExpress.XtraEditors.LabelControl q13Label;
        private DevExpress.XtraEditors.ComboBoxEdit q13SystemHoldComboBoxEdit2;
        private DevExpress.XtraWizard.WizardPage wizardPage14;
        private DevExpress.XtraEditors.LabelControl q14Label;
        private DevExpress.XtraWizard.WizardPage wizardPage15;
        private DevExpress.XtraEditors.PanelControl q15PanelControl4;
        private DevExpress.XtraEditors.CheckEdit q15CyclicCheckEdit24;
        private DevExpress.XtraEditors.CheckEdit q15IntegrationTechniquesCheckEdit23;
        private DevExpress.XtraEditors.CheckEdit q15SDLCCheckEdit22;
        private DevExpress.XtraEditors.CheckEdit q15BestPracticesCheckEdit21;
        private DevExpress.XtraEditors.LabelControl q15Label;
        private DevExpress.XtraWizard.WizardPage wizardPage16;
        private DevExpress.XtraEditors.PanelControl q16PanelControl5;
        private DevExpress.XtraEditors.CheckEdit q16OrganizationalSearchCheckEdit22;
        private DevExpress.XtraEditors.CheckEdit q16APIMCheckEdit21;
        private DevExpress.XtraEditors.LabelControl q16Label;
        private DevExpress.XtraWizard.WizardPage wizardPage17;
        private DevExpress.XtraEditors.RadioGroup q17RadioGroup4;
        private DevExpress.XtraEditors.LabelControl q17Label;
        private DevExpress.XtraWizard.WizardPage wizardPage18;
        private DevExpress.XtraEditors.MemoEdit q25MemoEdit1;
        private DevExpress.XtraEditors.LabelControl q25Label;
        private DevExpress.XtraWizard.WizardPage wizardPage19;
        private DevExpress.XtraEditors.MemoEdit q26MemoEdit1;
        private DevExpress.XtraEditors.LabelControl q26Label;
        private DevExpress.XtraWizard.WizardPage wizardPage20;
        private DevExpress.XtraEditors.MemoEdit q27MemoEdit1;
        private DevExpress.XtraEditors.LabelControl q27Label;
        private DevExpress.XtraWizard.WizardPage wizardPage21;
        private DevExpress.XtraEditors.PanelControl q28panelControl6;
        private DevExpress.XtraEditors.CheckEdit q28ESXcheckEdit25;
        private DevExpress.XtraEditors.CheckEdit q28AS400checkEdit24;
        private DevExpress.XtraEditors.CheckEdit q28LinuxCheckEdit23;
        private DevExpress.XtraEditors.CheckEdit q28UnixCheckEdit22;
        private DevExpress.XtraEditors.CheckEdit q28WinCheckEdit21;
        private DevExpress.XtraEditors.LabelControl q28Label;
        private DevExpress.XtraWizard.WizardPage wizardPage22;
        private DevExpress.XtraEditors.LabelControl q29Label;
        private DevExpress.XtraWizard.WizardPage wizardPage23;
        private DevExpress.XtraEditors.LabelControl q30Label;
        private DevExpress.XtraWizard.WizardPage wizardPage24;
        private DevExpress.XtraEditors.LabelControl q31Label;
        private DevExpress.XtraWizard.WizardPage wizardPage25;
        private DevExpress.XtraEditors.LabelControl q32Label;
        private DevExpress.XtraEditors.MemoEdit q29memoEdit1;
        private DevExpress.XtraEditors.MemoEdit q30memoEdit1;
        private DevExpress.XtraEditors.MemoEdit q31memoEdit1;
        private DevExpress.XtraEditors.MemoEdit q32memoEdit1;
        private DevExpress.XtraWizard.WizardPage wizardPage26;
        private DevExpress.XtraEditors.MemoEdit q33memoEdit1;
        private DevExpress.XtraEditors.LabelControl q33Label;
        private DevExpress.XtraWizard.WizardPage wizardPage27;
        private DevExpress.XtraEditors.MemoEdit q34memoEdit1;
        private DevExpress.XtraEditors.LabelControl q34Label;
        private DevExpress.XtraWizard.WizardPage wizardPage28;
        private DevExpress.XtraEditors.LabelControl q35Label;
        private DevExpress.XtraWizard.WizardPage wizardPage29;
        private DevExpress.XtraEditors.LabelControl q36Label;
        private DevExpress.XtraWizard.WizardPage wizardPage30;
        private DevExpress.XtraEditors.MemoEdit q44memoEdit1;
        private DevExpress.XtraEditors.LabelControl q44Label;
        private DevExpress.XtraWizard.WizardPage wizardPage31;
        private DevExpress.XtraEditors.MemoEdit q45memoEdit2;
        private DevExpress.XtraEditors.LabelControl q45Label;
        private DevExpress.XtraWizard.WizardPage wizardPage32;
        private DevExpress.XtraEditors.MemoEdit q46memoEdit3;
        private DevExpress.XtraEditors.LabelControl q46Label;
        private DevExpress.XtraWizard.WizardPage wizardPage33;
        private DevExpress.XtraEditors.MemoEdit q47memoEdit4;
        private DevExpress.XtraEditors.LabelControl q47Label;
        private DevExpress.XtraWizard.WizardPage wizardPage34;
        private DevExpress.XtraEditors.MemoEdit q48memoEdit1;
        private DevExpress.XtraEditors.LabelControl q48Label;
        private DevExpress.XtraWizard.WizardPage wizardPage35;
        private DevExpress.XtraEditors.MemoEdit q49memoEdit1;
        private DevExpress.XtraEditors.LabelControl q49Label;
        private DevExpress.XtraWizard.WizardPage wizardPage36;
        private DevExpress.XtraEditors.MemoEdit q50memoEdit1;
        private DevExpress.XtraEditors.LabelControl q50Label;
        private DevExpress.XtraWizard.WizardPage wizardPage37;
        private DevExpress.XtraEditors.MemoEdit q51memoEdit1;
        private DevExpress.XtraEditors.LabelControl q51Label;
        private DevExpress.XtraWizard.WizardPage wizardPage38;
        private DevExpress.XtraWizard.WizardPage wizardPage39;
        private DevExpress.XtraWizard.WizardPage wizardPage40;
        private DevExpress.XtraWizard.WizardPage wizardPage41;
        private DevExpress.XtraWizard.WizardPage wizardPage42;
        private DevExpress.XtraWizard.WizardPage wizardPage43;
        private DevExpress.XtraWizard.WizardPage wizardPage44;
        private DevExpress.XtraWizard.WizardPage wizardPage45;
        private DevExpress.XtraWizard.WizardPage wizardPage46;
        private DevExpress.XtraWizard.WizardPage wizardPage47;
        private DevExpress.XtraWizard.WizardPage wizardPage48;
        private DevExpress.XtraWizard.WizardPage wizardPage49;
        private DevExpress.XtraWizard.WizardPage wizardPage50;
        private DevExpress.XtraWizard.WizardPage wizardPage51;
        private DevExpress.XtraWizard.WizardPage wizardPage52;
        private DevExpress.XtraEditors.MemoEdit q52memoEdit1;
        private DevExpress.XtraEditors.LabelControl q52Label;
        private DevExpress.XtraEditors.LabelControl q53Label;
        private DevExpress.XtraEditors.LabelControl q54Label;
        private DevExpress.XtraEditors.MemoEdit q55memoEdit1;
        private DevExpress.XtraEditors.LabelControl q55Label;
        private DevExpress.XtraEditors.MemoEdit q56memoEdit1;
        private DevExpress.XtraEditors.LabelControl q56Label;
        private DevExpress.XtraEditors.LabelControl q57Label;
        private DevExpress.XtraEditors.MemoEdit q58memoEdit1;
        private DevExpress.XtraEditors.LabelControl q58Label;
        private DevExpress.XtraEditors.MemoEdit q59memoEdit1;
        private DevExpress.XtraEditors.LabelControl q59Label;
        private DevExpress.XtraEditors.MemoEdit q60memoEdit1;
        private DevExpress.XtraEditors.LabelControl q60Label;
        private DevExpress.XtraEditors.MemoEdit q61memoEdit1;
        private DevExpress.XtraEditors.LabelControl q61Label;
        private DevExpress.XtraEditors.MemoEdit q62memoEdit1;
        private DevExpress.XtraEditors.LabelControl q62Label;
        private DevExpress.XtraEditors.MemoEdit q63memoEdit1;
        private DevExpress.XtraEditors.LabelControl q63Label;
        private DevExpress.XtraEditors.LabelControl q64Label;
        private DevExpress.XtraEditors.MemoEdit q64memoEdit1;
        private DevExpress.XtraEditors.MemoEdit q65memoEdit1;
        private DevExpress.XtraEditors.LabelControl q65Label;
        private DevExpress.XtraEditors.MemoEdit q66memoEdit1;
        private DevExpress.XtraEditors.LabelControl q66Label;
        private DevExpress.XtraWizard.WizardPage wizardPage53;
        private DevExpress.XtraWizard.WizardPage wizardPage55;
        private DevExpress.XtraWizard.WizardPage wizardPage56;
        private DevExpress.XtraWizard.WizardPage wizardPage57;
        private DevExpress.XtraWizard.WizardPage wizardPage58;
        private DevExpress.XtraWizard.WizardPage wizardPage59;
        private DevExpress.XtraEditors.LabelControl q18aDiagramLabel;
        private DevExpress.XtraEditors.LabelControl q21OrganizationalCostLabel;
        private DevExpress.XtraEditors.LabelControl q19SolutionTypeLabel;
        private DevExpress.XtraEditors.TextEdit q21TextEdit1;
        private DevExpress.XtraEditors.TextEdit q18b1VendorTextEdit;
        private DevExpress.XtraEditors.LabelControl q18b1VendorLabel;
        private DevExpress.XtraEditors.MemoEdit q24CustomSolutionsMemoEdit;
        private DevExpress.XtraEditors.LabelControl q24CustomSolutionsLabel;
        private DevExpress.XtraEditors.RadioGroup q23SiteLicenseRadioGroup;
        private DevExpress.XtraEditors.LabelControl q23SiteLicenseLabel;
        private DevExpress.XtraEditors.LabelControl q22CashBackLabel;
        private DevExpress.XtraWizard.WizardPage wizardPage62;
        private DevExpress.XtraEditors.TextEdit q18b3IntegratorTextEdit;
        private DevExpress.XtraEditors.LabelControl q18b3IntegratorLabel;
        private DevExpress.XtraEditors.TextEdit q18b2DistributorTextEdit;
        private DevExpress.XtraEditors.LabelControl q18b2DistributorLabel;
        private DevExpress.XtraEditors.LabelControl q20ControlResolutionLabel;
        private DevExpress.XtraEditors.ComboBoxEdit q36ControlTypeComboBoxEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit q36ControlTypeComboBoxEdit1;
        private DevExpress.XtraEditors.RadioGroup q36ControlTypeRadioGroup;
        private DevExpress.XtraWizard.WizardPage wizardPage54;
        private DevExpress.XtraEditors.MemoEdit q40ControlTagMemoEdit;
        private DevExpress.XtraEditors.LabelControl q40ControlTagLabel;
        private DevExpress.XtraWizard.WizardPage wizardPage60;
        private DevExpress.XtraEditors.RadioGroup q39ControlMandatoryRadioGroup;
        private DevExpress.XtraEditors.LabelControl q39ControlMandatoryLabel;
        private DevExpress.XtraWizard.WizardPage wizardPage61;
        private DevExpress.XtraEditors.RadioGroup q38ControlValidityRadioGroup;
        private DevExpress.XtraEditors.LabelControl q38ControlValidityLabel;
        private DevExpress.XtraWizard.WizardPage wizardPage63;
        private DevExpress.XtraEditors.MemoEdit q37ControlDescriptionMemoEdit;
        private DevExpress.XtraEditors.LabelControl q37ControlDescriptionLabel;
        private DevExpress.XtraEditors.ComboBoxEdit q35MVCcomboBoxEdit;
        private DevExpress.XtraWizard.WizardPage wizardPage64;
        private DevExpress.XtraEditors.MemoEdit q43MemoEdit;
        private DevExpress.XtraEditors.LabelControl q43Label;
        private DevExpress.XtraWizard.WizardPage wizardPage65;
        private DevExpress.XtraEditors.MemoEdit q42MemoEdit;
        private DevExpress.XtraEditors.LabelControl q42Label;
        private DevExpress.XtraWizard.WizardPage wizardPage66;
        private DevExpress.XtraEditors.MemoEdit q41MemoEdit;
        private DevExpress.XtraEditors.LabelControl q41Label;
        private DevExpress.XtraEditors.HyperLinkEdit q18aHyperLinkEdit1;
        private DevExpress.XtraEditors.SimpleButton q18aAttachDiagramButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.HyperLinkEdit q53HyperLink;
        private DevExpress.XtraEditors.SimpleButton q53AttachButton;
        private DevExpress.XtraEditors.HyperLinkEdit q54HyperLink;
        private DevExpress.XtraEditors.SimpleButton q54AttachButton;
        private DevExpress.XtraEditors.HyperLinkEdit q57HyperLink;
        private DevExpress.XtraEditors.SimpleButton q57AttachButton;
        private ComboBoxEdit skinComboBox;
        private SimpleButton dataGridButton;
        private RadioGroup q14RadioGroup;
        private RadioGroup q22CashBackRadioGroup1;
        private RadioGroup q19SolutionTypeRadioGroup1;
        private RadioGroup q20ControlResolutionRadioGroup2;
        private RadioGroup q21CurrencyRadioGroup1;
        private LabelControl q21CurrencyLabel;
        private PanelControl q3PanelControl1;
        private CheckEdit BillingCheckEdit10;
        private CheckEdit DistributionCheckEdit9;
        private CheckEdit MarketingCheckEdit8;
        private CheckEdit ManagementDecisionCheckEdit7;
        private CheckEdit InformationSecurityCheckEdit6;
        private CheckEdit CRMcheckEdit5;
        private CheckEdit GeneralITCheckEdit4;
        private CheckEdit LogisticsCheckEdit3;
        private CheckEdit ManagementCheckEdit1;
        private CheckEdit HRCheckEdit2;
        private TextEdit systemNameTextEdit1;
        private LabelControl systemNameLabel;
        private TextEdit userNameTextEdit;
        private LabelControl userNameLabel;
        private SimpleButton generateReportButton;
        private ComboBoxEdit systemComboBox;
        private SimpleButton submitButton1;
    }
}

