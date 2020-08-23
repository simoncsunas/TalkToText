using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;


namespace sSpeech
{
    public partial class fMain : Form
    {

        SpeechSynthesizer speaker = new SpeechSynthesizer();
        SpeechRecognitionEngine speechrecognize = new SpeechRecognitionEngine();
      
        PromptBuilder pb = new PromptBuilder();

        Choices clist;

        public fMain()
        {
            InitializeComponent();

            speechrecognize.SpeechRecognized += speechrecognize_SpeechRecognized;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Grammar lsGrammar = new Grammar(new GrammarBuilder("hello"));

            try
            {
                speechrecognize.RequestRecognizerUpdate();
                speechrecognize.LoadGrammar(lsGrammar);
                speechrecognize.SetInputToDefaultAudioDevice();
                speechrecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recognize", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            speechrecognize.RecognizeAsyncStop();
            this.Close();
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            speaker.Rate = 1;
            speaker.Volume = 100;
            speaker.SelectVoice("Microsoft Anna");
            speaker.Speak(rtbToSpeak.Text);
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            //clist.Add(new string[] { "hello", "how are you", "thank you", "close" });
            Grammar lsGrammar = new Grammar(new GrammarBuilder(txtRecognize.Text.Trim()));
           
            try
            {
                speechrecognize.RequestRecognizerUpdate();
                speechrecognize.LoadGrammar(lsGrammar);            
                speechrecognize.SetInputToDefaultAudioDevice();
                speechrecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recognize", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void speechrecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text.ToString())
            {
                case "hello":
                    speaker.Speak("Hello Simon");
                    break;
                case "how are you":
                    speaker.SpeakAsync("fine thank you");
                    break;
                case "close":
                    speaker.SpeakAsync("the system will closed");
                    Application.Exit();
                    break;
            }
        }
    }
}
