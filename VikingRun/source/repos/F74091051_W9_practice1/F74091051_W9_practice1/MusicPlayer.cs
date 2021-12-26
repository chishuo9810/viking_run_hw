using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;     

namespace F74091051_W9_practice1
{
    class MusicPlayer:SoundPlayer
    {
        public void play(string p, System.Windows.Forms.CheckBox Loop)
        {
            SoundPlayer player1 = new SoundPlayer();        // 建立播放器物件
            player1.SoundLocation = p;                      // 指定音效所在路徑檔名
            player1.Load();                                 // 載入音效檔資料
            if (Loop.Checked)
            {
                player1.PlayLooping();
            }
            else player1.Play();                                 // 播放音效
        }
        public void stop(string s)
        {
            FileStream fIn = new FileStream(s, FileMode.Open);
            SoundPlayer player3 = new SoundPlayer(fIn);      // 使用檔案串流建立物件
            player3.Stop();　　　　　　　                 　 // 停止播放
            fIn.Close();　　                                 // 關閉串流
        }
        /*public void loop(string l)
        {
            SoundPlayer player2 = new SoundPlayer(l);   // 使用完整檔名建立物件
            player2.PlayLooping();　　　　　　　　                 // 重複播放
        }*/
        public string[] select_files(System.Windows.Forms.OpenFileDialog openFileDialog)
        {
            string[] a=new string[4];
            String stFilter = "WAV(*.wav)|*.wav";
            openFileDialog.Filter = stFilter;
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        a[i] = openFileDialog.FileNames[i];
                    }
                }
                catch { };
            }
                return a;
        }
    }
}
