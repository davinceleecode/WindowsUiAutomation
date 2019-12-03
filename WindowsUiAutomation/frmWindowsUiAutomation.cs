using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Automation;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsUiAutomation
{
    public partial class frmWindowsUiAutomation : Form
    {
        #region Constructor
        public frmWindowsUiAutomation()
        {
            InitializeComponent();
        }
        #endregion



        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        #region Built-in Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //Get the Main Application Window
            Condition filterMainWindow = new AndCondition(new PropertyCondition(AutomationElement.AutomationIdProperty, "frmWindowsUiAutomation"),
                                                          new PropertyCondition(AutomationElement.NameProperty, "WindowsUiAutomation"));
            AutomationElement AutomationMainWindow = AutomationElement.RootElement.FindFirst(TreeScope.Children, filterMainWindow);
            Thread.Sleep(100);




            //get the tabControl
            AutomationElement ControlTab = AutomationMainWindow.FindFirst(TreeScope.Descendants,
                                            new PropertyCondition(AutomationElement.AutomationIdProperty, "tabControl1"));
            ControlTab.SetFocus();




            //Select the GenderTabItem
            AutomationElement GenderTab = ControlTab.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "GenderTab"));

            //check if the SelectionItemProperty is avaiable or not
            bool IsSelectionAvailable = (bool)GenderTab.GetCurrentPropertyValue(AutomationElement.IsSelectionItemPatternAvailableProperty);
            if (IsSelectionAvailable)
                GenderTab.SelectTab();




            //Get radioButton and Invoke
            AutomationElement GenderTabX = ControlTab.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "GenderTab"));
            AutomationElement radioButton = GenderTabX.FindFirst(TreeScope.Descendants, new AndCondition(new PropertyCondition(AutomationElement.NameProperty, "Male"),
                                                                                                        new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.RadioButton)));
            radioButton.InvokeControl();




            //Select the CountryTabItem
            AutomationElement CountryTab = ControlTab.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "CountryTab"));
            CountryTab.SelectTab();




            //select specific item in ComboBoxItem 
            AutomationElement CountryTabX = ControlTab.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "CountryTab"));
            AutomationElement comboBox = CountryTabX.FindFirst(TreeScope.Descendants, new AndCondition(new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ComboBox),
                                                                                                       new PropertyCondition(AutomationElement.AutomationIdProperty, "cmbCountry")));
            comboBox.SetSelectedComboBoxItem("Philippines");
            SendKeys.SendWait("{TAB}");




            //Select the NameTab
            AutomationElement NameTab = ControlTab.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "NameTab"));
            NameTab.SelectTab();

            //get text value
            AutomationElement NameTabX = ControlTab.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, "NameTab"));
            AutomationElement txtName = NameTabX.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, "txtName"));
            MessageBox.Show(txtName.GetTextControl());


            //sample of getting ColletionElement
            //get all textmessages
            //AutomationElementCollection TextElementCollection = InternetExplorerServer.FindAll(TreeScope.Descendants, new AndCondition(new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Text),
            //                                                                                                                  new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, "text"),
            //                                                                                                                  new PropertyCondition(AutomationElement.AutomationIdProperty, "")));


            //var CssWebIndex = TextElementCollection.Cast<AutomationElement>().ToList().FindIndex(x => GetValue(x.Current.Name) == "CSS Web");
            //model.Date = DateTime.Parse(TextElementCollection.Cast<AutomationElement>().ToList()[CssWebIndex + 2].Current.Name.Trim()).ToShortDateString();
            //model.Name = TextElementCollection.Cast<AutomationElement>().ToList()[CssWebIndex + 3].Current.Name.Replace(",", "").Trim();

        }
        #endregion
    }


}
