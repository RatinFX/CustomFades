using ScriptPortal.Vegas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomFades
{
    // Form to show on opening the Script
    public partial class MainForm : Form
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

        public MainForm()
        {
            InitializeComponent();
            nudFI.Select();

            Helper.ChangeTheme(menuStrip);
        }

        private void tsmiCreatedByRatinFX_Click(object sender, EventArgs e)
        {
            Helper.OpenRatinFXWebsite();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Helper.ShowAbout(
                "Quickly Increase, Decrease or Set the length of the Fade in or Fade out on the selected Events" + "\n\n" +
                "You can select between Frames and Seconds to calculate the new lengths" + "\n\n" +
                "Enable Change curve if you want to change the Fade type to:"+"\n"+
                "- Fast, Linear, Sharp, Slow or Smooth."
            );
        }

        private void cbxChangeFICurveType_CheckedChanged(object sender, EventArgs e)
        {
            // Also change the curve type
            changeFIC = cbxFICurve.Enabled
                = cbxChangeFICurveType.Checked;
        }

        private void cbxChangeFOCurveType_CheckedChanged(object sender, EventArgs e)
        {
            // Also change the curve type
            changeFOC = cbxFOCurve.Enabled
                = cbxChangeFOCurveType.Checked;
        }

        private void cbxFIToZero_CheckedChanged(object sender, EventArgs e)
        {
            FITZ = cbxFIToZero.Checked;

            // Reset fade length
            if (FITZ)
                nudFI.Value = 0;

            nudFI.Enabled = cbxFITimecode.Enabled = cbxFIAddLength.Enabled = cbxFIReduceLength.Enabled
                = !cbxFIToZero.Checked;
        }

        private void cbxFOToZero_CheckedChanged(object sender, EventArgs e)
        {
            FOTZ = cbxFOToZero.Checked;

            // Reset fade length
            if (FOTZ)
                nudFO.Value = 0;

            nudFO.Enabled = cbxFOTimecode.Enabled = cbxFOAddLength.Enabled = cbxFOReduceLength.Enabled
                = !cbxFOToZero.Checked;
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
            SetLength(lblFI, "Increase by:", cbxFIAddLength, cbxFIReduceLength, cbxFIToZero);
            AFIL = cbxFIAddLength.Checked;
        }

        private void cbxFOAddLength_CheckedChanged(object sender, EventArgs e)
        {
            // Add-to instead of Set length
            SetLength(lblFO, "Increase by:", cbxFOAddLength, cbxFOReduceLength, cbxFOToZero);
            AFOL = cbxFOAddLength.Checked;
        }

        private void cbxFIReduceLength_CheckedChanged(object sender, EventArgs e)
        {
            // Reduce instead of Set length
            SetLength(lblFI, "Reduce by:", cbxFIReduceLength, cbxFIAddLength, cbxFIToZero);
            RFIL = cbxFIReduceLength.Checked;
        }

        private void cbxFOReduceLength_CheckedChanged(object sender, EventArgs e)
        {
            // Reduce instead of Set length
            SetLength(lblFO, "Reduce by:", cbxFOReduceLength, cbxFOAddLength, cbxFOToZero);
            RFOL = cbxFOReduceLength.Checked;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            FadeInValue = (int)nudFI.Value;
            FadeOutValue = (int)nudFO.Value;
            FadeInTimecode = cbxFITimecode.Text;
            FadeOutTimecode = cbxFOTimecode.Text;

            if (changeFIC)
                FadeInCurve = cbxFICurve.Text;

            if (changeFOC)
                FadeOutCurve = cbxFOCurve.Text;

            DialogResult = DialogResult.OK;
            Close();
            Dispose();
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

            using (MainForm form = new MainForm())
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
