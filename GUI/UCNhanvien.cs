using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BUS;
using System.Drawing.Imaging;
using System.Data.SqlClient;


namespace GUI
{
    public partial class UCNhanvien : UserControl
    {
        //----------------------------------Bien---------------------------
            BUS_Employ busEmploy= new BUS_Employ();
            BUS_Quarter busQuarter = new BUS_Quarter();
            BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
            DataTable employDataTable;
       //-----------------------------------ham-----------------------------

        public UCNhanvien()
        {
            InitializeComponent();
            employDataTable = busEmploy.getAllEmployList();
        }

        private void UCNhanvien_Load(object sender, EventArgs e)
        {
            setDisplayTableView();
            setDisplayQuarterCombobox();
            setDataForEmployId("All");
            setDataForEmployName("All");
            searchQuarterCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchQuarterCombobox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            searchEmployIdText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchEmployIdText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            searchEmployNameText.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchEmployNameText.AutoCompleteSource = AutoCompleteSource.CustomSource;

            searchEmployTotalLabel.Text = busEmploy.getTotalEmploy().ToString();
            if (this.dgvEmploy.Rows.Count > 0)
            {
                setDataDetail(0);
            }
            else
            {
                setDataDetailNull();
            }
        }

        public void setDisplayTableView()
        {
            dgvEmploy.Rows.Clear();
            dgvEmploy.Refresh();
            if (busEmploy.convertDatatable2Dict().Count > 0)
            {
                this.statusLabel.Visible = false;

                foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatable2Dict())
                {
                    QuarterModel quarter = busQuarter.convertQuarterDatatable2Dict()[employ.Value.quarterId];
                    dgvEmploy.Rows.Add(employ.Key, employ.Value.emPloyName, quarter.quarterName);
                    employIdText.Text = employ.Value.emPloyId.ToString();
                }
                setDataDetail(0);
            }
            else
            {
                this.statusLabel.Visible = true;
                setDataDetailNull();
            }
        }

        public void setDisplayQuarterCombobox()
       {
           AutoCompleteStringCollection data = new AutoCompleteStringCollection();
           if (busQuarter.convertQuarterDatatable2Dict().Count > 0)
           {
               this.searchQuarterCombobox.Items.Add("All");
               data.Add("All");
               foreach (KeyValuePair<string, QuarterModel> quarter in busQuarter.convertQuarterDatatable2Dict())
               {
                   string quarterName = quarter.Value.quarterName.Trim();
                   this.searchQuarterCombobox.Items.Add(quarterName);
                   this.searchQuarterCombobox.SelectedIndex = 0;
                   data.Add(quarterName);
               }
               searchQuarterCombobox.AutoCompleteCustomSource = data;
           }
       }

        private void bthuychonanh_Click(object sender, EventArgs e)
        {
            pbanh.BackgroundImage = null;
            pbanh.Image = null;
            pbanh.Invalidate();
            lbanh.Text = "";
        }

        private void searchQuarterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchQuarterCombobox.SelectedIndex > 0)
            {
                QuarterModel quarter = busQuarter.convertQuarterDatatable2Dict().ElementAt(searchQuarterCombobox.SelectedIndex - 1).Value;
                setDataWithQuarterId(quarter.quarterId);
                setDataForEmployName(quarter.quarterId);
                setDataForEmployId(quarter.quarterId);
                
            }
            else
            {
                setDisplayTableView();
            }
            this.searchEmployNameText.Text = "";
            this.searchEmployIdText.Text = "";
            this.searchEmployTotalLabel.Text = "";
        }

        private void setDataWithQuarterId(string quarterId)
        {
            if (busEmploy.convertDatatableWithQuartId2Dict(quarterId).Count > 0)
            {
                this.statusLabel.Visible = false;
                dgvEmploy.Rows.Clear();
                dgvEmploy.Refresh();

                foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatableWithQuartId2Dict(quarterId))
                {
                    QuarterModel quarter = busQuarter.convertQuarterDatatable2Dict()[employ.Value.quarterId];
                    dgvEmploy.Rows.Add(employ.Key, employ.Value.emPloyName, quarter.quarterName);
                    employIdText.Text = employ.Value.emPloyId.ToString();
                }
                setDataDetailWithQuarterId(quarterId, 0);
            }
            else
            {
                this.statusLabel.Visible = true;
                setDataDetailNull();
            }
        }

        private void searchQuarterCombobox_Enter(object sender, EventArgs e)
        {
            if (searchQuarterCombobox.Text.Equals("All"))
            {
                return;
            }
            QuarterModel quarter = busQuarter.convertQuarterDatatable2Dict().ElementAt(searchQuarterCombobox.SelectedIndex - 1).Value;
            setDataWithQuarterId(quarter.quarterId);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string quarterId = "";
            string stringSql = "";
            if (searchQuarterCombobox.SelectedIndex > 0)
            {
                QuarterModel quarter = busQuarter.convertQuarterDatatable2Dict().ElementAt(searchQuarterCombobox.SelectedIndex - 1).Value;
                quarterId = quarter.quarterId;
                stringSql = "select * from tblEmployee where Employ_Id Like '%" + searchEmployIdText.Text
                                    + "%' And Employ_Name Like '%" + searchEmployNameText.Text
                                    + "%' And Quarter_Id = '" + quarterId + "'";
            }
            else
            {
                stringSql = "select * from tblEmployee where Employ_Id Like '%" + searchEmployIdText.Text
                                    + "%' And Employ_Name Like '%" + searchEmployNameText.Text + "%'";
            }
            setDataAfterSearch(stringSql);
            if (this.dgvEmploy.Rows.Count > 0)
            {
                setDataDetail(0);
            }
            else
            {
                setDataDetailNull();
            }
        }

        private void setDataAfterSearch(string stringSql)
        {
            dgvEmploy.Rows.Clear();
            dgvEmploy.Refresh();

            if (busEmploy.convertDatatableWithSearch2Dict(stringSql).Count > 0)
            {
                this.statusLabel.Visible = false;

                foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatableWithSearch2Dict(stringSql))
                {
                    QuarterModel quarter = busQuarter.convertQuarterDatatable2Dict()[employ.Value.quarterId];
                    dgvEmploy.Rows.Add(employ.Key, employ.Value.emPloyName, quarter.quarterName);
                    employIdText.Text = employ.Value.emPloyId.ToString();
                }
            }
            else
            {
                this.statusLabel.Visible = true;
            }
        }

        private void setDataForEmployName(string quarterId)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            if (quarterId.Equals("All"))
            {
                foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatable2Dict())
                {
                    string employName = employ.Value.emPloyName.Trim();
                    data.Add(employName);
                }
            }
            else
            {
                if (busEmploy.convertDatatableWithQuartId2Dict(quarterId).Count > 0)
                {
                    foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatableWithQuartId2Dict(quarterId))
                    {
                        string employName = employ.Value.emPloyName.Trim();
                        data.Add(employName);
                    }
                }
            }
            searchEmployNameText.AutoCompleteCustomSource = data;
        }

        private void setDataForEmployId(string quarterId)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            if (quarterId.Equals("All"))
            {
                foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatable2Dict())
                {
                    string employId = employ.Value.emPloyId.Trim();
                    data.Add(employId);
                }
            }
            else if (busEmploy.convertDatatableWithQuartId2Dict(quarterId).Count > 0)
            {
                foreach (KeyValuePair<string, EmployeeModel> employ in busEmploy.convertDatatableWithQuartId2Dict(quarterId))
                {
                    string employId = employ.Value.emPloyId.Trim();
                    data.Add(employId);
                }
            }
            searchEmployIdText.AutoCompleteCustomSource = data;
        }

        private void dgvEmploy_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            setDataDetail(dgvEmploy.CurrentCell.RowIndex);
        }

        private void setDataDetail(int index)
        {
            EmployeeModel employModel = busEmploy.convertDatatable2Dict().ElementAt(index).Value;
            this.employIdText.Text              = employModel.emPloyId.Trim();
            this.employAccountText.Text         = employModel.emPloyAccount.Trim();
            this.employAddressText.Text         = employModel.emPloyAddress.Trim();
            this.employNameText.Text            = employModel.emPloyName.Trim();
            this.employPhoneNumberText.Text     = employModel.emPloyNumberPhone.Trim();
            this.employSalaryText.Text          = employModel.emPloySalary.ToString().Trim();
            this.quarterIdText.Text             = employModel.quarterId.Trim();
            this.setDataForRadioButton(employModel.emPloySex);
        }

        private void setDataDetailWithQuarterId(string quarterId, int index)
        {
            EmployeeModel employModel = busEmploy.convertDatatableWithQuartId2Dict(quarterId).ElementAt(index).Value;
            this.employIdText.Text = employModel.emPloyId.Trim();
            this.employAccountText.Text = employModel.emPloyAccount.Trim();
            this.employAddressText.Text = employModel.emPloyAddress.Trim();
            this.employNameText.Text = employModel.emPloyName.Trim();
            this.employPhoneNumberText.Text = employModel.emPloyNumberPhone.Trim();
            this.employSalaryText.Text = employModel.emPloySalary.ToString().Trim();
            this.quarterIdText.Text = employModel.quarterId.Trim();
            this.setDataForRadioButton(employModel.emPloySex);
        }

        private void setDataDetailNull()
        {
            this.employIdText.Text = "";
            this.employAccountText.Text ="";
            this.employAddressText.Text = "";
            this.employNameText.Text = "";
            this.employPhoneNumberText.Text = "";
            this.employSalaryText.Text = "";
            this.quarterIdText.Text = "";
            this.employFemaleRadio.Checked = false;
            this.employMaleRadio.Checked = false;
        }

        private void setDataForRadioButton(bool male)
        {
            if (male)
            {
                this.employFemaleRadio.Checked = false;
                this.employMaleRadio.Checked = true;
            }
            else
            {
                this.employMaleRadio.Checked = false;
                this.employFemaleRadio.Checked = true;
            }
        }
    }
}
