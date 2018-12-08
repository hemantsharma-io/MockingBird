using System;
using System.Windows.Forms;
using Fiddler;
using MockingBird.Core;
namespace MockingBird.UI
{
    public partial class CodeView : UserControl
    {
        public CodeView()
        {
            InitializeComponent();
            txtOutput.DragEnter += TxtOutput_DragEnter;
            txtOutput.DragOver += TxtOutput_DragEnter;
            txtOutput.DragDrop += TxtOutput_DragDrop;
            cmbTpl.SelectedIndexChanged += CmbTpl_SelectedIndexChanged;
            initView();
        }

        private void CmbTpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTemplate.Text = TemplateController.GetTemplateText(cmbTpl.SelectedItem.ToString());
        }

        private void initView()
        {
            try
            {
                cmbTpl.Items.AddRange(TemplateController.GetAllInstalledTemplateNames());
                cmbTpl.SelectedIndex = 0;
            }catch(Exception ex)
            {
                FiddlerApplication.Log.LogFormat("MockingBird - Problem loading templates check template path. Error message: {0} Stack: {1}", ex.Message, ex.StackTrace);
                throw ex;
            }
        }

        private void TxtOutput_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var sessions = (Fiddler.Session[])e.Data.GetData(typeof(Fiddler.Session[]));
                if (sessions == null || String.IsNullOrWhiteSpace(txtTemplate.Text))
                {
                    FiddlerApplication.Log.LogString("Mocking Bird - Either fidder session is null or template is empty");
                    return;
                }

                var codeGenerator = new CodeGenerator(sessions, txtTemplate.Text);
                txtOutput.Text = codeGenerator.GenerateOutput();
            }
            catch (Exception ex)
            {
                FiddlerApplication.Log.LogFormat("Mocking Bird - Error generating output. Message: {0} , Stack: {1}", ex.Message, ex.StackTrace);
            }
        }
        
        private void TxtOutput_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(typeof(Fiddler.Session[])) ? DragDropEffects.All : DragDropEffects.None);
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            btnSaveTpl.Enabled = true;
        }

        private void btnSaveTpl_Click(object sender, EventArgs e)
        {
            try
            {
                TemplateController.SaveTemplateText(cmbTpl.SelectedItem.ToString(), txtTemplate.Text);
            }catch(Exception ex){
                FiddlerApplication.Log.LogFormat("Mocking Bird - Error saving template. Message: {0} , Stack: {1}", ex.Message, ex.StackTrace);
            }
        }
    }
}