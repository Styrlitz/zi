using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WAV Files (*.wav)|*.wav";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            OutPut(ofd.SafeFileName, ofd.FileName, true);

            waveViewer1.SamplesPerPixel = 450;
            waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(ofd.FileName);

            string WaveStr = "wave" + DateTime.Now.ToString();
            chart1.Series.Clear();
            chart1.Series.Add(WaveStr);          
            chart1.Series[WaveStr].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series[WaveStr].ChartArea = "ChartArea1";

            NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(ofd.FileName));

            byte[] buffer = new byte[16384];
            int read = 0;

            while (wave.Position < wave.Length)
            {
                read = wave.Read(buffer, 0, 16384);

                for (int i = 0; i < read / 4; i++)
                {
                    chart1.Series[WaveStr].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                }
            }            
        }

        void OutPut(string name, string source, bool isNew)
        {
            var header = new Header();
            var headerSize = Marshal.SizeOf(header);
            var tmpFile = File.OpenRead(source);
            var buffer = new byte[headerSize];
            tmpFile.Read(buffer, 0, headerSize);
            var usingMemory = Marshal.AllocHGlobal(headerSize);
            Marshal.Copy(buffer, 0, usingMemory, headerSize);
            Marshal.PtrToStructure(usingMemory, header);
            var time = 1.0 * header.ChunkSize / (header.BitsPerSample / 8.0) / header.NumChannels / header.ByteRate;
            //out
            tbName.Text = name;
            tbSize.Text = header.ChunkSize.ToString() + " bytes";
            tbChannels.Text = header.NumChannels.ToString();
            tbTime.Text = time.ToString() + " sec";
            tbRate.Text = header.SampleRate.ToString() + " Hz";
            tbDigits.Text = header.BitsPerSample.ToString();
            tbBites.Text = header.ByteRate.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        [StructLayout(LayoutKind.Sequential)]
        internal class Header
        {
           
            public UInt32 ChunkId;

            // 36 + subchunk2Size, или более точно:
            // 4 + (8 + subchunk1Size) + (8 + subchunk2Size)
            // Это оставшийся размер цепочки, начиная с этой позиции.
            // Иначе говоря, это размер файла - 8, то есть,
            // исключены поля chunkId и chunkSize.
            public UInt32 ChunkSize;

            // Содержит символы "WAVE"
            // (0x57415645 в big-endian представлении)
            public UInt32 Format;

            // Формат "WAVE" состоит из двух подцепочек: "fmt " и "data":
            // Подцепочка "fmt " описывает формат звуковых данных:

            // Содержит символы "fmt "
            // (0x666d7420 в big-endian представлении)
            public UInt32 Subchunk1Id;

            // 16 для формата PCM.
            // Это оставшийся размер подцепочки, начиная с этой позиции.
            public UInt32 Subchunk1Size;

            // Аудио формат, полный список можно получить здесь http://audiocoding.ru/wav_formats.txt
            // Для PCM = 1 (то есть, Линейное квантование).
            // Значения, отличающиеся от 1, обозначают некоторый формат сжатия.
            public UInt16 AudioFormat;

            // Количество каналов. Моно = 1, Стерео = 2 и т.д.
            public UInt16 NumChannels;

            // Частота дискретизации. 8000 Гц, 44100 Гц и т.д.
            public UInt32 SampleRate;

            // sampleRate * numChannels * bitsPerSample/8
            public UInt32 ByteRate;

            // numChannels * bitsPerSample/8
            // Количество байт для одного сэмпла, включая все каналы.
            public UInt16 BlockAlign;

            // Так называемая "глубиная" или точность звучания. 8 бит, 16 бит и т.д.
            public UInt16 BitsPerSample;

            // Подцепочка "data" содержит аудио-данные и их размер.

            // Содержит символы "data"
            // (0x64617461 в big-endian представлении)
            public UInt32 Subchunk2Id;

            // numSamples * numChannels * bitsPerSample/8
            // Количество байт в области данных.
            public UInt32 Subchunk2Size;

        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
