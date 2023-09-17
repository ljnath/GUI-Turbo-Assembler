using GUITurboAssembler.Localization.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FastColoredTextBoxNS
{
    public partial class FindForm : Form
    {
        bool firstSearch = true;
        Place startPlace;
        FastColoredTextBox tb;
        Texts currentLocalizedText;

        public FindForm(FastColoredTextBox tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        public FindForm(FastColoredTextBox tb, Texts localizedText)
        {
            currentLocalizedText = localizedText;
            InitializeComponent();
            this.tb = tb;

            btClose.Text = currentLocalizedText.IDE.Close;
            btFindNext.Text = currentLocalizedText.IDE.FindNext;
            cbMatchCase.Text = currentLocalizedText.IDE.MatchCase;
            cbWholeWord.Text = currentLocalizedText.IDE.MatchWholeWord;
            this.Text = label1.Text = currentLocalizedText.IDE.Find;

            btClose.Refresh();
            btFindNext.Refresh();
            cbMatchCase.Refresh();
            cbWholeWord.Refresh();
            label1.Refresh();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            FindNext(tbFind.Text);
        }

        public virtual void FindNext(string pattern)
        {
            try
            {
                RegexOptions opt = cbMatchCase.Checked ? RegexOptions.None : RegexOptions.IgnoreCase;
                if (!cbRegex.Checked)
                    pattern = Regex.Escape(pattern);
                if (cbWholeWord.Checked)
                    pattern = "\\b" + pattern + "\\b";
                //
                Range range = tb.Selection.Clone();
                range.Normalize();
                //
                if (firstSearch)
                {
                    startPlace = range.Start;
                    firstSearch = false;
                }
                //
                range.Start = range.End;
                if (range.Start >= startPlace)
                    range.End = new Place(tb.GetLineLength(tb.LinesCount - 1), tb.LinesCount - 1);
                else
                    range.End = startPlace;
                //
                foreach (var r in range.GetRangesByLines(pattern, opt))
                {
                    tb.Selection = r;
                    tb.DoSelectionVisible();
                    tb.Invalidate();
                    return;
                }
                //
                if (range.Start >= startPlace && startPlace > Place.Empty)
                {
                    tb.Selection.Start = new Place(0, 0);
                    FindNext(pattern);
                    return;
                }
                MessageBox.Show(currentLocalizedText.IDE.NotFound);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btFindNext.PerformClick();
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '\x1b')
            {
                Hide();
                e.Handled = true;
                return;
            }
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            this.tb.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnActivated(EventArgs e)
        {
            tbFind.Focus();
            ResetSerach();
        }

        void ResetSerach()
        {
            firstSearch = true;
        }

        private void cbMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            ResetSerach();
        }
    }
}
