using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ScriptPortal.Vegas;
//using Sony.Vegas;

namespace CustomFades
{
    // Form to show on opening the Script
    public partial class WndForm : Form
    {
        public int FadeInValue;
        public int FadeOutValue;
        public string FadeInTimecode;
        public string FadeOutTimecode;
        public string FadeInCurve;
        public string FadeOutCurve;

        // Change Fade In/Out Curve
        public bool changeFIC;
        public bool changeFOC;

        // Fade In/Out To Zero
        public bool FITZ;
        public bool FOTZ;

        // Add Fade In/Out Length
        public bool AFIL;
        public bool AFOL;

        // Reduce Fade In/Out Length
        public bool RFIL;
        public bool RFOL;

        public WndForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            nudFadeIn.Select();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            FadeInValue = (int)nudFadeIn.Value;
            FadeOutValue = (int)nudFadeOut.Value;
            FadeInTimecode = cbxFadeInTimecode.Text;
            FadeOutTimecode = cbxFadeOutTimecode.Text;

            if (changeFIC)
                FadeInCurve = cbxFadeInCurve.Text;

            if (changeFOC)
                FadeOutCurve = cbxFadeOutCurve.Text;

            DialogResult = DialogResult.OK;
            Close();
            Dispose();
        }

        private void cbxChangeFadeInCurveType_CheckedChanged(object sender, EventArgs e)
        {
            // Also change the curve type
            changeFIC = cbxFadeInCurve.Enabled
                = cbxChangeFadeInCurveType.Checked;
        }

        private void cbxChangeFadeOutCurveType_CheckedChanged(object sender, EventArgs e)
        {
            // Also change the curve type
            changeFOC = cbxFadeOutCurve.Enabled
                = cbxChangeFadeOutCurveType.Checked;
        }

        private void cbxFadeInToZero_CheckedChanged(object sender, EventArgs e)
        {
            FITZ = cbxFadeInToZero.Checked;

            // Reset fade length
            if (FITZ)
                nudFadeIn.Value = 0;

            nudFadeIn.Enabled = cbxFadeInTimecode.Enabled = cbxFIAddLength.Enabled = cbxFIReduceLength.Enabled
                = !cbxFadeInToZero.Checked;
        }

        private void cbxFadeOutToZero_CheckedChanged(object sender, EventArgs e)
        {
            FOTZ = cbxFadeOutToZero.Checked;

            // Reset fade length
            if (FOTZ)
                nudFadeOut.Value = 0;

            nudFadeOut.Enabled = cbxFadeOutTimecode.Enabled = cbxFOAddLength.Enabled = cbxFOReduceLength.Enabled
                = !cbxFadeOutToZero.Checked;
        }

        private void SetLength(Label fadeLabel, string labelText, CheckBox checkBox_checked, CheckBox checkBox_other, CheckBox checkBox_setZero)
        {
            fadeLabel.Text = "New Length:";

            // Disable checkboxes and set the text of the labels
            if (checkBox_checked.Checked)
            {
                fadeLabel.Text = labelText;
                checkBox_other.Enabled = false;
                checkBox_setZero.Enabled = false;
            }
            else
            {
                checkBox_other.Enabled = true;
                checkBox_setZero.Enabled = true;
            }
        }

        private void cbxFIAddLength_CheckedChanged(object sender, EventArgs e)
        {
            // Add-to instead of Set length
            SetLength(lbFadeIn, "Increase by:", cbxFIAddLength, cbxFIReduceLength, cbxFadeInToZero);
            AFIL = cbxFIAddLength.Checked;
        }

        private void cbxFOAddLength_CheckedChanged(object sender, EventArgs e)
        {
            // Add-to instead of Set length
            SetLength(lbFadeOut, "Increase by:", cbxFOAddLength, cbxFOReduceLength, cbxFadeOutToZero);
            AFOL = cbxFOAddLength.Checked;
        }

        private void cbxFIReduceLength_CheckedChanged(object sender, EventArgs e)
        {
            // Reduce instead of Set length
            SetLength(lbFadeIn, "Reduce by:", cbxFIReduceLength, cbxFIAddLength, cbxFadeInToZero);
            RFIL = cbxFIReduceLength.Checked;
        }

        private void cbxFOReduceLength_CheckedChanged(object sender, EventArgs e)
        {
            // Reduce instead of Set length
            SetLength(lbFadeOut, "Reduce by:", cbxFOReduceLength, cbxFOAddLength, cbxFadeOutToZero);
            RFOL = cbxFOReduceLength.Checked;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- - - - - - - - - - - What can you do? - - - - - - - - - - -" +
                   "\n\n" + "You can set the Fade In/Out:" +
                   "\n\n" + "- Length (in either Frames or Seconds)" +
                     "\n" + "  > If Length stays 0 -> it stays the same" +
                     "\n" + "  > Use the CheckBox if you want the Fade In/Out length to be 0" +
                   "\n\n" + "- Curve Type (Fast, Linear, Sharp, Slow, Smooth)" +
                     "\n" + "  > It doesn't change the Curve Type by default" +
                     "\n" + "  > Use the CheckBox if you want to change it", "Help", MessageBoxButtons.OK);
        }
    }

    // Vegas recieves this
    public class EntryPoint
    {
        public void FromVegas(Vegas myVegas)
        {
            // setting local variables for later
            int FadeInValue;
            int FadeOutValue;
            string FadeInTimecode;
            string FadeOutTimecode;
            bool changeFIC;
            bool changeFOC;
            string FadeInCurve;
            string FadeOutCurve;
            bool FITZ;
            bool FOTZ;
            bool AFIL;
            bool AFOL;
            bool RFIL;
            bool RFOL;

            using (WndForm form = new WndForm())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Get variables fromm the Form after pressing Run
                    FadeInValue = form.FadeInValue;
                    FadeOutValue = form.FadeOutValue;
                    FadeInTimecode = form.FadeInTimecode;
                    FadeOutTimecode = form.FadeOutTimecode;
                    changeFIC = form.changeFIC;
                    changeFOC = form.changeFOC;
                    FITZ = form.FITZ;
                    FOTZ = form.FOTZ;
                    AFIL = form.AFIL;
                    AFOL = form.AFOL;
                    RFIL = form.RFIL;
                    RFOL = form.RFOL;
                    FadeInCurve = form.FadeInCurve;
                    FadeOutCurve = form.FadeOutCurve;
                }
                else return;
            }

            try
            {
                var selectedEvents = myVegas.Project.Tracks?
                    .SelectMany(x => x.Events
                    .Where(y => y.Selected))
                    .ToArray();

                foreach (TrackEvent trackEvent in selectedEvents)
                {
                    FrameChecker(FadeInValue, FadeInTimecode, RFIL, AFIL, FITZ, trackEvent.FadeIn);
                    FrameChecker(FadeOutValue, FadeOutTimecode, RFOL, AFOL, FOTZ, trackEvent.FadeOut);

                    if (changeFIC)
                        ChangeCurveTypes(FadeInCurve, trackEvent.FadeIn);

                    if (changeFOC)
                        ChangeCurveTypes(FadeOutCurve, trackEvent.FadeOut);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Something went wrong: " + ex.Message,
                    "Something went wrong",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw;
            }
        }

        void FrameChecker(int fadeValue, string fadeTimecode, bool reduceBool, bool addBool, bool fadeToZeroBool, Fade fade)
        {
            if (fadeValue < 0)
                return;

            if (fadeToZeroBool && fadeValue == 0)
            {
                fade.Length = Timecode.FromFrames(0);
                return;
            }

            switch (fadeTimecode)
            {
                // Count in frames
                case "Frames":
                    FrameCalculator(addBool, reduceBool, fade, Timecode.FromFrames(fadeValue));
                    break;
                // Count in seconds
                case "Seconds":
                    FrameCalculator(addBool, reduceBool, fade, Timecode.FromSeconds(fadeValue));
                    break;
                // ComboBox was empty -> Count in frames
                default:
                    FrameCalculator(addBool, reduceBool, fade, Timecode.FromFrames(fadeValue));
                    break;
            }
        }

        void FrameCalculator(bool addBool, bool reduceBool, Fade fade, Timecode timecode)
        {
            if (reduceBool)
                fade.Length -= timecode;
            else if (addBool)
                fade.Length += timecode;
            else
                fade.Length = timecode;
        }

        void ChangeCurveTypes(string fadeString, Fade fade)
        {
            switch (fadeString)
            {
                case "Fast":
                    fade.Curve = CurveType.Fast;
                    break;
                case "Linear":
                    fade.Curve = CurveType.Linear;
                    break;
                case "Sharp":
                    fade.Curve = CurveType.Sharp;
                    break;
                case "Slow":
                    fade.Curve = CurveType.Slow;
                    break;
                case "Smooth":
                    fade.Curve = CurveType.Smooth;
                    break;
                // ComboBox was empty
                default:
                    fade.Curve = CurveType.Smooth;
                    break;
            }
        }
    }
}
