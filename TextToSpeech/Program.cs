using System.Speech.Synthesis;
using System.Globalization;

var speech = new SpeechSynthesizer();

speech.SetOutputToDefaultAudioDevice();

Console.WriteLine("enter your text: \n");
var voice = Console.ReadLine();
var prompt = new PromptBuilder();
prompt.StartVoice(new CultureInfo("en-US"));
prompt.AppendText(voice);
prompt.EndVoice();

speech.Speak(prompt);