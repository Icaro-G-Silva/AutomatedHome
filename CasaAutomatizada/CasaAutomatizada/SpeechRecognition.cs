using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;
using System.Globalization;
using System.Configuration;

namespace CasaAutomatizada
{
    class SpeechRecognition
    {
        private static CultureInfo ci = new CultureInfo("pt-BR");
        public SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine(ci);

        public SpeechRecognition(string[] library)
        {
            configuration(library);
        }

        private void configuration(string[] library)
        {
            Choices instructions = new Choices();
            instructions.Add(library);
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(instructions);
            Grammar grammar = new Grammar(grammarBuilder);

            speechEngine.LoadGrammarAsync(grammar);
            speechEngine.SetInputToDefaultAudioDevice();
        }

        public void listen()
        {
            speechEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void stop()
        {
            speechEngine.RecognizeAsyncStop();
        }

    }
}
