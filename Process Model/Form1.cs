using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.Data.SQLite;
using DevExpress.CodeParser;
using DevExpress.XtraWizard;


namespace Process_Model
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        SQLiteConnection loginSqlConnection =
            new SQLiteConnection("Data Source=|DataDirectory|Process Model DB.db; Version = 3");


        SQLiteDataAdapter da = new SQLiteDataAdapter();



        String currentPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        static ConnectionStringSettings c = ConfigurationManager.ConnectionStrings["Process Model DB"];
        string fixedConnectionString = c.ConnectionString.Replace("{AppDir}", AppDomain.CurrentDomain.BaseDirectory);

        bool userSubmitted = false;
        bool userEntered = false;
        bool validSystemNameEntered = false;
        //string colName = "";

        int qs = 1;

        public Form1()
        {
            InitializeComponent();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                skinComboBox.Properties.Items.Add(cnt.SkinName);
            }
        }

        private void radioGroup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (q13SystemHoldRadioGroup.SelectedIndex == 0)
            {
                q13SystemHoldComboBoxEdit1.ResetText();
                q13SystemHoldComboBoxEdit2.Visible = false;
                q13SystemHoldComboBoxEdit1.Properties.Items.Clear();
                this.q13SystemHoldComboBoxEdit1.Properties.Items.AddRange(new object[]
                {
                    "External",
                    "Internal",
                    "Development",
                    "Production"
                });
            }
            else
            {
                q13SystemHoldComboBoxEdit1.ResetText();
                q13SystemHoldComboBoxEdit2.Visible = false;
                q13SystemHoldComboBoxEdit1.Properties.Items.Clear();
                this.q13SystemHoldComboBoxEdit1.Properties.Items.AddRange(new object[]
                {
                    "SaaS",
                    "PaaS",
                    "IaaS"
                });
            }
        }

        private void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (q13SystemHoldComboBoxEdit2.SelectedIndex == 0)
            {

            }
            else
            {

            }
        }

        private void comboBoxEdit1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (q13SystemHoldComboBoxEdit1.SelectedText == "IaaS")
            {
                q13SystemHoldComboBoxEdit2.Visible = true;
            }
            else
                q13SystemHoldComboBoxEdit2.Visible = false;
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e){
            qs++;
            if (qs == 2 && userSubmitted == false)
            {
                /* string colName = userNameTextEdit.Text;

                loginSqlConnection.Open();

                da.InsertCommand = new SQLiteCommand("alter table Answers add column " + colName + " VARCHAR(255)", loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();
                loginSqlConnection.Close();
                userNameTextEdit.Enabled = false;
                systemNameTextEdit1.Enabled = false;
                userSubmitted = true;XtraMessageBox.Show(""+ userNameTextEdit.Text + " is added!",
                    "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

            }
            if (qs == 18)
            {
                if (q17RadioGroup4.SelectedIndex == 0)
                {
                    wizardPage53.Text = "Technology – In house proprietary solution";
                    wizardPage59.Text = "Technology – In house proprietary solution";
                    wizardPage62.Text = "Technology – In house proprietary solution";
                    wizardPage58.Text = "Technology – In house proprietary solution";
                    wizardPage57.Text = "Technology – In house proprietary solution";
                    wizardPage56.Text = "Technology – In house proprietary solution";
                    wizardPage55.Text = "Technology – In house proprietary solution";

                    q18b1VendorLabel.Visible = false;
                    q18b1VendorTextEdit.Visible = false;
                    q18b2DistributorLabel.Visible = false;
                    q18b2DistributorTextEdit.Visible = false;
                    q18b3IntegratorLabel.Visible = false;
                    q18b3IntegratorTextEdit.Visible = false;


                    q18aDiagramLabel.Visible = true;
                    q18aHyperLinkEdit1.Visible = true;
                    q18aAttachDiagramButton.Visible = true;
                }
                else
                {
                    wizardPage53.Text = "Technology – On shelf solution";
                    wizardPage59.Text = "Technology – On shelf solution";
                    wizardPage62.Text = "Technology – On shelf solution";
                    wizardPage58.Text = "Technology – On shelf solution";
                    wizardPage57.Text = "Technology – On shelf solution";
                    wizardPage56.Text = "Technology – On shelf solution";
                    wizardPage55.Text = "Technology – On shelf solution";
                    q18aDiagramLabel.Visible = false;
                    q18aHyperLinkEdit1.Visible = false;
                    q18aAttachDiagramButton.Visible = false;

                    q18b1VendorLabel.Visible = true;
                    q18b1VendorTextEdit.Visible = true;
                    q18b2DistributorLabel.Visible = true;
                    q18b2DistributorTextEdit.Visible = true;
                    q18b3IntegratorLabel.Visible = true;
                    q18b3IntegratorTextEdit.Visible = true;

                }
            }
            this.wizardControl1.Text = string.Format(" {0} / 68", qs);

        }

        private void wizardControl1_PrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            qs--;
            this.wizardControl1.Text = string.Format(" {0} / 68", qs);
        }

        private void radioGroup4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (q17RadioGroup4.SelectedIndex == 0)
            {
                wizardPage53.Text = "Technology – In house proprietary solution";
                wizardPage59.Text = "Technology – In house proprietary solution";
                wizardPage62.Text = "Technology – In house proprietary solution";
                wizardPage58.Text = "Technology – In house proprietary solution";
                wizardPage57.Text = "Technology – In house proprietary solution";
                wizardPage56.Text = "Technology – In house proprietary solution";
                wizardPage55.Text = "Technology – In house proprietary solution";

                q18b1VendorLabel.Visible = false;
                q18b1VendorTextEdit.Visible = false;
                q18b2DistributorLabel.Visible = false;
                q18b2DistributorTextEdit.Visible = false;
                q18b3IntegratorLabel.Visible = false;
                q18b3IntegratorTextEdit.Visible = false;

                q18aDiagramLabel.Visible = true;
                q18aAttachDiagramButton.Visible = true;
                q18aHyperLinkEdit1.Visible = true;
            }
            else
            {
                wizardPage53.Text = "Technology – On shelf solution";
                wizardPage59.Text = "Technology – On shelf solution";
                wizardPage62.Text = "Technology – On shelf solution";
                wizardPage58.Text = "Technology – On shelf solution";
                wizardPage57.Text = "Technology – On shelf solution";
                wizardPage56.Text = "Technology – On shelf solution";
                wizardPage55.Text = "Technology – On shelf solution";
                q18aDiagramLabel.Visible = false;
                q18aHyperLinkEdit1.Visible = false;
                q18aAttachDiagramButton.Visible = false;

                q18b1VendorLabel.Visible = true;
                q18b1VendorTextEdit.Visible = true;
                q18b2DistributorLabel.Visible = true;
                q18b2DistributorTextEdit.Visible = true;
                q18b3IntegratorLabel.Visible = true;
                q18b3IntegratorTextEdit.Visible = true;

            }
        }

        private void ControlTypeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (q36ControlTypeRadioGroup.SelectedIndex == 0)
            {
                q36ControlTypeComboBoxEdit1.ResetText();
                q36ControlTypeComboBoxEdit2.Visible = false;
                q36ControlTypeComboBoxEdit1.Properties.Items.Clear();
                this.q36ControlTypeComboBoxEdit1.Properties.Items.AddRange(new object[]
                {
                    "External",
                    "Internal",
                    "Development",
                    "Production"
                });
            }
            else
            {
                q36ControlTypeComboBoxEdit1.ResetText();
                q36ControlTypeComboBoxEdit2.Visible = false;
                q36ControlTypeComboBoxEdit1.Properties.Items.Clear();
                this.q36ControlTypeComboBoxEdit1.Properties.Items.AddRange(new object[]
                {
                    "SaaS",
                    "PaaS",
                    "IaaS"
                });
            }
        }

        private void ControlTypeComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (q36ControlTypeComboBoxEdit1.SelectedText == "IaaS")
            {
                q36ControlTypeComboBoxEdit2.Visible = true;
            }
            else
                q36ControlTypeComboBoxEdit2.Visible = false;
        }

        private void attachDiagramButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {


                q18aHyperLinkEdit1.Text = openFileDialog1.FileName;
                q18aAttachDiagramButton.Text = "Change Selected File";
            }
        }

        private void ProcessFlowChartAttachButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                q53HyperLink.Text = openFileDialog1.FileName;
                q53AttachButton.Text = "Change Selected File";
            }
        }

        private void ProcessDiagramAttachButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                q54HyperLink.Text = openFileDialog1.FileName;
                q54AttachButton.Text = "Change Selected File";
            }
        }

        private void MainMilestonesAttachButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                q57HyperLink.Text = openFileDialog1.FileName;
                q57AttachButton.Text = "Change Selected File";
            }
        }

        private void userNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextEdit_EditValueChanging(object sender,
            DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string f = "user404";
            string colName = userNameTextEdit.Text;
            string c = "user404";
            string s = "yes";

            loginSqlConnection.Open();

            try
            {
                da.InsertCommand = new SQLiteCommand("alter table Answers add column " + colName + " VARCHAR(255)",
                                    loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();}
            catch (System.Data.SQLite.SQLiteException er)
            {
                XtraMessageBox.Show(colName + " already exists in the database. Please change the username. "+er);
                wizardControl1.Show();//throw;
            }

            //da.InsertCommand = new SQLiteCommand("alter table [Answers] drop column Faizi", loginSqlConnection);
            //da.InsertCommand = new SQLiteCommand("INSERT INTO [Answers] VALUES("+colName+")", loginSqlConnection);
            //da.InsertCommand.Parameters.Add(c, SqlDbType.VarChar).Value = s;

            /*da.InsertCommand = new SQLiteCommand("INSERT INTO [Answers] VALUES(@AnswerID, @QuestionID, "+colName+")", loginSqlConnection);
            da.InsertCommand.Parameters.Add("@AnswerID", SqlDbType.Int).Value = 6;
            da.InsertCommand.Parameters.Add("@QuestionID", SqlDbType.Int).Value = 6;
            da.InsertCommand.Parameters.Add(colName, SqlDbType.VarChar).Value = "werwer";
            

            da.InsertCommand = new SQLiteCommand("INSERT INTO [Answers] VALUES(@AnswerID, @QuestionID, " + colName + ")", loginSqlConnection);
            da.InsertCommand.Parameters.Add("@AnswerID", SqlDbType.Int).Value = 8;
            da.InsertCommand.Parameters.Add("@QuestionID", SqlDbType.Int).Value = 8;
            da.InsertCommand.Parameters.Add(colName, SqlDbType.VarChar).Value = "asdf";*/
            //da.InsertCommand = new SQLiteCommand("INSERT INTO [Answers] VALUES(@test1)", loginSqlConnection);
            //da.InsertCommand = new SQLiteCommand("UPDATE Answers SET test2=@test2 WHERE AnswerID=@AnswerID", loginSqlConnection);

            //da.InsertCommand.Parameters.Add("@AnswerId", SqlDbType.Int).Value = 7;//da.InsertCommand.Parameters.Add("@test1", SqlDbType.Int).Value = 6;
            //da.InsertCommand.Parameters.Add("@AnswerID", SqlDbType.Int).Value = 12;
            //da.InsertCommand.Parameters.Add("@test2", SqlDbType.VarChar).Value = "hiibyee";
            //da.InsertCommand.Parameters.Add("@test1", SqlDbType.VarChar).Value = "3";
            //for update
            //int id = 1;
            //da.InsertCommand = new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + colName + "' WHERE AnswerID=" + id + "", loginSqlConnection);
            //da.InsertCommand.Parameters.Add(new SQLiteParameter("@AnswerID", 1));//SqlDbType.Int).Value = 1);
            //da.InsertCommand.Parameters.Add(
            //new SQLiteParameter("@" + colName, q1memoEdit1.Text));//SqlDbType.VarChar).Value = q1memoEdit1.Text);da.InsertCommand.ExecuteNonQuery();
            
            //id++;
            //int id = 6;
            //for insert
            //da.InsertCommand = new SQLiteCommand("INSERT INTO Answers (AnswerID, " + colName + ") VALUES(" + id + ", '" + colName + "')", loginSqlConnection);
            loginSqlConnection.Close();

            XtraMessageBox.Show(string.Format("Account has been opened.\n{0}", loginSqlConnection.State.ToString()),
                "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            loginSqlConnection.Open();

            bool check = false;
            int id = 0;
            string colName = userNameTextEdit.Text;
            try
            {
                da.InsertCommand = new SQLiteCommand("alter table Answers add column " + colName + " VARCHAR(255)",
                                    loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

            }
            catch (System.Data.SQLite.SQLiteException)
            {
                check = true;
                loginSqlConnection.Close();
                XtraMessageBox.Show(colName + " already exists in the database. Please change the username.");
            }

            if (!check)
            {
                //question 1

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q1memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 2
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q2memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 3
                string q3SelectedOptions = "";
                if (ManagementCheckEdit1.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = ManagementCheckEdit1.Text;
                else if (ManagementCheckEdit1.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + ManagementCheckEdit1.Text;
                if (HRCheckEdit2.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = HRCheckEdit2.Text;
                else if (HRCheckEdit2.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + HRCheckEdit2.Text;
                if (LogisticsCheckEdit3.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = LogisticsCheckEdit3.Text;
                else if (LogisticsCheckEdit3.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + LogisticsCheckEdit3.Text;
                if (GeneralITCheckEdit4.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = GeneralITCheckEdit4.Text;
                else if (GeneralITCheckEdit4.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + GeneralITCheckEdit4.Text;
                if (CRMcheckEdit5.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = CRMcheckEdit5.Text;
                else if (CRMcheckEdit5.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + CRMcheckEdit5.Text;
                if (InformationSecurityCheckEdit6.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = InformationSecurityCheckEdit6.Text;
                else if (InformationSecurityCheckEdit6.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + InformationSecurityCheckEdit6.Text;
                if (ManagementDecisionCheckEdit7.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = ManagementDecisionCheckEdit7.Text;
                else if (ManagementDecisionCheckEdit7.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + ManagementDecisionCheckEdit7.Text;
                if (MarketingCheckEdit8.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = MarketingCheckEdit8.Text;
                else if (MarketingCheckEdit8.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + MarketingCheckEdit8.Text;
                if (DistributionCheckEdit9.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = DistributionCheckEdit9.Text;
                else if (DistributionCheckEdit9.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + DistributionCheckEdit9.Text;
                if (BillingCheckEdit10.Checked && q3SelectedOptions == "")
                    q3SelectedOptions = BillingCheckEdit10.Text;
                else if (BillingCheckEdit10.Checked && q3SelectedOptions != "")
                    q3SelectedOptions += ", " + BillingCheckEdit10.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q3SelectedOptions + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 4a
                string q4aAns = "";
                if (q4aRadioGroup1.SelectedIndex == 0)
                {
                    q4aAns = "Yes";
                }
                else if (q4aRadioGroup1.SelectedIndex == 1)
                {
                    q4aAns = "No";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q4aAns + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 4b

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q4BMemoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 5

                string q5Ans = "";
                if (q5RadioGroup2.SelectedIndex == 0)
                {
                    q5Ans = "Management";
                }
                else if (q5RadioGroup2.SelectedIndex == 1)
                {
                    q5Ans = "HR";
                }
                else if (q5RadioGroup2.SelectedIndex == 2)
                {
                    q5Ans = "Logistics";
                }
                else if (q5RadioGroup2.SelectedIndex == 3)
                {
                    q5Ans = "General IT";
                }
                else if (q5RadioGroup2.SelectedIndex == 4)
                {
                    q5Ans = "CRM";
                }
                else if (q5RadioGroup2.SelectedIndex == 5)
                {
                    q5Ans = "Information security";
                }
                else if (q5RadioGroup2.SelectedIndex == 6)
                {
                    q5Ans = "Management decision supporting system";
                }
                else if (q5RadioGroup2.SelectedIndex == 7)
                {
                    q5Ans = "Marketing";
                }
                else if (q5RadioGroup2.SelectedIndex == 8)
                {
                    q5Ans = "Distribution channels (Digital)";
                }
                else if (q5RadioGroup2.SelectedIndex == 9)
                {
                    q5Ans = "Billing";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q5Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 6
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q6MemoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 7

                string q7SelectedOptions = "";
                if (q7ManagementCheckEdit9.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7ManagementCheckEdit9.Text;
                else if (q7ManagementCheckEdit9.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7ManagementCheckEdit9.Text;
                if (q7HRCheckEdit10.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7HRCheckEdit10.Text;
                else if (q7HRCheckEdit10.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7HRCheckEdit10.Text;
                if (q7LogisticsCheckEdit8.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7LogisticsCheckEdit8.Text;
                else if (q7LogisticsCheckEdit8.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7LogisticsCheckEdit8.Text;
                if (q7GeneralITCheckEdit7.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7GeneralITCheckEdit7.Text;
                else if (q7GeneralITCheckEdit7.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7GeneralITCheckEdit7.Text;
                if (q7CRMCheckEdit6.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7CRMCheckEdit6.Text;
                else if (q7CRMCheckEdit6.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7CRMCheckEdit6.Text;
                if (q7InformationSecCheckEdit5.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7InformationSecCheckEdit5.Text;
                else if (q7InformationSecCheckEdit5.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7InformationSecCheckEdit5.Text;
                if (q7ManagDecsCheckEdit4.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7ManagDecsCheckEdit4.Text;
                else if (q7ManagDecsCheckEdit4.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7ManagDecsCheckEdit4.Text;
                if (q7MarketingCheckEdit3.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7MarketingCheckEdit3.Text;
                else if (q7MarketingCheckEdit3.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7MarketingCheckEdit3.Text;
                if (q7DistributionCheckEdit2.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7DistributionCheckEdit2.Text;
                else if (q7DistributionCheckEdit2.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7DistributionCheckEdit2.Text;
                if (q7BillingCheckEdit1.Checked && q7SelectedOptions == "")
                    q7SelectedOptions = q7BillingCheckEdit1.Text;
                else if (q7BillingCheckEdit1.Checked && q7SelectedOptions != "")
                    q7SelectedOptions += ", " + q7BillingCheckEdit1.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q7SelectedOptions + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 8a
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q8aNameTextEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 8b
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q8bJobTextEdit2.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 9
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q9TextEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 10
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q10TextEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 11
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q11MemoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 12

                string q12SelectedOptions = "";
                if (q12ManagementCheckEdit19.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12ManagementCheckEdit19.Text;
                else if (q12ManagementCheckEdit19.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12ManagementCheckEdit19.Text;
                if (q12HRCheckEdit20.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12HRCheckEdit20.Text;
                else if (q12HRCheckEdit20.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12HRCheckEdit20.Text;
                if (q12LogisticsCheckEdit18.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12LogisticsCheckEdit18.Text;
                else if (q12LogisticsCheckEdit18.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12LogisticsCheckEdit18.Text;
                if (q12GeneralITCheckEdit17.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12GeneralITCheckEdit17.Text;
                else if (q12GeneralITCheckEdit17.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12GeneralITCheckEdit17.Text;
                if (q12CRMCheckEdit16.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12CRMCheckEdit16.Text;
                else if (q12CRMCheckEdit16.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12CRMCheckEdit16.Text;
                if (q12InformationSecCheckEdit15.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12InformationSecCheckEdit15.Text;
                else if (q12InformationSecCheckEdit15.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12InformationSecCheckEdit15.Text;
                if (q12MangDecsCheckEdit14.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12MangDecsCheckEdit14.Text;
                else if (q12MangDecsCheckEdit14.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12MangDecsCheckEdit14.Text;
                if (q12MarketingCheckEdit13.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12MarketingCheckEdit13.Text;
                else if (q12MarketingCheckEdit13.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12MarketingCheckEdit13.Text;
                if (q12DistributionCheckEdit12.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12DistributionCheckEdit12.Text;
                else if (q12DistributionCheckEdit12.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12DistributionCheckEdit12.Text;
                if (q12BillingCheckEdit11.Checked && q12SelectedOptions == "")
                    q12SelectedOptions = q12BillingCheckEdit11.Text;
                else if (q12BillingCheckEdit11.Checked && q12SelectedOptions != "")
                    q12SelectedOptions += ", " + q12BillingCheckEdit11.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q12SelectedOptions + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 13
                string q13Ans = "";

                if (q13SystemHoldRadioGroup.SelectedIndex == 0)
                {
                    q13Ans = "On premise";

                    if (q13SystemHoldComboBoxEdit1.SelectedIndex == 0)
                    {
                        q13Ans += " -> External";
                    }
                    else if (q13SystemHoldComboBoxEdit1.SelectedIndex == 1)
                    {
                        q13Ans += " -> Internal";
                    }
                    else if (q13SystemHoldComboBoxEdit1.SelectedIndex == 2)
                    {
                        q13Ans += " -> Development";
                    }
                    else if (q13SystemHoldComboBoxEdit1.SelectedIndex == 3)
                    {
                        q13Ans += " -> Production";
                    }
                }
                else if (q13SystemHoldRadioGroup.SelectedIndex == 1)
                {
                    q13Ans = "Cloud";

                    if (q13SystemHoldComboBoxEdit1.SelectedIndex == 0)
                    {
                        q13Ans += " -> SaaS";
                    }
                    else if (q13SystemHoldComboBoxEdit1.SelectedIndex == 1)
                    {
                        q13Ans += " -> PaaS";
                    }
                    else if (q13SystemHoldComboBoxEdit1.SelectedIndex == 2)
                    {
                        q13Ans += " -> IaaS";

                        if (q13SystemHoldComboBoxEdit2.SelectedIndex == 0)
                        {
                            q13Ans += " -> AWS";
                        }
                        else if (q13SystemHoldComboBoxEdit2.SelectedIndex == 1)
                        {
                            q13Ans += " -> Azure";
                        }
                    }
                }
                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q13Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 14

                string q14Ans = "";
                if (q14RadioGroup.SelectedIndex == 0)
                {
                    q14Ans = "Virtual";
                }
                else if (q14RadioGroup.SelectedIndex == 1)
                {
                    q14Ans = "Physical";
                }


                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q14Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 15

                string q15Ans = "";

                if (q15BestPracticesCheckEdit21.Checked && q15Ans == "")
                {
                    q15Ans = q15BestPracticesCheckEdit21.Text;
                }
                else if (q15BestPracticesCheckEdit21.Checked && q15Ans != "")
                {
                    q15Ans += ", " + q15BestPracticesCheckEdit21.Text;
                }
                if (q15SDLCCheckEdit22.Checked && q15Ans == "")
                {
                    q15Ans = q15SDLCCheckEdit22.Text;
                }
                else if (q15SDLCCheckEdit22.Checked && q15Ans != "")
                {
                    q15Ans += ", " + q15SDLCCheckEdit22.Text;
                }
                if (q15IntegrationTechniquesCheckEdit23.Checked && q15Ans == "")
                {
                    q15Ans = q15IntegrationTechniquesCheckEdit23.Text;
                }
                else if (q15IntegrationTechniquesCheckEdit23.Checked && q15Ans != "")
                {
                    q15Ans += ", " + q15IntegrationTechniquesCheckEdit23.Text;
                }
                if (q15CyclicCheckEdit24.Checked && q15Ans == "")
                {
                    q15Ans = q15CyclicCheckEdit24.Text;
                }
                else if (q15CyclicCheckEdit24.Checked && q15Ans != "")
                {
                    q15Ans += ", " + q15CyclicCheckEdit24.Text;
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q15Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 16

                string q16Ans = "";

                if (q16APIMCheckEdit21.Checked && q16Ans == "")
                {
                    q16Ans = q16APIMCheckEdit21.Text;
                }
                else if (q16APIMCheckEdit21.Checked && q16Ans != "")
                {
                    q16Ans += ", " + q16APIMCheckEdit21.Text;
                }
                if (q16OrganizationalSearchCheckEdit22.Checked && q16Ans == "")
                {
                    q16Ans = q16OrganizationalSearchCheckEdit22.Text;
                }
                else if (q16OrganizationalSearchCheckEdit22.Checked && q16Ans != "")
                {
                    q16Ans += ", " + q16OrganizationalSearchCheckEdit22.Text;
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q16Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 17

                string q17Ans = "";

                if (q17RadioGroup4.SelectedIndex == 0)
                {
                    q17Ans = "In house proprietary solution";
                }
                else if (q17RadioGroup4.SelectedIndex == 1)
                {
                    q17Ans = "On shelf solution";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q17Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 18a

                string q18ALink = q18aHyperLinkEdit1.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q18ALink + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 18b1

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q18b1VendorTextEdit.Text + "' WHERE AnswerID=" + id +
                        "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 18b2

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q18b2DistributorTextEdit.Text + "' WHERE AnswerID=" +
                        id +
                        "", loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 18b3

                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q18b3IntegratorTextEdit.Text + "' WHERE AnswerID=" +
                        id +
                        "", loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 19
                string q19Ans = "";

                if (q19SolutionTypeRadioGroup1.SelectedIndex == 0)
                {
                    q19Ans = "Application";
                }
                else if (q19SolutionTypeRadioGroup1.SelectedIndex == 1)
                {
                    q19Ans = "Infrastructure";
                }
                else if (q19SolutionTypeRadioGroup1.SelectedIndex == 2)
                {
                    q19Ans = "Appliance";
                }
                else if (q19SolutionTypeRadioGroup1.SelectedIndex == 3)
                {
                    q19Ans = "Server";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q19Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 20

                string q20Ans = "";

                if (q20ControlResolutionRadioGroup2.SelectedIndex == 0)
                {
                    q20Ans = "SCCM";
                }
                else if (q20ControlResolutionRadioGroup2.SelectedIndex == 1)
                {
                    q20Ans = "SIEM SOC";
                }
                else if (q20ControlResolutionRadioGroup2.SelectedIndex == 2)
                {
                    q20Ans = "Help desk";
                }
                else if (q20ControlResolutionRadioGroup2.SelectedIndex == 3)
                {
                    q20Ans = "NOC";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q20Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 21

                string q21Ans = "";

                if (q21CurrencyRadioGroup1.SelectedIndex == 0)
                {
                    q21Ans = "\u20AA" + q21TextEdit1.Text;
                }
                else if (q21CurrencyRadioGroup1.SelectedIndex == 1)
                {
                    q21Ans = "$" + q21TextEdit1.Text;
                }
                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q21Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 22

                string q22Ans = "";

                if (q22CashBackRadioGroup1.SelectedIndex == 0)
                {
                    q22Ans = "SROI";
                }
                else if (q22CashBackRadioGroup1.SelectedIndex == 1)
                {
                    q22Ans = "Kill on premise";
                }
                else if (q22CashBackRadioGroup1.SelectedIndex == 2)
                {
                    q22Ans = "New service";
                }
                else if (q22CashBackRadioGroup1.SelectedIndex == 3)
                {
                    q22Ans = "Spare resources";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q22Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 23
                string q23Ans = "";
                if (q23SiteLicenseRadioGroup.SelectedIndex == 0)
                {
                    q23Ans = "Yes";
                }
                else if (q23SiteLicenseRadioGroup.SelectedIndex == 1)
                {
                    q23Ans = "No";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q23Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 24
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q24CustomSolutionsMemoEdit.Text + "' WHERE AnswerID=" +
                        id +
                        "", loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 25
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q25MemoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 26
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q26MemoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 27
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q27MemoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 28

                string q28Ans = "";

                if (q28WinCheckEdit21.Checked && q28Ans == "")
                {
                    q28Ans = q28WinCheckEdit21.Text;
                }
                else if (q28WinCheckEdit21.Checked && q28Ans != "")
                {
                    q28Ans += ", " + q28WinCheckEdit21.Text;
                }
                if (q28UnixCheckEdit22.Checked && q28Ans == "")
                {
                    q28Ans = q28UnixCheckEdit22.Text;
                }
                else if (q28UnixCheckEdit22.Checked && q28Ans != "")
                {
                    q28Ans += ", " + q28UnixCheckEdit22.Text;
                }
                if (q28LinuxCheckEdit23.Checked && q28Ans == "")
                {
                    q28Ans = q28LinuxCheckEdit23.Text;
                }
                else if (q28LinuxCheckEdit23.Checked && q28Ans != "")
                {
                    q28Ans += ", " + q28LinuxCheckEdit23.Text;
                }
                if (q28AS400checkEdit24.Checked && q28Ans == "")
                {
                    q28Ans = q28AS400checkEdit24.Text;
                }
                else if (q28AS400checkEdit24.Checked && q28Ans != "")
                {
                    q28Ans += ", " + q28AS400checkEdit24.Text;
                }
                if (q28ESXcheckEdit25.Checked && q28Ans == "")
                {
                    q28Ans = q28ESXcheckEdit25.Text;
                }
                else if (q28ESXcheckEdit25.Checked && q28Ans != "")
                {
                    q28Ans += ", " + q28ESXcheckEdit25.Text;
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q28Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 29
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q29memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 30
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q30memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 31
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q31memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 32
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q32memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 33
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q33memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 34
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q34memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 35
                string q35Ans = "";
                if (q35MVCcomboBoxEdit.SelectedIndex == 0)
                {
                    q35Ans = "1";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 1)
                {
                    q35Ans = "2";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 2)
                {
                    q35Ans = "3";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 3)
                {
                    q35Ans = "4";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 4)
                {
                    q35Ans = "5";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 5)
                {
                    q35Ans = "6";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 6)
                {
                    q35Ans = "7";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 7)
                {
                    q35Ans = "8";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 8)
                {
                    q35Ans = "9";
                }
                else if (q35MVCcomboBoxEdit.SelectedIndex == 9)
                {
                    q35Ans = "10";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q35Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 36
                string q36Ans = "";

                if (q36ControlTypeRadioGroup.SelectedIndex == 0)
                {
                    q36Ans = "On premise";

                    if (q36ControlTypeComboBoxEdit1.SelectedIndex == 0)
                    {
                        q36Ans += " -> External";
                    }
                    else if (q36ControlTypeComboBoxEdit1.SelectedIndex == 1)
                    {
                        q36Ans += " -> Internal";
                    }
                    else if (q36ControlTypeComboBoxEdit1.SelectedIndex == 2)
                    {
                        q36Ans += " -> Development";
                    }
                    else if (q36ControlTypeComboBoxEdit1.SelectedIndex == 3)
                    {
                        q36Ans += " -> Production";
                    }
                }
                else if (q36ControlTypeRadioGroup.SelectedIndex == 1)
                {
                    q36Ans = "Cloud";

                    if (q36ControlTypeComboBoxEdit1.SelectedIndex == 0)
                    {
                        q36Ans += " -> SaaS";
                    }
                    else if (q36ControlTypeComboBoxEdit1.SelectedIndex == 1)
                    {
                        q36Ans += " -> PaaS";
                    }
                    else if (q36ControlTypeComboBoxEdit1.SelectedIndex == 2)
                    {
                        q36Ans += " -> IaaS";

                        if (q36ControlTypeComboBoxEdit2.SelectedIndex == 0)
                        {
                            q36Ans += " -> AWS";
                        }
                        else if (q36ControlTypeComboBoxEdit2.SelectedIndex == 1)
                        {
                            q36Ans += " -> Azure";
                        }
                    }
                }
                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q36Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();


                //question 37
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q37ControlDescriptionMemoEdit.Text +
                        "' WHERE AnswerID=" +
                        id + "", loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 38
                string q38Ans = "";
                if (q38ControlValidityRadioGroup.SelectedIndex == 0)
                {
                    q38Ans = "Yes";
                }
                else if (q38ControlValidityRadioGroup.SelectedIndex == 1)
                {
                    q38Ans = "No";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q38Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 39
                string q39Ans = "";
                if (q39ControlMandatoryRadioGroup.SelectedIndex == 0)
                {
                    q39Ans = "Yes";
                }
                else if (q39ControlMandatoryRadioGroup.SelectedIndex == 1)
                {
                    q39Ans = "No";
                }

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q39Ans + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 40
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q40ControlTagMemoEdit.Text + "' WHERE AnswerID=" + id +
                        "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 41
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q41MemoEdit.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 42
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q42MemoEdit.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 43
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q43MemoEdit.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 44
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q44memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 45
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q45memoEdit2.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 46
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q46memoEdit3.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 47
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q47memoEdit4.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 48
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q48memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 49
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q49memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 50
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q50memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 51
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q51memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 52
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q52memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 53

                string q53Link = q53HyperLink.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q53Link + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 54

                string q54Link = q54HyperLink.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q54Link + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 55
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q55memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 56
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q56memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 57

                string q57Link = q57HyperLink.Text;

                id++;
                da.InsertCommand =
                    new SQLiteCommand("UPDATE Answers SET " + colName + "= '" + q57Link + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 58
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q58memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 59
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q59memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 60
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q60memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 61
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q61memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 62
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q62memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 63
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q63memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 64
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q64memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 65
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q65memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                //question 66
                id++;
                da.InsertCommand =
                    new SQLiteCommand(
                        "UPDATE Answers SET " + colName + "= '" + q66memoEdit1.Text + "' WHERE AnswerID=" + id + "",
                        loginSqlConnection);
                da.InsertCommand.ExecuteNonQuery();

                loginSqlConnection.Close();

                XtraMessageBox.Show(
                    "Record Submitted Successfully!",
                    "Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridButton_Click(object sender, EventArgs e)
        {
            GridForm gridForm = new GridForm();
            gridForm.Refresh();
            //.RefreshDataSource();
            gridForm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GridForm gridForm = new GridForm();
            gridForm.Refresh();
            //.RefreshDataSource();
            gridForm.Show();
        }

        private void systemNameTextEdit1_Properties_Leave(object sender, EventArgs e)
        {
            /*loginSqlConnection.Open();
            string col = "";
            bool check = false;
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Answers WHERE AnswerID = @AnswerID", loginSqlConnection);
            cmd.Parameters.AddWithValue("@AnswerID", 11);
            var systemName="";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    
                    if (!reader.IsDBNull(i))
                        systemName = reader.GetString(i);
                    if (systemNameTextEdit1.Text == (string) systemName && systemName != "")
                    {
                        check = true;
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            if (check)
            {
                wizardPage67.AllowNext = false;
                systemNameTextEdit1.Text = "";
                XtraMessageBox.Show(
                            string.Format(col + "-" + systemName + " is already in the database"),
                            "Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(systemNameTextEdit1.Text != "")
            {
                q9TextEdit1.Text = systemNameTextEdit1.Text;
                validSystemNameEntered = true;
            }
            if (userEntered && validSystemNameEntered)
            {
                wizardPage67.AllowNext = true;
            }
            else if (systemNameTextEdit1.Text=="")
            {
                validSystemNameEntered = false;systemNameTextEdit1.Text = "";
                wizardPage67.AllowNext = false;
            }
            loginSqlConnection.Close();*/

        }

        private void systemComboBox_Enter(object sender, EventArgs e)
        {
            systemComboBox.Properties.Items.Clear();

            loginSqlConnection.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Answers WHERE AnswerID = @AnswerID", loginSqlConnection);
            cmd.Parameters.AddWithValue("@AnswerID", 11);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    var systemName = "";
                    if (!reader.IsDBNull(i))
                    {
                        systemName = reader.GetString(i);

                        systemComboBox.Properties.Items.Add(systemName);
                    }

                }
            }
            loginSqlConnection.Close();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            string systemName = systemComboBox.SelectedText;

            string colName = "";
            loginSqlConnection.Open();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Answers WHERE AnswerID = @AnswerID", loginSqlConnection);
            cmd.Parameters.AddWithValue("@AnswerID", 11);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    var sysName = "";
                    if (!reader.IsDBNull(i))
                        sysName = reader.GetString(i);
                    if (systemName == (string) sysName)
                    {
                        colName = reader.GetName(i);
                        break;
                    }
                }
            }
            loginSqlConnection.Close();

            Report report = new Report(colName, systemName);

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                // Invoke the Ribbon Print Preview form modally, 
                // and load the report document into it.
                printTool.ShowRibbonPreviewDialog();

                // Invoke the Ribbon Print Preview form
                // with the specified look and feel setting.
                printTool.ShowRibbonPreview(UserLookAndFeel.Default);
            }
        }

        private void skinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            string skinName = comboBox.Text;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skinName;
        }

        private void userNameTextEdit_Leave(object sender, EventArgs e)
        {
            /*if (userNameTextEdit.Text == "" && userEntered==false && validSystemNameEntered==false)
            {
                wizardPage67.AllowNext = false;
                XtraMessageBox.Show("Enter User", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(userNameTextEdit.Text != "")
            {

                userEntered = true;
            }
            if (userEntered && validSystemNameEntered)
            {
                wizardPage67.AllowNext = true;
            }*/

        }

        private void wizardControl1_SelectedPageChanged(object sender,
            DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
        }

        private void wizardControl1_SelectedPageChanging(object sender,
            DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {


        }

        private void wizardControl1_Validated(object sender, EventArgs e)
        {

        }

        private void wizardPage67_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            if (userNameTextEdit.Text == "" || systemNameTextEdit1.Text == "")
                e.Valid = false;

            loginSqlConnection.Open();
            bool check1 = false;
            bool check2 = false;

            var userName = "";
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Answers", loginSqlConnection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int colm = 0; colm < reader.FieldCount; colm++)
                {
                    if (!reader.IsDBNull(colm))
                        userName = reader.GetName(colm);
                    if (userNameTextEdit.Text == (string)userName && userName != "")
                    {
                        check1 = true;
                        break;
                    }
                    else
                    {
                        check1 = false;
                    }
                }
            }
            

            SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM Answers WHERE AnswerID = @AnswerID", loginSqlConnection);
            cmd2.Parameters.AddWithValue("@AnswerID", 11);
            var systemName = "";
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                for (int i = 1; i < reader2.FieldCount; i++)
                {

                    if (!reader2.IsDBNull(i))
                        systemName = reader2.GetString(i);
                    if (systemNameTextEdit1.Text == (string)systemName && systemName != "")
                    {
                        check2 = true;
                        break;
                    }
                    else
                    {
                        check2 = false;
                    }
                }
            }
            if (check1 || check2)
            {
                e.Valid = false;
            }
            loginSqlConnection.Close();

            if (check1)
            {
                e.ErrorText = userName + " is already in the database";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
            if (check2){
                e.ErrorText = systemName + " is already in the database";
                e.ErrorIconType = MessageBoxIcon.Error;}
            if (userNameTextEdit.Text == "" && systemNameTextEdit1.Text == "")
            {
                e.ErrorText = "Please enter the information!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
            else if (systemNameTextEdit1.Text == "")
            {
                e.ErrorText = "Please give system a name!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
            else if(userNameTextEdit.Text == ""){
                e.ErrorText = "Please enter your name!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }}

        private void wizardPage3_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;
            if (ManagementCheckEdit1.Checked || HRCheckEdit2.Checked || LogisticsCheckEdit3.Checked ||
                GeneralITCheckEdit4.Checked || CRMcheckEdit5.Checked || InformationSecurityCheckEdit6.Checked ||
                ManagementDecisionCheckEdit7.Checked || MarketingCheckEdit8.Checked || DistributionCheckEdit9.Checked ||
                BillingCheckEdit10.Checked)
            {
                e.Valid = true;
            }
            if (!e.Valid)
            {
                e.ErrorText = "Please select at least 1 option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage4_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            if (q4aRadioGroup1.SelectedIndex == 0 && q4BMemoEdit1.Text == "")
                e.Valid = false;
            e.ErrorText = "Please explain the reason.";
            e.ErrorIconType = MessageBoxIcon.Error;
        }

        private void wizardPage7_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;
            if (q7ManagementCheckEdit9.Checked || q7HRCheckEdit10.Checked || q7LogisticsCheckEdit8.Checked ||
                q7GeneralITCheckEdit7.Checked || q7CRMCheckEdit6.Checked || q7InformationSecCheckEdit5.Checked ||
                q7ManagDecsCheckEdit4.Checked || q7MarketingCheckEdit3.Checked || q7DistributionCheckEdit2.Checked ||
                q7BillingCheckEdit1.Checked)
            {
                e.Valid = true;
            }
            if (!e.Valid)
            {
                e.ErrorText = "Please select at least 1 option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage12_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;
            if (q12ManagementCheckEdit19.Checked || q12HRCheckEdit20.Checked || q12LogisticsCheckEdit18.Checked ||
                q12GeneralITCheckEdit17.Checked || q12CRMCheckEdit16.Checked || q12InformationSecCheckEdit15.Checked ||
                q12MangDecsCheckEdit14.Checked || q12MarketingCheckEdit13.Checked || q12DistributionCheckEdit12.Checked ||
                q12BillingCheckEdit11.Checked)
            {
                e.Valid = true;
            }
            if (!e.Valid)
            {
                e.ErrorText = "Please select at least 1 option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage13_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;

            if (q13SystemHoldRadioGroup.SelectedIndex == 0)
            {
                if (q13SystemHoldComboBoxEdit1.SelectedIndex == 0 || q13SystemHoldComboBoxEdit1.SelectedIndex == 1 ||
                    q13SystemHoldComboBoxEdit1.SelectedIndex == 2 || q13SystemHoldComboBoxEdit1.SelectedIndex == 3)
                {
                    e.Valid = true;
                }
            }
            else if (q13SystemHoldRadioGroup.SelectedIndex == 1)
            {
                if (q13SystemHoldComboBoxEdit1.SelectedIndex == 0 ||
                     q13SystemHoldComboBoxEdit1.SelectedIndex == 1)
                {
                    e.Valid = true;
                }
                if (q13SystemHoldComboBoxEdit1.SelectedIndex == 2)
                {
                    if (q13SystemHoldComboBoxEdit2.SelectedIndex == 0 || q13SystemHoldComboBoxEdit2.SelectedIndex == 1)
                    {
                        e.Valid = true;
                    }
                    else
                    {
                        e.Valid = false;
                    }

                }
            }
            
            if (!e.Valid)
            {
                e.ErrorText = "Please select the right option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage15_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;

            if (q15BestPracticesCheckEdit21.Checked || q15SDLCCheckEdit22.Checked ||
                q15IntegrationTechniquesCheckEdit23.Checked ||
                q15CyclicCheckEdit24.Checked)
            {
                e.Valid = true;
            }
            if (!e.Valid)
            {
                e.ErrorText = "Please select at least 1 option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage16_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;

            if (q16APIMCheckEdit21.Checked || q16OrganizationalSearchCheckEdit22.Checked)
            {
                e.Valid = true;
            }
            if (!e.Valid)
            {
                e.ErrorText = "Please select at least 1 option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage21_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;

            if (q28AS400checkEdit24.Checked || q28ESXcheckEdit25.Checked || q28LinuxCheckEdit23.Checked ||
                q28UnixCheckEdit22.Checked || q28WinCheckEdit21.Checked)
            {
                e.Valid = true;
            }

            if (!e.Valid)
            {
                e.ErrorText = "Please select at least 1 option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void wizardPage29_PageValidating(object sender, WizardPageValidatingEventArgs e)
        {
            e.Valid = false;

            if (q36ControlTypeRadioGroup.SelectedIndex == 0)
            {
                if (q36ControlTypeComboBoxEdit1.SelectedIndex == 0 ||
                q36ControlTypeComboBoxEdit1.SelectedIndex == 1 || q36ControlTypeComboBoxEdit1.SelectedIndex == 2 ||
                q36ControlTypeComboBoxEdit1.SelectedIndex == 3)
                {
                    e.Valid = true;
                }
            }
            else if (q36ControlTypeRadioGroup.SelectedIndex == 1)
            {
                if (q36ControlTypeComboBoxEdit1.SelectedIndex == 0 ||
                     q36ControlTypeComboBoxEdit1.SelectedIndex == 1)
                {
                    e.Valid = true;
                }
                if (q36ControlTypeComboBoxEdit1.SelectedIndex == 2)
                {
                    if (q36ControlTypeComboBoxEdit2.SelectedIndex == 0 || q36ControlTypeComboBoxEdit2.SelectedIndex == 1)
                    {
                        e.Valid = true;
                    }
                    else
                    {
                        e.Valid = false;
                    }
                }
            }
            if (!e.Valid)
            {
                e.ErrorText = "Please select the right option!";
                e.ErrorIconType = MessageBoxIcon.Error;
            }
        }

        private void q21CurrencyRadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (q21CurrencyRadioGroup1.SelectedIndex == 0)
            {
                q21TextEdit1.Properties.NullValuePrompt = "\u20AA";
            }
            else if (q21CurrencyRadioGroup1.SelectedIndex == 1)
            {
                q21TextEdit1.Properties.NullValuePrompt = "$";
            }
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            Close();
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            Close();
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {
            }

    }
}