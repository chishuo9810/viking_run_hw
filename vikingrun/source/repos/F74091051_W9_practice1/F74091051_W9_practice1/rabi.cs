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
    class rabi : System.Windows.Forms.RadioButton
    {
        public void stop()
        {
            FileStream fIn = new FileStream(this.Text, FileMode.Open);
            SoundPlayer player3 = new SoundPlayer(fIn);      // 使用檔案串流建立物件
            player3.Stop();　　　　　　　                 　 // 停止播放
            fIn.Close();　　                                 // 關閉串流
        }
    }
}
